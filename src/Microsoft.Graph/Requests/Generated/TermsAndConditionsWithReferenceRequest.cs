// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type TermsAndConditionsWithReferenceRequest.
    /// </summary>
    public partial class TermsAndConditionsWithReferenceRequest : BaseRequest, ITermsAndConditionsWithReferenceRequest
    {
        /// <summary>
        /// Constructs a new TermsAndConditionsWithReferenceRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public TermsAndConditionsWithReferenceRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Gets the specified TermsAndConditions.
        /// </summary>
        /// <returns>The TermsAndConditions.</returns>
        public System.Threading.Tasks.Task<TermsAndConditions> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified TermsAndConditions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TermsAndConditions.</returns>
        public async System.Threading.Tasks.Task<TermsAndConditions> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<TermsAndConditions>(null, cancellationToken).ConfigureAwait(false);
            return retrievedEntity;
        }

		/// <summary>
        /// Creates the specified TermsAndConditions using POST.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <returns>The created TermsAndConditions.</returns>
        public System.Threading.Tasks.Task<TermsAndConditions> CreateAsync(TermsAndConditions termsAndConditionsToCreate)
        {
            return this.CreateAsync(termsAndConditionsToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified TermsAndConditions using POST.
        /// </summary>
        /// <param name="termsAndConditionsToCreate">The TermsAndConditions to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TermsAndConditions.</returns>
        public async System.Threading.Tasks.Task<TermsAndConditions> CreateAsync(TermsAndConditions termsAndConditionsToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<TermsAndConditions>(termsAndConditionsToCreate, cancellationToken).ConfigureAwait(false);
            return newEntity;
        }

		/// <summary>
        /// Updates the specified TermsAndConditions using PATCH.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <returns>The updated TermsAndConditions.</returns>
        public System.Threading.Tasks.Task<TermsAndConditions> UpdateAsync(TermsAndConditions termsAndConditionsToUpdate)
        {
            return this.UpdateAsync(termsAndConditionsToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified TermsAndConditions using PATCH.
        /// </summary>
        /// <param name="termsAndConditionsToUpdate">The TermsAndConditions to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TermsAndConditions.</returns>
        public async System.Threading.Tasks.Task<TermsAndConditions> UpdateAsync(TermsAndConditions termsAndConditionsToUpdate, CancellationToken cancellationToken)
        {
            if (termsAndConditionsToUpdate.AdditionalData != null)
            {
                if (termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    termsAndConditionsToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, termsAndConditionsToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<TermsAndConditions>(termsAndConditionsToUpdate, cancellationToken).ConfigureAwait(false);
            return updatedEntity;
        }

		/// <summary>
        /// Deletes the specified TermsAndConditions.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified TermsAndConditions.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<TermsAndConditions>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsAndConditionsWithReferenceRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsAndConditionsWithReferenceRequest Expand(Expression<Func<TermsAndConditions, object>> expandExpression)
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
        public ITermsAndConditionsWithReferenceRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public ITermsAndConditionsWithReferenceRequest Select(Expression<Func<TermsAndConditions, object>> selectExpression)
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

    }
}
