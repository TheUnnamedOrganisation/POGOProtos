// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/GymDeployResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GymDeployResponse.proto</summary>
  public static partial class GymDeployResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/GymDeployResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymDeployResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0d5bURlcGxveVJl",
            "c3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
            "Gi9QT0dPUHJvdG9zL0RhdGEvR3ltL0d5bVN0YXR1c0FuZERlZmVuZGVycy5w",
            "cm90bxorUE9HT1Byb3Rvcy9EYXRhL0JhZGdlL0F3YXJkZWRHeW1CYWRnZS5w",
            "cm90byLdBgoRR3ltRGVwbG95UmVzcG9uc2USSQoGcmVzdWx0GAEgASgOMjku",
            "UE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5HeW1EZXBsb3lSZXNw",
            "b25zZS5SZXN1bHQSTAoYZ3ltX3N0YXR1c19hbmRfZGVmZW5kZXJzGAIgASgL",
            "MiouUE9HT1Byb3Rvcy5EYXRhLkd5bS5HeW1TdGF0dXNBbmREZWZlbmRlcnMS",
            "QQoRYXdhcmRlZF9neW1fYmFkZ2UYAyABKAsyJi5QT0dPUHJvdG9zLkRhdGEu",
            "QmFkZ2UuQXdhcmRlZEd5bUJhZGdlEiYKHmNvb2xkb3duX2NvbXBsZXRlX3Rp",
            "bWVzdGFtcF9tcxgEIAEoAyLDBAoGUmVzdWx0EhEKDU5PX1JFU1VMVF9TRVQQ",
            "ABILCgdTVUNDRVNTEAESJQohRVJST1JfQUxSRUFEWV9IQVNfUE9LRU1PTl9P",
            "Tl9GT1JUEAISIQodRVJST1JfT1BQT1NJTkdfVEVBTV9PV05TX0ZPUlQQAxIW",
            "ChJFUlJPUl9GT1JUX0lTX0ZVTEwQBBIWChJFUlJPUl9OT1RfSU5fUkFOR0UQ",
            "BRIcChhFUlJPUl9QTEFZRVJfSEFTX05PX1RFQU0QBhIdChlFUlJPUl9QT0tF",
            "TU9OX05PVF9GVUxMX0hQEAcSJAogRVJST1JfUExBWUVSX0JFTE9XX01JTklN",
            "VU1fTEVWRUwQCBIaChZFUlJPUl9QT0tFTU9OX0lTX0JVRERZEAkSHQoZRVJS",
            "T1JfRk9SVF9ERVBMT1lfTE9DS09VVBAKEiAKHEVSUk9SX1BMQVlFUl9IQVNf",
            "Tk9fTklDS05BTUUQCxIaChZFUlJPUl9QT0lfSU5BQ0NFU1NJQkxFEAwSFwoT",
            "RVJST1JfTk9UX0FfUE9LRU1PThANEh8KG0VSUk9SX1RPT19NQU5ZX09GX1NB",
            "TUVfS0lORBAOEhsKF0VSUk9SX1RPT19NQU5ZX0RFUExPWUVEEA8SHQoZRVJS",
            "T1JfVEVBTV9ERVBMT1lfTE9DS09VVBAQEhsKF0VSUk9SX0xFR0VOREFSWV9Q",
            "T0tFTU9OEBESGQoVRVJST1JfSU5WQUxJRF9QT0tFTU9OEBISFQoRRVJST1Jf",
            "UkFJRF9BQ1RJVkUQE2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Gym.GymStatusAndDefendersReflection.Descriptor, global::POGOProtos.Data.Badge.AwardedGymBadgeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.GymDeployResponse), global::POGOProtos.Networking.Responses.GymDeployResponse.Parser, new[]{ "Result", "GymStatusAndDefenders", "AwardedGymBadge", "CooldownCompleteTimestampMs" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.GymDeployResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GymDeployResponse : pb::IMessage<GymDeployResponse> {
    private static readonly pb::MessageParser<GymDeployResponse> _parser = new pb::MessageParser<GymDeployResponse>(() => new GymDeployResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GymDeployResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.GymDeployResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDeployResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDeployResponse(GymDeployResponse other) : this() {
      result_ = other.result_;
      gymStatusAndDefenders_ = other.gymStatusAndDefenders_ != null ? other.gymStatusAndDefenders_.Clone() : null;
      awardedGymBadge_ = other.awardedGymBadge_ != null ? other.awardedGymBadge_.Clone() : null;
      cooldownCompleteTimestampMs_ = other.cooldownCompleteTimestampMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDeployResponse Clone() {
      return new GymDeployResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.GymDeployResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.GymDeployResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "gym_status_and_defenders" field.</summary>
    public const int GymStatusAndDefendersFieldNumber = 2;
    private global::POGOProtos.Data.Gym.GymStatusAndDefenders gymStatusAndDefenders_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Gym.GymStatusAndDefenders GymStatusAndDefenders {
      get { return gymStatusAndDefenders_; }
      set {
        gymStatusAndDefenders_ = value;
      }
    }

    /// <summary>Field number for the "awarded_gym_badge" field.</summary>
    public const int AwardedGymBadgeFieldNumber = 3;
    private global::POGOProtos.Data.Badge.AwardedGymBadge awardedGymBadge_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Badge.AwardedGymBadge AwardedGymBadge {
      get { return awardedGymBadge_; }
      set {
        awardedGymBadge_ = value;
      }
    }

    /// <summary>Field number for the "cooldown_complete_timestamp_ms" field.</summary>
    public const int CooldownCompleteTimestampMsFieldNumber = 4;
    private long cooldownCompleteTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CooldownCompleteTimestampMs {
      get { return cooldownCompleteTimestampMs_; }
      set {
        cooldownCompleteTimestampMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GymDeployResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GymDeployResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(GymStatusAndDefenders, other.GymStatusAndDefenders)) return false;
      if (!object.Equals(AwardedGymBadge, other.AwardedGymBadge)) return false;
      if (CooldownCompleteTimestampMs != other.CooldownCompleteTimestampMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (gymStatusAndDefenders_ != null) hash ^= GymStatusAndDefenders.GetHashCode();
      if (awardedGymBadge_ != null) hash ^= AwardedGymBadge.GetHashCode();
      if (CooldownCompleteTimestampMs != 0L) hash ^= CooldownCompleteTimestampMs.GetHashCode();
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
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (gymStatusAndDefenders_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GymStatusAndDefenders);
      }
      if (awardedGymBadge_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AwardedGymBadge);
      }
      if (CooldownCompleteTimestampMs != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(CooldownCompleteTimestampMs);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (gymStatusAndDefenders_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GymStatusAndDefenders);
      }
      if (awardedGymBadge_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AwardedGymBadge);
      }
      if (CooldownCompleteTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CooldownCompleteTimestampMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GymDeployResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.gymStatusAndDefenders_ != null) {
        if (gymStatusAndDefenders_ == null) {
          gymStatusAndDefenders_ = new global::POGOProtos.Data.Gym.GymStatusAndDefenders();
        }
        GymStatusAndDefenders.MergeFrom(other.GymStatusAndDefenders);
      }
      if (other.awardedGymBadge_ != null) {
        if (awardedGymBadge_ == null) {
          awardedGymBadge_ = new global::POGOProtos.Data.Badge.AwardedGymBadge();
        }
        AwardedGymBadge.MergeFrom(other.AwardedGymBadge);
      }
      if (other.CooldownCompleteTimestampMs != 0L) {
        CooldownCompleteTimestampMs = other.CooldownCompleteTimestampMs;
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
            result_ = (global::POGOProtos.Networking.Responses.GymDeployResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (gymStatusAndDefenders_ == null) {
              gymStatusAndDefenders_ = new global::POGOProtos.Data.Gym.GymStatusAndDefenders();
            }
            input.ReadMessage(gymStatusAndDefenders_);
            break;
          }
          case 26: {
            if (awardedGymBadge_ == null) {
              awardedGymBadge_ = new global::POGOProtos.Data.Badge.AwardedGymBadge();
            }
            input.ReadMessage(awardedGymBadge_);
            break;
          }
          case 32: {
            CooldownCompleteTimestampMs = input.ReadInt64();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GymDeployResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("NO_RESULT_SET")] NoResultSet = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_ALREADY_HAS_POKEMON_ON_FORT")] ErrorAlreadyHasPokemonOnFort = 2,
        [pbr::OriginalName("ERROR_OPPOSING_TEAM_OWNS_FORT")] ErrorOpposingTeamOwnsFort = 3,
        [pbr::OriginalName("ERROR_FORT_IS_FULL")] ErrorFortIsFull = 4,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 5,
        [pbr::OriginalName("ERROR_PLAYER_HAS_NO_TEAM")] ErrorPlayerHasNoTeam = 6,
        [pbr::OriginalName("ERROR_POKEMON_NOT_FULL_HP")] ErrorPokemonNotFullHp = 7,
        [pbr::OriginalName("ERROR_PLAYER_BELOW_MINIMUM_LEVEL")] ErrorPlayerBelowMinimumLevel = 8,
        [pbr::OriginalName("ERROR_POKEMON_IS_BUDDY")] ErrorPokemonIsBuddy = 9,
        [pbr::OriginalName("ERROR_FORT_DEPLOY_LOCKOUT")] ErrorFortDeployLockout = 10,
        [pbr::OriginalName("ERROR_PLAYER_HAS_NO_NICKNAME")] ErrorPlayerHasNoNickname = 11,
        [pbr::OriginalName("ERROR_POI_INACCESSIBLE")] ErrorPoiInaccessible = 12,
        [pbr::OriginalName("ERROR_NOT_A_POKEMON")] ErrorNotAPokemon = 13,
        [pbr::OriginalName("ERROR_TOO_MANY_OF_SAME_KIND")] ErrorTooManyOfSameKind = 14,
        [pbr::OriginalName("ERROR_TOO_MANY_DEPLOYED")] ErrorTooManyDeployed = 15,
        [pbr::OriginalName("ERROR_TEAM_DEPLOY_LOCKOUT")] ErrorTeamDeployLockout = 16,
        [pbr::OriginalName("ERROR_LEGENDARY_POKEMON")] ErrorLegendaryPokemon = 17,
        [pbr::OriginalName("ERROR_INVALID_POKEMON")] ErrorInvalidPokemon = 18,
        [pbr::OriginalName("ERROR_RAID_ACTIVE")] ErrorRaidActive = 19,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
