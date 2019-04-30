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
    /// The interface IThumbnailSetRequest.
    /// </summary>
    public partial interface IThumbnailSetRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ThumbnailSet using PUT.
        /// </summary>
        /// <param name="thumbnailSetToCreate">The ThumbnailSet to create.</param>
        /// <returns>The created ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> CreateAsync(ThumbnailSet thumbnailSetToCreate);        /// <summary>
        /// Creates the specified ThumbnailSet using PUT.
        /// </summary>
        /// <param name="thumbnailSetToCreate">The ThumbnailSet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> CreateAsync(ThumbnailSet thumbnailSetToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ThumbnailSet.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ThumbnailSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ThumbnailSet.
        /// </summary>
        /// <returns>The ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> GetAsync();

        /// <summary>
        /// Gets the specified ThumbnailSet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ThumbnailSet using PATCH.
        /// </summary>
        /// <param name="thumbnailSetToUpdate">The ThumbnailSet to update.</param>
        /// <returns>The updated ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> UpdateAsync(ThumbnailSet thumbnailSetToUpdate);

        /// <summary>
        /// Updates the specified ThumbnailSet using PATCH.
        /// </summary>
        /// <param name="thumbnailSetToUpdate">The ThumbnailSet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated ThumbnailSet.</returns>
        System.Threading.Tasks.Task<ThumbnailSet> UpdateAsync(ThumbnailSet thumbnailSetToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailSetRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailSetRequest Expand(Expression<Func<ThumbnailSet, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailSetRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IThumbnailSetRequest Select(Expression<Func<ThumbnailSet, object>> selectExpression);

    }
}
