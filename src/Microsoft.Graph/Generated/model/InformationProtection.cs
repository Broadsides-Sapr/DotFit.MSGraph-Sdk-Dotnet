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
    /// The type Information Protection.
    /// </summary>
    public partial class InformationProtection : Entity
    {
    
		///<summary>
		/// The InformationProtection constructor
		///</summary>
        public InformationProtection()
        {
            this.ODataType = "microsoft.graph.informationProtection";
        }
	
        /// <summary>
        /// Gets or sets threat assessment requests.
        /// </summary>
        [JsonPropertyName("threatAssessmentRequests")]
        public IInformationProtectionThreatAssessmentRequestsCollectionPage ThreatAssessmentRequests { get; set; }

        /// <summary>
        /// Gets or sets threatAssessmentRequestsNextLink.
        /// </summary>
        [JsonPropertyName("threatAssessmentRequests@odata.nextLink")]
        public string ThreatAssessmentRequestsNextLink { get; set; }
    
    }
}

