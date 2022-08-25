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
    /// The type PrinterDefaults.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<PrinterDefaults>))]
    public partial class PrinterDefaults
    {

        /// <summary>
        /// Gets or sets colorMode.
        /// The default color mode to use when printing the document. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("colorMode")]
        public PrintColorMode? ColorMode { get; set; }
    
        /// <summary>
        /// Gets or sets contentType.
        /// The default content (MIME) type to use when processing documents.
        /// </summary>
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    
        /// <summary>
        /// Gets or sets copiesPerJob.
        /// The default number of copies printed per job.
        /// </summary>
        [JsonPropertyName("copiesPerJob")]
        public Int32? CopiesPerJob { get; set; }
    
        /// <summary>
        /// Gets or sets dpi.
        /// The default resolution in DPI to use when printing the job.
        /// </summary>
        [JsonPropertyName("dpi")]
        public Int32? Dpi { get; set; }
    
        /// <summary>
        /// Gets or sets duplexMode.
        /// The default duplex (double-sided) configuration to use when printing a document. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("duplexMode")]
        public PrintDuplexMode? DuplexMode { get; set; }
    
        /// <summary>
        /// Gets or sets finishings.
        /// The default set of finishings to apply to print jobs. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("finishings")]
        public IEnumerable<PrintFinishing> Finishings { get; set; }
    
        /// <summary>
        /// Gets or sets fitPdfToPage.
        /// The default fitPdfToPage setting. True to fit each page of a PDF document to a physical sheet of media; false to let the printer decide how to lay out impressions.
        /// </summary>
        [JsonPropertyName("fitPdfToPage")]
        public bool? FitPdfToPage { get; set; }
    
        /// <summary>
        /// Gets or sets inputBin.
        /// </summary>
        [JsonPropertyName("inputBin")]
        public string InputBin { get; set; }
    
        /// <summary>
        /// Gets or sets mediaColor.
        /// The default media (such as paper) color to print the document on.
        /// </summary>
        [JsonPropertyName("mediaColor")]
        public string MediaColor { get; set; }
    
        /// <summary>
        /// Gets or sets mediaSize.
        /// The default media size to use. Supports standard size names for ISO and ANSI media sizes. Valid values are listed in the printerCapabilities topic.
        /// </summary>
        [JsonPropertyName("mediaSize")]
        public string MediaSize { get; set; }
    
        /// <summary>
        /// Gets or sets mediaType.
        /// The default media (such as paper) type to print the document on.
        /// </summary>
        [JsonPropertyName("mediaType")]
        public string MediaType { get; set; }
    
        /// <summary>
        /// Gets or sets multipageLayout.
        /// The default direction to lay out pages when multiple pages are being printed per sheet. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("multipageLayout")]
        public PrintMultipageLayout? MultipageLayout { get; set; }
    
        /// <summary>
        /// Gets or sets orientation.
        /// The default orientation to use when printing the document. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("orientation")]
        public PrintOrientation? Orientation { get; set; }
    
        /// <summary>
        /// Gets or sets outputBin.
        /// The default output bin to place completed prints into. See the printer's capabilities for a list of supported output bins.
        /// </summary>
        [JsonPropertyName("outputBin")]
        public string OutputBin { get; set; }
    
        /// <summary>
        /// Gets or sets pagesPerSheet.
        /// The default number of document pages to print on each sheet.
        /// </summary>
        [JsonPropertyName("pagesPerSheet")]
        public Int32? PagesPerSheet { get; set; }
    
        /// <summary>
        /// Gets or sets quality.
        /// The default quality to use when printing the document. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("quality")]
        public PrintQuality? Quality { get; set; }
    
        /// <summary>
        /// Gets or sets scaling.
        /// Specifies how the printer scales the document data to fit the requested media. Valid values are described in the following table.
        /// </summary>
        [JsonPropertyName("scaling")]
        public PrintScaling? Scaling { get; set; }
    
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
