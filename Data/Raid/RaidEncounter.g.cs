// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Raid/RaidEncounter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Raid {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Raid/RaidEncounter.proto</summary>
  public static partial class RaidEncounterReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Raid/RaidEncounter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RaidEncounterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihQT0dPUHJvdG9zL0RhdGEvUmFpZC9SYWlkRW5jb3VudGVyLnByb3RvEhRQ",
            "T0dPUHJvdG9zLkRhdGEuUmFpZBohUE9HT1Byb3Rvcy9EYXRhL1Bva2Vtb25E",
            "YXRhLnByb3RvGjBQT0dPUHJvdG9zL0RhdGEvQ2FwdHVyZS9DYXB0dXJlUHJv",
            "YmFiaWxpdHkucHJvdG8aIFBPR09Qcm90b3MvRW51bXMvUmFpZExldmVsLnBy",
            "b3RvIpMCCg1SYWlkRW5jb3VudGVyEi0KB3Bva2Vtb24YASABKAsyHC5QT0dP",
            "UHJvdG9zLkRhdGEuUG9rZW1vbkRhdGESFAoMZW5jb3VudGVyX2lkGAIgASgD",
            "EhUKDXNwYXducG9pbnRfaWQYAyABKAkSSgoVY2FwdHVyZV9wcm9iYWJpbGl0",
            "aWVzGAQgASgLMisuUE9HT1Byb3Rvcy5EYXRhLkNhcHR1cmUuQ2FwdHVyZVBy",
            "b2JhYmlsaXR5EhgKEHRocm93c19yZW1haW5pbmcYBSABKAUSLwoKcmFpZF9s",
            "ZXZlbBgGIAEoDjIbLlBPR09Qcm90b3MuRW51bXMuUmFpZExldmVsEg8KB2Zv",
            "cnRfaWQYByABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Data.Capture.CaptureProbabilityReflection.Descriptor, global::POGOProtos.Enums.RaidLevelReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Raid.RaidEncounter), global::POGOProtos.Data.Raid.RaidEncounter.Parser, new[]{ "Pokemon", "EncounterId", "SpawnpointId", "CaptureProbabilities", "ThrowsRemaining", "RaidLevel", "FortId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RaidEncounter : pb::IMessage<RaidEncounter> {
    private static readonly pb::MessageParser<RaidEncounter> _parser = new pb::MessageParser<RaidEncounter>(() => new RaidEncounter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RaidEncounter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Raid.RaidEncounterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidEncounter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidEncounter(RaidEncounter other) : this() {
      Pokemon = other.pokemon_ != null ? other.Pokemon.Clone() : null;
      encounterId_ = other.encounterId_;
      spawnpointId_ = other.spawnpointId_;
      CaptureProbabilities = other.captureProbabilities_ != null ? other.CaptureProbabilities.Clone() : null;
      throwsRemaining_ = other.throwsRemaining_;
      raidLevel_ = other.raidLevel_;
      fortId_ = other.fortId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RaidEncounter Clone() {
      return new RaidEncounter(this);
    }

    /// <summary>Field number for the "pokemon" field.</summary>
    public const int PokemonFieldNumber = 1;
    private global::POGOProtos.Data.PokemonData pokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonData Pokemon {
      get { return pokemon_; }
      set {
        pokemon_ = value;
      }
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 2;
    private long encounterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "spawnpoint_id" field.</summary>
    public const int SpawnpointIdFieldNumber = 3;
    private string spawnpointId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SpawnpointId {
      get { return spawnpointId_; }
      set {
        spawnpointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "capture_probabilities" field.</summary>
    public const int CaptureProbabilitiesFieldNumber = 4;
    private global::POGOProtos.Data.Capture.CaptureProbability captureProbabilities_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Capture.CaptureProbability CaptureProbabilities {
      get { return captureProbabilities_; }
      set {
        captureProbabilities_ = value;
      }
    }

    /// <summary>Field number for the "throws_remaining" field.</summary>
    public const int ThrowsRemainingFieldNumber = 5;
    private int throwsRemaining_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ThrowsRemaining {
      get { return throwsRemaining_; }
      set {
        throwsRemaining_ = value;
      }
    }

    /// <summary>Field number for the "raid_level" field.</summary>
    public const int RaidLevelFieldNumber = 6;
    private global::POGOProtos.Enums.RaidLevel raidLevel_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.RaidLevel RaidLevel {
      get { return raidLevel_; }
      set {
        raidLevel_ = value;
      }
    }

    /// <summary>Field number for the "fort_id" field.</summary>
    public const int FortIdFieldNumber = 7;
    private string fortId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortId {
      get { return fortId_; }
      set {
        fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RaidEncounter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RaidEncounter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Pokemon, other.Pokemon)) return false;
      if (EncounterId != other.EncounterId) return false;
      if (SpawnpointId != other.SpawnpointId) return false;
      if (!object.Equals(CaptureProbabilities, other.CaptureProbabilities)) return false;
      if (ThrowsRemaining != other.ThrowsRemaining) return false;
      if (RaidLevel != other.RaidLevel) return false;
      if (FortId != other.FortId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pokemon_ != null) hash ^= Pokemon.GetHashCode();
      if (EncounterId != 0L) hash ^= EncounterId.GetHashCode();
      if (SpawnpointId.Length != 0) hash ^= SpawnpointId.GetHashCode();
      if (captureProbabilities_ != null) hash ^= CaptureProbabilities.GetHashCode();
      if (ThrowsRemaining != 0) hash ^= ThrowsRemaining.GetHashCode();
      if (RaidLevel != 0) hash ^= RaidLevel.GetHashCode();
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
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
      if (pokemon_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Pokemon);
      }
      if (EncounterId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(EncounterId);
      }
      if (SpawnpointId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SpawnpointId);
      }
      if (captureProbabilities_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CaptureProbabilities);
      }
      if (ThrowsRemaining != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(ThrowsRemaining);
      }
      if (RaidLevel != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) RaidLevel);
      }
      if (FortId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(FortId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Pokemon);
      }
      if (EncounterId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EncounterId);
      }
      if (SpawnpointId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnpointId);
      }
      if (captureProbabilities_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CaptureProbabilities);
      }
      if (ThrowsRemaining != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ThrowsRemaining);
      }
      if (RaidLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) RaidLevel);
      }
      if (FortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RaidEncounter other) {
      if (other == null) {
        return;
      }
      if (other.pokemon_ != null) {
        if (pokemon_ == null) {
          pokemon_ = new global::POGOProtos.Data.PokemonData();
        }
        Pokemon.MergeFrom(other.Pokemon);
      }
      if (other.EncounterId != 0L) {
        EncounterId = other.EncounterId;
      }
      if (other.SpawnpointId.Length != 0) {
        SpawnpointId = other.SpawnpointId;
      }
      if (other.captureProbabilities_ != null) {
        if (captureProbabilities_ == null) {
          captureProbabilities_ = new global::POGOProtos.Data.Capture.CaptureProbability();
        }
        CaptureProbabilities.MergeFrom(other.CaptureProbabilities);
      }
      if (other.ThrowsRemaining != 0) {
        ThrowsRemaining = other.ThrowsRemaining;
      }
      if (other.RaidLevel != 0) {
        RaidLevel = other.RaidLevel;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
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
            if (pokemon_ == null) {
              pokemon_ = new global::POGOProtos.Data.PokemonData();
            }
            input.ReadMessage(pokemon_);
            break;
          }
          case 16: {
            EncounterId = input.ReadInt64();
            break;
          }
          case 26: {
            SpawnpointId = input.ReadString();
            break;
          }
          case 34: {
            if (captureProbabilities_ == null) {
              captureProbabilities_ = new global::POGOProtos.Data.Capture.CaptureProbability();
            }
            input.ReadMessage(captureProbabilities_);
            break;
          }
          case 40: {
            ThrowsRemaining = input.ReadInt32();
            break;
          }
          case 48: {
            raidLevel_ = (global::POGOProtos.Enums.RaidLevel) input.ReadEnum();
            break;
          }
          case 58: {
            FortId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
