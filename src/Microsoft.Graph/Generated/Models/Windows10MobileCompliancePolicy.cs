using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// This class contains compliance settings for Windows 10 Mobile.
    /// </summary>
    public class Windows10MobileCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Require devices to be reported healthy by Windows Device Health Attestation - bit locker is enabled</summary>
        public bool? BitLockerEnabled {
            get { return BackingStore?.Get<bool?>("bitLockerEnabled"); }
            set { BackingStore?.Set("bitLockerEnabled", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation.</summary>
        public bool? CodeIntegrityEnabled {
            get { return BackingStore?.Get<bool?>("codeIntegrityEnabled"); }
            set { BackingStore?.Set("codeIntegrityEnabled", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - early launch antimalware driver is enabled.</summary>
        public bool? EarlyLaunchAntiMalwareDriverEnabled {
            get { return BackingStore?.Get<bool?>("earlyLaunchAntiMalwareDriverEnabled"); }
            set { BackingStore?.Set("earlyLaunchAntiMalwareDriverEnabled", value); }
        }
        /// <summary>Maximum Windows Phone version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMaximumVersion {
            get { return BackingStore?.Get<string?>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
#nullable restore
#else
        public string OsMaximumVersion {
            get { return BackingStore?.Get<string>("osMaximumVersion"); }
            set { BackingStore?.Set("osMaximumVersion", value); }
        }
#endif
        /// <summary>Minimum Windows Phone version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMinimumVersion {
            get { return BackingStore?.Get<string?>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
#nullable restore
#else
        public string OsMinimumVersion {
            get { return BackingStore?.Get<string>("osMinimumVersion"); }
            set { BackingStore?.Set("osMinimumVersion", value); }
        }
#endif
        /// <summary>Whether or not to block syncing the calendar.</summary>
        public bool? PasswordBlockSimple {
            get { return BackingStore?.Get<bool?>("passwordBlockSimple"); }
            set { BackingStore?.Set("passwordBlockSimple", value); }
        }
        /// <summary>Number of days before password expiration. Valid values 1 to 255</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount {
            get { return BackingStore?.Get<int?>("passwordMinimumCharacterSetCount"); }
            set { BackingStore?.Set("passwordMinimumCharacterSetCount", value); }
        }
        /// <summary>Minimum password length. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeLock"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeLock", value); }
        }
        /// <summary>The number of previous passwords to prevent re-use of.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Require a password to unlock Windows Phone device.</summary>
        public bool? PasswordRequired {
            get { return BackingStore?.Get<bool?>("passwordRequired"); }
            set { BackingStore?.Set("passwordRequired", value); }
        }
        /// <summary>Possible values of required passwords.</summary>
        public RequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<RequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Require a password to unlock an idle device.</summary>
        public bool? PasswordRequireToUnlockFromIdle {
            get { return BackingStore?.Get<bool?>("passwordRequireToUnlockFromIdle"); }
            set { BackingStore?.Set("passwordRequireToUnlockFromIdle", value); }
        }
        /// <summary>Require devices to be reported as healthy by Windows Device Health Attestation - secure boot is enabled.</summary>
        public bool? SecureBootEnabled {
            get { return BackingStore?.Get<bool?>("secureBootEnabled"); }
            set { BackingStore?.Set("secureBootEnabled", value); }
        }
        /// <summary>Require encryption on windows devices.</summary>
        public bool? StorageRequireEncryption {
            get { return BackingStore?.Get<bool?>("storageRequireEncryption"); }
            set { BackingStore?.Set("storageRequireEncryption", value); }
        }
        /// <summary>
        /// Instantiates a new windows10MobileCompliancePolicy and sets the default values.
        /// </summary>
        public Windows10MobileCompliancePolicy() : base() {
            OdataType = "#microsoft.graph.windows10MobileCompliancePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10MobileCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10MobileCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bitLockerEnabled", n => { BitLockerEnabled = n.GetBoolValue(); } },
                {"codeIntegrityEnabled", n => { CodeIntegrityEnabled = n.GetBoolValue(); } },
                {"earlyLaunchAntiMalwareDriverEnabled", n => { EarlyLaunchAntiMalwareDriverEnabled = n.GetBoolValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordBlockSimple", n => { PasswordBlockSimple = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"passwordRequireToUnlockFromIdle", n => { PasswordRequireToUnlockFromIdle = n.GetBoolValue(); } },
                {"secureBootEnabled", n => { SecureBootEnabled = n.GetBoolValue(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("bitLockerEnabled", BitLockerEnabled);
            writer.WriteBoolValue("codeIntegrityEnabled", CodeIntegrityEnabled);
            writer.WriteBoolValue("earlyLaunchAntiMalwareDriverEnabled", EarlyLaunchAntiMalwareDriverEnabled);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteBoolValue("passwordBlockSimple", PasswordBlockSimple);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("passwordRequireToUnlockFromIdle", PasswordRequireToUnlockFromIdle);
            writer.WriteBoolValue("secureBootEnabled", SecureBootEnabled);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}
