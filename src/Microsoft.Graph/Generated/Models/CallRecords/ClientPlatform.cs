using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.CallRecords {
    public enum ClientPlatform {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "windows")]
        Windows,
        [EnumMember(Value = "macOS")]
        MacOS,
        [EnumMember(Value = "iOS")]
        IOS,
        [EnumMember(Value = "android")]
        Android,
        [EnumMember(Value = "web")]
        Web,
        [EnumMember(Value = "ipPhone")]
        IpPhone,
        [EnumMember(Value = "roomSystem")]
        RoomSystem,
        [EnumMember(Value = "surfaceHub")]
        SurfaceHub,
        [EnumMember(Value = "holoLens")]
        HoloLens,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
