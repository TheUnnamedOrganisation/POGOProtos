// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Logs/CompleteQuestStampCardLogEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Logs {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/CompleteQuestStampCardLogEntry.proto</summary>
  public static partial class CompleteQuestStampCardLogEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Logs/CompleteQuestStampCardLogEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompleteQuestStampCardLogEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlQT0dPUHJvdG9zL0RhdGEvTG9ncy9Db21wbGV0ZVF1ZXN0U3RhbXBDYXJk",
            "TG9nRW50cnkucHJvdG8SFFBPR09Qcm90b3MuRGF0YS5Mb2dzGihQT0dPUHJv",
            "dG9zL0RhdGEvUXVlc3RzL1F1ZXN0UmV3YXJkLnByb3RvIsQBCh5Db21wbGV0",
            "ZVF1ZXN0U3RhbXBDYXJkTG9nRW50cnkSSwoGcmVzdWx0GAEgASgOMjsuUE9H",
            "T1Byb3Rvcy5EYXRhLkxvZ3MuQ29tcGxldGVRdWVzdFN0YW1wQ2FyZExvZ0Vu",
            "dHJ5LlJlc3VsdBIzCgZyZXdhcmQYAiADKAsyIy5QT0dPUHJvdG9zLkRhdGEu",
            "UXVlc3RzLlF1ZXN0UmV3YXJkIiAKBlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NV",
            "Q0NFU1MQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Quests.QuestRewardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Logs.CompleteQuestStampCardLogEntry), global::POGOProtos.Data.Logs.CompleteQuestStampCardLogEntry.Parser, new[]{ "Result", "Reward" }, null, new[]{ typeof(global::POGOProtos.Data.Logs.CompleteQuestStampCardLogEntry.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CompleteQuestStampCardLogEntry : pb::IMessage<CompleteQuestStampCardLogEntry> {
    private static readonly pb::MessageParser<CompleteQuestStampCardLogEntry> _parser = new pb::MessageParser<CompleteQuestStampCardLogEntry>(() => new CompleteQuestStampCardLogEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompleteQuestStampCardLogEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Logs.CompleteQuestStampCardLogEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestStampCardLogEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestStampCardLogEntry(CompleteQuestStampCardLogEntry other) : this() {
      result_ = other.result_;
      reward_ = other.reward_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompleteQuestStampCardLogEntry Clone() {
      return new CompleteQuestStampCardLogEntry(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Data.Logs.CompleteQuestStampCardLogEntry.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Logs.CompleteQuestStampCardLogEntry.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "reward" field.</summary>
    public const int RewardFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Quests.QuestReward> _repeated_reward_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Data.Quests.QuestReward.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestReward> reward_ = new pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestReward>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestReward> Reward {
      get { return reward_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompleteQuestStampCardLogEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompleteQuestStampCardLogEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if(!reward_.Equals(other.reward_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      hash ^= reward_.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      reward_.WriteTo(output, _repeated_reward_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      size += reward_.CalculateSize(_repeated_reward_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompleteQuestStampCardLogEntry other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      reward_.Add(other.reward_);
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
            result_ = (global::POGOProtos.Data.Logs.CompleteQuestStampCardLogEntry.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            reward_.AddEntriesFrom(input, _repeated_reward_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CompleteQuestStampCardLogEntry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code