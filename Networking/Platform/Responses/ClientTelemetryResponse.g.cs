// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Platform/Responses/ClientTelemetryResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Platform/Responses/ClientTelemetryResponse.proto</summary>
  public static partial class ClientTelemetryResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Platform/Responses/ClientTelemetryResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientTelemetryResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZQT0dPUHJvdG9zL05ldHdvcmtpbmcvUGxhdGZvcm0vUmVzcG9uc2VzL0Ns",
            "aWVudFRlbGVtZXRyeVJlc3BvbnNlLnByb3RvEihQT0dPUHJvdG9zLk5ldHdv",
            "cmtpbmcuUGxhdGZvcm0uUmVzcG9uc2VzIooCChdDbGllbnRUZWxlbWV0cnlS",
            "ZXNwb25zZRJYCgZzdGF0dXMYASABKA4ySC5QT0dPUHJvdG9zLk5ldHdvcmtp",
            "bmcuUGxhdGZvcm0uUmVzcG9uc2VzLkNsaWVudFRlbGVtZXRyeVJlc3BvbnNl",
            "LlN0YXR1cxIUCgxyb3dzX3dyaXR0ZW4YAiABKAUifwoGU3RhdHVzEgkKBVVO",
            "U0VUEAASCwoHU1VDQ0VTUxABEgsKB0ZBSUxVUkUQAhIZChVFUlJPUl9JTlZB",
            "TElEX1JFUVVFU1QQAxIXChNFUlJPUl9JTlZBTElEX1BST1RPEAQSHAoYRVJS",
            "T1JfVU5TRVRfVEVMRU1FVFJZX0lEEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Responses.ClientTelemetryResponse), global::POGOProtos.Networking.Platform.Responses.ClientTelemetryResponse.Parser, new[]{ "Status", "RowsWritten" }, null, new[]{ typeof(global::POGOProtos.Networking.Platform.Responses.ClientTelemetryResponse.Types.Status) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientTelemetryResponse : pb::IMessage<ClientTelemetryResponse> {
    private static readonly pb::MessageParser<ClientTelemetryResponse> _parser = new pb::MessageParser<ClientTelemetryResponse>(() => new ClientTelemetryResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClientTelemetryResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Responses.ClientTelemetryResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryResponse(ClientTelemetryResponse other) : this() {
      status_ = other.status_;
      rowsWritten_ = other.rowsWritten_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClientTelemetryResponse Clone() {
      return new ClientTelemetryResponse(this);
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 1;
    private global::POGOProtos.Networking.Platform.Responses.ClientTelemetryResponse.Types.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Platform.Responses.ClientTelemetryResponse.Types.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "rows_written" field.</summary>
    public const int RowsWrittenFieldNumber = 2;
    private int rowsWritten_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RowsWritten {
      get { return rowsWritten_; }
      set {
        rowsWritten_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClientTelemetryResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClientTelemetryResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Status != other.Status) return false;
      if (RowsWritten != other.RowsWritten) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Status != 0) hash ^= Status.GetHashCode();
      if (RowsWritten != 0) hash ^= RowsWritten.GetHashCode();
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
      if (RowsWritten != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(RowsWritten);
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
      if (RowsWritten != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RowsWritten);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClientTelemetryResponse other) {
      if (other == null) {
        return;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.RowsWritten != 0) {
        RowsWritten = other.RowsWritten;
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
            status_ = (global::POGOProtos.Networking.Platform.Responses.ClientTelemetryResponse.Types.Status) input.ReadEnum();
            break;
          }
          case 16: {
            RowsWritten = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ClientTelemetryResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Status {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
        [pbr::OriginalName("ERROR_INVALID_REQUEST")] ErrorInvalidRequest = 3,
        [pbr::OriginalName("ERROR_INVALID_PROTO")] ErrorInvalidProto = 4,
        [pbr::OriginalName("ERROR_UNSET_TELEMETRY_ID")] ErrorUnsetTelemetryId = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
