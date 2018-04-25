// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Quests/QuestPokemonEncounter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Quests {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Quests/QuestPokemonEncounter.proto</summary>
  public static partial class QuestPokemonEncounterReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Quests/QuestPokemonEncounter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestPokemonEncounterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL1F1ZXN0UG9rZW1vbkVuY291bnRl",
            "ci5wcm90bxIWUE9HT1Byb3Rvcy5EYXRhLlF1ZXN0cxokUE9HT1Byb3Rvcy9F",
            "bnVtcy9FbmNvdW50ZXJUeXBlLnByb3RvGiBQT0dPUHJvdG9zL0VudW1zL1Bv",
            "a2Vtb25JZC5wcm90byKQAQoVUXVlc3RQb2tlbW9uRW5jb3VudGVyEhAKCHF1",
            "ZXN0X2lkGAEgASgJEiwKB3Bva2Vtb24YAiABKA4yGy5QT0dPUHJvdG9zLkVu",
            "dW1zLlBva2Vtb25JZBI3Cg5lbmNvdW50ZXJfdHlwZRgDIAEoDjIfLlBPR09Q",
            "cm90b3MuRW51bXMuRW5jb3VudGVyVHlwZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.EncounterTypeReflection.Descriptor, global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.QuestPokemonEncounter), global::POGOProtos.Data.Quests.QuestPokemonEncounter.Parser, new[]{ "QuestId", "Pokemon", "EncounterType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QuestPokemonEncounter : pb::IMessage<QuestPokemonEncounter> {
    private static readonly pb::MessageParser<QuestPokemonEncounter> _parser = new pb::MessageParser<QuestPokemonEncounter>(() => new QuestPokemonEncounter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QuestPokemonEncounter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Quests.QuestPokemonEncounterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestPokemonEncounter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestPokemonEncounter(QuestPokemonEncounter other) : this() {
      questId_ = other.questId_;
      pokemon_ = other.pokemon_;
      encounterType_ = other.encounterType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestPokemonEncounter Clone() {
      return new QuestPokemonEncounter(this);
    }

    /// <summary>Field number for the "quest_id" field.</summary>
    public const int QuestIdFieldNumber = 1;
    private string questId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string QuestId {
      get { return questId_; }
      set {
        questId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pokemon" field.</summary>
    public const int PokemonFieldNumber = 2;
    private global::POGOProtos.Enums.PokemonId pokemon_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId Pokemon {
      get { return pokemon_; }
      set {
        pokemon_ = value;
      }
    }

    /// <summary>Field number for the "encounter_type" field.</summary>
    public const int EncounterTypeFieldNumber = 3;
    private global::POGOProtos.Enums.EncounterType encounterType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.EncounterType EncounterType {
      get { return encounterType_; }
      set {
        encounterType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QuestPokemonEncounter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QuestPokemonEncounter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestId != other.QuestId) return false;
      if (Pokemon != other.Pokemon) return false;
      if (EncounterType != other.EncounterType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestId.Length != 0) hash ^= QuestId.GetHashCode();
      if (Pokemon != 0) hash ^= Pokemon.GetHashCode();
      if (EncounterType != 0) hash ^= EncounterType.GetHashCode();
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
      if (QuestId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(QuestId);
      }
      if (Pokemon != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Pokemon);
      }
      if (EncounterType != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) EncounterType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (QuestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QuestId);
      }
      if (Pokemon != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Pokemon);
      }
      if (EncounterType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EncounterType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QuestPokemonEncounter other) {
      if (other == null) {
        return;
      }
      if (other.QuestId.Length != 0) {
        QuestId = other.QuestId;
      }
      if (other.Pokemon != 0) {
        Pokemon = other.Pokemon;
      }
      if (other.EncounterType != 0) {
        EncounterType = other.EncounterType;
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
            QuestId = input.ReadString();
            break;
          }
          case 16: {
            pokemon_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 24: {
            encounterType_ = (global::POGOProtos.Enums.EncounterType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code