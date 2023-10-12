// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.IdentityGovernance {
    public class TaskReportSummary : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("AdditionalData"); }
            set { BackingStore?.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The number of failed tasks in a report.</summary>
        public int? FailedTasks {
            get { return BackingStore?.Get<int?>("failedTasks"); }
            set { BackingStore?.Set("failedTasks", value); }
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
        /// <summary>The total number of successful tasks in a report.</summary>
        public int? SuccessfulTasks {
            get { return BackingStore?.Get<int?>("successfulTasks"); }
            set { BackingStore?.Set("successfulTasks", value); }
        }
        /// <summary>The total number of tasks in a report.</summary>
        public int? TotalTasks {
            get { return BackingStore?.Get<int?>("totalTasks"); }
            set { BackingStore?.Set("totalTasks", value); }
        }
        /// <summary>The number of unprocessed tasks in a report.</summary>
        public int? UnprocessedTasks {
            get { return BackingStore?.Get<int?>("unprocessedTasks"); }
            set { BackingStore?.Set("unprocessedTasks", value); }
        }
        /// <summary>
        /// Instantiates a new taskReportSummary and sets the default values.
        /// </summary>
        public TaskReportSummary() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TaskReportSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskReportSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedTasks", n => { FailedTasks = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"successfulTasks", n => { SuccessfulTasks = n.GetIntValue(); } },
                {"totalTasks", n => { TotalTasks = n.GetIntValue(); } },
                {"unprocessedTasks", n => { UnprocessedTasks = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedTasks", FailedTasks);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("successfulTasks", SuccessfulTasks);
            writer.WriteIntValue("totalTasks", TotalTasks);
            writer.WriteIntValue("unprocessedTasks", UnprocessedTasks);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
