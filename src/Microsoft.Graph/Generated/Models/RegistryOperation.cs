using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum RegistryOperation {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "create")]
        Create,
        [EnumMember(Value = "modify")]
        Modify,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
