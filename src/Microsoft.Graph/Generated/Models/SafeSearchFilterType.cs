using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Specifies what level of safe search (filtering adult content) is required</summary>
    public enum SafeSearchFilterType {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Strict, highest filtering against adult content.</summary>
        [EnumMember(Value = "strict")]
        Strict,
        /// <summary>Moderate filtering against adult content (valid search results will not be filtered).</summary>
        [EnumMember(Value = "moderate")]
        Moderate,
    }
}
