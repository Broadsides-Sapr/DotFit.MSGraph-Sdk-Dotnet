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
    /// The interface IPlannerTaskDetailsRequest.
    /// </summary>
    public partial interface IPlannerTaskDetailsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PlannerTaskDetails using PUT.
        /// </summary>
        /// <param name="plannerTaskDetailsToCreate">The PlannerTaskDetails to create.</param>
        /// <returns>The created PlannerTaskDetails.</returns>
        System.Threading.Tasks.Task<PlannerTaskDetails> CreateAsync(PlannerTaskDetails plannerTaskDetailsToCreate);        /// <summary>
        /// Creates the specified PlannerTaskDetails using PUT.
        /// </summary>
        /// <param name="plannerTaskDetailsToCreate">The PlannerTaskDetails to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PlannerTaskDetails.</returns>
        System.Threading.Tasks.Task<PlannerTaskDetails> CreateAsync(PlannerTaskDetails plannerTaskDetailsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PlannerTaskDetails.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PlannerTaskDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PlannerTaskDetails.
        /// </summary>
        /// <returns>The PlannerTaskDetails.</returns>
        System.Threading.Tasks.Task<PlannerTaskDetails> GetAsync();

        /// <summary>
        /// Gets the specified PlannerTaskDetails.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PlannerTaskDetails.</returns>
        System.Threading.Tasks.Task<PlannerTaskDetails> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PlannerTaskDetails using PATCH.
        /// </summary>
        /// <param name="plannerTaskDetailsToUpdate">The PlannerTaskDetails to update.</param>
        /// <returns>The updated PlannerTaskDetails.</returns>
        System.Threading.Tasks.Task<PlannerTaskDetails> UpdateAsync(PlannerTaskDetails plannerTaskDetailsToUpdate);

        /// <summary>
        /// Updates the specified PlannerTaskDetails using PATCH.
        /// </summary>
        /// <param name="plannerTaskDetailsToUpdate">The PlannerTaskDetails to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PlannerTaskDetails.</returns>
        System.Threading.Tasks.Task<PlannerTaskDetails> UpdateAsync(PlannerTaskDetails plannerTaskDetailsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerTaskDetailsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerTaskDetailsRequest Expand(Expression<Func<PlannerTaskDetails, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerTaskDetailsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPlannerTaskDetailsRequest Select(Expression<Func<PlannerTaskDetails, object>> selectExpression);

    }
}
