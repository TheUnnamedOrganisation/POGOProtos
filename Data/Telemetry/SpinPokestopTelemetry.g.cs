// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Telemetry/SpinPokestopTelemetry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Telemetry {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Telemetry/SpinPokestopTelemetry.proto</summary>
  public static partial class SpinPokestopTelemetryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Telemetry/SpinPokestopTelemetry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpinPokestopTelemetryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVQT0dPUHJvdG9zL0RhdGEvVGVsZW1ldHJ5L1NwaW5Qb2tlc3RvcFRlbGVt",
            "ZXRyeS5wcm90bxIZUE9HT1Byb3Rvcy5EYXRhLlRlbGVtZXRyeRokUE9HT1By",
            "b3Rvcy9EYXRhL1Bva2VzdG9wUmV3YXJkLnByb3RvIp0BChVTcGluUG9rZXN0",
            "b3BUZWxlbWV0cnkSDgoGcmVzdWx0GAEgASgJEg8KB2ZvcnRfaWQYAiABKAkS",
            "EQoJZm9ydF90eXBlGAMgASgFEjkKEHBva2VzdG9wX3Jld2FyZHMYBCADKAsy",
            "Hy5QT0dPUHJvdG9zLkRhdGEuUG9rZXN0b3BSZXdhcmQSFQoNdG90YWxfcmV3",
            "YXJkcxgFIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokestopRewardReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Telemetry.SpinPokestopTelemetry), global::POGOProtos.Data.Telemetry.SpinPokestopTelemetry.Parser, new[]{ "Result", "FortId", "FortType", "PokestopRewards", "TotalRewards" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SpinPokestopTelemetry : pb::IMessage<SpinPokestopTelemetry> {
    private static readonly pb::MessageParser<SpinPokestopTelemetry> _parser = new pb::MessageParser<SpinPokestopTelemetry>(() => new SpinPokestopTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SpinPokestopTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Telemetry.SpinPokestopTelemetryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpinPokestopTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpinPokestopTelemetry(SpinPokestopTelemetry other) : this() {
      result_ = other.result_;
      fortId_ = other.fortId_;
      fortType_ = other.fortType_;
      pokestopRewards_ = other.pokestopRewards_.Clone();
      totalRewards_ = other.totalRewards_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpinPokestopTelemetry Clone() {
      return new SpinPokestopTelemetry(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private string result_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fort_id" field.</summary>
    public const int FortIdFieldNumber = 2;
    private string fortId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortId {
      get { return fortId_; }
      set {
        fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fort_type" field.</summary>
    public const int FortTypeFieldNumber = 3;
    private int fortType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FortType {
      get { return fortType_; }
      set {
        fortType_ = value;
      }
    }

    /// <summary>Field number for the "pokestop_rewards" field.</summary>
    public const int PokestopRewardsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.PokestopReward> _repeated_pokestopRewards_codec
        = pb::FieldCodec.ForMessage(34, global::POGOProtos.Data.PokestopReward.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.PokestopReward> pokestopRewards_ = new pbc::RepeatedField<global::POGOProtos.Data.PokestopReward>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.PokestopReward> PokestopRewards {
      get { return pokestopRewards_; }
    }

    /// <summary>Field number for the "total_rewards" field.</summary>
    public const int TotalRewardsFieldNumber = 5;
    private int totalRewards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TotalRewards {
      get { return totalRewards_; }
      set {
        totalRewards_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SpinPokestopTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SpinPokestopTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (FortId != other.FortId) return false;
      if (FortType != other.FortType) return false;
      if(!pokestopRewards_.Equals(other.pokestopRewards_)) return false;
      if (TotalRewards != other.TotalRewards) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result.Length != 0) hash ^= Result.GetHashCode();
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
      if (FortType != 0) hash ^= FortType.GetHashCode();
      hash ^= pokestopRewards_.GetHashCode();
      if (TotalRewards != 0) hash ^= TotalRewards.GetHashCode();
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
      if (Result.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Result);
      }
      if (FortId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FortId);
      }
      if (FortType != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(FortType);
      }
      pokestopRewards_.WriteTo(output, _repeated_pokestopRewards_codec);
      if (TotalRewards != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(TotalRewards);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (FortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      if (FortType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FortType);
      }
      size += pokestopRewards_.CalculateSize(_repeated_pokestopRewards_codec);
      if (TotalRewards != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalRewards);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SpinPokestopTelemetry other) {
      if (other == null) {
        return;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
      }
      if (other.FortType != 0) {
        FortType = other.FortType;
      }
      pokestopRewards_.Add(other.pokestopRewards_);
      if (other.TotalRewards != 0) {
        TotalRewards = other.TotalRewards;
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
            Result = input.ReadString();
            break;
          }
          case 18: {
            FortId = input.ReadString();
            break;
          }
          case 24: {
            FortType = input.ReadInt32();
            break;
          }
          case 34: {
            pokestopRewards_.AddEntriesFrom(input, _repeated_pokestopRewards_codec);
            break;
          }
          case 40: {
            TotalRewards = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
