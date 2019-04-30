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
    /// The type MobileThreatDefenseConnectorRequest.
    /// </summary>
    public partial class MobileThreatDefenseConnectorRequest : BaseRequest, IMobileThreatDefenseConnectorRequest
    {
        /// <summary>
        /// Constructs a new MobileThreatDefenseConnectorRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MobileThreatDefenseConnectorRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MobileThreatDefenseConnector using POST.
        /// </summary>
        /// <param name="mobileThreatDefenseConnectorToCreate">The MobileThreatDefenseConnector to create.</param>
        /// <returns>The created MobileThreatDefenseConnector.</returns>
        public System.Threading.Tasks.Task<MobileThreatDefenseConnector> CreateAsync(MobileThreatDefenseConnector mobileThreatDefenseConnectorToCreate)
        {
            return this.CreateAsync(mobileThreatDefenseConnectorToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified MobileThreatDefenseConnector using POST.
        /// </summary>
        /// <param name="mobileThreatDefenseConnectorToCreate">The MobileThreatDefenseConnector to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MobileThreatDefenseConnector.</returns>
        public async System.Threading.Tasks.Task<MobileThreatDefenseConnector> CreateAsync(MobileThreatDefenseConnector mobileThreatDefenseConnectorToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<MobileThreatDefenseConnector>(mobileThreatDefenseConnectorToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified MobileThreatDefenseConnector.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified MobileThreatDefenseConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<MobileThreatDefenseConnector>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified MobileThreatDefenseConnector.
        /// </summary>
        /// <returns>The MobileThreatDefenseConnector.</returns>
        public System.Threading.Tasks.Task<MobileThreatDefenseConnector> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified MobileThreatDefenseConnector.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MobileThreatDefenseConnector.</returns>
        public async System.Threading.Tasks.Task<MobileThreatDefenseConnector> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<MobileThreatDefenseConnector>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified MobileThreatDefenseConnector using PATCH.
        /// </summary>
        /// <param name="mobileThreatDefenseConnectorToUpdate">The MobileThreatDefenseConnector to update.</param>
        /// <returns>The updated MobileThreatDefenseConnector.</returns>
        public System.Threading.Tasks.Task<MobileThreatDefenseConnector> UpdateAsync(MobileThreatDefenseConnector mobileThreatDefenseConnectorToUpdate)
        {
            return this.UpdateAsync(mobileThreatDefenseConnectorToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified MobileThreatDefenseConnector using PATCH.
        /// </summary>
        /// <param name="mobileThreatDefenseConnectorToUpdate">The MobileThreatDefenseConnector to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated MobileThreatDefenseConnector.</returns>
        public async System.Threading.Tasks.Task<MobileThreatDefenseConnector> UpdateAsync(MobileThreatDefenseConnector mobileThreatDefenseConnectorToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<MobileThreatDefenseConnector>(mobileThreatDefenseConnectorToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileThreatDefenseConnectorRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileThreatDefenseConnectorRequest Expand(Expression<Func<MobileThreatDefenseConnector, object>> expandExpression)
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
        public IMobileThreatDefenseConnectorRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMobileThreatDefenseConnectorRequest Select(Expression<Func<MobileThreatDefenseConnector, object>> selectExpression)
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
        /// <param name="mobileThreatDefenseConnectorToInitialize">The <see cref="MobileThreatDefenseConnector"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MobileThreatDefenseConnector mobileThreatDefenseConnectorToInitialize)
        {

        }
    }
}
