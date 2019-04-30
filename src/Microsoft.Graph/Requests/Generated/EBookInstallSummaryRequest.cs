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
    /// The type EBookInstallSummaryRequest.
    /// </summary>
    public partial class EBookInstallSummaryRequest : BaseRequest, IEBookInstallSummaryRequest
    {
        /// <summary>
        /// Constructs a new EBookInstallSummaryRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EBookInstallSummaryRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EBookInstallSummary using POST.
        /// </summary>
        /// <param name="eBookInstallSummaryToCreate">The EBookInstallSummary to create.</param>
        /// <returns>The created EBookInstallSummary.</returns>
        public System.Threading.Tasks.Task<EBookInstallSummary> CreateAsync(EBookInstallSummary eBookInstallSummaryToCreate)
        {
            return this.CreateAsync(eBookInstallSummaryToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EBookInstallSummary using POST.
        /// </summary>
        /// <param name="eBookInstallSummaryToCreate">The EBookInstallSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EBookInstallSummary.</returns>
        public async System.Threading.Tasks.Task<EBookInstallSummary> CreateAsync(EBookInstallSummary eBookInstallSummaryToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EBookInstallSummary>(eBookInstallSummaryToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified EBookInstallSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EBookInstallSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EBookInstallSummary>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EBookInstallSummary.
        /// </summary>
        /// <returns>The EBookInstallSummary.</returns>
        public System.Threading.Tasks.Task<EBookInstallSummary> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EBookInstallSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EBookInstallSummary.</returns>
        public async System.Threading.Tasks.Task<EBookInstallSummary> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EBookInstallSummary>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified EBookInstallSummary using PATCH.
        /// </summary>
        /// <param name="eBookInstallSummaryToUpdate">The EBookInstallSummary to update.</param>
        /// <returns>The updated EBookInstallSummary.</returns>
        public System.Threading.Tasks.Task<EBookInstallSummary> UpdateAsync(EBookInstallSummary eBookInstallSummaryToUpdate)
        {
            return this.UpdateAsync(eBookInstallSummaryToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EBookInstallSummary using PATCH.
        /// </summary>
        /// <param name="eBookInstallSummaryToUpdate">The EBookInstallSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EBookInstallSummary.</returns>
        public async System.Threading.Tasks.Task<EBookInstallSummary> UpdateAsync(EBookInstallSummary eBookInstallSummaryToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EBookInstallSummary>(eBookInstallSummaryToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEBookInstallSummaryRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEBookInstallSummaryRequest Expand(Expression<Func<EBookInstallSummary, object>> expandExpression)
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
        public IEBookInstallSummaryRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEBookInstallSummaryRequest Select(Expression<Func<EBookInstallSummary, object>> selectExpression)
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
        /// <param name="eBookInstallSummaryToInitialize">The <see cref="EBookInstallSummary"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EBookInstallSummary eBookInstallSummaryToInitialize)
        {

        }
    }
}
