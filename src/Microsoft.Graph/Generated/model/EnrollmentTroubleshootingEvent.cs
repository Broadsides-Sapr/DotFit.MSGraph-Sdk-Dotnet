// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Enrollment Troubleshooting Event.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EnrollmentTroubleshootingEvent>))]
    public partial class EnrollmentTroubleshootingEvent : DeviceManagementTroubleshootingEvent
    {
    
        ///<summary>
        /// The EnrollmentTroubleshootingEvent constructor
        ///</summary>
        public EnrollmentTroubleshootingEvent()
        {
            this.ODataType = "microsoft.graph.enrollmentTroubleshootingEvent";
        }

        /// <summary>
        /// Gets or sets device id.
        /// Azure AD device identifier.
        /// </summary>
        [JsonPropertyName("deviceId")]
        public string DeviceId { get; set; }
    
        /// <summary>
        /// Gets or sets enrollment type.
        /// Type of the enrollment. Possible values are: unknown, userEnrollment, deviceEnrollmentManager, appleBulkWithUser, appleBulkWithoutUser, windowsAzureADJoin, windowsBulkUserless, windowsAutoEnrollment, windowsBulkAzureDomainJoin, windowsCoManagement, windowsAzureADJoinUsingDeviceAuth, appleUserEnrollment, appleUserEnrollmentWithServiceAccount.
        /// </summary>
        [JsonPropertyName("enrollmentType")]
        public DeviceEnrollmentType? EnrollmentType { get; set; }
    
        /// <summary>
        /// Gets or sets failure category.
        /// Highlevel failure category. Possible values are: unknown, authentication, authorization, accountValidation, userValidation, deviceNotSupported, inMaintenance, badRequest, featureNotSupported, enrollmentRestrictionsEnforced, clientDisconnected, userAbandonment.
        /// </summary>
        [JsonPropertyName("failureCategory")]
        public DeviceEnrollmentFailureReason? FailureCategory { get; set; }
    
        /// <summary>
        /// Gets or sets failure reason.
        /// Detailed failure reason.
        /// </summary>
        [JsonPropertyName("failureReason")]
        public string FailureReason { get; set; }
    
        /// <summary>
        /// Gets or sets managed device identifier.
        /// Device identifier created or collected by Intune.
        /// </summary>
        [JsonPropertyName("managedDeviceIdentifier")]
        public string ManagedDeviceIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets operating system.
        /// Operating System.
        /// </summary>
        [JsonPropertyName("operatingSystem")]
        public string OperatingSystem { get; set; }
    
        /// <summary>
        /// Gets or sets os version.
        /// OS Version.
        /// </summary>
        [JsonPropertyName("osVersion")]
        public string OsVersion { get; set; }
    
        /// <summary>
        /// Gets or sets user id.
        /// Identifier for the user that tried to enroll the device.
        /// </summary>
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    
    }
}

