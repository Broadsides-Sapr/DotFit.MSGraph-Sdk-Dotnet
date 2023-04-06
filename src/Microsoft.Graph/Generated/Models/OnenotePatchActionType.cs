using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum OnenotePatchActionType {
        [EnumMember(Value = "Replace")]
        Replace,
        [EnumMember(Value = "Append")]
        Append,
        [EnumMember(Value = "Delete")]
        Delete,
        [EnumMember(Value = "Insert")]
        Insert,
        [EnumMember(Value = "Prepend")]
        Prepend,
    }
}
