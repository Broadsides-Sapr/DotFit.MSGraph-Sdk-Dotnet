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
    /// The interface ISubscribedSkuRequest.
    /// </summary>
    public partial interface ISubscribedSkuRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SubscribedSku using PUT.
        /// </summary>
        /// <param name="subscribedSkuToCreate">The SubscribedSku to create.</param>
        /// <returns>The created SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> CreateAsync(SubscribedSku subscribedSkuToCreate);        /// <summary>
        /// Creates the specified SubscribedSku using PUT.
        /// </summary>
        /// <param name="subscribedSkuToCreate">The SubscribedSku to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> CreateAsync(SubscribedSku subscribedSkuToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SubscribedSku.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SubscribedSku.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SubscribedSku.
        /// </summary>
        /// <returns>The SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> GetAsync();

        /// <summary>
        /// Gets the specified SubscribedSku.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SubscribedSku using PATCH.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku to update.</param>
        /// <returns>The updated SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> UpdateAsync(SubscribedSku subscribedSkuToUpdate);

        /// <summary>
        /// Updates the specified SubscribedSku using PATCH.
        /// </summary>
        /// <param name="subscribedSkuToUpdate">The SubscribedSku to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SubscribedSku.</returns>
        System.Threading.Tasks.Task<SubscribedSku> UpdateAsync(SubscribedSku subscribedSkuToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubscribedSkuRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISubscribedSkuRequest Expand(Expression<Func<SubscribedSku, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISubscribedSkuRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISubscribedSkuRequest Select(Expression<Func<SubscribedSku, object>> selectExpression);

    }
}
