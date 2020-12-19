namespace HCGStudio.SystemRefresher.Core.Software
{
    /// <summary>
    ///     Record contains a software to be manually installed.
    /// </summary>
    public record ManuallyInstalledSoftware : SoftwareRestore
    {
        /// <summary>
        ///     Whether or not execute the installer when this software should be installed.
        /// </summary>

        public bool ExecuteInstaller { get; init; }
    }
}