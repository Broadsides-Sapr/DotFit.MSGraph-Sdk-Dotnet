using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WorkbookSessionInfo : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Id of the workbook session.</summary>
        public string Id { get; set; }
        /// <summary>true for persistent session. false for non-persistent session (view mode)</summary>
        public bool? PersistChanges { get; set; }
        /// <summary>
        /// Instantiates a new workbookSessionInfo and sets the default values.
        /// </summary>
        public WorkbookSessionInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"id", (o,n) => { (o as WorkbookSessionInfo).Id = n.GetStringValue(); } },
                {"persistChanges", (o,n) => { (o as WorkbookSessionInfo).PersistChanges = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("persistChanges", PersistChanges);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
