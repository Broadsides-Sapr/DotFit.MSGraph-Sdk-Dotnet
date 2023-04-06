using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum AuthenticationProtocol {
        [EnumMember(Value = "wsFed")]
        WsFed,
        [EnumMember(Value = "saml")]
        Saml,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
