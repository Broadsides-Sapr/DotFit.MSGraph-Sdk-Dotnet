// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum ApplicationGuardBlockClipboardSharingType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ApplicationGuardBlockClipboardSharingType
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Block Both
        /// </summary>
        BlockBoth = 1,
	
        /// <summary>
        /// Block Host To Container
        /// </summary>
        BlockHostToContainer = 2,
	
        /// <summary>
        /// Block Container To Host
        /// </summary>
        BlockContainerToHost = 3,
	
        /// <summary>
        /// Block None
        /// </summary>
        BlockNone = 4,
	
    }
}
