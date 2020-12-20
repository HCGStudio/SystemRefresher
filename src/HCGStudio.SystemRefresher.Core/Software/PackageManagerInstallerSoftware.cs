using System;

namespace HCGStudio.SystemRefresher.Core.Software
{
    /// <summary>
    ///     Record contains a software to install by package manager.
    /// </summary>
    public record PackageManagerInstallerSoftware : SoftwareRestore
    {
        /// <summary>
        ///     Package manager to install the software.
        /// </summary>
        public PackageManagerType PackageManager { get; init; }

        /// <summary>
        ///     Package name that used to manage package in package manager.
        /// </summary>
        public string PackageName { get; init; } = string.Empty;


        /// <summary>
        ///     Whether try to install same version of software when restore.
        /// </summary>
        public bool KeepSameVersion { get; init; }

        /// <summary>
        ///     Old version of installed software, not null only when <c>KeepSameVersion</c> is true.
        /// </summary>
        public Version? OldVersion { get; init; }
    }
}