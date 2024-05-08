// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    #pragma warning disable CS1591
    public class KubernetesServicePort : IAdditionalDataHolder, IBackedModel, IParsable 
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>The application protocol for this port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppProtocol {
            get { return BackingStore?.Get<string?>("appProtocol"); }
            set { BackingStore?.Set("appProtocol", value); }
        }
#nullable restore
#else
        public string AppProtocol {
            get { return BackingStore?.Get<string>("appProtocol"); }
            set { BackingStore?.Set("appProtocol", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The name of this port within the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The port on each node on which this service is exposed when the type is either NodePort or LoadBalancer.</summary>
        public int? NodePort {
            get { return BackingStore?.Get<int?>("nodePort"); }
            set { BackingStore?.Set("nodePort", value); }
        }
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
        /// <summary>The port that this service exposes.</summary>
        public int? Port {
            get { return BackingStore?.Get<int?>("port"); }
            set { BackingStore?.Set("port", value); }
        }
        /// <summary>The protocol name. Possible values are: udp, tcp, sctp, unknownFutureValue.</summary>
        public ContainerPortProtocol? Protocol {
            get { return BackingStore?.Get<ContainerPortProtocol?>("protocol"); }
            set { BackingStore?.Set("protocol", value); }
        }
        /// <summary>The name or number of the port to access on the pods targeted by the service. The port number must be in the range 1 to 65535. The name must be an IANASVCNAME.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetPort {
            get { return BackingStore?.Get<string?>("targetPort"); }
            set { BackingStore?.Set("targetPort", value); }
        }
#nullable restore
#else
        public string TargetPort {
            get { return BackingStore?.Get<string>("targetPort"); }
            set { BackingStore?.Set("targetPort", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="KubernetesServicePort"/> and sets the default values.
        /// </summary>
        public KubernetesServicePort()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="KubernetesServicePort"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static KubernetesServicePort CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesServicePort();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                {"appProtocol", n => { AppProtocol = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"nodePort", n => { NodePort = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"port", n => { Port = n.GetIntValue(); } },
                {"protocol", n => { Protocol = n.GetEnumValue<ContainerPortProtocol>(); } },
                {"targetPort", n => { TargetPort = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("appProtocol", AppProtocol);
            writer.WriteStringValue("name", Name);
            writer.WriteIntValue("nodePort", NodePort);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("port", Port);
            writer.WriteEnumValue<ContainerPortProtocol>("protocol", Protocol);
            writer.WriteStringValue("targetPort", TargetPort);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
