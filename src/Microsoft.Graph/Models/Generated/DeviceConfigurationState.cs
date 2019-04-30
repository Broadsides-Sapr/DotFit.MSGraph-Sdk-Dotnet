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
    /// The type Device Configuration State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceConfigurationState : Entity
    {
    
        /// <summary>
        /// Gets or sets setting states.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingStates", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<DeviceConfigurationSettingState> SettingStates { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name of the policy for this policyBase
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets version.
        /// The version of the policy
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "version", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Version { get; set; }
    
        /// <summary>
        /// Gets or sets platform type.
        /// Platform type that the policy applies to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platformType", Required = Newtonsoft.Json.Required.Default)]
        public PolicyPlatformType? PlatformType { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The compliance state of the policy
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public ComplianceStatus? State { get; set; }
    
        /// <summary>
        /// Gets or sets setting count.
        /// Count of how many setting a policy holds
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SettingCount { get; set; }
    
    }
}

