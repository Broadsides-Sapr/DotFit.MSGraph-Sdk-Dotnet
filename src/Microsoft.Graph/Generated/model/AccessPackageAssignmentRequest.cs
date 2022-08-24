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
    /// The type Access Package Assignment Request.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<AccessPackageAssignmentRequestObject>))]
    public partial class AccessPackageAssignmentRequestObject : Entity
    {
    
        /// <summary>
        /// Gets or sets completed date time.
        /// The date of the end of processing, either successful or failure, of a request. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.
        /// </summary>
        [JsonPropertyName("completedDateTime")]
        public DateTimeOffset? CompletedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Supports $filter.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets request type.
        /// The type of the request. The possible values are: notSpecified, userAdd, userUpdate, userRemove, adminAdd, adminUpdate, adminRemove, systemAdd, systemUpdate, systemRemove, onBehalfAdd, unknownFutureValue. A request from the user themselves would have requestType of UserAdd or UserRemove. This property cannot be changed once set.
        /// </summary>
        [JsonPropertyName("requestType")]
        public AccessPackageRequestType? RequestType { get; set; }
    
        /// <summary>
        /// Gets or sets schedule.
        /// The range of dates that access is to be assigned to the requestor. This property cannot be changed once set.
        /// </summary>
        [JsonPropertyName("schedule")]
        public EntitlementManagementSchedule Schedule { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The state of the request. The possible values are: submitted, pendingApproval, delivering, delivered, deliveryFailed, denied, scheduled, canceled, partiallyDelivered, unknownFutureValue. Read-only. Supports $filter (eq).
        /// </summary>
        [JsonPropertyName("state")]
        public AccessPackageRequestState? State { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// More information on the request processing status. Read-only.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    
        /// <summary>
        /// Gets or sets access package.
        /// The access package associated with the accessPackageAssignmentRequest. An access package defines the collections of resource roles and the policies for how one or more users can get access to those resources. Read-only. Nullable.  Supports $expand.
        /// </summary>
        [JsonPropertyName("accessPackage")]
        public AccessPackage AccessPackage { get; set; }
    
        /// <summary>
        /// Gets or sets assignment.
        /// For a requestType of UserAdd or AdminAdd, this is an access package assignment requested to be created.  For a requestType of UserRemove, AdminRemove or SystemRemove, this has the id property of an existing assignment to be removed.   Supports $expand.
        /// </summary>
        [JsonPropertyName("assignment")]
        public AccessPackageAssignment Assignment { get; set; }
    
        /// <summary>
        /// Gets or sets requestor.
        /// The subject who requested or, if a direct assignment, was assigned. Read-only. Nullable. Supports $expand.
        /// </summary>
        [JsonPropertyName("requestor")]
        public AccessPackageSubject Requestor { get; set; }
    
    }
}

