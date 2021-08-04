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
    /// The type Print Service.
    /// </summary>
    public partial class PrintService : Entity
    {
    
        /// <summary>
        /// Gets or sets endpoints.
        /// Endpoints that can be used to access the service. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("endpoints")]
        public IPrintServiceEndpointsCollectionPage Endpoints { get; set; }

        /// <summary>
        /// Gets or sets endpointsNextLink.
        /// </summary>
        [JsonPropertyName("endpoints@odata.nextLink")]
        public string EndpointsNextLink { get; set; }
    
    }
}
