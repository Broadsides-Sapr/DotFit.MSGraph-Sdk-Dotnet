using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Indicates the operating system / platform of the discovered application.  Some possible values are Windows, iOS, macOS. The default value is unknown (0).</summary>
    public enum DetectedAppPlatformType {
        /// <summary>Default. Set to unknown when platform cannot be determined.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the platform of the detected application is Windows.</summary>
        [EnumMember(Value = "windows")]
        Windows,
        /// <summary>Indicates that the platform of the detected application is Windows Mobile.</summary>
        [EnumMember(Value = "windowsMobile")]
        WindowsMobile,
        /// <summary>Indicates that the platform of the detected application is Windows Holographic.</summary>
        [EnumMember(Value = "windowsHolographic")]
        WindowsHolographic,
        /// <summary>Indicates that the platform of the detected application is iOS.</summary>
        [EnumMember(Value = "ios")]
        Ios,
        /// <summary>Indicates that the platform of the detected application is macOS.</summary>
        [EnumMember(Value = "macOS")]
        MacOS,
        /// <summary>Indicates that the platform of the detected application is ChromeOS.</summary>
        [EnumMember(Value = "chromeOS")]
        ChromeOS,
        /// <summary>Indicates that the platform of the detected application is Android open source project.</summary>
        [EnumMember(Value = "androidOSP")]
        AndroidOSP,
        /// <summary>Indicates that the platform of the detected application is Android device administrator.</summary>
        [EnumMember(Value = "androidDeviceAdministrator")]
        AndroidDeviceAdministrator,
        /// <summary>Indicates that the platform of the detected application is Android work profile.</summary>
        [EnumMember(Value = "androidWorkProfile")]
        AndroidWorkProfile,
        /// <summary>Indicates that the platform of the detected application is Android dedicated and fully managed.</summary>
        [EnumMember(Value = "androidDedicatedAndFullyManaged")]
        AndroidDedicatedAndFullyManaged,
    }
}
