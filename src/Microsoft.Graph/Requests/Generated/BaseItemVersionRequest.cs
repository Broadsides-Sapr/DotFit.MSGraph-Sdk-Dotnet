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
    /// The type BaseItemVersionRequest.
    /// </summary>
    public partial class BaseItemVersionRequest : BaseRequest, IBaseItemVersionRequest
    {
        /// <summary>
        /// Constructs a new BaseItemVersionRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public BaseItemVersionRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified BaseItemVersion using POST.
        /// </summary>
        /// <param name="baseItemVersionToCreate">The BaseItemVersion to create.</param>
        /// <returns>The created BaseItemVersion.</returns>
        public System.Threading.Tasks.Task<BaseItemVersion> CreateAsync(BaseItemVersion baseItemVersionToCreate)
        {
            return this.CreateAsync(baseItemVersionToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified BaseItemVersion using POST.
        /// </summary>
        /// <param name="baseItemVersionToCreate">The BaseItemVersion to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BaseItemVersion.</returns>
        public async System.Threading.Tasks.Task<BaseItemVersion> CreateAsync(BaseItemVersion baseItemVersionToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<BaseItemVersion>(baseItemVersionToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified BaseItemVersion.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified BaseItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<BaseItemVersion>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified BaseItemVersion.
        /// </summary>
        /// <returns>The BaseItemVersion.</returns>
        public System.Threading.Tasks.Task<BaseItemVersion> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified BaseItemVersion.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The BaseItemVersion.</returns>
        public async System.Threading.Tasks.Task<BaseItemVersion> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<BaseItemVersion>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified BaseItemVersion using PATCH.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion to update.</param>
        /// <returns>The updated BaseItemVersion.</returns>
        public System.Threading.Tasks.Task<BaseItemVersion> UpdateAsync(BaseItemVersion baseItemVersionToUpdate)
        {
            return this.UpdateAsync(baseItemVersionToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified BaseItemVersion using PATCH.
        /// </summary>
        /// <param name="baseItemVersionToUpdate">The BaseItemVersion to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated BaseItemVersion.</returns>
        public async System.Threading.Tasks.Task<BaseItemVersion> UpdateAsync(BaseItemVersion baseItemVersionToUpdate, CancellationToken cancellationToken)
        {
            if (baseItemVersionToUpdate.AdditionalData != null)
            {
                if (baseItemVersionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    baseItemVersionToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, baseItemVersionToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<BaseItemVersion>(baseItemVersionToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBaseItemVersionRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IBaseItemVersionRequest Expand(Expression<Func<BaseItemVersion, object>> expandExpression)
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
        public IBaseItemVersionRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IBaseItemVersionRequest Select(Expression<Func<BaseItemVersion, object>> selectExpression)
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
        /// <param name="baseItemVersionToInitialize">The <see cref="BaseItemVersion"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(BaseItemVersion baseItemVersionToInitialize)
        {

        }
    }
}
