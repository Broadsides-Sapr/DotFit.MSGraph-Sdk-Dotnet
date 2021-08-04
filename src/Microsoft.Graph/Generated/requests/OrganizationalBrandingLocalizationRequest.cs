// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type OrganizationalBrandingLocalizationRequest.
    /// </summary>
    public partial class OrganizationalBrandingLocalizationRequest : BaseRequest, IOrganizationalBrandingLocalizationRequest
    {
        /// <summary>
        /// Constructs a new OrganizationalBrandingLocalizationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OrganizationalBrandingLocalizationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified OrganizationalBrandingLocalization using POST.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToCreate">The OrganizationalBrandingLocalization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrganizationalBrandingLocalization.</returns>
        public async System.Threading.Tasks.Task<OrganizationalBrandingLocalization> CreateAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<OrganizationalBrandingLocalization>(organizationalBrandingLocalizationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified OrganizationalBrandingLocalization using POST and returns a <see cref="GraphResponse{OrganizationalBrandingLocalization}"/> object.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToCreate">The OrganizationalBrandingLocalization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationalBrandingLocalization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationalBrandingLocalization>> CreateResponseAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToCreate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<OrganizationalBrandingLocalization>(organizationalBrandingLocalizationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified OrganizationalBrandingLocalization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<OrganizationalBrandingLocalization>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified OrganizationalBrandingLocalization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified OrganizationalBrandingLocalization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrganizationalBrandingLocalization.</returns>
        public async System.Threading.Tasks.Task<OrganizationalBrandingLocalization> GetAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<OrganizationalBrandingLocalization>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified OrganizationalBrandingLocalization and returns a <see cref="GraphResponse{OrganizationalBrandingLocalization}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{OrganizationalBrandingLocalization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationalBrandingLocalization>> GetResponseAsync(CancellationToken cancellationToken = default)
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<OrganizationalBrandingLocalization>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OrganizationalBrandingLocalization using PATCH.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToUpdate">The OrganizationalBrandingLocalization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OrganizationalBrandingLocalization.</returns>
        public async System.Threading.Tasks.Task<OrganizationalBrandingLocalization> UpdateAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<OrganizationalBrandingLocalization>(organizationalBrandingLocalizationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OrganizationalBrandingLocalization using PATCH and returns a <see cref="GraphResponse{OrganizationalBrandingLocalization}"/> object.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToUpdate">The OrganizationalBrandingLocalization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{OrganizationalBrandingLocalization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationalBrandingLocalization>> UpdateResponseAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<OrganizationalBrandingLocalization>(organizationalBrandingLocalizationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified OrganizationalBrandingLocalization using PUT.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToUpdate">The OrganizationalBrandingLocalization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<OrganizationalBrandingLocalization> PutAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<OrganizationalBrandingLocalization>(organizationalBrandingLocalizationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified OrganizationalBrandingLocalization using PUT and returns a <see cref="GraphResponse{OrganizationalBrandingLocalization}"/> object.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToUpdate">The OrganizationalBrandingLocalization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{OrganizationalBrandingLocalization}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<OrganizationalBrandingLocalization>> PutResponseAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToUpdate, CancellationToken cancellationToken = default)
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<OrganizationalBrandingLocalization>(organizationalBrandingLocalizationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationalBrandingLocalizationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationalBrandingLocalizationRequest Expand(Expression<Func<OrganizationalBrandingLocalization, object>> expandExpression)
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
        public IOrganizationalBrandingLocalizationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationalBrandingLocalizationRequest Select(Expression<Func<OrganizationalBrandingLocalization, object>> selectExpression)
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
        /// <param name="organizationalBrandingLocalizationToInitialize">The <see cref="OrganizationalBrandingLocalization"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(OrganizationalBrandingLocalization organizationalBrandingLocalizationToInitialize)
        {

        }
    }
}