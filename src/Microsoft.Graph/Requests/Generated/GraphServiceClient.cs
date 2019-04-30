// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityClient.cs.tt

namespace Microsoft.Graph
{

    /// <summary>
    /// The type GraphServiceClient.
    /// </summary>
    public partial class GraphServiceClient : BaseClient, IGraphServiceClient
    {
        /// <summary>
        /// Instantiates a new GraphServiceClient.
        /// </summary>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public GraphServiceClient(
            IAuthenticationProvider authenticationProvider,
            IHttpProvider httpProvider = null)
            : this("https://graph.microsoft.com/v1.0", authenticationProvider, httpProvider)
        {
        }

        /// <summary>
        /// Instantiates a new GraphServiceClient.
        /// </summary>
        /// <param name="baseUrl">The base service URL. For example, "https://graph.microsoft.com/v1.0".</param>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        /// <param name="httpProvider">The <see cref="IHttpProvider"/> for sending requests.</param>
        public GraphServiceClient(
            string baseUrl,
            IAuthenticationProvider authenticationProvider,
            IHttpProvider httpProvider = null)
            : base(baseUrl, authenticationProvider, httpProvider)
        {
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryObjects request builder.
        /// </summary>
        public IGraphServiceDirectoryObjectsCollectionRequestBuilder DirectoryObjects
        {
            get
            {
                return new GraphServiceDirectoryObjectsCollectionRequestBuilder(this.BaseUrl + "/directoryObjects", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDevices request builder.
        /// </summary>
        public IGraphServiceDevicesCollectionRequestBuilder Devices
        {
            get
            {
                return new GraphServiceDevicesCollectionRequestBuilder(this.BaseUrl + "/devices", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDomains request builder.
        /// </summary>
        public IGraphServiceDomainsCollectionRequestBuilder Domains
        {
            get
            {
                return new GraphServiceDomainsCollectionRequestBuilder(this.BaseUrl + "/domains", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDomainDnsRecords request builder.
        /// </summary>
        public IGraphServiceDomainDnsRecordsCollectionRequestBuilder DomainDnsRecords
        {
            get
            {
                return new GraphServiceDomainDnsRecordsCollectionRequestBuilder(this.BaseUrl + "/domainDnsRecords", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroups request builder.
        /// </summary>
        public IGraphServiceGroupsCollectionRequestBuilder Groups
        {
            get
            {
                return new GraphServiceGroupsCollectionRequestBuilder(this.BaseUrl + "/groups", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoles request builder.
        /// </summary>
        public IGraphServiceDirectoryRolesCollectionRequestBuilder DirectoryRoles
        {
            get
            {
                return new GraphServiceDirectoryRolesCollectionRequestBuilder(this.BaseUrl + "/directoryRoles", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectoryRoleTemplates request builder.
        /// </summary>
        public IGraphServiceDirectoryRoleTemplatesCollectionRequestBuilder DirectoryRoleTemplates
        {
            get
            {
                return new GraphServiceDirectoryRoleTemplatesCollectionRequestBuilder(this.BaseUrl + "/directoryRoleTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceOrganization request builder.
        /// </summary>
        public IGraphServiceOrganizationCollectionRequestBuilder Organization
        {
            get
            {
                return new GraphServiceOrganizationCollectionRequestBuilder(this.BaseUrl + "/organization", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroupSettings request builder.
        /// </summary>
        public IGraphServiceGroupSettingsCollectionRequestBuilder GroupSettings
        {
            get
            {
                return new GraphServiceGroupSettingsCollectionRequestBuilder(this.BaseUrl + "/groupSettings", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroupSettingTemplates request builder.
        /// </summary>
        public IGraphServiceGroupSettingTemplatesCollectionRequestBuilder GroupSettingTemplates
        {
            get
            {
                return new GraphServiceGroupSettingTemplatesCollectionRequestBuilder(this.BaseUrl + "/groupSettingTemplates", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSubscribedSkus request builder.
        /// </summary>
        public IGraphServiceSubscribedSkusCollectionRequestBuilder SubscribedSkus
        {
            get
            {
                return new GraphServiceSubscribedSkusCollectionRequestBuilder(this.BaseUrl + "/subscribedSkus", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceUsers request builder.
        /// </summary>
        public IGraphServiceUsersCollectionRequestBuilder Users
        {
            get
            {
                return new GraphServiceUsersCollectionRequestBuilder(this.BaseUrl + "/users", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceContracts request builder.
        /// </summary>
        public IGraphServiceContractsCollectionRequestBuilder Contracts
        {
            get
            {
                return new GraphServiceContractsCollectionRequestBuilder(this.BaseUrl + "/contracts", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSchemaExtensions request builder.
        /// </summary>
        public IGraphServiceSchemaExtensionsCollectionRequestBuilder SchemaExtensions
        {
            get
            {
                return new GraphServiceSchemaExtensionsCollectionRequestBuilder(this.BaseUrl + "/schemaExtensions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDrives request builder.
        /// </summary>
        public IGraphServiceDrivesCollectionRequestBuilder Drives
        {
            get
            {
                return new GraphServiceDrivesCollectionRequestBuilder(this.BaseUrl + "/drives", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceShares request builder.
        /// </summary>
        public IGraphServiceSharesCollectionRequestBuilder Shares
        {
            get
            {
                return new GraphServiceSharesCollectionRequestBuilder(this.BaseUrl + "/shares", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSites request builder.
        /// </summary>
        public IGraphServiceSitesCollectionRequestBuilder Sites
        {
            get
            {
                return new GraphServiceSitesCollectionRequestBuilder(this.BaseUrl + "/sites", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceWorkbooks request builder.
        /// </summary>
        public IGraphServiceWorkbooksCollectionRequestBuilder Workbooks
        {
            get
            {
                return new GraphServiceWorkbooksCollectionRequestBuilder(this.BaseUrl + "/workbooks", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSubscriptions request builder.
        /// </summary>
        public IGraphServiceSubscriptionsCollectionRequestBuilder Subscriptions
        {
            get
            {
                return new GraphServiceSubscriptionsCollectionRequestBuilder(this.BaseUrl + "/subscriptions", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceInvitations request builder.
        /// </summary>
        public IGraphServiceInvitationsCollectionRequestBuilder Invitations
        {
            get
            {
                return new GraphServiceInvitationsCollectionRequestBuilder(this.BaseUrl + "/invitations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceGroupLifecyclePolicies request builder.
        /// </summary>
        public IGraphServiceGroupLifecyclePoliciesCollectionRequestBuilder GroupLifecyclePolicies
        {
            get
            {
                return new GraphServiceGroupLifecyclePoliciesCollectionRequestBuilder(this.BaseUrl + "/groupLifecyclePolicies", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceTeams request builder.
        /// </summary>
        public IGraphServiceTeamsCollectionRequestBuilder Teams
        {
            get
            {
                return new GraphServiceTeamsCollectionRequestBuilder(this.BaseUrl + "/teams", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDataPolicyOperations request builder.
        /// </summary>
        public IGraphServiceDataPolicyOperationsCollectionRequestBuilder DataPolicyOperations
        {
            get
            {
                return new GraphServiceDataPolicyOperationsCollectionRequestBuilder(this.BaseUrl + "/dataPolicyOperations", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceIdentityProviders request builder.
        /// </summary>
        public IGraphServiceIdentityProvidersCollectionRequestBuilder IdentityProviders
        {
            get
            {
                return new GraphServiceIdentityProvidersCollectionRequestBuilder(this.BaseUrl + "/identityProviders", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceMe request builder.
        /// </summary>
        public IUserRequestBuilder Me
        {
            get
            {
                return new UserRequestBuilder(this.BaseUrl + "/me", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDirectory request builder.
        /// </summary>
        public IDirectoryRequestBuilder Directory
        {
            get
            {
                return new DirectoryRequestBuilder(this.BaseUrl + "/directory", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDrive request builder.
        /// </summary>
        public IDriveRequestBuilder Drive
        {
            get
            {
                return new DriveRequestBuilder(this.BaseUrl + "/drive", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServicePlanner request builder.
        /// </summary>
        public IPlannerRequestBuilder Planner
        {
            get
            {
                return new PlannerRequestBuilder(this.BaseUrl + "/planner", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceReports request builder.
        /// </summary>
        public IReportRootRequestBuilder Reports
        {
            get
            {
                return new ReportRootRequestBuilder(this.BaseUrl + "/reports", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceEducation request builder.
        /// </summary>
        public IEducationRootRequestBuilder Education
        {
            get
            {
                return new EducationRootRequestBuilder(this.BaseUrl + "/education", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDeviceAppManagement request builder.
        /// </summary>
        public IDeviceAppManagementRequestBuilder DeviceAppManagement
        {
            get
            {
                return new DeviceAppManagementRequestBuilder(this.BaseUrl + "/deviceAppManagement", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceDeviceManagement request builder.
        /// </summary>
        public IDeviceManagementRequestBuilder DeviceManagement
        {
            get
            {
                return new DeviceManagementRequestBuilder(this.BaseUrl + "/deviceManagement", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceSecurity request builder.
        /// </summary>
        public ISecurityRequestBuilder Security
        {
            get
            {
                return new SecurityRequestBuilder(this.BaseUrl + "/Security", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAppCatalogs request builder.
        /// </summary>
        public IAppCatalogsRequestBuilder AppCatalogs
        {
            get
            {
                return new AppCatalogsRequestBuilder(this.BaseUrl + "/appCatalogs", this);
            }
        }
    
        /// <summary>
        /// Gets the GraphServiceAuditLogs request builder.
        /// </summary>
        public IAuditLogRootRequestBuilder AuditLogs
        {
            get
            {
                return new AuditLogRootRequestBuilder(this.BaseUrl + "/auditLogs", this);
            }
        }
    
    }
}
