// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Education User.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<EducationUser>))]
    public partial class EducationUser : Entity
    {
    
        /// <summary>
        /// Gets or sets related contacts.
        /// Related records associated with the user. Read-only.
        /// </summary>
        [JsonPropertyName("relatedContacts")]
        public IEnumerable<RelatedContact> RelatedContacts { get; set; }
    
        /// <summary>
        /// Gets or sets account enabled.
        /// True if the account is enabled; otherwise, false. This property is required when a user is created. Supports $filter.
        /// </summary>
        [JsonPropertyName("accountEnabled")]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets assigned licenses.
        /// The licenses that are assigned to the user. Not nullable.
        /// </summary>
        [JsonPropertyName("assignedLicenses")]
        public IEnumerable<AssignedLicense> AssignedLicenses { get; set; }
    
        /// <summary>
        /// Gets or sets assigned plans.
        /// The plans that are assigned to the user. Read-only. Not nullable.
        /// </summary>
        [JsonPropertyName("assignedPlans")]
        public IEnumerable<AssignedPlan> AssignedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// The telephone numbers for the user. Note: Although this is a string collection, only one number can be set for this property.
        /// </summary>
        [JsonPropertyName("businessPhones")]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets created by.
        /// The entity who created the user.
        /// </summary>
        [JsonPropertyName("createdBy")]
        public IdentitySet CreatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// The name for the department in which the user works. Supports $filter.
        /// </summary>
        [JsonPropertyName("department")]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial, and last name. This property is required when a user is created and it cannot be cleared during updates. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets external source.
        /// Where this user was created from. Possible values are: sis, manual.
        /// </summary>
        [JsonPropertyName("externalSource")]
        public EducationExternalSource? ExternalSource { get; set; }
    
        /// <summary>
        /// Gets or sets external source detail.
        /// The name of the external source this resource was generated from.
        /// </summary>
        [JsonPropertyName("externalSourceDetail")]
        public string ExternalSourceDetail { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// The given name (first name) of the user. Supports $filter.
        /// </summary>
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the user, for example, jeff@contoso.onmicrosoft.com. Read-Only. Supports $filter.
        /// </summary>
        [JsonPropertyName("mail")]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mailing address.
        /// The mail address of the user.
        /// </summary>
        [JsonPropertyName("mailingAddress")]
        public PhysicalAddress MailingAddress { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// The mail alias for the user. This property must be specified when a user is created. Supports $filter.
        /// </summary>
        [JsonPropertyName("mailNickname")]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets middle name.
        /// The middle name of the user.
        /// </summary>
        [JsonPropertyName("middleName")]
        public string MiddleName { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// The primary cellular telephone number for the user.
        /// </summary>
        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// </summary>
        [JsonPropertyName("officeLocation")]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets on premises info.
        /// Additional information used to associate the Azure Active Directory user with its Active Directory counterpart.
        /// </summary>
        [JsonPropertyName("onPremisesInfo")]
        public EducationOnPremisesInfo OnPremisesInfo { get; set; }
    
        /// <summary>
        /// Gets or sets password policies.
        /// Specifies password policies for the user. This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified. DisablePasswordExpiration can also be specified. The two can be specified together; for example: DisablePasswordExpiration, DisableStrongPassword.
        /// </summary>
        [JsonPropertyName("passwordPolicies")]
        public string PasswordPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets password profile.
        /// Specifies the password profile for the user. The profile contains the user's password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required.
        /// </summary>
        [JsonPropertyName("passwordProfile")]
        public PasswordProfile PasswordProfile { get; set; }
    
        /// <summary>
        /// Gets or sets preferred language.
        /// The preferred language for the user that should follow the ISO 639-1 code, for example, en-US.
        /// </summary>
        [JsonPropertyName("preferredLanguage")]
        public string PreferredLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets primary role.
        /// Default role for a user. The user's role might be different in an individual class. Possible values are: student, teacher, none, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("primaryRole")]
        public EducationUserRole? PrimaryRole { get; set; }
    
        /// <summary>
        /// Gets or sets provisioned plans.
        /// The plans that are provisioned for the user. Read-only. Not nullable.
        /// </summary>
        [JsonPropertyName("provisionedPlans")]
        public IEnumerable<ProvisionedPlan> ProvisionedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets refresh tokens valid from date time.
        /// </summary>
        [JsonPropertyName("refreshTokensValidFromDateTime")]
        public DateTimeOffset? RefreshTokensValidFromDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets residence address.
        /// The address where the user lives.
        /// </summary>
        [JsonPropertyName("residenceAddress")]
        public PhysicalAddress ResidenceAddress { get; set; }
    
        /// <summary>
        /// Gets or sets show in address list.
        /// True if the Outlook Global Address List should contain this user; otherwise, false. If not set, this will be treated as true. For users invited through the invitation manager, this property will be set to false.
        /// </summary>
        [JsonPropertyName("showInAddressList")]
        public bool? ShowInAddressList { get; set; }
    
        /// <summary>
        /// Gets or sets student.
        /// If the primary role is student, this block will contain student specific data.
        /// </summary>
        [JsonPropertyName("student")]
        public EducationStudent Student { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// The user's surname (family name or last name). Supports $filter.
        /// </summary>
        [JsonPropertyName("surname")]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets teacher.
        /// If the primary role is teacher, this block will contain teacher specific data.
        /// </summary>
        [JsonPropertyName("teacher")]
        public EducationTeacher Teacher { get; set; }
    
        /// <summary>
        /// Gets or sets usage location.
        /// A two-letter country code (ISO standard 3166). Required for users who will be assigned licenses due to a legal requirement to check for availability of services in countries or regions. Examples include: US, JP, and GB. Not nullable. Supports $filter.
        /// </summary>
        [JsonPropertyName("usageLocation")]
        public string UsageLocation { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the user. The UPN is an internet-style login name for the user based on the internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant's collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of the organization. Supports $filter and $orderby.
        /// </summary>
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user type.
        /// A string value that can be used to classify user types in your directory, such as Member and Guest. Supports $filter.
        /// </summary>
        [JsonPropertyName("userType")]
        public string UserType { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// Assignments belonging to the user.
        /// </summary>
        [JsonPropertyName("assignments")]
        public IEducationUserAssignmentsCollectionPage Assignments { get; set; }

        /// <summary>
        /// Gets or sets assignmentsNextLink.
        /// </summary>
        [JsonPropertyName("assignments@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string AssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets rubrics.
        /// When set, the grading rubric attached to the assignment.
        /// </summary>
        [JsonPropertyName("rubrics")]
        public IEducationUserRubricsCollectionPage Rubrics { get; set; }

        /// <summary>
        /// Gets or sets rubricsNextLink.
        /// </summary>
        [JsonPropertyName("rubrics@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string RubricsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets classes.
        /// Classes to which the user belongs. Nullable.
        /// </summary>
        [JsonPropertyName("classes")]
        public IEducationUserClassesCollectionWithReferencesPage Classes { get; set; }

        /// <summary>
        /// Gets or sets classesNextLink.
        /// </summary>
        [JsonPropertyName("classes@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string ClassesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets schools.
        /// Schools to which the user belongs. Nullable.
        /// </summary>
        [JsonPropertyName("schools")]
        public IEducationUserSchoolsCollectionWithReferencesPage Schools { get; set; }

        /// <summary>
        /// Gets or sets schoolsNextLink.
        /// </summary>
        [JsonPropertyName("schools@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string SchoolsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets taught classes.
        /// Classes for which the user is a teacher.
        /// </summary>
        [JsonPropertyName("taughtClasses")]
        public IEducationUserTaughtClassesCollectionWithReferencesPage TaughtClasses { get; set; }

        /// <summary>
        /// Gets or sets taughtClassesNextLink.
        /// </summary>
        [JsonPropertyName("taughtClasses@odata.nextLink")]
        [JsonConverter(typeof(NextLinkConverter))]
        public string TaughtClassesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user.
        /// The directory user that corresponds to this user.
        /// </summary>
        [JsonPropertyName("user")]
        public User User { get; set; }
    
    }
}

