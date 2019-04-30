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
    /// The type WorkbookFunctionsVdbRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsVdbRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsVdbRequest>, IWorkbookFunctionsVdbRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsVdbRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="cost">A cost parameter for the OData method call.</param>
        /// <param name="salvage">A salvage parameter for the OData method call.</param>
        /// <param name="life">A life parameter for the OData method call.</param>
        /// <param name="startPeriod">A startPeriod parameter for the OData method call.</param>
        /// <param name="endPeriod">A endPeriod parameter for the OData method call.</param>
        /// <param name="factor">A factor parameter for the OData method call.</param>
        /// <param name="noSwitch">A noSwitch parameter for the OData method call.</param>
        public WorkbookFunctionsVdbRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken cost,
            Newtonsoft.Json.Linq.JToken salvage,
            Newtonsoft.Json.Linq.JToken life,
            Newtonsoft.Json.Linq.JToken startPeriod,
            Newtonsoft.Json.Linq.JToken endPeriod,
            Newtonsoft.Json.Linq.JToken factor,
            Newtonsoft.Json.Linq.JToken noSwitch)
            : base(requestUrl, client)
        {
            this.SetParameter("cost", cost, true);
            this.SetParameter("salvage", salvage, true);
            this.SetParameter("life", life, true);
            this.SetParameter("startPeriod", startPeriod, true);
            this.SetParameter("endPeriod", endPeriod, true);
            this.SetParameter("factor", factor, true);
            this.SetParameter("noSwitch", noSwitch, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsVdbRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsVdbRequest(functionUrl, this.Client, options);

            if (this.HasParameter("cost"))
            {
                request.RequestBody.Cost = this.GetParameter<Newtonsoft.Json.Linq.JToken>("cost");
            }

            if (this.HasParameter("salvage"))
            {
                request.RequestBody.Salvage = this.GetParameter<Newtonsoft.Json.Linq.JToken>("salvage");
            }

            if (this.HasParameter("life"))
            {
                request.RequestBody.Life = this.GetParameter<Newtonsoft.Json.Linq.JToken>("life");
            }

            if (this.HasParameter("startPeriod"))
            {
                request.RequestBody.StartPeriod = this.GetParameter<Newtonsoft.Json.Linq.JToken>("startPeriod");
            }

            if (this.HasParameter("endPeriod"))
            {
                request.RequestBody.EndPeriod = this.GetParameter<Newtonsoft.Json.Linq.JToken>("endPeriod");
            }

            if (this.HasParameter("factor"))
            {
                request.RequestBody.Factor = this.GetParameter<Newtonsoft.Json.Linq.JToken>("factor");
            }

            if (this.HasParameter("noSwitch"))
            {
                request.RequestBody.NoSwitch = this.GetParameter<Newtonsoft.Json.Linq.JToken>("noSwitch");
            }

            return request;
        }
    }
}
