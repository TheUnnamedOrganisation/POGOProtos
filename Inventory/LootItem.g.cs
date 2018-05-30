// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Inventory/LootItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from POGOProtos/Inventory/LootItem.proto</summary>
  public static partial class LootItemReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Inventory/LootItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LootItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQT0dPUHJvdG9zL0ludmVudG9yeS9Mb290SXRlbS5wcm90bxIUUE9HT1By",
            "b3Rvcy5JbnZlbnRvcnkaJlBPR09Qcm90b3MvSW52ZW50b3J5L0l0ZW0vSXRl",
            "bUlkLnByb3RvGiBQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25JZC5wcm90bxoh",
            "UE9HT1Byb3Rvcy9EYXRhL1Bva2Vtb25EYXRhLnByb3RvIukBCghMb290SXRl",
            "bRIvCgRpdGVtGAEgASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5J",
            "dGVtSWQSEAoIc3RhcmR1c3QYAiABKAgSEAoIcG9rZWNvaW4YAyABKAgSMgoN",
            "cG9rZW1vbl9jYW5keRgEIAEoDjIbLlBPR09Qcm90b3MuRW51bXMuUG9rZW1v",
            "bklkEg0KBWNvdW50GAUgASgFEhIKCmV4cGVyaWVuY2UYBiABKAgSMQoLcG9r",
            "ZW1vbl9lZ2cYByABKAsyHC5QT0dPUHJvdG9zLkRhdGEuUG9rZW1vbkRhdGFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, global::POGOProtos.Enums.PokemonIdReflection.Descriptor, global::POGOProtos.Data.PokemonDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.LootItem), global::POGOProtos.Inventory.LootItem.Parser, new[]{ "Item", "Stardust", "Pokecoin", "PokemonCandy", "Count", "Experience", "PokemonEgg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LootItem : pb::IMessage<LootItem> {
    private static readonly pb::MessageParser<LootItem> _parser = new pb::MessageParser<LootItem>(() => new LootItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LootItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.LootItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootItem(LootItem other) : this() {
      item_ = other.item_;
      stardust_ = other.stardust_;
      pokecoin_ = other.pokecoin_;
      pokemonCandy_ = other.pokemonCandy_;
      count_ = other.count_;
      experience_ = other.experience_;
      PokemonEgg = other.pokemonEgg_ != null ? other.PokemonEgg.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LootItem Clone() {
      return new LootItem(this);
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 1;
    private global::POGOProtos.Inventory.Item.ItemId item_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }

    /// <summary>Field number for the "stardust" field.</summary>
    public const int StardustFieldNumber = 2;
    private bool stardust_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Stardust {
      get { return stardust_; }
      set {
        stardust_ = value;
      }
    }

    /// <summary>Field number for the "pokecoin" field.</summary>
    public const int PokecoinFieldNumber = 3;
    private bool pokecoin_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Pokecoin {
      get { return pokecoin_; }
      set {
        pokecoin_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_candy" field.</summary>
    public const int PokemonCandyFieldNumber = 4;
    private global::POGOProtos.Enums.PokemonId pokemonCandy_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId PokemonCandy {
      get { return pokemonCandy_; }
      set {
        pokemonCandy_ = value;
      }
    }

    /// <summary>Field number for the "count" field.</summary>
    public const int CountFieldNumber = 5;
    private int count_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Count {
      get { return count_; }
      set {
        count_ = value;
      }
    }

    /// <summary>Field number for the "experience" field.</summary>
    public const int ExperienceFieldNumber = 6;
    private bool experience_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Experience {
      get { return experience_; }
      set {
        experience_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_egg" field.</summary>
    public const int PokemonEggFieldNumber = 7;
    private global::POGOProtos.Data.PokemonData pokemonEgg_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonData PokemonEgg {
      get { return pokemonEgg_; }
      set {
        pokemonEgg_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LootItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LootItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Item != other.Item) return false;
      if (Stardust != other.Stardust) return false;
      if (Pokecoin != other.Pokecoin) return false;
      if (PokemonCandy != other.PokemonCandy) return false;
      if (Count != other.Count) return false;
      if (Experience != other.Experience) return false;
      if (!object.Equals(PokemonEgg, other.PokemonEgg)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Item != 0) hash ^= Item.GetHashCode();
      if (Stardust != false) hash ^= Stardust.GetHashCode();
      if (Pokecoin != false) hash ^= Pokecoin.GetHashCode();
      if (PokemonCandy != 0) hash ^= PokemonCandy.GetHashCode();
      if (Count != 0) hash ^= Count.GetHashCode();
      if (Experience != false) hash ^= Experience.GetHashCode();
      if (pokemonEgg_ != null) hash ^= PokemonEgg.GetHashCode();
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
      if (Item != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Item);
      }
      if (Stardust != false) {
        output.WriteRawTag(16);
        output.WriteBool(Stardust);
      }
      if (Pokecoin != false) {
        output.WriteRawTag(24);
        output.WriteBool(Pokecoin);
      }
      if (PokemonCandy != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) PokemonCandy);
      }
      if (Count != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Count);
      }
      if (Experience != false) {
        output.WriteRawTag(48);
        output.WriteBool(Experience);
      }
      if (pokemonEgg_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(PokemonEgg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Item != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Item);
      }
      if (Stardust != false) {
        size += 1 + 1;
      }
      if (Pokecoin != false) {
        size += 1 + 1;
      }
      if (PokemonCandy != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonCandy);
      }
      if (Count != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
      }
      if (Experience != false) {
        size += 1 + 1;
      }
      if (pokemonEgg_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonEgg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LootItem other) {
      if (other == null) {
        return;
      }
      if (other.Item != 0) {
        Item = other.Item;
      }
      if (other.Stardust != false) {
        Stardust = other.Stardust;
      }
      if (other.Pokecoin != false) {
        Pokecoin = other.Pokecoin;
      }
      if (other.PokemonCandy != 0) {
        PokemonCandy = other.PokemonCandy;
      }
      if (other.Count != 0) {
        Count = other.Count;
      }
      if (other.Experience != false) {
        Experience = other.Experience;
      }
      if (other.pokemonEgg_ != null) {
        if (pokemonEgg_ == null) {
          pokemonEgg_ = new global::POGOProtos.Data.PokemonData();
        }
        PokemonEgg.MergeFrom(other.PokemonEgg);
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
            item_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 16: {
            Stardust = input.ReadBool();
            break;
          }
          case 24: {
            Pokecoin = input.ReadBool();
            break;
          }
          case 32: {
            pokemonCandy_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 40: {
            Count = input.ReadInt32();
            break;
          }
          case 48: {
            Experience = input.ReadBool();
            break;
          }
          case 58: {
            if (pokemonEgg_ == null) {
              pokemonEgg_ = new global::POGOProtos.Data.PokemonData();
            }
            input.ReadMessage(pokemonEgg_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
