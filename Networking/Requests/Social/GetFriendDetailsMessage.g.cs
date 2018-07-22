// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Social/GetFriendDetailsMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Social {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Social/GetFriendDetailsMessage.proto</summary>
  public static partial class GetFriendDetailsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Social/GetFriendDetailsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetFriendDetailsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvU29jaWFsL0dldEZy",
            "aWVuZERldGFpbHNNZXNzYWdlLnByb3RvEiVQT0dPUHJvdG9zLk5ldHdvcmtp",
            "bmcuUmVxdWVzdHMuU29jaWFsIiwKF0dldEZyaWVuZERldGFpbHNNZXNzYWdl",
            "EhEKCXBsYXllcl9pZBgBIAMoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Social.GetFriendDetailsMessage), global::POGOProtos.Networking.Requests.Social.GetFriendDetailsMessage.Parser, new[]{ "PlayerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetFriendDetailsMessage : pb::IMessage<GetFriendDetailsMessage> {
    private static readonly pb::MessageParser<GetFriendDetailsMessage> _parser = new pb::MessageParser<GetFriendDetailsMessage>(() => new GetFriendDetailsMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetFriendDetailsMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Social.GetFriendDetailsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFriendDetailsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFriendDetailsMessage(GetFriendDetailsMessage other) : this() {
      playerId_ = other.playerId_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetFriendDetailsMessage Clone() {
      return new GetFriendDetailsMessage(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_playerId_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> playerId_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> PlayerId {
      get { return playerId_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetFriendDetailsMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetFriendDetailsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!playerId_.Equals(other.playerId_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= playerId_.GetHashCode();
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
      playerId_.WriteTo(output, _repeated_playerId_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += playerId_.CalculateSize(_repeated_playerId_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetFriendDetailsMessage other) {
      if (other == null) {
        return;
      }
      playerId_.Add(other.playerId_);
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
            playerId_.AddEntriesFrom(input, _repeated_playerId_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code