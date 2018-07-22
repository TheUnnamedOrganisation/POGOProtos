// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Social/DeclineFriendInviteMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Social {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Social/DeclineFriendInviteMessage.proto</summary>
  public static partial class DeclineFriendInviteMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Social/DeclineFriendInviteMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DeclineFriendInviteMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvU29jaWFsL0RlY2xp",
            "bmVGcmllbmRJbnZpdGVNZXNzYWdlLnByb3RvEiVQT0dPUHJvdG9zLk5ldHdv",
            "cmtpbmcuUmVxdWVzdHMuU29jaWFsIi8KGkRlY2xpbmVGcmllbmRJbnZpdGVN",
            "ZXNzYWdlEhEKCXBsYXllcl9pZBgBIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Social.DeclineFriendInviteMessage), global::POGOProtos.Networking.Requests.Social.DeclineFriendInviteMessage.Parser, new[]{ "PlayerId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DeclineFriendInviteMessage : pb::IMessage<DeclineFriendInviteMessage> {
    private static readonly pb::MessageParser<DeclineFriendInviteMessage> _parser = new pb::MessageParser<DeclineFriendInviteMessage>(() => new DeclineFriendInviteMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeclineFriendInviteMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Social.DeclineFriendInviteMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeclineFriendInviteMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeclineFriendInviteMessage(DeclineFriendInviteMessage other) : this() {
      playerId_ = other.playerId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeclineFriendInviteMessage Clone() {
      return new DeclineFriendInviteMessage(this);
    }

    /// <summary>Field number for the "player_id" field.</summary>
    public const int PlayerIdFieldNumber = 1;
    private string playerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PlayerId {
      get { return playerId_; }
      set {
        playerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeclineFriendInviteMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeclineFriendInviteMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PlayerId != other.PlayerId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PlayerId.Length != 0) hash ^= PlayerId.GetHashCode();
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
      if (PlayerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(PlayerId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PlayerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PlayerId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeclineFriendInviteMessage other) {
      if (other == null) {
        return;
      }
      if (other.PlayerId.Length != 0) {
        PlayerId = other.PlayerId;
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
            PlayerId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code