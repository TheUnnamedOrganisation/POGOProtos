// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/UseItemXpBoostResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemXpBoostResponse.proto</summary>
  public static partial class UseItemXpBoostResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemXpBoostResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UseItemXpBoostResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1YcEJv",
            "b3N0UmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
            "b25zZXMaJ1BPR09Qcm90b3MvSW52ZW50b3J5L0FwcGxpZWRJdGVtcy5wcm90",
            "byK+AgoWVXNlSXRlbVhwQm9vc3RSZXNwb25zZRJOCgZyZXN1bHQYASABKA4y",
            "Pi5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlVzZUl0ZW1YcEJv",
            "b3N0UmVzcG9uc2UuUmVzdWx0EjkKDWFwcGxpZWRfaXRlbXMYAiABKAsyIi5Q",
            "T0dPUHJvdG9zLkludmVudG9yeS5BcHBsaWVkSXRlbXMimAEKBlJlc3VsdBIJ",
            "CgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIbChdFUlJPUl9JTlZBTElEX0lURU1f",
            "VFlQRRACEiEKHUVSUk9SX1hQX0JPT1NUX0FMUkVBRFlfQUNUSVZFEAMSHAoY",
            "RVJST1JfTk9fSVRFTVNfUkVNQUlOSU5HEAQSGAoURVJST1JfTE9DQVRJT05f",
            "VU5TRVQQBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.AppliedItemsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.UseItemXpBoostResponse), global::POGOProtos.Networking.Responses.UseItemXpBoostResponse.Parser, new[]{ "Result", "AppliedItems" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.UseItemXpBoostResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UseItemXpBoostResponse : pb::IMessage<UseItemXpBoostResponse> {
    private static readonly pb::MessageParser<UseItemXpBoostResponse> _parser = new pb::MessageParser<UseItemXpBoostResponse>(() => new UseItemXpBoostResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UseItemXpBoostResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.UseItemXpBoostResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemXpBoostResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemXpBoostResponse(UseItemXpBoostResponse other) : this() {
      result_ = other.result_;
      AppliedItems = other.appliedItems_ != null ? other.AppliedItems.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UseItemXpBoostResponse Clone() {
      return new UseItemXpBoostResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.UseItemXpBoostResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.UseItemXpBoostResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "applied_items" field.</summary>
    public const int AppliedItemsFieldNumber = 2;
    private global::POGOProtos.Inventory.AppliedItems appliedItems_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.AppliedItems AppliedItems {
      get { return appliedItems_; }
      set {
        appliedItems_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UseItemXpBoostResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UseItemXpBoostResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(AppliedItems, other.AppliedItems)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (appliedItems_ != null) hash ^= AppliedItems.GetHashCode();
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
      if (appliedItems_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AppliedItems);
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
      if (appliedItems_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppliedItems);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UseItemXpBoostResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.appliedItems_ != null) {
        if (appliedItems_ == null) {
          appliedItems_ = new global::POGOProtos.Inventory.AppliedItems();
        }
        AppliedItems.MergeFrom(other.AppliedItems);
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
            result_ = (global::POGOProtos.Networking.Responses.UseItemXpBoostResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (appliedItems_ == null) {
              appliedItems_ = new global::POGOProtos.Inventory.AppliedItems();
            }
            input.ReadMessage(appliedItems_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the UseItemXpBoostResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_INVALID_ITEM_TYPE")] ErrorInvalidItemType = 2,
        [pbr::OriginalName("ERROR_XP_BOOST_ALREADY_ACTIVE")] ErrorXpBoostAlreadyActive = 3,
        [pbr::OriginalName("ERROR_NO_ITEMS_REMAINING")] ErrorNoItemsRemaining = 4,
        [pbr::OriginalName("ERROR_LOCATION_UNSET")] ErrorLocationUnset = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
