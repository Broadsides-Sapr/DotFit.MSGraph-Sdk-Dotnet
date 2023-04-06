using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>TV content rating labels in New Zealand</summary>
    public enum RatingNewZealandTelevisionType {
        /// <summary>Default value, allow all TV shows content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any TV shows content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The G classification excludes materials likely to harm children under 14</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The PGR classification encourages parents and guardians to supervise younger viewers</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>The AO classification is not suitable for children</summary>
        [EnumMember(Value = "adults")]
        Adults,
    }
}
