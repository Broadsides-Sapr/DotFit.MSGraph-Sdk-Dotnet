// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type MailFolderRequestBuilder.
    /// </summary>
    public partial class MailFolderRequestBuilder : EntityRequestBuilder, IMailFolderRequestBuilder
    {

        /// <summary>
        /// Constructs a new MailFolderRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public MailFolderRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IMailFolderRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IMailFolderRequest Request(IEnumerable<Option> options)
        {
            return new MailFolderRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Messages.
        /// </summary>
        /// <returns>The <see cref="IMailFolderMessagesCollectionRequestBuilder"/>.</returns>
        public IMailFolderMessagesCollectionRequestBuilder Messages
        {
            get
            {
                return new MailFolderMessagesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("messages"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MessageRules.
        /// </summary>
        /// <returns>The <see cref="IMailFolderMessageRulesCollectionRequestBuilder"/>.</returns>
        public IMailFolderMessageRulesCollectionRequestBuilder MessageRules
        {
            get
            {
                return new MailFolderMessageRulesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("messageRules"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ChildFolders.
        /// </summary>
        /// <returns>The <see cref="IMailFolderChildFoldersCollectionRequestBuilder"/>.</returns>
        public IMailFolderChildFoldersCollectionRequestBuilder ChildFolders
        {
            get
            {
                return new MailFolderChildFoldersCollectionRequestBuilder(this.AppendSegmentToRequestUrl("childFolders"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for SingleValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IMailFolderSingleValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IMailFolderSingleValueExtendedPropertiesCollectionRequestBuilder SingleValueExtendedProperties
        {
            get
            {
                return new MailFolderSingleValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("singleValueExtendedProperties"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for MultiValueExtendedProperties.
        /// </summary>
        /// <returns>The <see cref="IMailFolderMultiValueExtendedPropertiesCollectionRequestBuilder"/>.</returns>
        public IMailFolderMultiValueExtendedPropertiesCollectionRequestBuilder MultiValueExtendedProperties
        {
            get
            {
                return new MailFolderMultiValueExtendedPropertiesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("multiValueExtendedProperties"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for MailFolderCopy.
        /// </summary>
        /// <returns>The <see cref="IMailFolderCopyRequestBuilder"/>.</returns>
        public IMailFolderCopyRequestBuilder Copy(
            string DestinationId = null)
        {
            return new MailFolderCopyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.copy"),
                this.Client,
                DestinationId);
        }

        /// <summary>
        /// Gets the request builder for MailFolderMove.
        /// </summary>
        /// <returns>The <see cref="IMailFolderMoveRequestBuilder"/>.</returns>
        public IMailFolderMoveRequestBuilder Move(
            string DestinationId = null)
        {
            return new MailFolderMoveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.move"),
                this.Client,
                DestinationId);
        }
    
    }
}
