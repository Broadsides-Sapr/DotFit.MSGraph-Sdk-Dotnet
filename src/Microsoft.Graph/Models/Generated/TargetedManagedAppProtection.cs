// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Targeted Managed App Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TargetedManagedAppProtection : ManagedAppProtection
    {
    
		///<summary>
		/// The internal TargetedManagedAppProtection constructor
		///</summary>
        protected internal TargetedManagedAppProtection()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets is assigned.
        /// Indicates if the policy is deployed to any inclusion groups or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAssigned", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Navigation property to list of inclusion and exclusion groups to which the policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public ITargetedManagedAppProtectionAssignmentsCollectionPage Assignments { get; set; }
    
    }
}

