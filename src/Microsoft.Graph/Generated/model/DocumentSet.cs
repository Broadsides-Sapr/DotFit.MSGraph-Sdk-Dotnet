// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type DocumentSet.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DocumentSet>))]
    public partial class DocumentSet
    {

        /// <summary>
        /// Gets or sets allowedContentTypes.
        /// Content types allowed in document set.
        /// </summary>
        [JsonPropertyName("allowedContentTypes")]
        public IEnumerable<ContentTypeInfo> AllowedContentTypes { get; set; }
    
        /// <summary>
        /// Gets or sets defaultContents.
        /// Default contents of document set.
        /// </summary>
        [JsonPropertyName("defaultContents")]
        public IEnumerable<DocumentSetContent> DefaultContents { get; set; }
    
        /// <summary>
        /// Gets or sets propagateWelcomePageChanges.
        /// Specifies whether to push welcome page changes to inherited content types.
        /// </summary>
        [JsonPropertyName("propagateWelcomePageChanges")]
        public bool? PropagateWelcomePageChanges { get; set; }
    
        /// <summary>
        /// Gets or sets shouldPrefixNameToFile.
        /// Indicates whether to add the name of the document set to each file name.
        /// </summary>
        [JsonPropertyName("shouldPrefixNameToFile")]
        public bool? ShouldPrefixNameToFile { get; set; }
    
        /// <summary>
        /// Gets or sets welcomePageUrl.
        /// Welcome page absolute URL.
        /// </summary>
        [JsonPropertyName("welcomePageUrl")]
        public string WelcomePageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets sharedColumns.
        /// </summary>
        [JsonPropertyName("sharedColumns")]
        public IEnumerable<ColumnDefinition> SharedColumns { get; set; }
    
        /// <summary>
        /// Gets or sets welcomePageColumns.
        /// </summary>
        [JsonPropertyName("welcomePageColumns")]
        public IEnumerable<ColumnDefinition> WelcomePageColumns { get; set; }
    
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
