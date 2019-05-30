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
    /// The type DeviceConfigurationRequest.
    /// </summary>
    public partial class DeviceConfigurationRequest : BaseRequest, IDeviceConfigurationRequest
    {
        /// <summary>
        /// Constructs a new DeviceConfigurationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public DeviceConfigurationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified DeviceConfiguration using POST.
        /// </summary>
        /// <param name="deviceConfigurationToCreate">The DeviceConfiguration to create.</param>
        /// <returns>The created DeviceConfiguration.</returns>
        public System.Threading.Tasks.Task<DeviceConfiguration> CreateAsync(DeviceConfiguration deviceConfigurationToCreate)
        {
            return this.CreateAsync(deviceConfigurationToCreate, CancellationToken.None);
        }

        /// <summary>
        /// Creates the specified DeviceConfiguration using POST.
        /// </summary>
        /// <param name="deviceConfigurationToCreate">The DeviceConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceConfiguration> CreateAsync(DeviceConfiguration deviceConfigurationToCreate, CancellationToken cancellationToken)
        {
            this.ContentType = "application/json";
            this.Method = "POST";
            var newEntity = await this.SendAsync<DeviceConfiguration>(deviceConfigurationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Deletes the specified DeviceConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        public System.Threading.Tasks.Task DeleteAsync()
        {
            return this.DeleteAsync(CancellationToken.None);
        }

        /// <summary>
        /// Deletes the specified DeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken)
        {
            this.Method = "DELETE";
            await this.SendAsync<DeviceConfiguration>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified DeviceConfiguration.
        /// </summary>
        /// <returns>The DeviceConfiguration.</returns>
        public System.Threading.Tasks.Task<DeviceConfiguration> GetAsync()
        {
            return this.GetAsync(CancellationToken.None);
        }

        /// <summary>
        /// Gets the specified DeviceConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceConfiguration> GetAsync(CancellationToken cancellationToken)
        {
            this.Method = "GET";
            var retrievedEntity = await this.SendAsync<DeviceConfiguration>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Updates the specified DeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationToUpdate">The DeviceConfiguration to update.</param>
        /// <returns>The updated DeviceConfiguration.</returns>
        public System.Threading.Tasks.Task<DeviceConfiguration> UpdateAsync(DeviceConfiguration deviceConfigurationToUpdate)
        {
            return this.UpdateAsync(deviceConfigurationToUpdate, CancellationToken.None);
        }

        /// <summary>
        /// Updates the specified DeviceConfiguration using PATCH.
        /// </summary>
        /// <param name="deviceConfigurationToUpdate">The DeviceConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DeviceConfiguration.</returns>
        public async System.Threading.Tasks.Task<DeviceConfiguration> UpdateAsync(DeviceConfiguration deviceConfigurationToUpdate, CancellationToken cancellationToken)
        {
            if (deviceConfigurationToUpdate.AdditionalData != null)
            {
                if (deviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.ResponseHeaders) ||
                    deviceConfigurationToUpdate.AdditionalData.ContainsKey(Constants.HttpPropertyNames.StatusCode))
                {
                    throw new ClientException(
                        new Error
                        {
                            Code = GeneratedErrorConstants.Codes.NotAllowed,
                            Message = String.Format(GeneratedErrorConstants.Messages.ResponseObjectUsedForUpdate, deviceConfigurationToUpdate.GetType().Name)
                        });
                }
            }
            this.ContentType = "application/json";
            this.Method = "PATCH";
            var updatedEntity = await this.SendAsync<DeviceConfiguration>(deviceConfigurationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationRequest Expand(Expression<Func<DeviceConfiguration, object>> expandExpression)
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
        public IDeviceConfigurationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IDeviceConfigurationRequest Select(Expression<Func<DeviceConfiguration, object>> selectExpression)
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
        /// <param name="deviceConfigurationToInitialize">The <see cref="DeviceConfiguration"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(DeviceConfiguration deviceConfigurationToInitialize)
        {

            if (deviceConfigurationToInitialize != null && deviceConfigurationToInitialize.AdditionalData != null)
            {

                if (deviceConfigurationToInitialize.Assignments != null && deviceConfigurationToInitialize.Assignments.CurrentPage != null)
                {
                    deviceConfigurationToInitialize.Assignments.AdditionalData = deviceConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceConfigurationToInitialize.AdditionalData.TryGetValue("assignments@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceConfigurationToInitialize.Assignments.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceConfigurationToInitialize.DeviceStatuses != null && deviceConfigurationToInitialize.DeviceStatuses.CurrentPage != null)
                {
                    deviceConfigurationToInitialize.DeviceStatuses.AdditionalData = deviceConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceConfigurationToInitialize.AdditionalData.TryGetValue("deviceStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceConfigurationToInitialize.DeviceStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceConfigurationToInitialize.UserStatuses != null && deviceConfigurationToInitialize.UserStatuses.CurrentPage != null)
                {
                    deviceConfigurationToInitialize.UserStatuses.AdditionalData = deviceConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceConfigurationToInitialize.AdditionalData.TryGetValue("userStatuses@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceConfigurationToInitialize.UserStatuses.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

                if (deviceConfigurationToInitialize.DeviceSettingStateSummaries != null && deviceConfigurationToInitialize.DeviceSettingStateSummaries.CurrentPage != null)
                {
                    deviceConfigurationToInitialize.DeviceSettingStateSummaries.AdditionalData = deviceConfigurationToInitialize.AdditionalData;

                    object nextPageLink;
                    deviceConfigurationToInitialize.AdditionalData.TryGetValue("deviceSettingStateSummaries@odata.nextLink", out nextPageLink);
                    var nextPageLinkString = nextPageLink as string;

                    if (!string.IsNullOrEmpty(nextPageLinkString))
                    {
                        deviceConfigurationToInitialize.DeviceSettingStateSummaries.InitializeNextPageRequest(
                            this.Client,
                            nextPageLinkString);
                    }
                }

            }


        }
    }
}
