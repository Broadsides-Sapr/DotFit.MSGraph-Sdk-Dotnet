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
    /// The type Workbook Chart.
    /// </summary>
    public partial class WorkbookChart : Entity
    {
    
		///<summary>
		/// The WorkbookChart constructor
		///</summary>
        public WorkbookChart()
        {
            this.ODataType = "microsoft.graph.workbookChart";
        }
	
        /// <summary>
        /// Gets or sets height.
        /// Represents the height, in points, of the chart object.
        /// </summary>
        [JsonPropertyName("height")]
        public double? Height { get; set; }
    
        /// <summary>
        /// Gets or sets left.
        /// The distance, in points, from the left side of the chart to the worksheet origin.
        /// </summary>
        [JsonPropertyName("left")]
        public double? Left { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// Represents the name of a chart object.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets top.
        /// Represents the distance, in points, from the top edge of the object to the top of row 1 (on a worksheet) or the top of the chart area (on a chart).
        /// </summary>
        [JsonPropertyName("top")]
        public double? Top { get; set; }
    
        /// <summary>
        /// Gets or sets width.
        /// Represents the width, in points, of the chart object.
        /// </summary>
        [JsonPropertyName("width")]
        public double? Width { get; set; }
    
        /// <summary>
        /// Gets or sets axes.
        /// Represents chart axes. Read-only.
        /// </summary>
        [JsonPropertyName("axes")]
        public WorkbookChartAxes Axes { get; set; }
    
        /// <summary>
        /// Gets or sets data labels.
        /// Represents the datalabels on the chart. Read-only.
        /// </summary>
        [JsonPropertyName("dataLabels")]
        public WorkbookChartDataLabels DataLabels { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Encapsulates the format properties for the chart area. Read-only.
        /// </summary>
        [JsonPropertyName("format")]
        public WorkbookChartAreaFormat Format { get; set; }
    
        /// <summary>
        /// Gets or sets legend.
        /// Represents the legend for the chart. Read-only.
        /// </summary>
        [JsonPropertyName("legend")]
        public WorkbookChartLegend Legend { get; set; }
    
        /// <summary>
        /// Gets or sets series.
        /// Represents either a single series or collection of series in the chart. Read-only.
        /// </summary>
        [JsonPropertyName("series")]
        public IWorkbookChartSeriesCollectionPage Series { get; set; }

        /// <summary>
        /// Gets or sets seriesNextLink.
        /// </summary>
        [JsonPropertyName("series@odata.nextLink")]
        public string SeriesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Represents the title of the specified chart, including the text, visibility, position and formating of the title. Read-only.
        /// </summary>
        [JsonPropertyName("title")]
        public WorkbookChartTitle Title { get; set; }
    
        /// <summary>
        /// Gets or sets worksheet.
        /// The worksheet containing the current chart. Read-only.
        /// </summary>
        [JsonPropertyName("worksheet")]
        public WorkbookWorksheet Worksheet { get; set; }
    
    }
}

