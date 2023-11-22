// <auto-generated/>
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.CellWithRowWithColumn;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Names;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.PivotTables;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Protection;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeNamespace;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.RangeWithAddress;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRange;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.UsedRangeWithValuesOnly;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item {
    /// <summary>
    /// Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.
    /// </summary>
    public class WorkbookWorksheetItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the charts property of the microsoft.graph.workbookWorksheet entity.</summary>
        public ChartsRequestBuilder Charts { get =>
            new ChartsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the names property of the microsoft.graph.workbookWorksheet entity.</summary>
        public NamesRequestBuilder Names { get =>
            new NamesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the pivotTables property of the microsoft.graph.workbookWorksheet entity.</summary>
        public PivotTablesRequestBuilder PivotTables { get =>
            new PivotTablesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the protection property of the microsoft.graph.workbookWorksheet entity.</summary>
        public ProtectionRequestBuilder Protection { get =>
            new ProtectionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the range method.</summary>
        public RangeRequestBuilder Range { get =>
            new RangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the tables property of the microsoft.graph.workbookWorksheet entity.</summary>
        public TablesRequestBuilder Tables { get =>
            new TablesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the usedRange method.</summary>
        public UsedRangeRequestBuilder UsedRange { get =>
            new UsedRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Provides operations to call the cell method.
        /// </summary>
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        public CellWithRowWithColumnRequestBuilder CellWithRowWithColumn(int? column, int? row) {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new CellWithRowWithColumnRequestBuilder(PathParameters, RequestAdapter, column, row);
        }
        /// <summary>
        /// Instantiates a new WorkbookWorksheetItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookWorksheetItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WorkbookWorksheetItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WorkbookWorksheetItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}{?%24select,%24expand}", rawUrl) {
        }
        /// <summary>
        /// Deletes the worksheet from the workbook. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/worksheet-delete?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieve the properties and relationships of worksheet object. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/worksheet-get?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkbookWorksheet?> GetAsync(Action<RequestConfiguration<WorkbookWorksheetItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkbookWorksheet> GetAsync(Action<RequestConfiguration<WorkbookWorksheetItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WorkbookWorksheet>(requestInfo, WorkbookWorksheet.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the properties of worksheet object. This API is available in the following national cloud deployments.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/worksheet-update?view=graph-rest-1.0" />
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkbookWorksheet?> PatchAsync(WorkbookWorksheet body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkbookWorksheet> PatchAsync(WorkbookWorksheet body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPatchRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WorkbookWorksheet>(requestInfo, WorkbookWorksheet.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the range method.
        /// </summary>
        /// <param name="address">Usage: address=&apos;{address}&apos;</param>
        public RangeWithAddressRequestBuilder RangeWithAddress(string address) {
            if(string.IsNullOrEmpty(address)) throw new ArgumentNullException(nameof(address));
            return new RangeWithAddressRequestBuilder(PathParameters, RequestAdapter, address);
        }
        /// <summary>
        /// Deletes the worksheet from the workbook. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.DELETE, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Retrieve the properties and relationships of worksheet object. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkbookWorksheetItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkbookWorksheetItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of worksheet object. This API is available in the following national cloud deployments.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(WorkbookWorksheet body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(WorkbookWorksheet body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.PATCH, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Provides operations to call the usedRange method.
        /// </summary>
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        public UsedRangeWithValuesOnlyRequestBuilder UsedRangeWithValuesOnly(bool? valuesOnly) {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new UsedRangeWithValuesOnlyRequestBuilder(PathParameters, RequestAdapter, valuesOnly);
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WorkbookWorksheetItemRequestBuilder WithUrl(string rawUrl) {
            return new WorkbookWorksheetItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorkbookWorksheetItemRequestBuilderDeleteRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
        /// <summary>
        /// Retrieve the properties and relationships of worksheet object. This API is available in the following national cloud deployments.
        /// </summary>
        public class WorkbookWorksheetItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorkbookWorksheetItemRequestBuilderGetRequestConfiguration : RequestConfiguration<WorkbookWorksheetItemRequestBuilderGetQueryParameters> {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class WorkbookWorksheetItemRequestBuilderPatchRequestConfiguration : RequestConfiguration<DefaultQueryParameters> {
        }
    }
}
