// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/StartRaidBattleMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/StartRaidBattleMessage.proto</summary>
  public static partial class StartRaidBattleMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/StartRaidBattleMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartRaidBattleMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvU3Rh",
            "cnRSYWlkQmF0dGxlTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3Jr",
            "aW5nLlJlcXVlc3RzLk1lc3NhZ2VzItUBChZTdGFydFJhaWRCYXR0bGVNZXNz",
            "YWdlEg4KBmd5bV9pZBgBIAEoCRIRCglyYWlkX3NlZWQYAiABKAMSEAoIbG9i",
            "YnlfaWQYBCADKAUSHAoUYXR0YWNraW5nX3Bva2Vtb25faWQYBSADKAYSGgoS",
            "cGxheWVyX2xhdF9kZWdyZWVzGAYgASgBEhoKEnBsYXllcl9sbmdfZGVncmVl",
            "cxgHIAEoARIXCg9neW1fbGF0X2RlZ3JlZXMYCCABKAESFwoPZ3ltX2xuZ19k",
            "ZWdyZWVzGAkgASgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.StartRaidBattleMessage), global::POGOProtos.Networking.Requests.Messages.StartRaidBattleMessage.Parser, new[]{ "GymId", "RaidSeed", "LobbyId", "AttackingPokemonId", "PlayerLatDegrees", "PlayerLngDegrees", "GymLatDegrees", "GymLngDegrees" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StartRaidBattleMessage : pb::IMessage<StartRaidBattleMessage> {
    private static readonly pb::MessageParser<StartRaidBattleMessage> _parser = new pb::MessageParser<StartRaidBattleMessage>(() => new StartRaidBattleMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StartRaidBattleMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.StartRaidBattleMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRaidBattleMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRaidBattleMessage(StartRaidBattleMessage other) : this() {
      gymId_ = other.gymId_;
      raidSeed_ = other.raidSeed_;
      lobbyId_ = other.lobbyId_.Clone();
      attackingPokemonId_ = other.attackingPokemonId_.Clone();
      playerLatDegrees_ = other.playerLatDegrees_;
      playerLngDegrees_ = other.playerLngDegrees_;
      gymLatDegrees_ = other.gymLatDegrees_;
      gymLngDegrees_ = other.gymLngDegrees_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRaidBattleMessage Clone() {
      return new StartRaidBattleMessage(this);
    }

    /// <summary>Field number for the "gym_id" field.</summary>
    public const int GymIdFieldNumber = 1;
    private string gymId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GymId {
      get { return gymId_; }
      set {
        gymId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "raid_seed" field.</summary>
    public const int RaidSeedFieldNumber = 2;
    private long raidSeed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long RaidSeed {
      get { return raidSeed_; }
      set {
        raidSeed_ = value;
      }
    }

    /// <summary>Field number for the "lobby_id" field.</summary>
    public const int LobbyIdFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_lobbyId_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> lobbyId_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> LobbyId {
      get { return lobbyId_; }
    }

    /// <summary>Field number for the "attacking_pokemon_id" field.</summary>
    public const int AttackingPokemonIdFieldNumber = 5;
    private static readonly pb::FieldCodec<ulong> _repeated_attackingPokemonId_codec
        = pb::FieldCodec.ForFixed64(42);
    private readonly pbc::RepeatedField<ulong> attackingPokemonId_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<ulong> AttackingPokemonId {
      get { return attackingPokemonId_; }
    }

    /// <summary>Field number for the "player_lat_degrees" field.</summary>
    public const int PlayerLatDegreesFieldNumber = 6;
    private double playerLatDegrees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLatDegrees {
      get { return playerLatDegrees_; }
      set {
        playerLatDegrees_ = value;
      }
    }

    /// <summary>Field number for the "player_lng_degrees" field.</summary>
    public const int PlayerLngDegreesFieldNumber = 7;
    private double playerLngDegrees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLngDegrees {
      get { return playerLngDegrees_; }
      set {
        playerLngDegrees_ = value;
      }
    }

    /// <summary>Field number for the "gym_lat_degrees" field.</summary>
    public const int GymLatDegreesFieldNumber = 8;
    private double gymLatDegrees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double GymLatDegrees {
      get { return gymLatDegrees_; }
      set {
        gymLatDegrees_ = value;
      }
    }

    /// <summary>Field number for the "gym_lng_degrees" field.</summary>
    public const int GymLngDegreesFieldNumber = 9;
    private double gymLngDegrees_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double GymLngDegrees {
      get { return gymLngDegrees_; }
      set {
        gymLngDegrees_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StartRaidBattleMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StartRaidBattleMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GymId != other.GymId) return false;
      if (RaidSeed != other.RaidSeed) return false;
      if(!lobbyId_.Equals(other.lobbyId_)) return false;
      if(!attackingPokemonId_.Equals(other.attackingPokemonId_)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerLatDegrees, other.PlayerLatDegrees)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerLngDegrees, other.PlayerLngDegrees)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GymLatDegrees, other.GymLatDegrees)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(GymLngDegrees, other.GymLngDegrees)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GymId.Length != 0) hash ^= GymId.GetHashCode();
      if (RaidSeed != 0L) hash ^= RaidSeed.GetHashCode();
      hash ^= lobbyId_.GetHashCode();
      hash ^= attackingPokemonId_.GetHashCode();
      if (PlayerLatDegrees != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerLatDegrees);
      if (PlayerLngDegrees != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerLngDegrees);
      if (GymLatDegrees != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GymLatDegrees);
      if (GymLngDegrees != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(GymLngDegrees);
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
      if (GymId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GymId);
      }
      if (RaidSeed != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(RaidSeed);
      }
      lobbyId_.WriteTo(output, _repeated_lobbyId_codec);
      attackingPokemonId_.WriteTo(output, _repeated_attackingPokemonId_codec);
      if (PlayerLatDegrees != 0D) {
        output.WriteRawTag(49);
        output.WriteDouble(PlayerLatDegrees);
      }
      if (PlayerLngDegrees != 0D) {
        output.WriteRawTag(57);
        output.WriteDouble(PlayerLngDegrees);
      }
      if (GymLatDegrees != 0D) {
        output.WriteRawTag(65);
        output.WriteDouble(GymLatDegrees);
      }
      if (GymLngDegrees != 0D) {
        output.WriteRawTag(73);
        output.WriteDouble(GymLngDegrees);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GymId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GymId);
      }
      if (RaidSeed != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RaidSeed);
      }
      size += lobbyId_.CalculateSize(_repeated_lobbyId_codec);
      size += attackingPokemonId_.CalculateSize(_repeated_attackingPokemonId_codec);
      if (PlayerLatDegrees != 0D) {
        size += 1 + 8;
      }
      if (PlayerLngDegrees != 0D) {
        size += 1 + 8;
      }
      if (GymLatDegrees != 0D) {
        size += 1 + 8;
      }
      if (GymLngDegrees != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StartRaidBattleMessage other) {
      if (other == null) {
        return;
      }
      if (other.GymId.Length != 0) {
        GymId = other.GymId;
      }
      if (other.RaidSeed != 0L) {
        RaidSeed = other.RaidSeed;
      }
      lobbyId_.Add(other.lobbyId_);
      attackingPokemonId_.Add(other.attackingPokemonId_);
      if (other.PlayerLatDegrees != 0D) {
        PlayerLatDegrees = other.PlayerLatDegrees;
      }
      if (other.PlayerLngDegrees != 0D) {
        PlayerLngDegrees = other.PlayerLngDegrees;
      }
      if (other.GymLatDegrees != 0D) {
        GymLatDegrees = other.GymLatDegrees;
      }
      if (other.GymLngDegrees != 0D) {
        GymLngDegrees = other.GymLngDegrees;
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
            GymId = input.ReadString();
            break;
          }
          case 16: {
            RaidSeed = input.ReadInt64();
            break;
          }
          case 34:
          case 32: {
            lobbyId_.AddEntriesFrom(input, _repeated_lobbyId_codec);
            break;
          }
          case 42:
          case 41: {
            attackingPokemonId_.AddEntriesFrom(input, _repeated_attackingPokemonId_codec);
            break;
          }
          case 49: {
            PlayerLatDegrees = input.ReadDouble();
            break;
          }
          case 57: {
            PlayerLngDegrees = input.ReadDouble();
            break;
          }
          case 65: {
            GymLatDegrees = input.ReadDouble();
            break;
          }
          case 73: {
            GymLngDegrees = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
