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
    /// The interface IActivityHistoryItemRequest.
    /// </summary>
    public partial interface IActivityHistoryItemRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ActivityHistoryItem using PUT.
        /// </summary>
        /// <param name="activityHistoryItemToCreate">The ActivityHistoryItem to create.</param>
        /// <returns>The created ActivityHistoryItem.</returns>
        System.Threading.Tasks.Task<ActivityHistoryItem> CreateAsync(ActivityHistoryItem activityHistoryItemToCreate);        /// <summary>
        /// Creates the specified ActivityHistoryItem using PUT.
        /// </summary>
        /// <param name="activityHistoryItemToCreate">The ActivityHistoryItem to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ActivityHistoryItem.</returns>
        System.Threading.Tasks.Task<ActivityHistoryItem> CreateAsync(ActivityHistoryItem activityHistoryItemToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ActivityHistoryItem.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ActivityHistoryItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ActivityHistoryItem.
        /// </summary>
        /// <returns>The ActivityHistoryItem.</returns>
        System.Threading.Tasks.Task<ActivityHistoryItem> GetAsync();

        /// <summary>
        /// Gets the specified ActivityHistoryItem.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ActivityHistoryItem.</returns>
        System.Threading.Tasks.Task<ActivityHistoryItem> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ActivityHistoryItem using PATCH.
        /// </summary>
        /// <param name="activityHistoryItemToUpdate">The ActivityHistoryItem to update.</param>
        /// <returns>The updated ActivityHistoryItem.</returns>
        System.Threading.Tasks.Task<ActivityHistoryItem> UpdateAsync(ActivityHistoryItem activityHistoryItemToUpdate);

        /// <summary>
        /// Updates the specified ActivityHistoryItem using PATCH.
        /// </summary>
        /// <param name="activityHistoryItemToUpdate">The ActivityHistoryItem to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ActivityHistoryItem.</returns>
        System.Threading.Tasks.Task<ActivityHistoryItem> UpdateAsync(ActivityHistoryItem activityHistoryItemToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IActivityHistoryItemRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IActivityHistoryItemRequest Expand(Expression<Func<ActivityHistoryItem, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IActivityHistoryItemRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IActivityHistoryItemRequest Select(Expression<Func<ActivityHistoryItem, object>> selectExpression);

    }
}
