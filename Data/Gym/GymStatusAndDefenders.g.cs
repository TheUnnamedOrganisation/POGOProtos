// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Gym/GymStatusAndDefenders.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Gym {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Gym/GymStatusAndDefenders.proto</summary>
  public static partial class GymStatusAndDefendersReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Gym/GymStatusAndDefenders.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymStatusAndDefendersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9QT0dPUHJvdG9zL0RhdGEvR3ltL0d5bVN0YXR1c0FuZERlZmVuZGVycy5w",
            "cm90bxITUE9HT1Byb3Rvcy5EYXRhLkd5bRoiUE9HT1Byb3Rvcy9NYXAvRm9y",
            "dC9Gb3J0RGF0YS5wcm90bxolUE9HT1Byb3Rvcy9EYXRhL0d5bS9HeW1EZWZl",
            "bmRlci5wcm90byKKAQoVR3ltU3RhdHVzQW5kRGVmZW5kZXJzEjkKEnBva2Vt",
            "b25fZm9ydF9wcm90bxgBIAEoCzIdLlBPR09Qcm90b3MuTWFwLkZvcnQuRm9y",
            "dERhdGESNgoMZ3ltX2RlZmVuZGVyGAIgAygLMiAuUE9HT1Byb3Rvcy5EYXRh",
            "Lkd5bS5HeW1EZWZlbmRlcmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Map.Fort.FortDataReflection.Descriptor, global::POGOProtos.Data.Gym.GymDefenderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Gym.GymStatusAndDefenders), global::POGOProtos.Data.Gym.GymStatusAndDefenders.Parser, new[]{ "PokemonFortProto", "GymDefender" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GymStatusAndDefenders : pb::IMessage<GymStatusAndDefenders> {
    private static readonly pb::MessageParser<GymStatusAndDefenders> _parser = new pb::MessageParser<GymStatusAndDefenders>(() => new GymStatusAndDefenders());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GymStatusAndDefenders> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Gym.GymStatusAndDefendersReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymStatusAndDefenders() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymStatusAndDefenders(GymStatusAndDefenders other) : this() {
      PokemonFortProto = other.pokemonFortProto_ != null ? other.PokemonFortProto.Clone() : null;
      gymDefender_ = other.gymDefender_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymStatusAndDefenders Clone() {
      return new GymStatusAndDefenders(this);
    }

    /// <summary>Field number for the "pokemon_fort_proto" field.</summary>
    public const int PokemonFortProtoFieldNumber = 1;
    private global::POGOProtos.Map.Fort.FortData pokemonFortProto_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Fort.FortData PokemonFortProto {
      get { return pokemonFortProto_; }
      set {
        pokemonFortProto_ = value;
      }
    }

    /// <summary>Field number for the "gym_defender" field.</summary>
    public const int GymDefenderFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Gym.GymDefender> _repeated_gymDefender_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Data.Gym.GymDefender.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Gym.GymDefender> gymDefender_ = new pbc::RepeatedField<global::POGOProtos.Data.Gym.GymDefender>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Gym.GymDefender> GymDefender {
      get { return gymDefender_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GymStatusAndDefenders);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GymStatusAndDefenders other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PokemonFortProto, other.PokemonFortProto)) return false;
      if(!gymDefender_.Equals(other.gymDefender_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pokemonFortProto_ != null) hash ^= PokemonFortProto.GetHashCode();
      hash ^= gymDefender_.GetHashCode();
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
      if (pokemonFortProto_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PokemonFortProto);
      }
      gymDefender_.WriteTo(output, _repeated_gymDefender_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pokemonFortProto_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonFortProto);
      }
      size += gymDefender_.CalculateSize(_repeated_gymDefender_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GymStatusAndDefenders other) {
      if (other == null) {
        return;
      }
      if (other.pokemonFortProto_ != null) {
        if (pokemonFortProto_ == null) {
          pokemonFortProto_ = new global::POGOProtos.Map.Fort.FortData();
        }
        PokemonFortProto.MergeFrom(other.PokemonFortProto);
      }
      gymDefender_.Add(other.gymDefender_);
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
            if (pokemonFortProto_ == null) {
              pokemonFortProto_ = new global::POGOProtos.Map.Fort.FortData();
            }
            input.ReadMessage(pokemonFortProto_);
            break;
          }
          case 18: {
            gymDefender_.AddEntriesFrom(input, _repeated_gymDefender_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
