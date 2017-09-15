// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/SetLobbyPokemonResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/SetLobbyPokemonResponse.proto</summary>
  public static partial class SetLobbyPokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/SetLobbyPokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetLobbyPokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NldExvYmJ5UG9r",
            "ZW1vblJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzGiBQT0dPUHJvdG9zL0RhdGEvUmFpZC9Mb2JieS5wcm90byKKAgoX",
            "U2V0TG9iYnlQb2tlbW9uUmVzcG9uc2USTwoGcmVzdWx0GAEgASgOMj8uUE9H",
            "T1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5TZXRMb2JieVBva2Vtb25S",
            "ZXNwb25zZS5SZXN1bHQSKgoFbG9iYnkYAiABKAsyGy5QT0dPUHJvdG9zLkRh",
            "dGEuUmFpZC5Mb2JieSJyCgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNT",
            "EAESGQoVRVJST1JfTE9CQllfTk9UX0ZPVU5EEAISGgoWRVJST1JfUkFJRF9V",
            "TkFWQUlMQUJMRRADEhkKFUVSUk9SX0lOVkFMSURfUE9LRU1PThAEYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Raid.LobbyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.SetLobbyPokemonResponse), global::POGOProtos.Networking.Responses.SetLobbyPokemonResponse.Parser, new[]{ "Result", "Lobby" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.SetLobbyPokemonResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SetLobbyPokemonResponse : pb::IMessage<SetLobbyPokemonResponse> {
    private static readonly pb::MessageParser<SetLobbyPokemonResponse> _parser = new pb::MessageParser<SetLobbyPokemonResponse>(() => new SetLobbyPokemonResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SetLobbyPokemonResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.SetLobbyPokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyPokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyPokemonResponse(SetLobbyPokemonResponse other) : this() {
      result_ = other.result_;
      Lobby = other.lobby_ != null ? other.Lobby.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SetLobbyPokemonResponse Clone() {
      return new SetLobbyPokemonResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.SetLobbyPokemonResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.SetLobbyPokemonResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "lobby" field.</summary>
    public const int LobbyFieldNumber = 2;
    private global::POGOProtos.Data.Raid.Lobby lobby_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Raid.Lobby Lobby {
      get { return lobby_; }
      set {
        lobby_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SetLobbyPokemonResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SetLobbyPokemonResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(Lobby, other.Lobby)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (lobby_ != null) hash ^= Lobby.GetHashCode();
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
      if (lobby_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Lobby);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (lobby_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Lobby);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SetLobbyPokemonResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.lobby_ != null) {
        if (lobby_ == null) {
          lobby_ = new global::POGOProtos.Data.Raid.Lobby();
        }
        Lobby.MergeFrom(other.Lobby);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::POGOProtos.Networking.Responses.SetLobbyPokemonResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (lobby_ == null) {
              lobby_ = new global::POGOProtos.Data.Raid.Lobby();
            }
            input.ReadMessage(lobby_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SetLobbyPokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_LOBBY_NOT_FOUND")] ErrorLobbyNotFound = 2,
        [pbr::OriginalName("ERROR_RAID_UNAVAILABLE")] ErrorRaidUnavailable = 3,
        [pbr::OriginalName("ERROR_INVALID_POKEMON")] ErrorInvalidPokemon = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
