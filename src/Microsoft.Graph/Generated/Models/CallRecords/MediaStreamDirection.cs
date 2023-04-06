using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.CallRecords {
    public enum MediaStreamDirection {
        [EnumMember(Value = "callerToCallee")]
        CallerToCallee,
        [EnumMember(Value = "calleeToCaller")]
        CalleeToCaller,
    }
}
