using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using HCGStudio.SystemRefresher.Core.Software;
using Microsoft.Extensions.Logging;

namespace HCGStudio.SystemRefresher.Core.Scanner
{
    [SupportedOSPlatform("windows")]
    public class WindowsVcPkgScanner : VcPkgScanner
    {
        public WindowsVcPkgScanner(ILogger<WindowsVcPkgScanner> logger)
        {
            Logger = logger;
        }

        protected override ILogger Logger { get; }

        public override List<VcPkgInstalledPackage> ScanSoftware()
        {
            Logger.LogTrace("Find vcpkg in path.");

            var path = Environment.GetEnvironmentVariable("Path");
            if (path == null)
            {
                Logger.LogDebug("Path should not be null.");
                throw new NullReferenceException();
            }

            var splitPath = path.Split(':');
            var vcpkgExecute = splitPath.Select(p => Path.Combine(p, "vcpkg.exe")).FirstOrDefault(File.Exists);

            if (vcpkgExecute != null)
                return ListPackageFromProcess(vcpkgExecute);
            Logger.LogTrace("Vcpkg not found in the path. " +
                            "Trying to find in local appdata");
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var vcpkgInfo = Path.Combine(appdata, @"vcpkg\vcpkg.path.txt");
            if (!File.Exists(vcpkgInfo))
            {
                Logger.LogTrace("No vcpkg found in local appdata");
                return new();
            }

            var vcpkgInstallDir = File.ReadAllText(vcpkgInfo, Encoding.UTF8);
            vcpkgExecute = Path.Combine(vcpkgInstallDir, "vcpkg.exe");
            if (File.Exists(vcpkgExecute))
                return ListPackageFromProcess(vcpkgExecute);
            Logger.LogTrace("No vcpkg found in local appdata");
            return new();
        }
    }
}