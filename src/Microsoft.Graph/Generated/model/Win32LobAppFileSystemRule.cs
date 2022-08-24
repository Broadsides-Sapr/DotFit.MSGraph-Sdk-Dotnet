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
    /// The type Win32LobAppFileSystemRule.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Win32LobAppFileSystemRule>))]
    public partial class Win32LobAppFileSystemRule : Win32LobAppRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Win32LobAppFileSystemRule"/> class.
        /// </summary>
        public Win32LobAppFileSystemRule()
        {
            this.ODataType = "microsoft.graph.win32LobAppFileSystemRule";
        }

        /// <summary>
        /// Gets or sets check32BitOn64System.
        /// A value indicating whether to expand environment variables in the 32-bit context on 64-bit systems.
        /// </summary>
        [JsonPropertyName("check32BitOn64System")]
        public bool? Check32BitOn64System { get; set; }
    
        /// <summary>
        /// Gets or sets comparisonValue.
        /// The file or folder comparison value.
        /// </summary>
        [JsonPropertyName("comparisonValue")]
        public string ComparisonValue { get; set; }
    
        /// <summary>
        /// Gets or sets fileOrFolderName.
        /// The file or folder name to look up.
        /// </summary>
        [JsonPropertyName("fileOrFolderName")]
        public string FileOrFolderName { get; set; }
    
        /// <summary>
        /// Gets or sets operationType.
        /// The file system operation type. Possible values are: notConfigured, exists, modifiedDate, createdDate, version, sizeInMB.
        /// </summary>
        [JsonPropertyName("operationType")]
        public Win32LobAppFileSystemOperationType? OperationType { get; set; }
    
        /// <summary>
        /// Gets or sets operator.
        /// The operator for file or folder detection. Possible values are: notConfigured, equal, notEqual, greaterThan, greaterThanOrEqual, lessThan, lessThanOrEqual.
        /// </summary>
        [JsonPropertyName("operator")]
        public Win32LobAppRuleOperator? Operator { get; set; }
    
        /// <summary>
        /// Gets or sets path.
        /// The file or folder path to look up.
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }
    
    }
}
