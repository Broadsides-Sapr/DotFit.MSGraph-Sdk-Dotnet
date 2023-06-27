using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum UserSignInRecommendationScope {
        [EnumMember(Value = "tenant")]
        Tenant,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
