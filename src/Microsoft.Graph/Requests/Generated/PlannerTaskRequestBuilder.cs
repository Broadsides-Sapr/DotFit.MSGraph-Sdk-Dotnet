// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type PlannerTaskRequestBuilder.
    /// </summary>
    public partial class PlannerTaskRequestBuilder : EntityRequestBuilder, IPlannerTaskRequestBuilder
    {

        /// <summary>
        /// Constructs a new PlannerTaskRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PlannerTaskRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPlannerTaskRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPlannerTaskRequest Request(IEnumerable<Option> options)
        {
            return new PlannerTaskRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Details.
        /// </summary>
        /// <returns>The <see cref="IPlannerTaskDetailsRequestBuilder"/>.</returns>
        public IPlannerTaskDetailsRequestBuilder Details
        {
            get
            {
                return new PlannerTaskDetailsRequestBuilder(this.AppendSegmentToRequestUrl("details"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AssignedToTaskBoardFormat.
        /// </summary>
        /// <returns>The <see cref="IPlannerAssignedToTaskBoardTaskFormatRequestBuilder"/>.</returns>
        public IPlannerAssignedToTaskBoardTaskFormatRequestBuilder AssignedToTaskBoardFormat
        {
            get
            {
                return new PlannerAssignedToTaskBoardTaskFormatRequestBuilder(this.AppendSegmentToRequestUrl("assignedToTaskBoardFormat"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ProgressTaskBoardFormat.
        /// </summary>
        /// <returns>The <see cref="IPlannerProgressTaskBoardTaskFormatRequestBuilder"/>.</returns>
        public IPlannerProgressTaskBoardTaskFormatRequestBuilder ProgressTaskBoardFormat
        {
            get
            {
                return new PlannerProgressTaskBoardTaskFormatRequestBuilder(this.AppendSegmentToRequestUrl("progressTaskBoardFormat"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for BucketTaskBoardFormat.
        /// </summary>
        /// <returns>The <see cref="IPlannerBucketTaskBoardTaskFormatRequestBuilder"/>.</returns>
        public IPlannerBucketTaskBoardTaskFormatRequestBuilder BucketTaskBoardFormat
        {
            get
            {
                return new PlannerBucketTaskBoardTaskFormatRequestBuilder(this.AppendSegmentToRequestUrl("bucketTaskBoardFormat"), this.Client);
            }
        }
    
    }
}
