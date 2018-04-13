// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/RegisterBackgroundDeviceResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/RegisterBackgroundDeviceResponse.proto</summary>
  public static partial class RegisterBackgroundDeviceResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/RegisterBackgroundDeviceResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RegisterBackgroundDeviceResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1JlZ2lzdGVyQmFj",
            "a2dyb3VuZERldmljZVJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdv",
            "cmtpbmcuUmVzcG9uc2VzGiVQT0dPUHJvdG9zL0RhdGEvQmFja2dyb3VuZFRv",
            "a2VuLnByb3RvItoBCiBSZWdpc3RlckJhY2tncm91bmREZXZpY2VSZXNwb25z",
            "ZRJYCgZzdGF0dXMYASABKA4ySC5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzLlJlZ2lzdGVyQmFja2dyb3VuZERldmljZVJlc3BvbnNlLlN0YXR1",
            "cxIvCgV0b2tlbhgCIAEoCzIgLlBPR09Qcm90b3MuRGF0YS5CYWNrZ3JvdW5k",
            "VG9rZW4iKwoGU3RhdHVzEgkKBVVOU0VUEAASCwoHU1VDQ0VTUxABEgkKBUVS",
            "Uk9SEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.BackgroundTokenReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.RegisterBackgroundDeviceResponse), global::POGOProtos.Networking.Responses.RegisterBackgroundDeviceResponse.Parser, new[]{ "Status", "Token" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.RegisterBackgroundDeviceResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class RegisterBackgroundDeviceResponse : pb::IMessage<RegisterBackgroundDeviceResponse> {
    private static readonly pb::MessageParser<RegisterBackgroundDeviceResponse> _parser = new pb::MessageParser<RegisterBackgroundDeviceResponse>(() => new RegisterBackgroundDeviceResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RegisterBackgroundDeviceResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.RegisterBackgroundDeviceResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterBackgroundDeviceResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterBackgroundDeviceResponse(RegisterBackgroundDeviceResponse other) : this() {
      status_ = other.status_;
      Token = other.token_ != null ? other.Token.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RegisterBackgroundDeviceResponse Clone() {
      return new RegisterBackgroundDeviceResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.RegisterBackgroundDeviceResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.RegisterBackgroundDeviceResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "token" field.</summary>
    public const int TokenFieldNumber = 2;
    private global::POGOProtos.Data.BackgroundToken token_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.BackgroundToken Token {
      get { return token_; }
      set {
        token_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RegisterBackgroundDeviceResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RegisterBackgroundDeviceResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (!object.Equals(Token, other.Token)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (token_ != null) hash ^= Token.GetHashCode();
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
      if (Status != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Status);
      }
      if (token_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Token);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (token_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Token);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RegisterBackgroundDeviceResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.token_ != null) {
        if (token_ == null) {
          token_ = new global::POGOProtos.Data.BackgroundToken();
        }
        Token.MergeFrom(other.Token);
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
            status_ = (global::POGOProtos.Networking.Responses.RegisterBackgroundDeviceResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 18: {
            if (token_ == null) {
              token_ = new global::POGOProtos.Data.BackgroundToken();
            }
            input.ReadMessage(token_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the RegisterBackgroundDeviceResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR")] Error = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
