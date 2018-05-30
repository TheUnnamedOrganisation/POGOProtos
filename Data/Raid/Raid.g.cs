// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Raid/Raid.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Raid {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Raid/Raid.proto</summary>
  public static partial class RaidReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Raid/Raid.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RaidReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9QT0dPUHJvdG9zL0RhdGEvUmFpZC9SYWlkLnByb3RvEhRQT0dPUHJvdG9z",
            "LkRhdGEuUmFpZBogUE9HT1Byb3Rvcy9FbnVtcy9Qb2tlbW9uSWQucHJvdG8i",
            "kgIKBFJhaWQSEQoJcmFpZF9zZWVkGAEgASgDEhIKCnN0YXJ0ZWRfbXMYAiAB",
            "KAMSFAoMY29tcGxldGVkX21zGAMgASgDEjkKFGVuY291bnRlcl9wb2tlbW9u",
            "X2lkGAQgASgOMhsuUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9uSWQSGAoQY29t",
            "cGxldGVkX2JhdHRsZRgFIAEoCBIYChByZWNlaXZlZF9yZXdhcmRzGAYgASgI",
            "EhoKEmZpbmlzaGVkX2VuY291bnRlchgHIAEoCBIgChhyZWNlaXZlZF9kZWZh",
            "dWx0X3Jld2FyZHMYCCABKAgSIAoYaW5jcmVtZW50ZWRfcmFpZF9mcmllbmRz",
            "GAkgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Raid.Raid), global::POGOProtos.Data.Raid.Raid.Parser, new[]{ "RaidSeed", "StartedMs", "CompletedMs", "EncounterPokemonId", "CompletedBattle", "ReceivedRewards", "FinishedEncounter", "ReceivedDefaultRewards", "IncrementedRaidFriends" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Raid : pb::IMessage<Raid> {
    private static readonly pb::MessageParser<Raid> _parser = new pb::MessageParser<Raid>(() => new Raid());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Raid> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Raid.RaidReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Raid() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Raid(Raid other) : this() {
      raidSeed_ = other.raidSeed_;
      startedMs_ = other.startedMs_;
      completedMs_ = other.completedMs_;
      encounterPokemonId_ = other.encounterPokemonId_;
      completedBattle_ = other.completedBattle_;
      receivedRewards_ = other.receivedRewards_;
      finishedEncounter_ = other.finishedEncounter_;
      receivedDefaultRewards_ = other.receivedDefaultRewards_;
      incrementedRaidFriends_ = other.incrementedRaidFriends_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Raid Clone() {
      return new Raid(this);
    }

    /// <summary>Field number for the "raid_seed" field.</summary>
    public const int RaidSeedFieldNumber = 1;
    private long raidSeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RaidSeed {
      get { return raidSeed_; }
      set {
        raidSeed_ = value;
      }
    }

    /// <summary>Field number for the "started_ms" field.</summary>
    public const int StartedMsFieldNumber = 2;
    private long startedMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long StartedMs {
      get { return startedMs_; }
      set {
        startedMs_ = value;
      }
    }

    /// <summary>Field number for the "completed_ms" field.</summary>
    public const int CompletedMsFieldNumber = 3;
    private long completedMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CompletedMs {
      get { return completedMs_; }
      set {
        completedMs_ = value;
      }
    }

    /// <summary>Field number for the "encounter_pokemon_id" field.</summary>
    public const int EncounterPokemonIdFieldNumber = 4;
    private global::POGOProtos.Enums.PokemonId encounterPokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId EncounterPokemonId {
      get { return encounterPokemonId_; }
      set {
        encounterPokemonId_ = value;
      }
    }

    /// <summary>Field number for the "completed_battle" field.</summary>
    public const int CompletedBattleFieldNumber = 5;
    private bool completedBattle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CompletedBattle {
      get { return completedBattle_; }
      set {
        completedBattle_ = value;
      }
    }

    /// <summary>Field number for the "received_rewards" field.</summary>
    public const int ReceivedRewardsFieldNumber = 6;
    private bool receivedRewards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ReceivedRewards {
      get { return receivedRewards_; }
      set {
        receivedRewards_ = value;
      }
    }

    /// <summary>Field number for the "finished_encounter" field.</summary>
    public const int FinishedEncounterFieldNumber = 7;
    private bool finishedEncounter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool FinishedEncounter {
      get { return finishedEncounter_; }
      set {
        finishedEncounter_ = value;
      }
    }

    /// <summary>Field number for the "received_default_rewards" field.</summary>
    public const int ReceivedDefaultRewardsFieldNumber = 8;
    private bool receivedDefaultRewards_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ReceivedDefaultRewards {
      get { return receivedDefaultRewards_; }
      set {
        receivedDefaultRewards_ = value;
      }
    }

    /// <summary>Field number for the "incremented_raid_friends" field.</summary>
    public const int IncrementedRaidFriendsFieldNumber = 9;
    private bool incrementedRaidFriends_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IncrementedRaidFriends {
      get { return incrementedRaidFriends_; }
      set {
        incrementedRaidFriends_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Raid);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Raid other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RaidSeed != other.RaidSeed) return false;
      if (StartedMs != other.StartedMs) return false;
      if (CompletedMs != other.CompletedMs) return false;
      if (EncounterPokemonId != other.EncounterPokemonId) return false;
      if (CompletedBattle != other.CompletedBattle) return false;
      if (ReceivedRewards != other.ReceivedRewards) return false;
      if (FinishedEncounter != other.FinishedEncounter) return false;
      if (ReceivedDefaultRewards != other.ReceivedDefaultRewards) return false;
      if (IncrementedRaidFriends != other.IncrementedRaidFriends) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RaidSeed != 0L) hash ^= RaidSeed.GetHashCode();
      if (StartedMs != 0L) hash ^= StartedMs.GetHashCode();
      if (CompletedMs != 0L) hash ^= CompletedMs.GetHashCode();
      if (EncounterPokemonId != 0) hash ^= EncounterPokemonId.GetHashCode();
      if (CompletedBattle != false) hash ^= CompletedBattle.GetHashCode();
      if (ReceivedRewards != false) hash ^= ReceivedRewards.GetHashCode();
      if (FinishedEncounter != false) hash ^= FinishedEncounter.GetHashCode();
      if (ReceivedDefaultRewards != false) hash ^= ReceivedDefaultRewards.GetHashCode();
      if (IncrementedRaidFriends != false) hash ^= IncrementedRaidFriends.GetHashCode();
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
      if (RaidSeed != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(RaidSeed);
      }
      if (StartedMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(StartedMs);
      }
      if (CompletedMs != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(CompletedMs);
      }
      if (EncounterPokemonId != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) EncounterPokemonId);
      }
      if (CompletedBattle != false) {
        output.WriteRawTag(40);
        output.WriteBool(CompletedBattle);
      }
      if (ReceivedRewards != false) {
        output.WriteRawTag(48);
        output.WriteBool(ReceivedRewards);
      }
      if (FinishedEncounter != false) {
        output.WriteRawTag(56);
        output.WriteBool(FinishedEncounter);
      }
      if (ReceivedDefaultRewards != false) {
        output.WriteRawTag(64);
        output.WriteBool(ReceivedDefaultRewards);
      }
      if (IncrementedRaidFriends != false) {
        output.WriteRawTag(72);
        output.WriteBool(IncrementedRaidFriends);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RaidSeed != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RaidSeed);
      }
      if (StartedMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(StartedMs);
      }
      if (CompletedMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CompletedMs);
      }
      if (EncounterPokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) EncounterPokemonId);
      }
      if (CompletedBattle != false) {
        size += 1 + 1;
      }
      if (ReceivedRewards != false) {
        size += 1 + 1;
      }
      if (FinishedEncounter != false) {
        size += 1 + 1;
      }
      if (ReceivedDefaultRewards != false) {
        size += 1 + 1;
      }
      if (IncrementedRaidFriends != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Raid other) {
      if (other == null) {
        return;
      }
      if (other.RaidSeed != 0L) {
        RaidSeed = other.RaidSeed;
      }
      if (other.StartedMs != 0L) {
        StartedMs = other.StartedMs;
      }
      if (other.CompletedMs != 0L) {
        CompletedMs = other.CompletedMs;
      }
      if (other.EncounterPokemonId != 0) {
        EncounterPokemonId = other.EncounterPokemonId;
      }
      if (other.CompletedBattle != false) {
        CompletedBattle = other.CompletedBattle;
      }
      if (other.ReceivedRewards != false) {
        ReceivedRewards = other.ReceivedRewards;
      }
      if (other.FinishedEncounter != false) {
        FinishedEncounter = other.FinishedEncounter;
      }
      if (other.ReceivedDefaultRewards != false) {
        ReceivedDefaultRewards = other.ReceivedDefaultRewards;
      }
      if (other.IncrementedRaidFriends != false) {
        IncrementedRaidFriends = other.IncrementedRaidFriends;
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
            RaidSeed = input.ReadInt64();
            break;
          }
          case 16: {
            StartedMs = input.ReadInt64();
            break;
          }
          case 24: {
            CompletedMs = input.ReadInt64();
            break;
          }
          case 32: {
            encounterPokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 40: {
            CompletedBattle = input.ReadBool();
            break;
          }
          case 48: {
            ReceivedRewards = input.ReadBool();
            break;
          }
          case 56: {
            FinishedEncounter = input.ReadBool();
            break;
          }
          case 64: {
            ReceivedDefaultRewards = input.ReadBool();
            break;
          }
          case 72: {
            IncrementedRaidFriends = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
