using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Defender’s default action to take on detected Malware threats.</summary>
    public enum DefenderThreatAction {
        /// <summary>Apply action based on the update definition.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Clean the detected threat.</summary>
        [EnumMember(Value = "clean")]
        Clean,
        /// <summary>Quarantine the detected threat.</summary>
        [EnumMember(Value = "quarantine")]
        Quarantine,
        /// <summary>Remove the detected threat.</summary>
        [EnumMember(Value = "remove")]
        Remove,
        /// <summary>Allow the detected threat.</summary>
        [EnumMember(Value = "allow")]
        Allow,
        /// <summary>Allow the user to determine the action to take with the detected threat.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Block the detected threat.</summary>
        [EnumMember(Value = "block")]
        Block,
    }
}
