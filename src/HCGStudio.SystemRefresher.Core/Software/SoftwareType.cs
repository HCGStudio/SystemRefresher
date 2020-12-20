namespace HCGStudio.SystemRefresher.Core.Software
{
    /// <summary>
    ///     Enum contains restore method of software.
    /// </summary>
    public enum SoftwareType
    {
        /// <summary>
        ///     Only download package and let the user manually installs it.
        /// </summary>
        DownloadPackageOnly,

        /// <summary>
        ///     Use a package manager to install it.
        /// </summary>
        InstallByPackageManager,

        /// <summary>
        ///     Use a script to install it.
        /// </summary>
        InstallByScript
    }
}