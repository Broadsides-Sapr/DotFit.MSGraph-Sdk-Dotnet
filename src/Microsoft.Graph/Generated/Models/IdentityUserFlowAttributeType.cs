using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum IdentityUserFlowAttributeType {
        [EnumMember(Value = "builtIn")]
        BuiltIn,
        [EnumMember(Value = "custom")]
        Custom,
        [EnumMember(Value = "required")]
        Required,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
