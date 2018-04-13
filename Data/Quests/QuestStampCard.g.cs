// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Quests/QuestStampCard.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Quests {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Quests/QuestStampCard.proto</summary>
  public static partial class QuestStampCardReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Quests/QuestStampCard.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestStampCardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL1F1ZXN0U3RhbXBDYXJkLnByb3Rv",
            "EhZQT0dPUHJvdG9zLkRhdGEuUXVlc3RzGidQT0dPUHJvdG9zL0RhdGEvUXVl",
            "c3RzL1F1ZXN0U3RhbXAucHJvdG8ifwoOUXVlc3RTdGFtcENhcmQSMQoFc3Rh",
            "bXAYASADKAsyIi5QT0dPUHJvdG9zLkRhdGEuUXVlc3RzLlF1ZXN0U3RhbXAS",
            "DgoGdGFyZ2V0GAIgASgFEh4KFnJlbWFpbmluZ19kYWlseV9zdGFtcHMYAyAB",
            "KAUSCgoCaWQYBCABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Quests.QuestStampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.QuestStampCard), global::POGOProtos.Data.Quests.QuestStampCard.Parser, new[]{ "Stamp", "Target", "RemainingDailyStamps", "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QuestStampCard : pb::IMessage<QuestStampCard> {
    private static readonly pb::MessageParser<QuestStampCard> _parser = new pb::MessageParser<QuestStampCard>(() => new QuestStampCard());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QuestStampCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Quests.QuestStampCardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestStampCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestStampCard(QuestStampCard other) : this() {
      stamp_ = other.stamp_.Clone();
      target_ = other.target_;
      remainingDailyStamps_ = other.remainingDailyStamps_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestStampCard Clone() {
      return new QuestStampCard(this);
    }

    /// <summary>Field number for the "stamp" field.</summary>
    public const int StampFieldNumber = 1;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Quests.QuestStamp> _repeated_stamp_codec
        = pb::FieldCodec.ForMessage(10, global::POGOProtos.Data.Quests.QuestStamp.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestStamp> stamp_ = new pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestStamp>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Quests.QuestStamp> Stamp {
      get { return stamp_; }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 2;
    private int target_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Target {
      get { return target_; }
      set {
        target_ = value;
      }
    }

    /// <summary>Field number for the "remaining_daily_stamps" field.</summary>
    public const int RemainingDailyStampsFieldNumber = 3;
    private int remainingDailyStamps_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RemainingDailyStamps {
      get { return remainingDailyStamps_; }
      set {
        remainingDailyStamps_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 4;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QuestStampCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QuestStampCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!stamp_.Equals(other.stamp_)) return false;
      if (Target != other.Target) return false;
      if (RemainingDailyStamps != other.RemainingDailyStamps) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= stamp_.GetHashCode();
      if (Target != 0) hash ^= Target.GetHashCode();
      if (RemainingDailyStamps != 0) hash ^= RemainingDailyStamps.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
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
      stamp_.WriteTo(output, _repeated_stamp_codec);
      if (Target != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Target);
      }
      if (RemainingDailyStamps != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(RemainingDailyStamps);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += stamp_.CalculateSize(_repeated_stamp_codec);
      if (Target != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Target);
      }
      if (RemainingDailyStamps != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RemainingDailyStamps);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QuestStampCard other) {
      if (other == null) {
        return;
      }
      stamp_.Add(other.stamp_);
      if (other.Target != 0) {
        Target = other.Target;
      }
      if (other.RemainingDailyStamps != 0) {
        RemainingDailyStamps = other.RemainingDailyStamps;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
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
            stamp_.AddEntriesFrom(input, _repeated_stamp_codec);
            break;
          }
          case 16: {
            Target = input.ReadInt32();
            break;
          }
          case 24: {
            RemainingDailyStamps = input.ReadInt32();
            break;
          }
          case 34: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
