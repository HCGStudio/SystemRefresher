namespace HCGStudio.SystemRefresher.Core.Software
{
    /// <summary>
    /// Enum contains possible package managers.
    /// </summary>
    public enum PackageManagerType
    {
        /// <summary>
        /// The software was not install manually.
        /// </summary>
        None,
        /// <summary>
        /// The software was installed by Chocolatey.
        /// </summary>
        Chocolatey,
        /// <summary>
        /// The software of library wa installed by vcpkg.
        /// </summary>
        VcPkg,
        /// <summary>
        /// The software was installed by HomeBrew.
        /// </summary>
        HomeBrew,
        /// <summary>
        /// The software was installed by pacman.
        /// </summary>
        Pacman,
        /// <summary>
        /// The software was installed by dnf.
        /// </summary>
        DandifiedYum,
        /// <summary>
        /// The software was installed by apt.
        /// </summary>
        AptGet,
        /// <summary>
        /// The software was installed by snap store.
        /// </summary>
        Snap


    }
}
