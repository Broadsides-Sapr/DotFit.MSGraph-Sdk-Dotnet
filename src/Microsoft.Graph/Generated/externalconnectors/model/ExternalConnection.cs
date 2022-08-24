// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type External Connection.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ExternalConnection>))]
    public partial class ExternalConnection : Microsoft.Graph.Entity
    {
    
        /// <summary>
        /// Gets or sets configuration.
        /// Specifies additional application IDs that are allowed to manage the connection and to index content in the connection. Optional.
        /// </summary>
        [JsonPropertyName("configuration")]
        public Configuration Configuration { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Description of the connection displayed in the Microsoft 365 admin center. Optional.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The display name of the connection to be displayed in the Microsoft 365 admin center. Maximum length of 128 characters. Required.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// Indicates the current state of the connection. Possible values are: draft, ready, obsolete, limitExceeded, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("state")]
        public ConnectionState? State { get; set; }
    
        /// <summary>
        /// Gets or sets groups.
        /// </summary>
        [JsonPropertyName("groups")]
        public IExternalConnectionGroupsCollectionPage Groups { get; set; }

        /// <summary>
        /// Gets or sets groupsNextLink.
        /// </summary>
        [JsonPropertyName("groups@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string GroupsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// </summary>
        [JsonPropertyName("items")]
        public IExternalConnectionItemsCollectionPage Items { get; set; }

        /// <summary>
        /// Gets or sets itemsNextLink.
        /// </summary>
        [JsonPropertyName("items@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ItemsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// </summary>
        [JsonPropertyName("operations")]
        public IExternalConnectionOperationsCollectionPage Operations { get; set; }

        /// <summary>
        /// Gets or sets operationsNextLink.
        /// </summary>
        [JsonPropertyName("operations@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string OperationsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets schema.
        /// </summary>
        [JsonPropertyName("schema")]
        public Schema Schema { get; set; }
    
    }
}

