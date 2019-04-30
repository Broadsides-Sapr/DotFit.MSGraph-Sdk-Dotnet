// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IDeviceComplianceSettingStateRequest.
    /// </summary>
    public partial interface IDeviceComplianceSettingStateRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceComplianceSettingState using PUT.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToCreate">The DeviceComplianceSettingState to create.</param>
        /// <returns>The created DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> CreateAsync(DeviceComplianceSettingState deviceComplianceSettingStateToCreate);        /// <summary>
        /// Creates the specified DeviceComplianceSettingState using PUT.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToCreate">The DeviceComplianceSettingState to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> CreateAsync(DeviceComplianceSettingState deviceComplianceSettingStateToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceComplianceSettingState.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceComplianceSettingState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceComplianceSettingState.
        /// </summary>
        /// <returns>The DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> GetAsync();

        /// <summary>
        /// Gets the specified DeviceComplianceSettingState.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceComplianceSettingState using PATCH.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToUpdate">The DeviceComplianceSettingState to update.</param>
        /// <returns>The updated DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> UpdateAsync(DeviceComplianceSettingState deviceComplianceSettingStateToUpdate);

        /// <summary>
        /// Updates the specified DeviceComplianceSettingState using PATCH.
        /// </summary>
        /// <param name="deviceComplianceSettingStateToUpdate">The DeviceComplianceSettingState to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceComplianceSettingState.</returns>
        System.Threading.Tasks.Task<DeviceComplianceSettingState> UpdateAsync(DeviceComplianceSettingState deviceComplianceSettingStateToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceSettingStateRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceSettingStateRequest Expand(Expression<Func<DeviceComplianceSettingState, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceSettingStateRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceComplianceSettingStateRequest Select(Expression<Func<DeviceComplianceSettingState, object>> selectExpression);

    }
}
