// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type WorkbookTableRequest.
    /// </summary>
    public partial class WorkbookTableRequest : BaseRequest, IWorkbookTableRequest
    {
        /// <summary>
        /// Constructs a new WorkbookTableRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public WorkbookTableRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified WorkbookTable using POST.
        /// </summary>
        /// <param name="workbookTableToCreate">The WorkbookTable to create.</param>
        /// <returns>The created WorkbookTable.</returns>
        public System.Threading.Tasks.Task<WorkbookTable> CreateAsync(WorkbookTable workbookTableToCreate)
        {
            return this.CreateAsync(workbookTableToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified WorkbookTable using POST.
        /// </summary>
        /// <param name="workbookTableToCreate">The WorkbookTable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookTable.</returns>
        public async System.Threading.Tasks.Task<WorkbookTable> CreateAsync(WorkbookTable workbookTableToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<WorkbookTable>(workbookTableToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified WorkbookTable.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified WorkbookTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<WorkbookTable>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified WorkbookTable.
        /// </summary>
        /// <returns>The WorkbookTable.</returns>
        public System.Threading.Tasks.Task<WorkbookTable> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified WorkbookTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookTable.</returns>
        public async System.Threading.Tasks.Task<WorkbookTable> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<WorkbookTable>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified WorkbookTable using PATCH.
        /// </summary>
        /// <param name="workbookTableToUpdate">The WorkbookTable to update.</param>
        /// <returns>The updated WorkbookTable.</returns>
        public System.Threading.Tasks.Task<WorkbookTable> UpdateAsync(WorkbookTable workbookTableToUpdate)
        {
            return this.UpdateAsync(workbookTableToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified WorkbookTable using PATCH.
        /// </summary>
        /// <param name="workbookTableToUpdate">The WorkbookTable to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookTable.</returns>
        public async System.Threading.Tasks.Task<WorkbookTable> UpdateAsync(WorkbookTable workbookTableToUpdate, CancellationToken cancellationToken)
        {
            if (workbookTableToUpdate.AdditionalData != null)
            {
                if (workbookTableToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    workbookTableToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, workbookTableToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<WorkbookTable>(workbookTableToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookTableRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookTableRequest Expand(Expression<Func<WorkbookTable, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookTableRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWorkbookTableRequest Select(Expression<Func<WorkbookTable, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="workbookTableToInitialize">The <see cref="WorkbookTable"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(WorkbookTable workbookTableToInitialize)
        {

            if (workbookTableToInitialize != null && workbookTableToInitialize.AdditionalData != null)
            {

                if (workbookTableToInitialize.Columns != null && workbookTableToInitialize.Columns.CurrentPage != null)
                {
                    workbookTableToInitialize.Columns.AdditionalData = workbookTableToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookTableToInitialize.AdditionalData.TryGetValue("columns@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookTableToInitialize.Columns.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (workbookTableToInitialize.Rows != null && workbookTableToInitialize.Rows.CurrentPage != null)
                {
                    workbookTableToInitialize.Rows.AdditionalData = workbookTableToInitialize.AdditionalData;

                    object nextPageLink;
                    workbookTableToInitialize.AdditionalData.TryGetValue("rows@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        workbookTableToInitialize.Rows.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
