// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Responses/NicknamePokemonResponse.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/NicknamePokemonResponse.proto</summary>
  public static partial class NicknamePokemonResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/NicknamePokemonResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NicknamePokemonResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL05pY2tuYW1lUG9r",
            "ZW1vblJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVz",
            "cG9uc2VzIt8BChdOaWNrbmFtZVBva2Vtb25SZXNwb25zZRJPCgZyZXN1bHQY",
            "ASABKA4yPy5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLk5pY2tu",
            "YW1lUG9rZW1vblJlc3BvbnNlLlJlc3VsdCJzCgZSZXN1bHQSCQoFVU5TRVQQ",
            "ABILCgdTVUNDRVNTEAESGgoWRVJST1JfSU5WQUxJRF9OSUNLTkFNRRACEhsK",
            "F0VSUk9SX1BPS0VNT05fTk9UX0ZPVU5EEAMSGAoURVJST1JfUE9LRU1PTl9J",
            "U19FR0cQBGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.NicknamePokemonResponse), global::POGOProtos.Networking.Responses.NicknamePokemonResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.NicknamePokemonResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NicknamePokemonResponse : pb::IMessage<NicknamePokemonResponse> {
    private static readonly pb::MessageParser<NicknamePokemonResponse> _parser = new pb::MessageParser<NicknamePokemonResponse>(() => new NicknamePokemonResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NicknamePokemonResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.NicknamePokemonResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NicknamePokemonResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NicknamePokemonResponse(NicknamePokemonResponse other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NicknamePokemonResponse Clone() {
      return new NicknamePokemonResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.NicknamePokemonResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.NicknamePokemonResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NicknamePokemonResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NicknamePokemonResponse other) {
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
    public void MergeFrom(NicknamePokemonResponse other) {
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
            result_ = (global::POGOProtos.Networking.Responses.NicknamePokemonResponse.Types.Result) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the NicknamePokemonResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("ERROR_INVALID_NICKNAME")] ErrorInvalidNickname = 2,
        [pbr::OriginalName("ERROR_POKEMON_NOT_FOUND")] ErrorPokemonNotFound = 3,
        [pbr::OriginalName("ERROR_POKEMON_IS_EGG")] ErrorPokemonIsEgg = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
