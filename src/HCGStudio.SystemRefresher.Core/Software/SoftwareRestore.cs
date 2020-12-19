using System;
using System.Text.Json.Serialization;

namespace HCGStudio.SystemRefresher.Core.Software
{
    /// <summary>
    ///     Record that contains all information to restore a installed software.
    /// </summary>
    [JsonConverter(typeof(SoftwareRestoreJsonConverter))]
    public record SoftwareRestore
    {
        /// <summary>
        ///     Name of the software.
        /// </summary>
        public string Name { get; init; } = string.Empty;

        /// <summary>
        ///     Installation method of the software.
        /// </summary>
        public SoftwareType Type { get; init; }

        /// <summary>
        ///     Package manager to install the software.
        /// </summary>
        public PackageManagerType PackageManager { get; init; }

        /// <summary>
        ///     Files required to download before installation.
        /// </summary>
        public Uri[] FilesToDownload { get; init; } = Array.Empty<Uri>();

        /// <summary>
        ///     The software should install after these software.
        /// </summary>
        public string[] InstallAfter { get; init; } = Array.Empty<string>();

        /// <summary>
        ///     Script file execute before the software installation.
        /// </summary>
        /// <remarks>
        ///     Script will be executed by bash (on linux),
        ///     by zsh (on macOS) or by Windows PowerShell (on Windows).
        ///     Script will never be executed on <see cref="ManuallyInstalledSoftware" /> if <c>ExecuteInstaller</c> is false.
        /// </remarks>
        public string PreInstall { get; init; } = string.Empty;

        /// <summary>
        ///     Script file execute after the software installation.
        /// </summary>
        /// <remarks>
        ///     Script will be executed by bash (on linux),
        ///     by zsh (on macOS) or by Windows PowerShell (on Windows).
        ///     Script will never be executed on <see cref="ManuallyInstalledSoftware" /> if <c>ExecuteInstaller</c> is false.
        /// </remarks>
        public string PostInstall { get; init; } = string.Empty;
    }
}