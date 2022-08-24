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
    /// The type Saml Or Ws Fed Provider.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SamlOrWsFedProvider>))]
    public partial class SamlOrWsFedProvider : IdentityProviderBase
    {
    
        ///<summary>
        /// The internal SamlOrWsFedProvider constructor
        ///</summary>
        protected internal SamlOrWsFedProvider()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets issuer uri.
        /// Issuer URI of the federation server.
        /// </summary>
        [JsonPropertyName("issuerUri")]
        public string IssuerUri { get; set; }
    
        /// <summary>
        /// Gets or sets metadata exchange uri.
        /// URI of the metadata exchange endpoint used for authentication from rich client applications.
        /// </summary>
        [JsonPropertyName("metadataExchangeUri")]
        public string MetadataExchangeUri { get; set; }
    
        /// <summary>
        /// Gets or sets passive sign in uri.
        /// URI that web-based clients are directed to when signing in to Azure Active Directory (Azure AD) services.
        /// </summary>
        [JsonPropertyName("passiveSignInUri")]
        public string PassiveSignInUri { get; set; }
    
        /// <summary>
        /// Gets or sets preferred authentication protocol.
        /// Preferred authentication protocol. The possible values are: wsFed, saml, unknownFutureValue.
        /// </summary>
        [JsonPropertyName("preferredAuthenticationProtocol")]
        public AuthenticationProtocol? PreferredAuthenticationProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets signing certificate.
        /// Current certificate used to sign tokens passed to the Microsoft identity platform. The certificate is formatted as a Base64 encoded string of the public portion of the federated IdP's token signing certificate and must be compatible with the X509Certificate2 class.   This property is used in the following scenarios:  if a rollover is required outside of the autorollover update a new federation service is being set up  if the new token signing certificate isn't present in the federation properties after the federation service certificate has been updated.   Azure AD updates certificates via an autorollover process in which it attempts to retrieve a new certificate from the federation service metadata, 30 days before expiry of the current certificate. If a new certificate isn't available, Azure AD monitors the metadata daily and will update the federation settings for the domain when a new certificate is available.
        /// </summary>
        [JsonPropertyName("signingCertificate")]
        public string SigningCertificate { get; set; }
    
    }
}

