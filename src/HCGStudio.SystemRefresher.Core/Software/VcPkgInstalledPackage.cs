namespace HCGStudio.SystemRefresher.Core.Software
{
    /// <summary>
    ///     Record contains a software to install by package manager.
    /// </summary>
    public record VcPkgInstalledPackage : PackageManagerInstallerSoftware
    {
        /// <summary>
        ///     Triplet of the package installed by vcpkg.
        /// </summary>
        public string Triplet { get; init; } = string.Empty;
    }
}