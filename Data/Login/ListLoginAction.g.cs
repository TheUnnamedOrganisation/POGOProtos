// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Login/ListLoginAction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Login {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Login/ListLoginAction.proto</summary>
  public static partial class ListLoginActionReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Login/ListLoginAction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListLoginActionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL0RhdGEvTG9naW4vTGlzdExvZ2luQWN0aW9uLnByb3Rv",
            "EhVQT0dPUHJvdG9zLkRhdGEuTG9naW4aJ1BPR09Qcm90b3MvRGF0YS9Mb2dp",
            "bi9Mb2dpbkRldGFpbC5wcm90byJkChdMaXN0TG9naW5BY3Rpb25SZXNwb25z",
            "ZRIPCgdzdWNjZXNzGAEgASgIEjgKDGxvZ2luX2RldGFpbBgCIAMoCzIiLlBP",
            "R09Qcm90b3MuRGF0YS5Mb2dpbi5Mb2dpbkRldGFpbGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Login.LoginDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Login.ListLoginActionResponse), global::POGOProtos.Data.Login.ListLoginActionResponse.Parser, new[]{ "Success", "LoginDetail" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListLoginActionResponse : pb::IMessage<ListLoginActionResponse> {
    private static readonly pb::MessageParser<ListLoginActionResponse> _parser = new pb::MessageParser<ListLoginActionResponse>(() => new ListLoginActionResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListLoginActionResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Login.ListLoginActionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLoginActionResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLoginActionResponse(ListLoginActionResponse other) : this() {
      success_ = other.success_;
      loginDetail_ = other.loginDetail_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLoginActionResponse Clone() {
      return new ListLoginActionResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "login_detail" field.</summary>
    public const int LoginDetailFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.Login.LoginDetail> _repeated_loginDetail_codec
        = pb::FieldCodec.ForMessage(18, global::POGOProtos.Data.Login.LoginDetail.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.Login.LoginDetail> loginDetail_ = new pbc::RepeatedField<global::POGOProtos.Data.Login.LoginDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.Login.LoginDetail> LoginDetail {
      get { return loginDetail_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListLoginActionResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListLoginActionResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if(!loginDetail_.Equals(other.loginDetail_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      hash ^= loginDetail_.GetHashCode();
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
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      loginDetail_.WriteTo(output, _repeated_loginDetail_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      size += loginDetail_.CalculateSize(_repeated_loginDetail_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListLoginActionResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      loginDetail_.Add(other.loginDetail_);
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
            Success = input.ReadBool();
            break;
          }
          case 18: {
            loginDetail_.AddEntriesFrom(input, _repeated_loginDetail_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
