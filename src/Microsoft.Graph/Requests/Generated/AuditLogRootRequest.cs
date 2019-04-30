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
    /// The type AuditLogRootRequest.
    /// </summary>
    public partial class AuditLogRootRequest : BaseRequest, IAuditLogRootRequest
    {
        /// <summary>
        /// Constructs a new AuditLogRootRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AuditLogRootRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AuditLogRoot using POST.
        /// </summary>
        /// <param name="auditLogRootToCreate">The AuditLogRoot to create.</param>
        /// <returns>The created AuditLogRoot.</returns>
        public System.Threading.Tasks.Task<AuditLogRoot> CreateAsync(AuditLogRoot auditLogRootToCreate)
        {
            return this.CreateAsync(auditLogRootToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified AuditLogRoot using POST.
        /// </summary>
        /// <param name="auditLogRootToCreate">The AuditLogRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuditLogRoot.</returns>
        public async System.Threading.Tasks.Task<AuditLogRoot> CreateAsync(AuditLogRoot auditLogRootToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<AuditLogRoot>(auditLogRootToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified AuditLogRoot.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified AuditLogRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<AuditLogRoot>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified AuditLogRoot.
        /// </summary>
        /// <returns>The AuditLogRoot.</returns>
        public System.Threading.Tasks.Task<AuditLogRoot> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified AuditLogRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuditLogRoot.</returns>
        public async System.Threading.Tasks.Task<AuditLogRoot> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<AuditLogRoot>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified AuditLogRoot using PATCH.
        /// </summary>
        /// <param name="auditLogRootToUpdate">The AuditLogRoot to update.</param>
        /// <returns>The updated AuditLogRoot.</returns>
        public System.Threading.Tasks.Task<AuditLogRoot> UpdateAsync(AuditLogRoot auditLogRootToUpdate)
        {
            return this.UpdateAsync(auditLogRootToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified AuditLogRoot using PATCH.
        /// </summary>
        /// <param name="auditLogRootToUpdate">The AuditLogRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AuditLogRoot.</returns>
        public async System.Threading.Tasks.Task<AuditLogRoot> UpdateAsync(AuditLogRoot auditLogRootToUpdate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<AuditLogRoot>(auditLogRootToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuditLogRootRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuditLogRootRequest Expand(Expression<Func<AuditLogRoot, object>> expandExpression)
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
        public IAuditLogRootRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAuditLogRootRequest Select(Expression<Func<AuditLogRoot, object>> selectExpression)
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
        /// <param name="auditLogRootToInitialize">The <see cref="AuditLogRoot"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AuditLogRoot auditLogRootToInitialize)
        {

            if (auditLogRootToInitialize != null && auditLogRootToInitialize.AdditionalData != null)
            {

                if (auditLogRootToInitialize.SignIns != null && auditLogRootToInitialize.SignIns.CurrentPage != null)
                {
                    auditLogRootToInitialize.SignIns.AdditionalData = auditLogRootToInitialize.AdditionalData;

                    object nextPageLink;
                    auditLogRootToInitialize.AdditionalData.TryGetValue("signIns@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        auditLogRootToInitialize.SignIns.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (auditLogRootToInitialize.DirectoryAudits != null && auditLogRootToInitialize.DirectoryAudits.CurrentPage != null)
                {
                    auditLogRootToInitialize.DirectoryAudits.AdditionalData = auditLogRootToInitialize.AdditionalData;

                    object nextPageLink;
                    auditLogRootToInitialize.AdditionalData.TryGetValue("directoryAudits@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        auditLogRootToInitialize.DirectoryAudits.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (auditLogRootToInitialize.RestrictedSignIns != null && auditLogRootToInitialize.RestrictedSignIns.CurrentPage != null)
                {
                    auditLogRootToInitialize.RestrictedSignIns.AdditionalData = auditLogRootToInitialize.AdditionalData;

                    object nextPageLink;
                    auditLogRootToInitialize.AdditionalData.TryGetValue("restrictedSignIns@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        auditLogRootToInitialize.RestrictedSignIns.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
