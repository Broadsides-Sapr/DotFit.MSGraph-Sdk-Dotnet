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
    /// The type Agreement File Localization.
    /// </summary>
    public partial class AgreementFileLocalization : AgreementFileProperties
    {
    
        /// <summary>
        /// Gets or sets versions.
        /// </summary>
        [JsonPropertyName("versions")]
        public IAgreementFileLocalizationVersionsCollectionPage Versions { get; set; }

        /// <summary>
        /// Gets or sets versionsNextLink.
        /// </summary>
        [JsonPropertyName("versions@odata.nextLink")]
        public string VersionsNextLink { get; set; }
    
    }
}
