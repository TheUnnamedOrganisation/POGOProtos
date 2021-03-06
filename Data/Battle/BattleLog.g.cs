// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Battle/BattleLog.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Battle {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleLog.proto</summary>
  public static partial class BattleLogReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Battle/BattleLog.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleLogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUxvZy5wcm90bxIWUE9H",
            "T1Byb3Rvcy5EYXRhLkJhdHRsZRooUE9HT1Byb3Rvcy9EYXRhL0JhdHRsZS9C",
            "YXR0bGVTdGF0ZS5wcm90bxonUE9HT1Byb3Rvcy9EYXRhL0JhdHRsZS9CYXR0",
            "bGVUeXBlLnByb3RvGilQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUFj",
            "dGlvbi5wcm90byKNAgoJQmF0dGxlTG9nEjIKBXN0YXRlGAEgASgOMiMuUE9H",
            "T1Byb3Rvcy5EYXRhLkJhdHRsZS5CYXR0bGVTdGF0ZRI3CgtiYXR0bGVfdHlw",
            "ZRgCIAEoDjIiLlBPR09Qcm90b3MuRGF0YS5CYXR0bGUuQmF0dGxlVHlwZRIR",
            "CglzZXJ2ZXJfbXMYAyABKAMSPAoOYmF0dGxlX2FjdGlvbnMYBCADKAsyJC5Q",
            "T0dPUHJvdG9zLkRhdGEuQmF0dGxlLkJhdHRsZUFjdGlvbhIhChliYXR0bGVf",
            "c3RhcnRfdGltZXN0YW1wX21zGAUgASgDEh8KF2JhdHRsZV9lbmRfdGltZXN0",
            "YW1wX21zGAYgASgDYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Battle.BattleStateReflection.Descriptor, global::POGOProtos.Data.Battle.BattleTypeReflection.Descriptor, global::POGOProtos.Data.Battle.BattleActionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Battle.BattleLog), global::POGOProtos.Data.Battle.BattleLog.Parser, new[]{ "State", "BattleType", "ServerMs", "BattleActions", "BattleStartTimestampMs", "BattleEndTimestampMs" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BattleLog : pb::IMessage<BattleLog> {
    private static readonly pb::MessageParser<BattleLog> _parser = new pb::MessageParser<BattleLog>(() => new BattleLog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BattleLog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Battle.BattleLogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleLog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleLog(BattleLog other) : this() {
      state_ = other.state_;
      battleType_ = other.battleType_;
      serverMs_ = other.serverMs_;
      battleActions_ = other.battleActions_.Clone();
      battleStartTimestampMs_ = other.battleStartTimestampMs_;
      battleEndTimestampMs_ = other.battleEndTimestampMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BattleLog Clone() {
      return new BattleLog(this);
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 1;
    private global::POGOProtos.Data.Battle.BattleState state_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattleState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "battle_type" field.</summary>
    public const int BattleTypeFieldNumber = 2;
    private global::POGOProtos.Data.Battle.BattleType battleType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.BattleType BattleType {
      get { return battleType_; }
      set {
        battleType_ = value;
      }
    }

    /// <summary>Field number for the "server_ms" field.</summary>
    public const int ServerMsFieldNumber = 3;
    private long serverMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ServerMs {
      get { return serverMs_; }
      set {
        serverMs_ = value;
      }
    }

    /// <summary>Field number for the "battle_actions" field.</summary>
    public const int BattleActionsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Battle.BattleAction> _repeated_battleActions_codec
        = pb::FieldCodec.ForMessage(34, global::POGOProtos.Data.Battle.BattleAction.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Battle.BattleAction> battleActions_ = new pbc::RepeatedField<global::POGOProtos.Data.Battle.BattleAction>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Battle.BattleAction> BattleActions {
      get { return battleActions_; }
    }

    /// <summary>Field number for the "battle_start_timestamp_ms" field.</summary>
    public const int BattleStartTimestampMsFieldNumber = 5;
    private long battleStartTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BattleStartTimestampMs {
      get { return battleStartTimestampMs_; }
      set {
        battleStartTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "battle_end_timestamp_ms" field.</summary>
    public const int BattleEndTimestampMsFieldNumber = 6;
    private long battleEndTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long BattleEndTimestampMs {
      get { return battleEndTimestampMs_; }
      set {
        battleEndTimestampMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BattleLog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BattleLog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (State != other.State) return false;
      if (BattleType != other.BattleType) return false;
      if (ServerMs != other.ServerMs) return false;
      if(!battleActions_.Equals(other.battleActions_)) return false;
      if (BattleStartTimestampMs != other.BattleStartTimestampMs) return false;
      if (BattleEndTimestampMs != other.BattleEndTimestampMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (State != 0) hash ^= State.GetHashCode();
      if (BattleType != 0) hash ^= BattleType.GetHashCode();
      if (ServerMs != 0L) hash ^= ServerMs.GetHashCode();
      hash ^= battleActions_.GetHashCode();
      if (BattleStartTimestampMs != 0L) hash ^= BattleStartTimestampMs.GetHashCode();
      if (BattleEndTimestampMs != 0L) hash ^= BattleEndTimestampMs.GetHashCode();
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
      if (State != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
      if (BattleType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) BattleType);
      }
      if (ServerMs != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ServerMs);
      }
      battleActions_.WriteTo(output, _repeated_battleActions_codec);
      if (BattleStartTimestampMs != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(BattleStartTimestampMs);
      }
      if (BattleEndTimestampMs != 0L) {
        output.WriteRawTag(48);
        output.WriteInt64(BattleEndTimestampMs);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (BattleType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BattleType);
      }
      if (ServerMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerMs);
      }
      size += battleActions_.CalculateSize(_repeated_battleActions_codec);
      if (BattleStartTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleStartTimestampMs);
      }
      if (BattleEndTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleEndTimestampMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BattleLog other) {
      if (other == null) {
        return;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.BattleType != 0) {
        BattleType = other.BattleType;
      }
      if (other.ServerMs != 0L) {
        ServerMs = other.ServerMs;
      }
      battleActions_.Add(other.battleActions_);
      if (other.BattleStartTimestampMs != 0L) {
        BattleStartTimestampMs = other.BattleStartTimestampMs;
      }
      if (other.BattleEndTimestampMs != 0L) {
        BattleEndTimestampMs = other.BattleEndTimestampMs;
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
          case 8: {
            state_ = (global::POGOProtos.Data.Battle.BattleState) input.ReadEnum();
            break;
          }
          case 16: {
            battleType_ = (global::POGOProtos.Data.Battle.BattleType) input.ReadEnum();
            break;
          }
          case 24: {
            ServerMs = input.ReadInt64();
            break;
          }
          case 34: {
            battleActions_.AddEntriesFrom(input, _repeated_battleActions_codec);
            break;
          }
          case 40: {
            BattleStartTimestampMs = input.ReadInt64();
            break;
          }
          case 48: {
            BattleEndTimestampMs = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
