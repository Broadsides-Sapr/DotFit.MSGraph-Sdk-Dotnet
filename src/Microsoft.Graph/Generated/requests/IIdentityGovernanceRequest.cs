// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIdentityGovernanceRequest.
    /// </summary>
    public partial interface IIdentityGovernanceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IdentityGovernance using POST.
        /// </summary>
        /// <param name="identityGovernanceToCreate">The IdentityGovernance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IdentityGovernance.</returns>
        System.Threading.Tasks.Task<IdentityGovernance> CreateAsync(IdentityGovernance identityGovernanceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified IdentityGovernance using POST and returns a <see cref="GraphResponse{IdentityGovernance}"/> object.
        /// </summary>
        /// <param name="identityGovernanceToCreate">The IdentityGovernance to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityGovernance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityGovernance>> CreateResponseAsync(IdentityGovernance identityGovernanceToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IdentityGovernance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified IdentityGovernance and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IdentityGovernance.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IdentityGovernance.</returns>
        System.Threading.Tasks.Task<IdentityGovernance> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified IdentityGovernance and returns a <see cref="GraphResponse{IdentityGovernance}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IdentityGovernance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityGovernance>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityGovernance using PATCH.
        /// </summary>
        /// <param name="identityGovernanceToUpdate">The IdentityGovernance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IdentityGovernance.</returns>
        System.Threading.Tasks.Task<IdentityGovernance> UpdateAsync(IdentityGovernance identityGovernanceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityGovernance using PATCH and returns a <see cref="GraphResponse{IdentityGovernance}"/> object.
        /// </summary>
        /// <param name="identityGovernanceToUpdate">The IdentityGovernance to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IdentityGovernance}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityGovernance>> UpdateResponseAsync(IdentityGovernance identityGovernanceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityGovernance using PUT.
        /// </summary>
        /// <param name="identityGovernanceToUpdate">The IdentityGovernance object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IdentityGovernance> PutAsync(IdentityGovernance identityGovernanceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified IdentityGovernance using PUT and returns a <see cref="GraphResponse{IdentityGovernance}"/> object.
        /// </summary>
        /// <param name="identityGovernanceToUpdate">The IdentityGovernance object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IdentityGovernance}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IdentityGovernance>> PutResponseAsync(IdentityGovernance identityGovernanceToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityGovernanceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityGovernanceRequest Expand(Expression<Func<IdentityGovernance, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityGovernanceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIdentityGovernanceRequest Select(Expression<Func<IdentityGovernance, object>> selectExpression);

    }
}