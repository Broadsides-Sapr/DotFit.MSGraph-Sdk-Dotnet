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
    /// The interface IDeviceCompliancePolicyDeviceStateSummaryRequest.
    /// </summary>
    public partial interface IDeviceCompliancePolicyDeviceStateSummaryRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DeviceCompliancePolicyDeviceStateSummary using PUT.
        /// </summary>
        /// <param name="deviceCompliancePolicyDeviceStateSummaryToCreate">The DeviceCompliancePolicyDeviceStateSummary to create.</param>
        /// <returns>The created DeviceCompliancePolicyDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyDeviceStateSummary> CreateAsync(DeviceCompliancePolicyDeviceStateSummary deviceCompliancePolicyDeviceStateSummaryToCreate);        /// <summary>
        /// Creates the specified DeviceCompliancePolicyDeviceStateSummary using PUT.
        /// </summary>
        /// <param name="deviceCompliancePolicyDeviceStateSummaryToCreate">The DeviceCompliancePolicyDeviceStateSummary to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DeviceCompliancePolicyDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyDeviceStateSummary> CreateAsync(DeviceCompliancePolicyDeviceStateSummary deviceCompliancePolicyDeviceStateSummaryToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyDeviceStateSummary.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified DeviceCompliancePolicyDeviceStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyDeviceStateSummary.
        /// </summary>
        /// <returns>The DeviceCompliancePolicyDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyDeviceStateSummary> GetAsync();

        /// <summary>
        /// Gets the specified DeviceCompliancePolicyDeviceStateSummary.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DeviceCompliancePolicyDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyDeviceStateSummary> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyDeviceStateSummary using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyDeviceStateSummaryToUpdate">The DeviceCompliancePolicyDeviceStateSummary to update.</param>
        /// <returns>The updated DeviceCompliancePolicyDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyDeviceStateSummary> UpdateAsync(DeviceCompliancePolicyDeviceStateSummary deviceCompliancePolicyDeviceStateSummaryToUpdate);

        /// <summary>
        /// Updates the specified DeviceCompliancePolicyDeviceStateSummary using PATCH.
        /// </summary>
        /// <param name="deviceCompliancePolicyDeviceStateSummaryToUpdate">The DeviceCompliancePolicyDeviceStateSummary to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated DeviceCompliancePolicyDeviceStateSummary.</returns>
        System.Threading.Tasks.Task<DeviceCompliancePolicyDeviceStateSummary> UpdateAsync(DeviceCompliancePolicyDeviceStateSummary deviceCompliancePolicyDeviceStateSummaryToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStateSummaryRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStateSummaryRequest Expand(Expression<Func<DeviceCompliancePolicyDeviceStateSummary, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStateSummaryRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDeviceCompliancePolicyDeviceStateSummaryRequest Select(Expression<Func<DeviceCompliancePolicyDeviceStateSummary, object>> selectExpression);

    }
}
