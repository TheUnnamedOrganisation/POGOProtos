// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/Social/SaveSocialPlayerSettingsResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses.Social {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/Social/SaveSocialPlayerSettingsResponse.proto</summary>
  public static partial class SaveSocialPlayerSettingsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/Social/SaveSocialPlayerSettingsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SaveSocialPlayerSettingsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck1QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NvY2lhbC9TYXZl",
            "U29jaWFsUGxheWVyU2V0dGluZ3NSZXNwb25zZS5wcm90bxImUE9HT1Byb3Rv",
            "cy5OZXR3b3JraW5nLlJlc3BvbnNlcy5Tb2NpYWwiuAEKIFNhdmVTb2NpYWxQ",
            "bGF5ZXJTZXR0aW5nc1Jlc3BvbnNlEl8KBnJlc3VsdBgBIAEoDjJPLlBPR09Q",
            "cm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuU29jaWFsLlNhdmVTb2NpYWxQ",
            "bGF5ZXJTZXR0aW5nc1Jlc3BvbnNlLlJlc3VsdCIzCgZSZXN1bHQSCQoFVU5T",
            "RVQQABILCgdTVUNDRVNTEAESEQoNRVJST1JfVU5LTk9XThACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.Social.SaveSocialPlayerSettingsResponse), global::POGOProtos.Networking.Responses.Social.SaveSocialPlayerSettingsResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.Social.SaveSocialPlayerSettingsResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SaveSocialPlayerSettingsResponse : pb::IMessage<SaveSocialPlayerSettingsResponse> {
    private static readonly pb::MessageParser<SaveSocialPlayerSettingsResponse> _parser = new pb::MessageParser<SaveSocialPlayerSettingsResponse>(() => new SaveSocialPlayerSettingsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SaveSocialPlayerSettingsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.Social.SaveSocialPlayerSettingsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveSocialPlayerSettingsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveSocialPlayerSettingsResponse(SaveSocialPlayerSettingsResponse other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SaveSocialPlayerSettingsResponse Clone() {
      return new SaveSocialPlayerSettingsResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.Social.SaveSocialPlayerSettingsResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.Social.SaveSocialPlayerSettingsResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SaveSocialPlayerSettingsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SaveSocialPlayerSettingsResponse other) {
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
    public void MergeFrom(SaveSocialPlayerSettingsResponse other) {
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
            result_ = (global::POGOProtos.Networking.Responses.Social.SaveSocialPlayerSettingsResponse.Types.Result) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SaveSocialPlayerSettingsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_UNKNOWN")] ErrorUnknown = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
