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
    /// The type EducationClassRequest.
    /// </summary>
    public partial class EducationClassRequest : BaseRequest, IEducationClassRequest
    {
        /// <summary>
        /// Constructs a new EducationClassRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public EducationClassRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified EducationClass using POST.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <returns>The created EducationClass.</returns>
        public System.Threading.Tasks.Task<EducationClass> CreateAsync(EducationClass educationClassToCreate)
        {
            return this.CreateAsync(educationClassToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified EducationClass using POST.
        /// </summary>
        /// <param name="educationClassToCreate">The EducationClass to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> CreateAsync(EducationClass educationClassToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<EducationClass>(educationClassToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified EducationClass.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified EducationClass.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<EducationClass>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified EducationClass.
        /// </summary>
        /// <returns>The EducationClass.</returns>
        public System.Threading.Tasks.Task<EducationClass> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified EducationClass.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<EducationClass>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified EducationClass using PATCH.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <returns>The updated EducationClass.</returns>
        public System.Threading.Tasks.Task<EducationClass> UpdateAsync(EducationClass educationClassToUpdate)
        {
            return this.UpdateAsync(educationClassToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified EducationClass using PATCH.
        /// </summary>
        /// <param name="educationClassToUpdate">The EducationClass to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated EducationClass.</returns>
        public async System.Threading.Tasks.Task<EducationClass> UpdateAsync(EducationClass educationClassToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<EducationClass>(educationClassToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassRequest Expand(Expression<Func<EducationClass, object>> expandExpression)
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
        public IEducationClassRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IEducationClassRequest Select(Expression<Func<EducationClass, object>> selectExpression)
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
        /// <param name="educationClassToInitialize">The <see cref="EducationClass"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(EducationClass educationClassToInitialize)
        {

            if (educationClassToInitialize != null && educationClassToInitialize.AdditionalData != null)
            {

                if (educationClassToInitialize.Schools != null && educationClassToInitialize.Schools.CurrentPage != null)
                {
                    educationClassToInitialize.Schools.AdditionalData = educationClassToInitialize.AdditionalData;

                    object nextPageLink;
                    educationClassToInitialize.AdditionalData.TryGetValue("schools@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationClassToInitialize.Schools.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (educationClassToInitialize.Members != null && educationClassToInitialize.Members.CurrentPage != null)
                {
                    educationClassToInitialize.Members.AdditionalData = educationClassToInitialize.AdditionalData;

                    object nextPageLink;
                    educationClassToInitialize.AdditionalData.TryGetValue("members@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationClassToInitialize.Members.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (educationClassToInitialize.Teachers != null && educationClassToInitialize.Teachers.CurrentPage != null)
                {
                    educationClassToInitialize.Teachers.AdditionalData = educationClassToInitialize.AdditionalData;

                    object nextPageLink;
                    educationClassToInitialize.AdditionalData.TryGetValue("teachers@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        educationClassToInitialize.Teachers.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
