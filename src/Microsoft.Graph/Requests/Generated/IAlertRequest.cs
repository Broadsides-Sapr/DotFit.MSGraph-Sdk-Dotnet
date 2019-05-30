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
    /// The interface IAlertRequest.
    /// </summary>
    public partial interface IAlertRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Alert using PUT.
        /// </summary>
        /// <param name="alertToCreate">The Alert to create.</param>
        /// <returns>The created Alert.</returns>
        System.Threading.Tasks.Task<Alert> CreateAsync(Alert alertToCreate);        /// <summary>
        /// Creates the specified Alert using PUT.
        /// </summary>
        /// <param name="alertToCreate">The Alert to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Alert.</returns>
        System.Threading.Tasks.Task<Alert> CreateAsync(Alert alertToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Alert.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Alert.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Alert.
        /// </summary>
        /// <returns>The Alert.</returns>
        System.Threading.Tasks.Task<Alert> GetAsync();

        /// <summary>
        /// Gets the specified Alert.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Alert.</returns>
        System.Threading.Tasks.Task<Alert> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Alert using PATCH.
        /// </summary>
        /// <param name="alertToUpdate">The Alert to update.</param>
        /// <returns>The updated Alert.</returns>
        System.Threading.Tasks.Task<Alert> UpdateAsync(Alert alertToUpdate);

        /// <summary>
        /// Updates the specified Alert using PATCH.
        /// </summary>
        /// <param name="alertToUpdate">The Alert to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Alert.</returns>
        System.Threading.Tasks.Task<Alert> UpdateAsync(Alert alertToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAlertRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAlertRequest Expand(Expression<Func<Alert, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAlertRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAlertRequest Select(Expression<Func<Alert, object>> selectExpression);

    }
}
