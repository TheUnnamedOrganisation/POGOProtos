// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/StartRaidBattleResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/StartRaidBattleResponse.proto</summary>
  public static partial class StartRaidBattleResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/StartRaidBattleResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static StartRaidBattleResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1N0YXJ0UmFpZEJh",
            "dHRsZVJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzGiNQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZS5wcm90byLs",
            "AwoXU3RhcnRSYWlkQmF0dGxlUmVzcG9uc2USTwoGcmVzdWx0GAEgASgOMj8u",
            "UE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5TdGFydFJhaWRCYXR0",
            "bGVSZXNwb25zZS5SZXN1bHQSLgoGYmF0dGxlGAIgASgLMh4uUE9HT1Byb3Rv",
            "cy5EYXRhLkJhdHRsZS5CYXR0bGUizwIKBlJlc3VsdBIJCgVVTlNFVBAAEgsK",
            "B1NVQ0NFU1MQARIXChNFUlJPUl9HWU1fTk9UX0ZPVU5EEAISGgoWRVJST1Jf",
            "UkFJRF9VTkFWQUlMQUJMRRADEhgKFEVSUk9SX1JBSURfQ09NUExFVEVEEAQS",
            "GwoXRVJST1JfSU5WQUxJRF9BVFRBQ0tFUlMQBRIkCiBFUlJPUl9QTEFZRVJf",
            "QkVMT1dfTUlOSU1VTV9MRVZFTBAGEhYKEkVSUk9SX05PVF9JTl9SQU5HRRAH",
            "EhoKFkVSUk9SX1BPSV9JTkFDQ0VTU0lCTEUQCBIZChVFUlJPUl9MT0JCWV9O",
            "T1RfRk9VTkQQCRITCg9FUlJPUl9OT19USUNLRVQQChIYChRFUlJPUl9JTlZB",
            "TElEX1NFUlZFUhALEh0KGUVSUk9SX05FVkVSX0pPSU5FRF9CQVRUTEUQDGIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Battle.BattleReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.StartRaidBattleResponse), global::POGOProtos.Networking.Responses.StartRaidBattleResponse.Parser, new[]{ "Result", "Battle" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.StartRaidBattleResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StartRaidBattleResponse : pb::IMessage<StartRaidBattleResponse> {
    private static readonly pb::MessageParser<StartRaidBattleResponse> _parser = new pb::MessageParser<StartRaidBattleResponse>(() => new StartRaidBattleResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StartRaidBattleResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.StartRaidBattleResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRaidBattleResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRaidBattleResponse(StartRaidBattleResponse other) : this() {
      result_ = other.result_;
      Battle = other.battle_ != null ? other.Battle.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartRaidBattleResponse Clone() {
      return new StartRaidBattleResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.StartRaidBattleResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.StartRaidBattleResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "battle" field.</summary>
    public const int BattleFieldNumber = 2;
    private global::POGOProtos.Data.Battle.Battle battle_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Battle.Battle Battle {
      get { return battle_; }
      set {
        battle_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StartRaidBattleResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StartRaidBattleResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(Battle, other.Battle)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (battle_ != null) hash ^= Battle.GetHashCode();
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
      if (battle_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Battle);
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
      if (battle_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Battle);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StartRaidBattleResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.battle_ != null) {
        if (battle_ == null) {
          battle_ = new global::POGOProtos.Data.Battle.Battle();
        }
        Battle.MergeFrom(other.Battle);
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
            result_ = (global::POGOProtos.Networking.Responses.StartRaidBattleResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (battle_ == null) {
              battle_ = new global::POGOProtos.Data.Battle.Battle();
            }
            input.ReadMessage(battle_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the StartRaidBattleResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_GYM_NOT_FOUND")] ErrorGymNotFound = 2,
        [pbr::OriginalName("ERROR_RAID_UNAVAILABLE")] ErrorRaidUnavailable = 3,
        [pbr::OriginalName("ERROR_RAID_COMPLETED")] ErrorRaidCompleted = 4,
        [pbr::OriginalName("ERROR_INVALID_ATTACKERS")] ErrorInvalidAttackers = 5,
        [pbr::OriginalName("ERROR_PLAYER_BELOW_MINIMUM_LEVEL")] ErrorPlayerBelowMinimumLevel = 6,
        [pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 7,
        [pbr::OriginalName("ERROR_POI_INACCESSIBLE")] ErrorPoiInaccessible = 8,
        [pbr::OriginalName("ERROR_LOBBY_NOT_FOUND")] ErrorLobbyNotFound = 9,
        [pbr::OriginalName("ERROR_NO_TICKET")] ErrorNoTicket = 10,
        [pbr::OriginalName("ERROR_INVALID_SERVER")] ErrorInvalidServer = 11,
        [pbr::OriginalName("ERROR_NEVER_JOINED_BATTLE")] ErrorNeverJoinedBattle = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
