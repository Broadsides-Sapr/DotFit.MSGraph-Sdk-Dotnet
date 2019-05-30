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
    /// The type OnenoteRequest.
    /// </summary>
    public partial class OnenoteRequest : BaseRequest, IOnenoteRequest
    {
        /// <summary>
        /// Constructs a new OnenoteRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OnenoteRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Onenote using POST.
        /// </summary>
        /// <param name="onenoteToCreate">The Onenote to create.</param>
        /// <returns>The created Onenote.</returns>
        public System.Threading.Tasks.Task<Onenote> CreateAsync(Onenote onenoteToCreate)
        {
            return this.CreateAsync(onenoteToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Onenote using POST.
        /// </summary>
        /// <param name="onenoteToCreate">The Onenote to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Onenote.</returns>
        public async System.Threading.Tasks.Task<Onenote> CreateAsync(Onenote onenoteToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Onenote>(onenoteToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Onenote.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Onenote.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Onenote>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Onenote.
        /// </summary>
        /// <returns>The Onenote.</returns>
        public System.Threading.Tasks.Task<Onenote> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Onenote.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Onenote.</returns>
        public async System.Threading.Tasks.Task<Onenote> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Onenote>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Onenote using PATCH.
        /// </summary>
        /// <param name="onenoteToUpdate">The Onenote to update.</param>
        /// <returns>The updated Onenote.</returns>
        public System.Threading.Tasks.Task<Onenote> UpdateAsync(Onenote onenoteToUpdate)
        {
            return this.UpdateAsync(onenoteToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Onenote using PATCH.
        /// </summary>
        /// <param name="onenoteToUpdate">The Onenote to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Onenote.</returns>
        public async System.Threading.Tasks.Task<Onenote> UpdateAsync(Onenote onenoteToUpdate, CancellationToken cancellationToken)
        {
            if (onenoteToUpdate.AdditionalData != null)
            {
                if (onenoteToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    onenoteToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, onenoteToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Onenote>(onenoteToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteRequest Expand(Expression<Func<Onenote, object>> expandExpression)
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
        public IOnenoteRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOnenoteRequest Select(Expression<Func<Onenote, object>> selectExpression)
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
        /// <param name="onenoteToInitialize">The <see cref="Onenote"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Onenote onenoteToInitialize)
        {

            if (onenoteToInitialize != null && onenoteToInitialize.AdditionalData != null)
            {

                if (onenoteToInitialize.Notebooks != null && onenoteToInitialize.Notebooks.CurrentPage != null)
                {
                    onenoteToInitialize.Notebooks.AdditionalData = onenoteToInitialize.AdditionalData;

                    object nextPageLink;
                    onenoteToInitialize.AdditionalData.TryGetValue("notebooks@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onenoteToInitialize.Notebooks.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (onenoteToInitialize.Sections != null && onenoteToInitialize.Sections.CurrentPage != null)
                {
                    onenoteToInitialize.Sections.AdditionalData = onenoteToInitialize.AdditionalData;

                    object nextPageLink;
                    onenoteToInitialize.AdditionalData.TryGetValue("sections@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onenoteToInitialize.Sections.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (onenoteToInitialize.SectionGroups != null && onenoteToInitialize.SectionGroups.CurrentPage != null)
                {
                    onenoteToInitialize.SectionGroups.AdditionalData = onenoteToInitialize.AdditionalData;

                    object nextPageLink;
                    onenoteToInitialize.AdditionalData.TryGetValue("sectionGroups@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onenoteToInitialize.SectionGroups.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (onenoteToInitialize.Pages != null && onenoteToInitialize.Pages.CurrentPage != null)
                {
                    onenoteToInitialize.Pages.AdditionalData = onenoteToInitialize.AdditionalData;

                    object nextPageLink;
                    onenoteToInitialize.AdditionalData.TryGetValue("pages@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onenoteToInitialize.Pages.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (onenoteToInitialize.Resources != null && onenoteToInitialize.Resources.CurrentPage != null)
                {
                    onenoteToInitialize.Resources.AdditionalData = onenoteToInitialize.AdditionalData;

                    object nextPageLink;
                    onenoteToInitialize.AdditionalData.TryGetValue("resources@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onenoteToInitialize.Resources.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (onenoteToInitialize.Operations != null && onenoteToInitialize.Operations.CurrentPage != null)
                {
                    onenoteToInitialize.Operations.AdditionalData = onenoteToInitialize.AdditionalData;

                    object nextPageLink;
                    onenoteToInitialize.AdditionalData.TryGetValue("operations@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        onenoteToInitialize.Operations.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
