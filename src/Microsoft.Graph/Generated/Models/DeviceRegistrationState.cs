using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Device registration status.</summary>
    public enum DeviceRegistrationState {
        /// <summary>The device is not registered.</summary>
        [EnumMember(Value = "notRegistered")]
        NotRegistered,
        /// <summary>The device is registered.</summary>
        [EnumMember(Value = "registered")]
        Registered,
        /// <summary>The device has been blocked, wiped or retired.</summary>
        [EnumMember(Value = "revoked")]
        Revoked,
        /// <summary>The device has a key conflict.</summary>
        [EnumMember(Value = "keyConflict")]
        KeyConflict,
        /// <summary>The device is pending approval.</summary>
        [EnumMember(Value = "approvalPending")]
        ApprovalPending,
        /// <summary>The device certificate has been reset.</summary>
        [EnumMember(Value = "certificateReset")]
        CertificateReset,
        /// <summary>The device is not registered and pending enrollment.</summary>
        [EnumMember(Value = "notRegisteredPendingEnrollment")]
        NotRegisteredPendingEnrollment,
        /// <summary>The device registration status is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
    }
}
