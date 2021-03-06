// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Telemetry/PasscodeRedeemTelemetry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Telemetry {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Telemetry/PasscodeRedeemTelemetry.proto</summary>
  public static partial class PasscodeRedeemTelemetryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Telemetry/PasscodeRedeemTelemetry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PasscodeRedeemTelemetryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjdQT0dPUHJvdG9zL0RhdGEvVGVsZW1ldHJ5L1Bhc3Njb2RlUmVkZWVtVGVs",
            "ZW1ldHJ5LnByb3RvEhlQT0dPUHJvdG9zLkRhdGEuVGVsZW1ldHJ5IoABChdQ",
            "YXNzY29kZVJlZGVlbVRlbGVtZXRyeRIOCgZyZXN1bHQYASABKAkSEAoIcGFz",
            "c2NvZGUYAiABKAkSFAoMY291bnRyeV9jb2RlGAMgASgJEhUKDWxhbmd1YWdl",
            "X2NvZGUYBCABKAkSFgoOYnVuZGxlX3ZlcnNpb24YBSABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Telemetry.PasscodeRedeemTelemetry), global::POGOProtos.Data.Telemetry.PasscodeRedeemTelemetry.Parser, new[]{ "Result", "Passcode", "CountryCode", "LanguageCode", "BundleVersion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PasscodeRedeemTelemetry : pb::IMessage<PasscodeRedeemTelemetry> {
    private static readonly pb::MessageParser<PasscodeRedeemTelemetry> _parser = new pb::MessageParser<PasscodeRedeemTelemetry>(() => new PasscodeRedeemTelemetry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PasscodeRedeemTelemetry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Telemetry.PasscodeRedeemTelemetryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PasscodeRedeemTelemetry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PasscodeRedeemTelemetry(PasscodeRedeemTelemetry other) : this() {
      result_ = other.result_;
      passcode_ = other.passcode_;
      countryCode_ = other.countryCode_;
      languageCode_ = other.languageCode_;
      bundleVersion_ = other.bundleVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PasscodeRedeemTelemetry Clone() {
      return new PasscodeRedeemTelemetry(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private string result_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "passcode" field.</summary>
    public const int PasscodeFieldNumber = 2;
    private string passcode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Passcode {
      get { return passcode_; }
      set {
        passcode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "country_code" field.</summary>
    public const int CountryCodeFieldNumber = 3;
    private string countryCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CountryCode {
      get { return countryCode_; }
      set {
        countryCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 4;
    private string languageCode_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LanguageCode {
      get { return languageCode_; }
      set {
        languageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bundle_version" field.</summary>
    public const int BundleVersionFieldNumber = 5;
    private string bundleVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BundleVersion {
      get { return bundleVersion_; }
      set {
        bundleVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PasscodeRedeemTelemetry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PasscodeRedeemTelemetry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (Passcode != other.Passcode) return false;
      if (CountryCode != other.CountryCode) return false;
      if (LanguageCode != other.LanguageCode) return false;
      if (BundleVersion != other.BundleVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result.Length != 0) hash ^= Result.GetHashCode();
      if (Passcode.Length != 0) hash ^= Passcode.GetHashCode();
      if (CountryCode.Length != 0) hash ^= CountryCode.GetHashCode();
      if (LanguageCode.Length != 0) hash ^= LanguageCode.GetHashCode();
      if (BundleVersion.Length != 0) hash ^= BundleVersion.GetHashCode();
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
      if (Result.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Result);
      }
      if (Passcode.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Passcode);
      }
      if (CountryCode.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CountryCode);
      }
      if (LanguageCode.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LanguageCode);
      }
      if (BundleVersion.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(BundleVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (Passcode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Passcode);
      }
      if (CountryCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CountryCode);
      }
      if (LanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageCode);
      }
      if (BundleVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BundleVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PasscodeRedeemTelemetry other) {
      if (other == null) {
        return;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
      }
      if (other.Passcode.Length != 0) {
        Passcode = other.Passcode;
      }
      if (other.CountryCode.Length != 0) {
        CountryCode = other.CountryCode;
      }
      if (other.LanguageCode.Length != 0) {
        LanguageCode = other.LanguageCode;
      }
      if (other.BundleVersion.Length != 0) {
        BundleVersion = other.BundleVersion;
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
            Result = input.ReadString();
            break;
          }
          case 18: {
            Passcode = input.ReadString();
            break;
          }
          case 26: {
            CountryCode = input.ReadString();
            break;
          }
          case 34: {
            LanguageCode = input.ReadString();
            break;
          }
          case 42: {
            BundleVersion = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
