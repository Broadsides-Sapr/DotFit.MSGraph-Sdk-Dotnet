using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum OnlineMeetingRole {
        [EnumMember(Value = "attendee")]
        Attendee,
        [EnumMember(Value = "presenter")]
        Presenter,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "producer")]
        Producer,
        [EnumMember(Value = "coorganizer")]
        Coorganizer,
    }
}
