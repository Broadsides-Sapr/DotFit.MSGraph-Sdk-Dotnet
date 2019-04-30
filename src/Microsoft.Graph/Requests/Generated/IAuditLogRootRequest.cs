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
    /// The interface IAuditLogRootRequest.
    /// </summary>
    public partial interface IAuditLogRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AuditLogRoot using PUT.
        /// </summary>
        /// <param name="auditLogRootToCreate">The AuditLogRoot to create.</param>
        /// <returns>The created AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> CreateAsync(AuditLogRoot auditLogRootToCreate);        /// <summary>
        /// Creates the specified AuditLogRoot using PUT.
        /// </summary>
        /// <param name="auditLogRootToCreate">The AuditLogRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> CreateAsync(AuditLogRoot auditLogRootToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AuditLogRoot.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AuditLogRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AuditLogRoot.
        /// </summary>
        /// <returns>The AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> GetAsync();

        /// <summary>
        /// Gets the specified AuditLogRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AuditLogRoot using PATCH.
        /// </summary>
        /// <param name="auditLogRootToUpdate">The AuditLogRoot to update.</param>
        /// <returns>The updated AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> UpdateAsync(AuditLogRoot auditLogRootToUpdate);

        /// <summary>
        /// Updates the specified AuditLogRoot using PATCH.
        /// </summary>
        /// <param name="auditLogRootToUpdate">The AuditLogRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated AuditLogRoot.</returns>
        System.Threading.Tasks.Task<AuditLogRoot> UpdateAsync(AuditLogRoot auditLogRootToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuditLogRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAuditLogRootRequest Expand(Expression<Func<AuditLogRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAuditLogRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAuditLogRootRequest Select(Expression<Func<AuditLogRoot, object>> selectExpression);

    }
}
