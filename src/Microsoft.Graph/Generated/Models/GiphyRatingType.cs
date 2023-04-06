using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum GiphyRatingType {
        [EnumMember(Value = "strict")]
        Strict,
        [EnumMember(Value = "moderate")]
        Moderate,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
