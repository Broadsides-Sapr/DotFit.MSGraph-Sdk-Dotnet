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
    /// The interface IWindows81GeneralConfigurationRequest.
    /// </summary>
    public partial interface IWindows81GeneralConfigurationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Windows81GeneralConfiguration using PUT.
        /// </summary>
        /// <param name="windows81GeneralConfigurationToCreate">The Windows81GeneralConfiguration to create.</param>
        /// <returns>The created Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> CreateAsync(Windows81GeneralConfiguration windows81GeneralConfigurationToCreate);        /// <summary>
        /// Creates the specified Windows81GeneralConfiguration using PUT.
        /// </summary>
        /// <param name="windows81GeneralConfigurationToCreate">The Windows81GeneralConfiguration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> CreateAsync(Windows81GeneralConfiguration windows81GeneralConfigurationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Windows81GeneralConfiguration.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Windows81GeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Windows81GeneralConfiguration.
        /// </summary>
        /// <returns>The Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> GetAsync();

        /// <summary>
        /// Gets the specified Windows81GeneralConfiguration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Windows81GeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windows81GeneralConfigurationToUpdate">The Windows81GeneralConfiguration to update.</param>
        /// <returns>The updated Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> UpdateAsync(Windows81GeneralConfiguration windows81GeneralConfigurationToUpdate);

        /// <summary>
        /// Updates the specified Windows81GeneralConfiguration using PATCH.
        /// </summary>
        /// <param name="windows81GeneralConfigurationToUpdate">The Windows81GeneralConfiguration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Windows81GeneralConfiguration.</returns>
        System.Threading.Tasks.Task<Windows81GeneralConfiguration> UpdateAsync(Windows81GeneralConfiguration windows81GeneralConfigurationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81GeneralConfigurationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81GeneralConfigurationRequest Expand(Expression<Func<Windows81GeneralConfiguration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81GeneralConfigurationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindows81GeneralConfigurationRequest Select(Expression<Func<Windows81GeneralConfiguration, object>> selectExpression);

    }
}
