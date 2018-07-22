// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Logs/OpenGiftLogEntry.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Logs {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/OpenGiftLogEntry.proto</summary>
  public static partial class OpenGiftLogEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Logs/OpenGiftLogEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OpenGiftLogEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitQT0dPUHJvdG9zL0RhdGEvTG9ncy9PcGVuR2lmdExvZ0VudHJ5LnByb3Rv",
            "EhRQT0dPUHJvdG9zLkRhdGEuTG9ncxohUE9HT1Byb3Rvcy9EYXRhL1Bva2Vt",
            "b25EYXRhLnByb3RvGh9QT0dPUHJvdG9zL0ludmVudG9yeS9Mb290LnByb3Rv",
            "IusBChBPcGVuR2lmdExvZ0VudHJ5Ej0KBnJlc3VsdBgBIAEoDjItLlBPR09Q",
            "cm90b3MuRGF0YS5Mb2dzLk9wZW5HaWZ0TG9nRW50cnkuUmVzdWx0EhcKD2Zy",
            "aWVuZF9jb2RlbmFtZRgCIAEoCRIpCgVpdGVtcxgDIAEoCzIaLlBPR09Qcm90",
            "b3MuSW52ZW50b3J5Lkxvb3QSMgoMcG9rZW1vbl9lZ2dzGAQgAygLMhwuUE9H",
            "T1Byb3Rvcy5EYXRhLlBva2Vtb25EYXRhIiAKBlJlc3VsdBIJCgVVTlNFVBAA",
            "EgsKB1NVQ0NFU1MQAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, global::POGOProtos.Inventory.LootReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Logs.OpenGiftLogEntry), global::POGOProtos.Data.Logs.OpenGiftLogEntry.Parser, new[]{ "Result", "FriendCodename", "Items", "PokemonEggs" }, null, new[]{ typeof(global::POGOProtos.Data.Logs.OpenGiftLogEntry.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class OpenGiftLogEntry : pb::IMessage<OpenGiftLogEntry> {
    private static readonly pb::MessageParser<OpenGiftLogEntry> _parser = new pb::MessageParser<OpenGiftLogEntry>(() => new OpenGiftLogEntry());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OpenGiftLogEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Logs.OpenGiftLogEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenGiftLogEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenGiftLogEntry(OpenGiftLogEntry other) : this() {
      result_ = other.result_;
      friendCodename_ = other.friendCodename_;
      items_ = other.items_ != null ? other.items_.Clone() : null;
      pokemonEggs_ = other.pokemonEggs_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OpenGiftLogEntry Clone() {
      return new OpenGiftLogEntry(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Data.Logs.OpenGiftLogEntry.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Logs.OpenGiftLogEntry.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "friend_codename" field.</summary>
    public const int FriendCodenameFieldNumber = 2;
    private string friendCodename_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FriendCodename {
      get { return friendCodename_; }
      set {
        friendCodename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "items" field.</summary>
    public const int ItemsFieldNumber = 3;
    private global::POGOProtos.Inventory.Loot items_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Inventory.Loot Items {
      get { return items_; }
      set {
        items_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_eggs" field.</summary>
    public const int PokemonEggsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.PokemonData> _repeated_pokemonEggs_codec
        = pb::FieldCodec.ForMessage(34, global::POGOProtos.Data.PokemonData.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.PokemonData> pokemonEggs_ = new pbc::RepeatedField<global::POGOProtos.Data.PokemonData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.PokemonData> PokemonEggs {
      get { return pokemonEggs_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OpenGiftLogEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OpenGiftLogEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (FriendCodename != other.FriendCodename) return false;
      if (!object.Equals(Items, other.Items)) return false;
      if(!pokemonEggs_.Equals(other.pokemonEggs_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (FriendCodename.Length != 0) hash ^= FriendCodename.GetHashCode();
      if (items_ != null) hash ^= Items.GetHashCode();
      hash ^= pokemonEggs_.GetHashCode();
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
      if (FriendCodename.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FriendCodename);
      }
      if (items_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Items);
      }
      pokemonEggs_.WriteTo(output, _repeated_pokemonEggs_codec);
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
      if (FriendCodename.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FriendCodename);
      }
      if (items_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Items);
      }
      size += pokemonEggs_.CalculateSize(_repeated_pokemonEggs_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OpenGiftLogEntry other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.FriendCodename.Length != 0) {
        FriendCodename = other.FriendCodename;
      }
      if (other.items_ != null) {
        if (items_ == null) {
          items_ = new global::POGOProtos.Inventory.Loot();
        }
        Items.MergeFrom(other.Items);
      }
      pokemonEggs_.Add(other.pokemonEggs_);
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
            result_ = (global::POGOProtos.Data.Logs.OpenGiftLogEntry.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            FriendCodename = input.ReadString();
            break;
          }
          case 26: {
            if (items_ == null) {
              items_ = new global::POGOProtos.Inventory.Loot();
            }
            input.ReadMessage(items_);
            break;
          }
          case 34: {
            pokemonEggs_.AddEntriesFrom(input, _repeated_pokemonEggs_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the OpenGiftLogEntry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code