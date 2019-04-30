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
    /// The interface IWorkbookChartPointRequest.
    /// </summary>
    public partial interface IWorkbookChartPointRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartPoint using PUT.
        /// </summary>
        /// <param name="workbookChartPointToCreate">The WorkbookChartPoint to create.</param>
        /// <returns>The created WorkbookChartPoint.</returns>
        System.Threading.Tasks.Task<WorkbookChartPoint> CreateAsync(WorkbookChartPoint workbookChartPointToCreate);        /// <summary>
        /// Creates the specified WorkbookChartPoint using PUT.
        /// </summary>
        /// <param name="workbookChartPointToCreate">The WorkbookChartPoint to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartPoint.</returns>
        System.Threading.Tasks.Task<WorkbookChartPoint> CreateAsync(WorkbookChartPoint workbookChartPointToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookChartPoint.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookChartPoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookChartPoint.
        /// </summary>
        /// <returns>The WorkbookChartPoint.</returns>
        System.Threading.Tasks.Task<WorkbookChartPoint> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookChartPoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartPoint.</returns>
        System.Threading.Tasks.Task<WorkbookChartPoint> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookChartPoint using PATCH.
        /// </summary>
        /// <param name="workbookChartPointToUpdate">The WorkbookChartPoint to update.</param>
        /// <returns>The updated WorkbookChartPoint.</returns>
        System.Threading.Tasks.Task<WorkbookChartPoint> UpdateAsync(WorkbookChartPoint workbookChartPointToUpdate);

        /// <summary>
        /// Updates the specified WorkbookChartPoint using PATCH.
        /// </summary>
        /// <param name="workbookChartPointToUpdate">The WorkbookChartPoint to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookChartPoint.</returns>
        System.Threading.Tasks.Task<WorkbookChartPoint> UpdateAsync(WorkbookChartPoint workbookChartPointToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartPointRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartPointRequest Expand(Expression<Func<WorkbookChartPoint, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartPointRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartPointRequest Select(Expression<Func<WorkbookChartPoint, object>> selectExpression);

    }
}
