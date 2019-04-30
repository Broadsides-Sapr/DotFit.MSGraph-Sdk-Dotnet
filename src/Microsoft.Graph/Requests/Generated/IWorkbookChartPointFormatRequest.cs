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
    /// The interface IWorkbookChartPointFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartPointFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartPointFormat using PUT.
        /// </summary>
        /// <param name="workbookChartPointFormatToCreate">The WorkbookChartPointFormat to create.</param>
        /// <returns>The created WorkbookChartPointFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartPointFormat> CreateAsync(WorkbookChartPointFormat workbookChartPointFormatToCreate);        /// <summary>
        /// Creates the specified WorkbookChartPointFormat using PUT.
        /// </summary>
        /// <param name="workbookChartPointFormatToCreate">The WorkbookChartPointFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartPointFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartPointFormat> CreateAsync(WorkbookChartPointFormat workbookChartPointFormatToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartPointFormat.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartPointFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartPointFormat.
        /// </summary>
        /// <returns>The WorkbookChartPointFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartPointFormat> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartPointFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartPointFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartPointFormat> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartPointFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartPointFormatToUpdate">The WorkbookChartPointFormat to update.</param>
        /// <returns>The updated WorkbookChartPointFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartPointFormat> UpdateAsync(WorkbookChartPointFormat workbookChartPointFormatToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartPointFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartPointFormatToUpdate">The WorkbookChartPointFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartPointFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartPointFormat> UpdateAsync(WorkbookChartPointFormat workbookChartPointFormatToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartPointFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartPointFormatRequest Expand(Expression<Func<WorkbookChartPointFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartPointFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartPointFormatRequest Select(Expression<Func<WorkbookChartPointFormat, object>> selectExpression);

    }
}
