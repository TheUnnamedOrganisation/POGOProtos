// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/SubmitNewPoiResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/SubmitNewPoiResponse.proto</summary>
  public static partial class SubmitNewPoiResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/SubmitNewPoiResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SubmitNewPoiResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1N1Ym1pdE5ld1Bv",
            "aVJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
            "c2VzIsgBChRTdWJtaXROZXdQb2lSZXNwb25zZRJMCgZzdGF0dXMYASABKA4y",
            "PC5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlN1Ym1pdE5ld1Bv",
            "aVJlc3BvbnNlLlN0YXR1cyJiCgZTdGF0dXMSCQoFVU5TRVQQABILCgdTVUND",
            "RVNTEAESCwoHRkFJTFVSRRACEhIKDklOVEVSTkFMX0VSUk9SEAMSHwobVE9P",
            "X01BTllfUkVDRU5UX1NVQk1JU1NJT05TEARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.SubmitNewPoiResponse), global::POGOProtos.Networking.Responses.SubmitNewPoiResponse.Parser, new[]{ "Status" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.SubmitNewPoiResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SubmitNewPoiResponse : pb::IMessage<SubmitNewPoiResponse> {
    private static readonly pb::MessageParser<SubmitNewPoiResponse> _parser = new pb::MessageParser<SubmitNewPoiResponse>(() => new SubmitNewPoiResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SubmitNewPoiResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.SubmitNewPoiResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitNewPoiResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitNewPoiResponse(SubmitNewPoiResponse other) : this() {
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubmitNewPoiResponse Clone() {
      return new SubmitNewPoiResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.SubmitNewPoiResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.SubmitNewPoiResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SubmitNewPoiResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SubmitNewPoiResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SubmitNewPoiResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
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
            status_ = (global::POGOProtos.Networking.Responses.SubmitNewPoiResponse.Types.Status) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SubmitNewPoiResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
        [pbr::OriginalName("INTERNAL_ERROR")] InternalError = 3,
        [pbr::OriginalName("TOO_MANY_RECENT_SUBMISSIONS")] TooManyRecentSubmissions = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
