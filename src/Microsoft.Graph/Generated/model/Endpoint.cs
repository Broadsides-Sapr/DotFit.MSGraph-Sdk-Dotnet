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
    /// The type Endpoint.
    /// </summary>
    public partial class Endpoint : DirectoryObject
    {
    
        ///<summary>
        /// The Endpoint constructor
        ///</summary>
        public Endpoint()
        {
            this.ODataType = "microsoft.graph.endpoint";
        }

        /// <summary>
        /// Gets or sets capability.
        /// </summary>
        [JsonPropertyName("capability")]
        public string Capability { get; set; }
    
        /// <summary>
        /// Gets or sets provider id.
        /// </summary>
        [JsonPropertyName("providerId")]
        public string ProviderId { get; set; }
    
        /// <summary>
        /// Gets or sets provider name.
        /// </summary>
        [JsonPropertyName("providerName")]
        public string ProviderName { get; set; }
    
        /// <summary>
        /// Gets or sets provider resource id.
        /// </summary>
        [JsonPropertyName("providerResourceId")]
        public string ProviderResourceId { get; set; }
    
        /// <summary>
        /// Gets or sets uri.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    
    }
}

