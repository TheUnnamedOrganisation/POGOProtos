// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/Social/InviteFacebookFriendResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses.Social {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/Social/InviteFacebookFriendResponse.proto</summary>
  public static partial class InviteFacebookFriendResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/Social/InviteFacebookFriendResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InviteFacebookFriendResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CklQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NvY2lhbC9JbnZp",
            "dGVGYWNlYm9va0ZyaWVuZFJlc3BvbnNlLnByb3RvEiZQT0dPUHJvdG9zLk5l",
            "dHdvcmtpbmcuUmVzcG9uc2VzLlNvY2lhbCKpAgocSW52aXRlRmFjZWJvb2tG",
            "cmllbmRSZXNwb25zZRJbCgZyZXN1bHQYASABKA4ySy5QT0dPUHJvdG9zLk5l",
            "dHdvcmtpbmcuUmVzcG9uc2VzLlNvY2lhbC5JbnZpdGVGYWNlYm9va0ZyaWVu",
            "ZFJlc3BvbnNlLlJlc3VsdCKrAQoGUmVzdWx0EgkKBVVOU0VUEAASCwoHU1VD",
            "Q0VTUxABEhEKDUVSUk9SX1VOS05PV04QAhIaChZFUlJPUl9BTFJFQURZX0Ff",
            "RlJJRU5EEAMSHwobRVJST1JfUExBWUVSX0RPRVNfTk9UX0VYSVNUEAQSGwoX",
            "RVJST1JfUExBWUVSX0lOQk9YX0ZVTEwQBRIcChhFUlJPUl9QTEFZRVJfT1VU",
            "Qk9YX0ZVTEwQBmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.Social.InviteFacebookFriendResponse), global::POGOProtos.Networking.Responses.Social.InviteFacebookFriendResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.Social.InviteFacebookFriendResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InviteFacebookFriendResponse : pb::IMessage<InviteFacebookFriendResponse> {
    private static readonly pb::MessageParser<InviteFacebookFriendResponse> _parser = new pb::MessageParser<InviteFacebookFriendResponse>(() => new InviteFacebookFriendResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InviteFacebookFriendResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.Social.InviteFacebookFriendResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InviteFacebookFriendResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InviteFacebookFriendResponse(InviteFacebookFriendResponse other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InviteFacebookFriendResponse Clone() {
      return new InviteFacebookFriendResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.Social.InviteFacebookFriendResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.Social.InviteFacebookFriendResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InviteFacebookFriendResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InviteFacebookFriendResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InviteFacebookFriendResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
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
            result_ = (global::POGOProtos.Networking.Responses.Social.InviteFacebookFriendResponse.Types.Result) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the InviteFacebookFriendResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_UNKNOWN")] ErrorUnknown = 2,
        [pbr::OriginalName("ERROR_ALREADY_A_FRIEND")] ErrorAlreadyAFriend = 3,
        [pbr::OriginalName("ERROR_PLAYER_DOES_NOT_EXIST")] ErrorPlayerDoesNotExist = 4,
        [pbr::OriginalName("ERROR_PLAYER_INBOX_FULL")] ErrorPlayerInboxFull = 5,
        [pbr::OriginalName("ERROR_PLAYER_OUTBOX_FULL")] ErrorPlayerOutboxFull = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
