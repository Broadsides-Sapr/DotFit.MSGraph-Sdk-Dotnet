using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class TrainingEventsContent : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>List of assigned trainings and their information in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignedTrainingInfo>? AssignedTrainingsInfos {
            get { return BackingStore?.Get<List<AssignedTrainingInfo>?>("assignedTrainingsInfos"); }
            set { BackingStore?.Set("assignedTrainingsInfos", value); }
        }
#nullable restore
#else
        public List<AssignedTrainingInfo> AssignedTrainingsInfos {
            get { return BackingStore?.Get<List<AssignedTrainingInfo>>("assignedTrainingsInfos"); }
            set { BackingStore?.Set("assignedTrainingsInfos", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
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
        /// <summary>Number of users who were assigned trainings in an attack simulation and training campaign.</summary>
        public int? TrainingsAssignedUserCount {
            get { return BackingStore?.Get<int?>("trainingsAssignedUserCount"); }
            set { BackingStore?.Set("trainingsAssignedUserCount", value); }
        }
        /// <summary>
        /// Instantiates a new trainingEventsContent and sets the default values.
        /// </summary>
        public TrainingEventsContent() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TrainingEventsContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrainingEventsContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedTrainingsInfos", n => { AssignedTrainingsInfos = n.GetCollectionOfObjectValues<AssignedTrainingInfo>(AssignedTrainingInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"trainingsAssignedUserCount", n => { TrainingsAssignedUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AssignedTrainingInfo>("assignedTrainingsInfos", AssignedTrainingsInfos);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("trainingsAssignedUserCount", TrainingsAssignedUserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
