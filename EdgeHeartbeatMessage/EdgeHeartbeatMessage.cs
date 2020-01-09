// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EdgeHeartbeatMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace EdgeHeartbeartMessage {

  /// <summary>Holder for reflection information generated from EdgeHeartbeatMessage.proto</summary>
  public static partial class EdgeHeartbeatMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for EdgeHeartbeatMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EdgeHeartbeatMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpFZGdlSGVhcnRiZWF0TWVzc2FnZS5wcm90bxIVRWRnZUhlYXJ0YmVhcnRN",
            "ZXNzYWdlIlgKCUhlYXJ0YmVhdBIPCgdNc2dUeXBlGAEgASgJEgwKBE5hbWUY",
            "AiABKAkSCgoCSWQYAyABKAMSIAoYSGVhcnRiZWF0Q3JlYXRlZFRpY2tzVXRj",
            "GAQgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::EdgeHeartbeartMessage.Heartbeat), global::EdgeHeartbeartMessage.Heartbeat.Parser, new[]{ "MsgType", "Name", "Id", "HeartbeatCreatedTicksUtc" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Heartbeat : pb::IMessage<Heartbeat> {
    private static readonly pb::MessageParser<Heartbeat> _parser = new pb::MessageParser<Heartbeat>(() => new Heartbeat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Heartbeat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::EdgeHeartbeartMessage.EdgeHeartbeatMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Heartbeat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Heartbeat(Heartbeat other) : this() {
      msgType_ = other.msgType_;
      name_ = other.name_;
      id_ = other.id_;
      heartbeatCreatedTicksUtc_ = other.heartbeatCreatedTicksUtc_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Heartbeat Clone() {
      return new Heartbeat(this);
    }

    /// <summary>Field number for the "MsgType" field.</summary>
    public const int MsgTypeFieldNumber = 1;
    private string msgType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MsgType {
      get { return msgType_; }
      set {
        msgType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 3;
    private long id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "HeartbeatCreatedTicksUtc" field.</summary>
    public const int HeartbeatCreatedTicksUtcFieldNumber = 4;
    private long heartbeatCreatedTicksUtc_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long HeartbeatCreatedTicksUtc {
      get { return heartbeatCreatedTicksUtc_; }
      set {
        heartbeatCreatedTicksUtc_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Heartbeat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Heartbeat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MsgType != other.MsgType) return false;
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if (HeartbeatCreatedTicksUtc != other.HeartbeatCreatedTicksUtc) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MsgType.Length != 0) hash ^= MsgType.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (HeartbeatCreatedTicksUtc != 0L) hash ^= HeartbeatCreatedTicksUtc.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MsgType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(MsgType);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Id != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(Id);
      }
      if (HeartbeatCreatedTicksUtc != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(HeartbeatCreatedTicksUtc);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MsgType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MsgType);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HeartbeatCreatedTicksUtc != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HeartbeatCreatedTicksUtc);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Heartbeat other) {
      if (other == null) {
        return;
      }
      if (other.MsgType.Length != 0) {
        MsgType = other.MsgType;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.HeartbeatCreatedTicksUtc != 0L) {
        HeartbeatCreatedTicksUtc = other.HeartbeatCreatedTicksUtc;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            MsgType = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 24: {
            Id = input.ReadInt64();
            break;
          }
          case 32: {
            HeartbeatCreatedTicksUtc = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
