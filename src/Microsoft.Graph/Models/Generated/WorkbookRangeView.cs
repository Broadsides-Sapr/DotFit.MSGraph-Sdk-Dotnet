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
    /// The type Workbook Range View.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookRangeView : Entity
    {
    
        /// <summary>
        /// Gets or sets cell addresses.
        /// Represents the cell addresses
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellAddresses", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken CellAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets column count.
        /// Returns the number of visible columns. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columnCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ColumnCount { get; set; }
    
        /// <summary>
        /// Gets or sets formulas.
        /// Represents the formula in A1-style notation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formulas", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Formulas { get; set; }
    
        /// <summary>
        /// Gets or sets formulas local.
        /// Represents the formula in A1-style notation, in the user's language and number-formatting locale. For example, the English '=SUM(A1, 1.5)' formula would become '=SUMME(A1; 1,5)' in German.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formulasLocal", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken FormulasLocal { get; set; }
    
        /// <summary>
        /// Gets or sets formulas r1c1.
        /// Represents the formula in R1C1-style notation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formulasR1C1", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken FormulasR1C1 { get; set; }
    
        /// <summary>
        /// Gets or sets index.
        /// Index of the range.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "index", Required = Newtonsoft.Json.Required.Default)]
        public Int32? Index { get; set; }
    
        /// <summary>
        /// Gets or sets number format.
        /// Represents Excel's number format code for the given cell. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "numberFormat", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken NumberFormat { get; set; }
    
        /// <summary>
        /// Gets or sets row count.
        /// Returns the number of visible rows. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rowCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RowCount { get; set; }
    
        /// <summary>
        /// Gets or sets text.
        /// Text values of the specified range. The Text value will not depend on the cell width. The # sign substitution that happens in Excel UI will not affect the text value returned by the API. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "text", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Text { get; set; }
    
        /// <summary>
        /// Gets or sets value types.
        /// Represents the type of data of each cell. Read-only. The possible values are: Unknown, Empty, String, Integer, Double, Boolean, Error.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "valueTypes", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken ValueTypes { get; set; }
    
        /// <summary>
        /// Gets or sets values.
        /// Represents the raw values of the specified range view. The data returned could be of type string, number, or a boolean. Cell that contain an error will return the error string.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "values", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Values { get; set; }
    
        /// <summary>
        /// Gets or sets rows.
        /// Represents a collection of range views associated with the range. Read-only. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rows", Required = Newtonsoft.Json.Required.Default)]
        public IWorkbookRangeViewRowsCollectionPage Rows { get; set; }
    
    }
}

