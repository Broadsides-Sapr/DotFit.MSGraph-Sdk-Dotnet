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
    /// The interface ITargetedManagedAppProtectionRequest.
    /// </summary>
    public partial interface ITargetedManagedAppProtectionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified TargetedManagedAppProtection using PUT.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToCreate">The TargetedManagedAppProtection to create.</param>
        /// <returns>The created TargetedManagedAppProtection.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppProtection> CreateAsync(TargetedManagedAppProtection targetedManagedAppProtectionToCreate);        /// <summary>
        /// Creates the specified TargetedManagedAppProtection using PUT.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToCreate">The TargetedManagedAppProtection to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created TargetedManagedAppProtection.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppProtection> CreateAsync(TargetedManagedAppProtection targetedManagedAppProtectionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified TargetedManagedAppProtection.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified TargetedManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified TargetedManagedAppProtection.
        /// </summary>
        /// <returns>The TargetedManagedAppProtection.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppProtection> GetAsync();

        /// <summary>
        /// Gets the specified TargetedManagedAppProtection.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The TargetedManagedAppProtection.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppProtection> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified TargetedManagedAppProtection using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToUpdate">The TargetedManagedAppProtection to update.</param>
        /// <returns>The updated TargetedManagedAppProtection.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppProtection> UpdateAsync(TargetedManagedAppProtection targetedManagedAppProtectionToUpdate);

        /// <summary>
        /// Updates the specified TargetedManagedAppProtection using PATCH.
        /// </summary>
        /// <param name="targetedManagedAppProtectionToUpdate">The TargetedManagedAppProtection to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated TargetedManagedAppProtection.</returns>
        System.Threading.Tasks.Task<TargetedManagedAppProtection> UpdateAsync(TargetedManagedAppProtection targetedManagedAppProtectionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppProtectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppProtectionRequest Expand(Expression<Func<TargetedManagedAppProtection, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppProtectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ITargetedManagedAppProtectionRequest Select(Expression<Func<TargetedManagedAppProtection, object>> selectExpression);

    }
}
