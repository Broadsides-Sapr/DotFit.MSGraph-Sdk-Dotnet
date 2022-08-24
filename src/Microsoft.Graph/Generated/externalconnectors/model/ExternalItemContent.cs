// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph.ExternalConnectors
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ExternalItemContent.
    /// </summary>
    [JsonConverter(typeof(Microsoft.Graph.DerivedTypeConverter<ExternalItemContent>))]
    public partial class ExternalItemContent
    {

        /// <summary>
        /// Gets or sets type.
        /// The type of content in the value property. Possible values are: text, html, unknownFutureValue. These are the content types that the indexer supports, and not the file extension types allowed.
        /// </summary>
        [JsonPropertyName("type")]
        public ExternalItemContentType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// The content for the externalItem. Required.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
