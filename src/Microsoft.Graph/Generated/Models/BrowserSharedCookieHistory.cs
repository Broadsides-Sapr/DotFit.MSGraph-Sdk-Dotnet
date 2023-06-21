using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class BrowserSharedCookieHistory : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The comment for the shared cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment {
            get { return BackingStore?.Get<string?>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#nullable restore
#else
        public string Comment {
            get { return BackingStore?.Get<string>("comment"); }
            set { BackingStore?.Set("comment", value); }
        }
#endif
        /// <summary>The name of the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Controls whether a cookie is a host-only or domain cookie.</summary>
        public bool? HostOnly {
            get { return BackingStore?.Get<bool?>("hostOnly"); }
            set { BackingStore?.Set("hostOnly", value); }
        }
        /// <summary>The URL of the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostOrDomain {
            get { return BackingStore?.Get<string?>("hostOrDomain"); }
            set { BackingStore?.Set("hostOrDomain", value); }
        }
#nullable restore
#else
        public string HostOrDomain {
            get { return BackingStore?.Get<string>("hostOrDomain"); }
            set { BackingStore?.Set("hostOrDomain", value); }
        }
#endif
        /// <summary>The lastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The path of the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path {
            get { return BackingStore?.Get<string?>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#nullable restore
#else
        public string Path {
            get { return BackingStore?.Get<string>("path"); }
            set { BackingStore?.Set("path", value); }
        }
#endif
        /// <summary>The date and time when the cookie was last published.</summary>
        public DateTimeOffset? PublishedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("publishedDateTime"); }
            set { BackingStore?.Set("publishedDateTime", value); }
        }
        /// <summary>Specifies how the cookies are shared between Microsoft Edge and Internet Explorer. The possible values are: microsoftEdge, internetExplorer11, both, unknownFutureValue.</summary>
        public BrowserSharedCookieSourceEnvironment? SourceEnvironment {
            get { return BackingStore?.Get<BrowserSharedCookieSourceEnvironment?>("sourceEnvironment"); }
            set { BackingStore?.Set("sourceEnvironment", value); }
        }
        /// <summary>
        /// Instantiates a new BrowserSharedCookieHistory and sets the default values.
        /// </summary>
        public BrowserSharedCookieHistory() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BrowserSharedCookieHistory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BrowserSharedCookieHistory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"hostOnly", n => { HostOnly = n.GetBoolValue(); } },
                {"hostOrDomain", n => { HostOrDomain = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"sourceEnvironment", n => { SourceEnvironment = n.GetEnumValue<BrowserSharedCookieSourceEnvironment>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hostOnly", HostOnly);
            writer.WriteStringValue("hostOrDomain", HostOrDomain);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("path", Path);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteEnumValue<BrowserSharedCookieSourceEnvironment>("sourceEnvironment", SourceEnvironment);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
