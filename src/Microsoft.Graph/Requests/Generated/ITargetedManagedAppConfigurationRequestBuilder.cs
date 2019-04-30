// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ITargetedManagedAppConfigurationRequestBuilder.
    /// </summary>
    public partial interface ITargetedManagedAppConfigurationRequestBuilder : IManagedAppConfigurationRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new ITargetedManagedAppConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new ITargetedManagedAppConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for Apps.
        /// </summary>
        /// <returns>The <see cref="ITargetedManagedAppConfigurationAppsCollectionRequestBuilder"/>.</returns>
        ITargetedManagedAppConfigurationAppsCollectionRequestBuilder Apps { get; }

        /// <summary>
        /// Gets the request builder for DeploymentSummary.
        /// </summary>
        /// <returns>The <see cref="IManagedAppPolicyDeploymentSummaryRequestBuilder"/>.</returns>
        IManagedAppPolicyDeploymentSummaryRequestBuilder DeploymentSummary { get; }

        /// <summary>
        /// Gets the request builder for Assignments.
        /// </summary>
        /// <returns>The <see cref="ITargetedManagedAppConfigurationAssignmentsCollectionRequestBuilder"/>.</returns>
        ITargetedManagedAppConfigurationAssignmentsCollectionRequestBuilder Assignments { get; }
    
        /// <summary>
        /// Gets the request builder for TargetedManagedAppConfigurationAssign.
        /// </summary>
        /// <returns>The <see cref="ITargetedManagedAppConfigurationAssignRequestBuilder"/>.</returns>
        ITargetedManagedAppConfigurationAssignRequestBuilder Assign(
            IEnumerable<TargetedManagedAppPolicyAssignment> assignments = null);

        /// <summary>
        /// Gets the request builder for TargetedManagedAppConfigurationTargetApps.
        /// </summary>
        /// <returns>The <see cref="ITargetedManagedAppConfigurationTargetAppsRequestBuilder"/>.</returns>
        ITargetedManagedAppConfigurationTargetAppsRequestBuilder TargetApps(
            IEnumerable<ManagedMobileApp> apps = null);
    
    }
}
