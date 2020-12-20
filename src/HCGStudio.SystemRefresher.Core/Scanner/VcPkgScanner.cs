using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HCGStudio.SystemRefresher.Core.Software;
using Microsoft.Extensions.Logging;

namespace HCGStudio.SystemRefresher.Core.Scanner
{
    public abstract class VcPkgScanner : ISoftwareScanner<VcPkgInstalledPackage>
    {
        protected abstract ILogger? Logger { get; }
        public abstract List<VcPkgInstalledPackage> ScanSoftware();

        protected List<VcPkgInstalledPackage> ListPackageFromProcess(string path)
        {
            using var vcpkg = Process.Start(new ProcessStartInfo(path, "install")
            {
                RedirectStandardOutput = true
            });

            if (vcpkg == null)
            {
                Logger.LogDebug("Process should not create failed.");
                return new();
            }

            vcpkg.WaitForExit(1000);

            if (!vcpkg.HasExited)
            {
                Logger.LogDebug("List progress should not cost so long.");
                vcpkg.Kill();
                return new();
            }

            var content = vcpkg.StandardOutput.ReadToEnd()
                .Replace("\n", "").Split('\r',
                    StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            return (from line in content.SkipWhile(string.IsNullOrEmpty)
                select line.Split(' ')[0].Split(':')
                into name
                let packageName = name[0]
                let triplet = name[1]
                select new VcPkgInstalledPackage
                {
                    Triplet = triplet,
                    DisplayName = $"{packageName}:{triplet}",
                    Type = SoftwareType.InstallByPackageManager,
                    PackageManager = PackageManagerType.VcPkg,
                    PackageName = packageName,
                    KeepSameVersion = false,
                    OldVersion = null
                }).ToList();
        }
    }
}