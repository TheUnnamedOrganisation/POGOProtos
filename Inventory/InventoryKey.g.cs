// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Inventory/InventoryKey.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryKey.proto</summary>
  public static partial class InventoryKeyReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Inventory/InventoryKey.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InventoryKeyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlLZXkucHJvdG8SFFBP",
            "R09Qcm90b3MuSW52ZW50b3J5GiBQT0dPUHJvdG9zL0VudW1zL1F1ZXN0VHlw",
            "ZS5wcm90bxomUE9HT1Byb3Rvcy9FbnVtcy9Qb2tlbW9uRmFtaWx5SWQucHJv",
            "dG8aJlBPR09Qcm90b3MvSW52ZW50b3J5L0l0ZW0vSXRlbUlkLnByb3RvIq8D",
            "CgxJbnZlbnRvcnlLZXkSEgoKcG9rZW1vbl9pZBgBIAEoBhIvCgRpdGVtGAIg",
            "ASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVtSWQSGAoQcG9r",
            "ZWRleF9lbnRyeV9pZBgDIAEoBRIUCgxwbGF5ZXJfc3RhdHMYBCABKAgSFwoP",
            "cGxheWVyX2N1cnJlbmN5GAUgASgIEhUKDXBsYXllcl9jYW1lcmEYBiABKAgS",
            "GgoSaW52ZW50b3J5X3VwZ3JhZGVzGAcgASgIEhUKDWFwcGxpZWRfaXRlbXMY",
            "CCABKAgSFgoOZWdnX2luY3ViYXRvcnMYCSABKAgSPAoRcG9rZW1vbl9mYW1p",
            "bHlfaWQYCiABKA4yIS5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25GYW1pbHlJ",
            "ZBIvCgpxdWVzdF90eXBlGAsgASgOMhsuUE9HT1Byb3Rvcy5FbnVtcy5RdWVz",
            "dFR5cGUSGgoSYXZhdGFyX3RlbXBsYXRlX2lkGAwgASgJEhQKDHJhaWRfdGlj",
            "a2V0cxgNIAEoCBIOCgZxdWVzdHMYDiABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.QuestTypeReflection.Descriptor, global::POGOProtos.Enums.PokemonFamilyIdReflection.Descriptor, global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.InventoryKey), global::POGOProtos.Inventory.InventoryKey.Parser, new[]{ "PokemonId", "Item", "PokedexEntryId", "PlayerStats", "PlayerCurrency", "PlayerCamera", "InventoryUpgrades", "AppliedItems", "EggIncubators", "PokemonFamilyId", "QuestType", "AvatarTemplateId", "RaidTickets", "Quests" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InventoryKey : pb::IMessage<InventoryKey> {
    private static readonly pb::MessageParser<InventoryKey> _parser = new pb::MessageParser<InventoryKey>(() => new InventoryKey());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InventoryKey> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.InventoryKeyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryKey() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryKey(InventoryKey other) : this() {
      pokemonId_ = other.pokemonId_;
      item_ = other.item_;
      pokedexEntryId_ = other.pokedexEntryId_;
      playerStats_ = other.playerStats_;
      playerCurrency_ = other.playerCurrency_;
      playerCamera_ = other.playerCamera_;
      inventoryUpgrades_ = other.inventoryUpgrades_;
      appliedItems_ = other.appliedItems_;
      eggIncubators_ = other.eggIncubators_;
      pokemonFamilyId_ = other.pokemonFamilyId_;
      questType_ = other.questType_;
      avatarTemplateId_ = other.avatarTemplateId_;
      raidTickets_ = other.raidTickets_;
      quests_ = other.quests_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InventoryKey Clone() {
      return new InventoryKey(this);
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 1;
    private ulong pokemonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 2;
    private global::POGOProtos.Inventory.Item.ItemId item_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Item.ItemId Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }

    /// <summary>Field number for the "pokedex_entry_id" field.</summary>
    public const int PokedexEntryIdFieldNumber = 3;
    private int pokedexEntryId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PokedexEntryId {
      get { return pokedexEntryId_; }
      set {
        pokedexEntryId_ = value;
      }
    }

    /// <summary>Field number for the "player_stats" field.</summary>
    public const int PlayerStatsFieldNumber = 4;
    private bool playerStats_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PlayerStats {
      get { return playerStats_; }
      set {
        playerStats_ = value;
      }
    }

    /// <summary>Field number for the "player_currency" field.</summary>
    public const int PlayerCurrencyFieldNumber = 5;
    private bool playerCurrency_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PlayerCurrency {
      get { return playerCurrency_; }
      set {
        playerCurrency_ = value;
      }
    }

    /// <summary>Field number for the "player_camera" field.</summary>
    public const int PlayerCameraFieldNumber = 6;
    private bool playerCamera_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PlayerCamera {
      get { return playerCamera_; }
      set {
        playerCamera_ = value;
      }
    }

    /// <summary>Field number for the "inventory_upgrades" field.</summary>
    public const int InventoryUpgradesFieldNumber = 7;
    private bool inventoryUpgrades_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool InventoryUpgrades {
      get { return inventoryUpgrades_; }
      set {
        inventoryUpgrades_ = value;
      }
    }

    /// <summary>Field number for the "applied_items" field.</summary>
    public const int AppliedItemsFieldNumber = 8;
    private bool appliedItems_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AppliedItems {
      get { return appliedItems_; }
      set {
        appliedItems_ = value;
      }
    }

    /// <summary>Field number for the "egg_incubators" field.</summary>
    public const int EggIncubatorsFieldNumber = 9;
    private bool eggIncubators_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EggIncubators {
      get { return eggIncubators_; }
      set {
        eggIncubators_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_family_id" field.</summary>
    public const int PokemonFamilyIdFieldNumber = 10;
    private global::POGOProtos.Enums.PokemonFamilyId pokemonFamilyId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonFamilyId PokemonFamilyId {
      get { return pokemonFamilyId_; }
      set {
        pokemonFamilyId_ = value;
      }
    }

    /// <summary>Field number for the "quest_type" field.</summary>
    public const int QuestTypeFieldNumber = 11;
    private global::POGOProtos.Enums.QuestType questType_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.QuestType QuestType {
      get { return questType_; }
      set {
        questType_ = value;
      }
    }

    /// <summary>Field number for the "avatar_template_id" field.</summary>
    public const int AvatarTemplateIdFieldNumber = 12;
    private string avatarTemplateId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AvatarTemplateId {
      get { return avatarTemplateId_; }
      set {
        avatarTemplateId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "raid_tickets" field.</summary>
    public const int RaidTicketsFieldNumber = 13;
    private bool raidTickets_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool RaidTickets {
      get { return raidTickets_; }
      set {
        raidTickets_ = value;
      }
    }

    /// <summary>Field number for the "quests" field.</summary>
    public const int QuestsFieldNumber = 14;
    private bool quests_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Quests {
      get { return quests_; }
      set {
        quests_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InventoryKey);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InventoryKey other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonId != other.PokemonId) return false;
      if (Item != other.Item) return false;
      if (PokedexEntryId != other.PokedexEntryId) return false;
      if (PlayerStats != other.PlayerStats) return false;
      if (PlayerCurrency != other.PlayerCurrency) return false;
      if (PlayerCamera != other.PlayerCamera) return false;
      if (InventoryUpgrades != other.InventoryUpgrades) return false;
      if (AppliedItems != other.AppliedItems) return false;
      if (EggIncubators != other.EggIncubators) return false;
      if (PokemonFamilyId != other.PokemonFamilyId) return false;
      if (QuestType != other.QuestType) return false;
      if (AvatarTemplateId != other.AvatarTemplateId) return false;
      if (RaidTickets != other.RaidTickets) return false;
      if (Quests != other.Quests) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
      if (Item != 0) hash ^= Item.GetHashCode();
      if (PokedexEntryId != 0) hash ^= PokedexEntryId.GetHashCode();
      if (PlayerStats != false) hash ^= PlayerStats.GetHashCode();
      if (PlayerCurrency != false) hash ^= PlayerCurrency.GetHashCode();
      if (PlayerCamera != false) hash ^= PlayerCamera.GetHashCode();
      if (InventoryUpgrades != false) hash ^= InventoryUpgrades.GetHashCode();
      if (AppliedItems != false) hash ^= AppliedItems.GetHashCode();
      if (EggIncubators != false) hash ^= EggIncubators.GetHashCode();
      if (PokemonFamilyId != 0) hash ^= PokemonFamilyId.GetHashCode();
      if (QuestType != 0) hash ^= QuestType.GetHashCode();
      if (AvatarTemplateId.Length != 0) hash ^= AvatarTemplateId.GetHashCode();
      if (RaidTickets != false) hash ^= RaidTickets.GetHashCode();
      if (Quests != false) hash ^= Quests.GetHashCode();
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
      if (PokemonId != 0UL) {
        output.WriteRawTag(9);
        output.WriteFixed64(PokemonId);
      }
      if (Item != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Item);
      }
      if (PokedexEntryId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PokedexEntryId);
      }
      if (PlayerStats != false) {
        output.WriteRawTag(32);
        output.WriteBool(PlayerStats);
      }
      if (PlayerCurrency != false) {
        output.WriteRawTag(40);
        output.WriteBool(PlayerCurrency);
      }
      if (PlayerCamera != false) {
        output.WriteRawTag(48);
        output.WriteBool(PlayerCamera);
      }
      if (InventoryUpgrades != false) {
        output.WriteRawTag(56);
        output.WriteBool(InventoryUpgrades);
      }
      if (AppliedItems != false) {
        output.WriteRawTag(64);
        output.WriteBool(AppliedItems);
      }
      if (EggIncubators != false) {
        output.WriteRawTag(72);
        output.WriteBool(EggIncubators);
      }
      if (PokemonFamilyId != 0) {
        output.WriteRawTag(80);
        output.WriteEnum((int) PokemonFamilyId);
      }
      if (QuestType != 0) {
        output.WriteRawTag(88);
        output.WriteEnum((int) QuestType);
      }
      if (AvatarTemplateId.Length != 0) {
        output.WriteRawTag(98);
        output.WriteString(AvatarTemplateId);
      }
      if (RaidTickets != false) {
        output.WriteRawTag(104);
        output.WriteBool(RaidTickets);
      }
      if (Quests != false) {
        output.WriteRawTag(112);
        output.WriteBool(Quests);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PokemonId != 0UL) {
        size += 1 + 8;
      }
      if (Item != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Item);
      }
      if (PokedexEntryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokedexEntryId);
      }
      if (PlayerStats != false) {
        size += 1 + 1;
      }
      if (PlayerCurrency != false) {
        size += 1 + 1;
      }
      if (PlayerCamera != false) {
        size += 1 + 1;
      }
      if (InventoryUpgrades != false) {
        size += 1 + 1;
      }
      if (AppliedItems != false) {
        size += 1 + 1;
      }
      if (EggIncubators != false) {
        size += 1 + 1;
      }
      if (PokemonFamilyId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonFamilyId);
      }
      if (QuestType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) QuestType);
      }
      if (AvatarTemplateId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AvatarTemplateId);
      }
      if (RaidTickets != false) {
        size += 1 + 1;
      }
      if (Quests != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InventoryKey other) {
      if (other == null) {
        return;
      }
      if (other.PokemonId != 0UL) {
        PokemonId = other.PokemonId;
      }
      if (other.Item != 0) {
        Item = other.Item;
      }
      if (other.PokedexEntryId != 0) {
        PokedexEntryId = other.PokedexEntryId;
      }
      if (other.PlayerStats != false) {
        PlayerStats = other.PlayerStats;
      }
      if (other.PlayerCurrency != false) {
        PlayerCurrency = other.PlayerCurrency;
      }
      if (other.PlayerCamera != false) {
        PlayerCamera = other.PlayerCamera;
      }
      if (other.InventoryUpgrades != false) {
        InventoryUpgrades = other.InventoryUpgrades;
      }
      if (other.AppliedItems != false) {
        AppliedItems = other.AppliedItems;
      }
      if (other.EggIncubators != false) {
        EggIncubators = other.EggIncubators;
      }
      if (other.PokemonFamilyId != 0) {
        PokemonFamilyId = other.PokemonFamilyId;
      }
      if (other.QuestType != 0) {
        QuestType = other.QuestType;
      }
      if (other.AvatarTemplateId.Length != 0) {
        AvatarTemplateId = other.AvatarTemplateId;
      }
      if (other.RaidTickets != false) {
        RaidTickets = other.RaidTickets;
      }
      if (other.Quests != false) {
        Quests = other.Quests;
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
          case 9: {
            PokemonId = input.ReadFixed64();
            break;
          }
          case 16: {
            item_ = (global::POGOProtos.Inventory.Item.ItemId) input.ReadEnum();
            break;
          }
          case 24: {
            PokedexEntryId = input.ReadInt32();
            break;
          }
          case 32: {
            PlayerStats = input.ReadBool();
            break;
          }
          case 40: {
            PlayerCurrency = input.ReadBool();
            break;
          }
          case 48: {
            PlayerCamera = input.ReadBool();
            break;
          }
          case 56: {
            InventoryUpgrades = input.ReadBool();
            break;
          }
          case 64: {
            AppliedItems = input.ReadBool();
            break;
          }
          case 72: {
            EggIncubators = input.ReadBool();
            break;
          }
          case 80: {
            pokemonFamilyId_ = (global::POGOProtos.Enums.PokemonFamilyId) input.ReadEnum();
            break;
          }
          case 88: {
            questType_ = (global::POGOProtos.Enums.QuestType) input.ReadEnum();
            break;
          }
          case 98: {
            AvatarTemplateId = input.ReadString();
            break;
          }
          case 104: {
            RaidTickets = input.ReadBool();
            break;
          }
          case 112: {
            Quests = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
