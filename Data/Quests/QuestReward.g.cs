// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Quests/QuestReward.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Quests {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Quests/QuestReward.proto</summary>
  public static partial class QuestRewardReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Quests/QuestReward.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestRewardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihQT0dPUHJvdG9zL0RhdGEvUXVlc3RzL1F1ZXN0UmV3YXJkLnByb3RvEhZQ",
            "T0dPUHJvdG9zLkRhdGEuUXVlc3RzGiRQT0dPUHJvdG9zL0RhdGEvUG9rZW1v",
            "bkRpc3BsYXkucHJvdG8aIFBPR09Qcm90b3MvRW51bXMvUG9rZW1vbklkLnBy",
            "b3RvGiZQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVtL0l0ZW1JZC5wcm90byLT",
            "BgoLUXVlc3RSZXdhcmQSNgoEdHlwZRgBIAEoDjIoLlBPR09Qcm90b3MuRGF0",
            "YS5RdWVzdHMuUXVlc3RSZXdhcmQuVHlwZRILCgNleHAYAiABKAUSPAoEaXRl",
            "bRgDIAEoCzIuLlBPR09Qcm90b3MuRGF0YS5RdWVzdHMuUXVlc3RSZXdhcmQu",
            "SXRlbVJld2FyZBIQCghzdGFyZHVzdBgEIAEoBRJFCgVjYW5keRgFIAEoCzI2",
            "LlBPR09Qcm90b3MuRGF0YS5RdWVzdHMuUXVlc3RSZXdhcmQuUG9rZW1vbkNh",
            "bmR5UmV3YXJkEhoKEmF2YXRhcl90ZW1wbGF0ZV9pZBgGIAEoCRIZChFxdWVz",
            "dF90ZW1wbGF0ZV9pZBgHIAEoCRJVChFwb2tlbW9uX2VuY291bnRlchgIIAEo",
            "CzI6LlBPR09Qcm90b3MuRGF0YS5RdWVzdHMuUXVlc3RSZXdhcmQuUG9rZW1v",
            "bkVuY291bnRlclJld2FyZBpNCgpJdGVtUmV3YXJkEi8KBGl0ZW0YASABKA4y",
            "IS5QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtLkl0ZW1JZBIOCgZhbW91bnQY",
            "AiABKAUaVQoSUG9rZW1vbkNhbmR5UmV3YXJkEi8KCnBva2Vtb25faWQYASAB",
            "KA4yGy5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25JZBIOCgZhbW91bnQYAiAB",
            "KAUatgEKFlBva2Vtb25FbmNvdW50ZXJSZXdhcmQSLwoKcG9rZW1vbl9pZBgB",
            "IAEoDjIbLlBPR09Qcm90b3MuRW51bXMuUG9rZW1vbklkEjEKKXVzZV9xdWVz",
            "dF9wb2tlbW9uX2VuY291bnRlcl9kaXN0cmlidWl0aW9uGAIgASgIEjgKD3Bv",
            "a2Vtb25fZGlzcGxheRgDIAEoCzIfLlBPR09Qcm90b3MuRGF0YS5Qb2tlbW9u",
            "RGlzcGxheSJ7CgRUeXBlEgkKBVVOU0VUEAASDgoKRVhQRVJJRU5DRRABEggK",
            "BElURU0QAhIMCghTVEFSRFVTVBADEgkKBUNBTkRZEAQSEwoPQVZBVEFSX0NM",
            "T1RISU5HEAUSCQoFUVVFU1QQBhIVChFQT0tFTU9OX0VOQ09VTlRFUhAHYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDisplayReflection.Descriptor, global::POGOProtos.Enums.PokemonIdReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.QuestReward), global::POGOProtos.Data.Quests.QuestReward.Parser, new[]{ "Type", "Exp", "Item", "Stardust", "Candy", "AvatarTemplateId", "QuestTemplateId", "PokemonEncounter" }, null, new[]{ typeof(global::POGOProtos.Data.Quests.QuestReward.Types.Type) }, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.QuestReward.Types.ItemReward), global::POGOProtos.Data.Quests.QuestReward.Types.ItemReward.Parser, new[]{ "Item", "Amount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.QuestReward.Types.PokemonCandyReward), global::POGOProtos.Data.Quests.QuestReward.Types.PokemonCandyReward.Parser, new[]{ "PokemonId", "Amount" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Quests.QuestReward.Types.PokemonEncounterReward), global::POGOProtos.Data.Quests.QuestReward.Types.PokemonEncounterReward.Parser, new[]{ "PokemonId", "UseQuestPokemonEncounterDistribuition", "PokemonDisplay" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class QuestReward : pb::IMessage<QuestReward> {
    private static readonly pb::MessageParser<QuestReward> _parser = new pb::MessageParser<QuestReward>(() => new QuestReward());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<QuestReward> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Quests.QuestRewardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestReward() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestReward(QuestReward other) : this() {
      type_ = other.type_;
      exp_ = other.exp_;
      Item = other.item_ != null ? other.Item.Clone() : null;
      stardust_ = other.stardust_;
      Candy = other.candy_ != null ? other.Candy.Clone() : null;
      avatarTemplateId_ = other.avatarTemplateId_;
      questTemplateId_ = other.questTemplateId_;
      PokemonEncounter = other.pokemonEncounter_ != null ? other.PokemonEncounter.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public QuestReward Clone() {
      return new QuestReward(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::POGOProtos.Data.Quests.QuestReward.Types.Type type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.QuestReward.Types.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "exp" field.</summary>
    public const int ExpFieldNumber = 2;
    private int exp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 3;
    private global::POGOProtos.Data.Quests.QuestReward.Types.ItemReward item_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.QuestReward.Types.ItemReward Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }

    /// <summary>Field number for the "stardust" field.</summary>
    public const int StardustFieldNumber = 4;
    private int stardust_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Stardust {
      get { return stardust_; }
      set {
        stardust_ = value;
      }
    }

    /// <summary>Field number for the "candy" field.</summary>
    public const int CandyFieldNumber = 5;
    private global::POGOProtos.Data.Quests.QuestReward.Types.PokemonCandyReward candy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.QuestReward.Types.PokemonCandyReward Candy {
      get { return candy_; }
      set {
        candy_ = value;
      }
    }

    /// <summary>Field number for the "avatar_template_id" field.</summary>
    public const int AvatarTemplateIdFieldNumber = 6;
    private string avatarTemplateId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AvatarTemplateId {
      get { return avatarTemplateId_; }
      set {
        avatarTemplateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "quest_template_id" field.</summary>
    public const int QuestTemplateIdFieldNumber = 7;
    private string questTemplateId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string QuestTemplateId {
      get { return questTemplateId_; }
      set {
        questTemplateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pokemon_encounter" field.</summary>
    public const int PokemonEncounterFieldNumber = 8;
    private global::POGOProtos.Data.Quests.QuestReward.Types.PokemonEncounterReward pokemonEncounter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Quests.QuestReward.Types.PokemonEncounterReward PokemonEncounter {
      get { return pokemonEncounter_; }
      set {
        pokemonEncounter_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as QuestReward);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(QuestReward other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Exp != other.Exp) return false;
      if (!object.Equals(Item, other.Item)) return false;
      if (Stardust != other.Stardust) return false;
      if (!object.Equals(Candy, other.Candy)) return false;
      if (AvatarTemplateId != other.AvatarTemplateId) return false;
      if (QuestTemplateId != other.QuestTemplateId) return false;
      if (!object.Equals(PokemonEncounter, other.PokemonEncounter)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Exp != 0) hash ^= Exp.GetHashCode();
      if (item_ != null) hash ^= Item.GetHashCode();
      if (Stardust != 0) hash ^= Stardust.GetHashCode();
      if (candy_ != null) hash ^= Candy.GetHashCode();
      if (AvatarTemplateId.Length != 0) hash ^= AvatarTemplateId.GetHashCode();
      if (QuestTemplateId.Length != 0) hash ^= QuestTemplateId.GetHashCode();
      if (pokemonEncounter_ != null) hash ^= PokemonEncounter.GetHashCode();
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
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Exp != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Exp);
      }
      if (item_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Item);
      }
      if (Stardust != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Stardust);
      }
      if (candy_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Candy);
      }
      if (AvatarTemplateId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(AvatarTemplateId);
      }
      if (QuestTemplateId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(QuestTemplateId);
      }
      if (pokemonEncounter_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PokemonEncounter);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Exp);
      }
      if (item_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
      }
      if (Stardust != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Stardust);
      }
      if (candy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Candy);
      }
      if (AvatarTemplateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AvatarTemplateId);
      }
      if (QuestTemplateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(QuestTemplateId);
      }
      if (pokemonEncounter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonEncounter);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(QuestReward other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Exp != 0) {
        Exp = other.Exp;
      }
      if (other.item_ != null) {
        if (item_ == null) {
          item_ = new global::POGOProtos.Data.Quests.QuestReward.Types.ItemReward();
        }
        Item.MergeFrom(other.Item);
      }
      if (other.Stardust != 0) {
        Stardust = other.Stardust;
      }
      if (other.candy_ != null) {
        if (candy_ == null) {
          candy_ = new global::POGOProtos.Data.Quests.QuestReward.Types.PokemonCandyReward();
        }
        Candy.MergeFrom(other.Candy);
      }
      if (other.AvatarTemplateId.Length != 0) {
        AvatarTemplateId = other.AvatarTemplateId;
      }
      if (other.QuestTemplateId.Length != 0) {
        QuestTemplateId = other.QuestTemplateId;
      }
      if (other.pokemonEncounter_ != null) {
        if (pokemonEncounter_ == null) {
          pokemonEncounter_ = new global::POGOProtos.Data.Quests.QuestReward.Types.PokemonEncounterReward();
        }
        PokemonEncounter.MergeFrom(other.PokemonEncounter);
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
            type_ = (global::POGOProtos.Data.Quests.QuestReward.Types.Type) input.ReadEnum();
            break;
          }
          case 16: {
            Exp = input.ReadInt32();
            break;
          }
          case 26: {
            if (item_ == null) {
              item_ = new global::POGOProtos.Data.Quests.QuestReward.Types.ItemReward();
            }
            input.ReadMessage(item_);
            break;
          }
          case 32: {
            Stardust = input.ReadInt32();
            break;
          }
          case 42: {
            if (candy_ == null) {
              candy_ = new global::POGOProtos.Data.Quests.QuestReward.Types.PokemonCandyReward();
            }
            input.ReadMessage(candy_);
            break;
          }
          case 50: {
            AvatarTemplateId = input.ReadString();
            break;
          }
          case 58: {
            QuestTemplateId = input.ReadString();
            break;
          }
          case 66: {
            if (pokemonEncounter_ == null) {
              pokemonEncounter_ = new global::POGOProtos.Data.Quests.QuestReward.Types.PokemonEncounterReward();
            }
            input.ReadMessage(pokemonEncounter_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the QuestReward message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Type {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("EXPERIENCE")] Experience = 1,
        [pbr::OriginalName("ITEM")] Item = 2,
        [pbr::OriginalName("STARDUST")] Stardust = 3,
        [pbr::OriginalName("CANDY")] Candy = 4,
        [pbr::OriginalName("AVATAR_CLOTHING")] AvatarClothing = 5,
        [pbr::OriginalName("QUEST")] Quest = 6,
        [pbr::OriginalName("POKEMON_ENCOUNTER")] PokemonEncounter = 7,
      }

      public sealed partial class ItemReward : pb::IMessage<ItemReward> {
        private static readonly pb::MessageParser<ItemReward> _parser = new pb::MessageParser<ItemReward>(() => new ItemReward());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ItemReward> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Data.Quests.QuestReward.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ItemReward() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ItemReward(ItemReward other) : this() {
          item_ = other.item_;
          amount_ = other.amount_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ItemReward Clone() {
          return new ItemReward(this);
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

        /// <summary>Field number for the "amount" field.</summary>
        public const int AmountFieldNumber = 2;
        private int amount_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Amount {
          get { return amount_; }
          set {
            amount_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as ItemReward);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ItemReward other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Item != other.Item) return false;
          if (Amount != other.Amount) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Item != 0) hash ^= Item.GetHashCode();
          if (Amount != 0) hash ^= Amount.GetHashCode();
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
          if (Amount != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Amount);
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
          if (Amount != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ItemReward other) {
          if (other == null) {
            return;
          }
          if (other.Item != 0) {
            Item = other.Item;
          }
          if (other.Amount != 0) {
            Amount = other.Amount;
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
                Amount = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

      public sealed partial class PokemonCandyReward : pb::IMessage<PokemonCandyReward> {
        private static readonly pb::MessageParser<PokemonCandyReward> _parser = new pb::MessageParser<PokemonCandyReward>(() => new PokemonCandyReward());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PokemonCandyReward> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Data.Quests.QuestReward.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PokemonCandyReward() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PokemonCandyReward(PokemonCandyReward other) : this() {
          pokemonId_ = other.pokemonId_;
          amount_ = other.amount_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PokemonCandyReward Clone() {
          return new PokemonCandyReward(this);
        }

        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 1;
        private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Enums.PokemonId PokemonId {
          get { return pokemonId_; }
          set {
            pokemonId_ = value;
          }
        }

        /// <summary>Field number for the "amount" field.</summary>
        public const int AmountFieldNumber = 2;
        private int amount_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int Amount {
          get { return amount_; }
          set {
            amount_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PokemonCandyReward);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PokemonCandyReward other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (PokemonId != other.PokemonId) return false;
          if (Amount != other.Amount) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
          if (Amount != 0) hash ^= Amount.GetHashCode();
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
          if (PokemonId != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) PokemonId);
          }
          if (Amount != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(Amount);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (PokemonId != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
          }
          if (Amount != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PokemonCandyReward other) {
          if (other == null) {
            return;
          }
          if (other.PokemonId != 0) {
            PokemonId = other.PokemonId;
          }
          if (other.Amount != 0) {
            Amount = other.Amount;
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
                pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
                break;
              }
              case 16: {
                Amount = input.ReadInt32();
                break;
              }
            }
          }
        }

      }

      public sealed partial class PokemonEncounterReward : pb::IMessage<PokemonEncounterReward> {
        private static readonly pb::MessageParser<PokemonEncounterReward> _parser = new pb::MessageParser<PokemonEncounterReward>(() => new PokemonEncounterReward());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PokemonEncounterReward> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Data.Quests.QuestReward.Descriptor.NestedTypes[2]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PokemonEncounterReward() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PokemonEncounterReward(PokemonEncounterReward other) : this() {
          pokemonId_ = other.pokemonId_;
          useQuestPokemonEncounterDistribuition_ = other.useQuestPokemonEncounterDistribuition_;
          PokemonDisplay = other.pokemonDisplay_ != null ? other.PokemonDisplay.Clone() : null;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PokemonEncounterReward Clone() {
          return new PokemonEncounterReward(this);
        }

        /// <summary>Field number for the "pokemon_id" field.</summary>
        public const int PokemonIdFieldNumber = 1;
        private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Enums.PokemonId PokemonId {
          get { return pokemonId_; }
          set {
            pokemonId_ = value;
          }
        }

        /// <summary>Field number for the "use_quest_pokemon_encounter_distribuition" field.</summary>
        public const int UseQuestPokemonEncounterDistribuitionFieldNumber = 2;
        private bool useQuestPokemonEncounterDistribuition_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool UseQuestPokemonEncounterDistribuition {
          get { return useQuestPokemonEncounterDistribuition_; }
          set {
            useQuestPokemonEncounterDistribuition_ = value;
          }
        }

        /// <summary>Field number for the "pokemon_display" field.</summary>
        public const int PokemonDisplayFieldNumber = 3;
        private global::POGOProtos.Data.PokemonDisplay pokemonDisplay_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::POGOProtos.Data.PokemonDisplay PokemonDisplay {
          get { return pokemonDisplay_; }
          set {
            pokemonDisplay_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PokemonEncounterReward);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PokemonEncounterReward other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (PokemonId != other.PokemonId) return false;
          if (UseQuestPokemonEncounterDistribuition != other.UseQuestPokemonEncounterDistribuition) return false;
          if (!object.Equals(PokemonDisplay, other.PokemonDisplay)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
          if (UseQuestPokemonEncounterDistribuition != false) hash ^= UseQuestPokemonEncounterDistribuition.GetHashCode();
          if (pokemonDisplay_ != null) hash ^= PokemonDisplay.GetHashCode();
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
          if (PokemonId != 0) {
            output.WriteRawTag(8);
            output.WriteEnum((int) PokemonId);
          }
          if (UseQuestPokemonEncounterDistribuition != false) {
            output.WriteRawTag(16);
            output.WriteBool(UseQuestPokemonEncounterDistribuition);
          }
          if (pokemonDisplay_ != null) {
            output.WriteRawTag(26);
            output.WriteMessage(PokemonDisplay);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (PokemonId != 0) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
          }
          if (UseQuestPokemonEncounterDistribuition != false) {
            size += 1 + 1;
          }
          if (pokemonDisplay_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonDisplay);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PokemonEncounterReward other) {
          if (other == null) {
            return;
          }
          if (other.PokemonId != 0) {
            PokemonId = other.PokemonId;
          }
          if (other.UseQuestPokemonEncounterDistribuition != false) {
            UseQuestPokemonEncounterDistribuition = other.UseQuestPokemonEncounterDistribuition;
          }
          if (other.pokemonDisplay_ != null) {
            if (pokemonDisplay_ == null) {
              pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
            }
            PokemonDisplay.MergeFrom(other.PokemonDisplay);
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
                pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
                break;
              }
              case 16: {
                UseQuestPokemonEncounterDistribuition = input.ReadBool();
                break;
              }
              case 26: {
                if (pokemonDisplay_ == null) {
                  pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
                }
                input.ReadMessage(pokemonDisplay_);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
