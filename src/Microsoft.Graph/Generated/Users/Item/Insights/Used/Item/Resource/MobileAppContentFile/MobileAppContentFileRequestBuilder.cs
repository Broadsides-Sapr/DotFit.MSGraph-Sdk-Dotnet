using Microsoft.Kiota.Abstractions;
using MicrosoftGraphSdk.Users.Item.Insights.Used.Item.Resource.MobileAppContentFile.Commit;
using MicrosoftGraphSdk.Users.Item.Insights.Used.Item.Resource.MobileAppContentFile.RenewUpload;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace MicrosoftGraphSdk.Users.Item.Insights.Used.Item.Resource.MobileAppContentFile {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\used\{usedInsight-id}\resource\microsoft.graph.mobileAppContentFile</summary>
    public class MobileAppContentFileRequestBuilder {
        public CommitRequestBuilder Commit { get =>
            new CommitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        public RenewUploadRequestBuilder RenewUpload { get =>
            new RenewUploadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new MobileAppContentFileRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MobileAppContentFileRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/used/{usedInsight_id}/resource/microsoft.graph.mobileAppContentFile";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new MobileAppContentFileRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public MobileAppContentFileRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/users/{user_id}/insights/used/{usedInsight_id}/resource/microsoft.graph.mobileAppContentFile";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
