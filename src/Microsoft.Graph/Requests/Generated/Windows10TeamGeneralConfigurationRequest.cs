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
    /// The type Windows10TeamGeneralConfigurationRequest.
    /// </summary>
    public partial class Windows10TeamGeneralConfigurationRequest : BaseRequest, IWindows10TeamGeneralConfigurationRequest
    {
        /// <summary>
        /// Constructs a new Windows10TeamGeneralConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public Windows10TeamGeneralConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Windows10TeamGeneralConfiguration using POST.
        /// </summary>
        /// <param name="windows10TeamGeneralConfigurationToCreate">The Windows10TeamGeneralConfiguration to create.</param>
        /// <returns>The created Windows10TeamGeneralConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10TeamGeneralConfiguration> CreateAsync(Windows10TeamGeneralConfiguration windows10TeamGeneralConfigurationToCreate)
        {
            return this.CreateAsync(windows10TeamGeneralConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified Windows10TeamGeneralConfiguration using POST.
        /// </summary>
        /// <param name="windows10TeamGeneralConfigurationToCreate">The Windows10TeamGeneralConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows10TeamGeneralConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10TeamGeneralConfiguration> CreateAsync(Windows10TeamGeneralConfiguration windows10TeamGeneralConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<Windows10TeamGeneralConfiguration>(windows10TeamGeneralConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified Windows10TeamGeneralConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified Windows10TeamGeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<Windows10TeamGeneralConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified Windows10TeamGeneralConfiguration.
        /// </summary>
        /// <returns>The Windows10TeamGeneralConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10TeamGeneralConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified Windows10TeamGeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows10TeamGeneralConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10TeamGeneralConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<Windows10TeamGeneralConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified Windows10TeamGeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10TeamGeneralConfigurationToUpdate">The Windows10TeamGeneralConfiguration to update.</param>
        /// <returns>The updated Windows10TeamGeneralConfiguration.</returns>
        public System.Threading.Tasks.Task<Windows10TeamGeneralConfiguration> UpdateAsync(Windows10TeamGeneralConfiguration windows10TeamGeneralConfigurationToUpdate)
        {
            return this.UpdateAsync(windows10TeamGeneralConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified Windows10TeamGeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windows10TeamGeneralConfigurationToUpdate">The Windows10TeamGeneralConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows10TeamGeneralConfiguration.</returns>
        public async System.Threading.Tasks.Task<Windows10TeamGeneralConfiguration> UpdateAsync(Windows10TeamGeneralConfiguration windows10TeamGeneralConfigurationToUpdate, CancellationToken cancellationToken)
        {
            if (windows10TeamGeneralConfigurationToUpdate.AdditionalData != null)
            {
                if (windows10TeamGeneralConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    windows10TeamGeneralConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, windows10TeamGeneralConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<Windows10TeamGeneralConfiguration>(windows10TeamGeneralConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10TeamGeneralConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10TeamGeneralConfigurationRequest Expand(Expression<Func<Windows10TeamGeneralConfiguration, object>> expandExpression)
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
        public IWindows10TeamGeneralConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IWindows10TeamGeneralConfigurationRequest Select(Expression<Func<Windows10TeamGeneralConfiguration, object>> selectExpression)
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
        /// <param name="windows10TeamGeneralConfigurationToInitialize">The <see cref="Windows10TeamGeneralConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Windows10TeamGeneralConfiguration windows10TeamGeneralConfigurationToInitialize)
        {

        }
    }
}
