using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AndroidWorkProfileGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasswordBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>("passwordBlockFingerprintUnlock"); }
            set { BackingStore?.Set("passwordBlockFingerprintUnlock", value); }
        }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents.</summary>
        public bool? PasswordBlockTrustAgents {
            get { return BackingStore?.Get<bool?>("passwordBlockTrustAgents"); }
            set { BackingStore?.Set("passwordBlockTrustAgents", value); }
        }
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>Minimum length of passwords. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>("passwordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("passwordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>Number of previous passwords to block. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Android Work Profile required password type.</summary>
        public AndroidWorkProfileRequiredPasswordType? PasswordRequiredType {
            get { return BackingStore?.Get<AndroidWorkProfileRequiredPasswordType?>("passwordRequiredType"); }
            set { BackingStore?.Set("passwordRequiredType", value); }
        }
        /// <summary>Number of sign in failures allowed before factory reset. Valid values 1 to 16</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>("passwordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("passwordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps {
            get { return BackingStore?.Get<bool?>("securityRequireVerifyApps"); }
            set { BackingStore?.Set("securityRequireVerifyApps", value); }
        }
        /// <summary>Block users from adding/removing accounts in work profile.</summary>
        public bool? WorkProfileBlockAddingAccounts {
            get { return BackingStore?.Get<bool?>("workProfileBlockAddingAccounts"); }
            set { BackingStore?.Set("workProfileBlockAddingAccounts", value); }
        }
        /// <summary>Block work profile camera.</summary>
        public bool? WorkProfileBlockCamera {
            get { return BackingStore?.Get<bool?>("workProfileBlockCamera"); }
            set { BackingStore?.Set("workProfileBlockCamera", value); }
        }
        /// <summary>Block display work profile caller ID in personal profile.</summary>
        public bool? WorkProfileBlockCrossProfileCallerId {
            get { return BackingStore?.Get<bool?>("workProfileBlockCrossProfileCallerId"); }
            set { BackingStore?.Set("workProfileBlockCrossProfileCallerId", value); }
        }
        /// <summary>Block work profile contacts availability in personal profile.</summary>
        public bool? WorkProfileBlockCrossProfileContactsSearch {
            get { return BackingStore?.Get<bool?>("workProfileBlockCrossProfileContactsSearch"); }
            set { BackingStore?.Set("workProfileBlockCrossProfileContactsSearch", value); }
        }
        /// <summary>Boolean that indicates if the setting disallow cross profile copy/paste is enabled.</summary>
        public bool? WorkProfileBlockCrossProfileCopyPaste {
            get { return BackingStore?.Get<bool?>("workProfileBlockCrossProfileCopyPaste"); }
            set { BackingStore?.Set("workProfileBlockCrossProfileCopyPaste", value); }
        }
        /// <summary>Indicates whether or not to block notifications while device locked.</summary>
        public bool? WorkProfileBlockNotificationsWhileDeviceLocked {
            get { return BackingStore?.Get<bool?>("workProfileBlockNotificationsWhileDeviceLocked"); }
            set { BackingStore?.Set("workProfileBlockNotificationsWhileDeviceLocked", value); }
        }
        /// <summary>Block screen capture in work profile.</summary>
        public bool? WorkProfileBlockScreenCapture {
            get { return BackingStore?.Get<bool?>("workProfileBlockScreenCapture"); }
            set { BackingStore?.Set("workProfileBlockScreenCapture", value); }
        }
        /// <summary>Allow bluetooth devices to access enterprise contacts.</summary>
        public bool? WorkProfileBluetoothEnableContactSharing {
            get { return BackingStore?.Get<bool?>("workProfileBluetoothEnableContactSharing"); }
            set { BackingStore?.Set("workProfileBluetoothEnableContactSharing", value); }
        }
        /// <summary>Android Work Profile cross profile data sharing type.</summary>
        public AndroidWorkProfileCrossProfileDataSharingType? WorkProfileDataSharingType {
            get { return BackingStore?.Get<AndroidWorkProfileCrossProfileDataSharingType?>("workProfileDataSharingType"); }
            set { BackingStore?.Set("workProfileDataSharingType", value); }
        }
        /// <summary>Android Work Profile default app permission policy type.</summary>
        public AndroidWorkProfileDefaultAppPermissionPolicyType? WorkProfileDefaultAppPermissionPolicy {
            get { return BackingStore?.Get<AndroidWorkProfileDefaultAppPermissionPolicyType?>("workProfileDefaultAppPermissionPolicy"); }
            set { BackingStore?.Set("workProfileDefaultAppPermissionPolicy", value); }
        }
        /// <summary>Indicates whether or not to block fingerprint unlock for work profile.</summary>
        public bool? WorkProfilePasswordBlockFingerprintUnlock {
            get { return BackingStore?.Get<bool?>("workProfilePasswordBlockFingerprintUnlock"); }
            set { BackingStore?.Set("workProfilePasswordBlockFingerprintUnlock", value); }
        }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents for work profile.</summary>
        public bool? WorkProfilePasswordBlockTrustAgents {
            get { return BackingStore?.Get<bool?>("workProfilePasswordBlockTrustAgents"); }
            set { BackingStore?.Set("workProfilePasswordBlockTrustAgents", value); }
        }
        /// <summary>Number of days before the work profile password expires. Valid values 1 to 365</summary>
        public int? WorkProfilePasswordExpirationDays {
            get { return BackingStore?.Get<int?>("workProfilePasswordExpirationDays"); }
            set { BackingStore?.Set("workProfilePasswordExpirationDays", value); }
        }
        /// <summary>Minimum length of work profile password. Valid values 4 to 16</summary>
        public int? WorkProfilePasswordMinimumLength {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinimumLength"); }
            set { BackingStore?.Set("workProfilePasswordMinimumLength", value); }
        }
        /// <summary>Minimum # of letter characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinLetterCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinLetterCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinLetterCharacters", value); }
        }
        /// <summary>Minimum # of lower-case characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinLowerCaseCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinLowerCaseCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinLowerCaseCharacters", value); }
        }
        /// <summary>Minimum # of non-letter characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinNonLetterCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinNonLetterCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinNonLetterCharacters", value); }
        }
        /// <summary>Minimum # of numeric characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinNumericCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinNumericCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinNumericCharacters", value); }
        }
        /// <summary>Minimum # of symbols required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinSymbolCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinSymbolCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinSymbolCharacters", value); }
        }
        /// <summary>Minimum # of upper-case characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinUpperCaseCharacters {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinUpperCaseCharacters"); }
            set { BackingStore?.Set("workProfilePasswordMinUpperCaseCharacters", value); }
        }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout {
            get { return BackingStore?.Get<int?>("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout"); }
            set { BackingStore?.Set("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", value); }
        }
        /// <summary>Number of previous work profile passwords to block. Valid values 0 to 24</summary>
        public int? WorkProfilePasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("workProfilePasswordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("workProfilePasswordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Android Work Profile required password type.</summary>
        public AndroidWorkProfileRequiredPasswordType? WorkProfilePasswordRequiredType {
            get { return BackingStore?.Get<AndroidWorkProfileRequiredPasswordType?>("workProfilePasswordRequiredType"); }
            set { BackingStore?.Set("workProfilePasswordRequiredType", value); }
        }
        /// <summary>Number of sign in failures allowed before work profile is removed and all corporate data deleted. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordSignInFailureCountBeforeFactoryReset {
            get { return BackingStore?.Get<int?>("workProfilePasswordSignInFailureCountBeforeFactoryReset"); }
            set { BackingStore?.Set("workProfilePasswordSignInFailureCountBeforeFactoryReset", value); }
        }
        /// <summary>Password is required or not for work profile</summary>
        public bool? WorkProfileRequirePassword {
            get { return BackingStore?.Get<bool?>("workProfileRequirePassword"); }
            set { BackingStore?.Set("workProfileRequirePassword", value); }
        }
        /// <summary>
        /// Instantiates a new AndroidWorkProfileGeneralDeviceConfiguration and sets the default values.
        /// </summary>
        public AndroidWorkProfileGeneralDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.androidWorkProfileGeneralDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidWorkProfileGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidWorkProfileGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"passwordBlockFingerprintUnlock", n => { PasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passwordBlockTrustAgents", n => { PasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidWorkProfileRequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"workProfileBlockAddingAccounts", n => { WorkProfileBlockAddingAccounts = n.GetBoolValue(); } },
                {"workProfileBlockCamera", n => { WorkProfileBlockCamera = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileCallerId", n => { WorkProfileBlockCrossProfileCallerId = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileContactsSearch", n => { WorkProfileBlockCrossProfileContactsSearch = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileCopyPaste", n => { WorkProfileBlockCrossProfileCopyPaste = n.GetBoolValue(); } },
                {"workProfileBlockNotificationsWhileDeviceLocked", n => { WorkProfileBlockNotificationsWhileDeviceLocked = n.GetBoolValue(); } },
                {"workProfileBlockScreenCapture", n => { WorkProfileBlockScreenCapture = n.GetBoolValue(); } },
                {"workProfileBluetoothEnableContactSharing", n => { WorkProfileBluetoothEnableContactSharing = n.GetBoolValue(); } },
                {"workProfileDataSharingType", n => { WorkProfileDataSharingType = n.GetEnumValue<AndroidWorkProfileCrossProfileDataSharingType>(); } },
                {"workProfileDefaultAppPermissionPolicy", n => { WorkProfileDefaultAppPermissionPolicy = n.GetEnumValue<AndroidWorkProfileDefaultAppPermissionPolicyType>(); } },
                {"workProfilePasswordBlockFingerprintUnlock", n => { WorkProfilePasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"workProfilePasswordBlockTrustAgents", n => { WorkProfilePasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"workProfilePasswordExpirationDays", n => { WorkProfilePasswordExpirationDays = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLength", n => { WorkProfilePasswordMinimumLength = n.GetIntValue(); } },
                {"workProfilePasswordMinLetterCharacters", n => { WorkProfilePasswordMinLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinLowerCaseCharacters", n => { WorkProfilePasswordMinLowerCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinNonLetterCharacters", n => { WorkProfilePasswordMinNonLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinNumericCharacters", n => { WorkProfilePasswordMinNumericCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinSymbolCharacters", n => { WorkProfilePasswordMinSymbolCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinUpperCaseCharacters", n => { WorkProfilePasswordMinUpperCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", n => { WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"workProfilePasswordPreviousPasswordBlockCount", n => { WorkProfilePasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"workProfilePasswordRequiredType", n => { WorkProfilePasswordRequiredType = n.GetEnumValue<AndroidWorkProfileRequiredPasswordType>(); } },
                {"workProfilePasswordSignInFailureCountBeforeFactoryReset", n => { WorkProfilePasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"workProfileRequirePassword", n => { WorkProfileRequirePassword = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("passwordBlockFingerprintUnlock", PasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("passwordBlockTrustAgents", PasswordBlockTrustAgents);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<AndroidWorkProfileRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteBoolValue("workProfileBlockAddingAccounts", WorkProfileBlockAddingAccounts);
            writer.WriteBoolValue("workProfileBlockCamera", WorkProfileBlockCamera);
            writer.WriteBoolValue("workProfileBlockCrossProfileCallerId", WorkProfileBlockCrossProfileCallerId);
            writer.WriteBoolValue("workProfileBlockCrossProfileContactsSearch", WorkProfileBlockCrossProfileContactsSearch);
            writer.WriteBoolValue("workProfileBlockCrossProfileCopyPaste", WorkProfileBlockCrossProfileCopyPaste);
            writer.WriteBoolValue("workProfileBlockNotificationsWhileDeviceLocked", WorkProfileBlockNotificationsWhileDeviceLocked);
            writer.WriteBoolValue("workProfileBlockScreenCapture", WorkProfileBlockScreenCapture);
            writer.WriteBoolValue("workProfileBluetoothEnableContactSharing", WorkProfileBluetoothEnableContactSharing);
            writer.WriteEnumValue<AndroidWorkProfileCrossProfileDataSharingType>("workProfileDataSharingType", WorkProfileDataSharingType);
            writer.WriteEnumValue<AndroidWorkProfileDefaultAppPermissionPolicyType>("workProfileDefaultAppPermissionPolicy", WorkProfileDefaultAppPermissionPolicy);
            writer.WriteBoolValue("workProfilePasswordBlockFingerprintUnlock", WorkProfilePasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("workProfilePasswordBlockTrustAgents", WorkProfilePasswordBlockTrustAgents);
            writer.WriteIntValue("workProfilePasswordExpirationDays", WorkProfilePasswordExpirationDays);
            writer.WriteIntValue("workProfilePasswordMinimumLength", WorkProfilePasswordMinimumLength);
            writer.WriteIntValue("workProfilePasswordMinLetterCharacters", WorkProfilePasswordMinLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinLowerCaseCharacters", WorkProfilePasswordMinLowerCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinNonLetterCharacters", WorkProfilePasswordMinNonLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinNumericCharacters", WorkProfilePasswordMinNumericCharacters);
            writer.WriteIntValue("workProfilePasswordMinSymbolCharacters", WorkProfilePasswordMinSymbolCharacters);
            writer.WriteIntValue("workProfilePasswordMinUpperCaseCharacters", WorkProfilePasswordMinUpperCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("workProfilePasswordPreviousPasswordBlockCount", WorkProfilePasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<AndroidWorkProfileRequiredPasswordType>("workProfilePasswordRequiredType", WorkProfilePasswordRequiredType);
            writer.WriteIntValue("workProfilePasswordSignInFailureCountBeforeFactoryReset", WorkProfilePasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("workProfileRequirePassword", WorkProfileRequirePassword);
        }
    }
}
