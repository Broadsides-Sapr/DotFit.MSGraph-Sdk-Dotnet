// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsEdateRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsEdateRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsEdateRequest>, IWorkbookFunctionsEdateRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsEdateRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="startDate">A startDate parameter for the OData method call.</param>
        /// <param name="months">A months parameter for the OData method call.</param>
        public WorkbookFunctionsEdateRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken startDate,
            Newtonsoft.Json.Linq.JToken months)
            : base(requestUrl, client)
        {
            this.SetParameter("startDate", startDate, true);
            this.SetParameter("months", months, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsEdateRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsEdateRequest(functionUrl, this.Client, options);

            if (this.HasParameter("startDate"))
            {
                request.RequestBody.StartDate = this.GetParameter<Newtonsoft.Json.Linq.JToken>("startDate");
            }

            if (this.HasParameter("months"))
            {
                request.RequestBody.Months = this.GetParameter<Newtonsoft.Json.Linq.JToken>("months");
            }

            return request;
        }
    }
}
