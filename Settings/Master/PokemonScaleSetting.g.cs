// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Settings/Master/PokemonScaleSetting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/PokemonScaleSetting.proto</summary>
  public static partial class PokemonScaleSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/PokemonScaleSetting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonScaleSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uU2NhbGVTZXR0",
            "aW5nLnByb3RvEhpQT0dPUHJvdG9zLlNldHRpbmdzLk1hc3RlciKkAgoTUG9r",
            "ZW1vblNjYWxlU2V0dGluZxJcChJwb2tlbW9uX3NjYWxlX21vZGUYASABKA4y",
            "QC5QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5Qb2tlbW9uU2NhbGVTZXR0",
            "aW5nLlBva2Vtb25TY2FsZU1vZGUSEgoKbWluX2hlaWdodBgCIAEoAhISCgpt",
            "YXhfaGVpZ2h0GAMgASgCIoYBChBQb2tlbW9uU2NhbGVNb2RlEhAKDE5hdHVy",
            "YWxTY2FsZRAAEgwKCEd1aVNjYWxlEAESFgoSQmF0dGxlUG9rZW1vblNjYWxl",
            "EAISEQoNUmFpZEJvc3NTY2FsZRADEhIKDkd5bVRvcHBlclNjYWxlEAQSEwoP",
            "TWFwUG9rZW1vblNjYWxlEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.PokemonScaleSetting), global::POGOProtos.Settings.Master.PokemonScaleSetting.Parser, new[]{ "PokemonScaleMode", "MinHeight", "MaxHeight" }, null, new[]{ typeof(global::POGOProtos.Settings.Master.PokemonScaleSetting.Types.PokemonScaleMode) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PokemonScaleSetting : pb::IMessage<PokemonScaleSetting> {
    private static readonly pb::MessageParser<PokemonScaleSetting> _parser = new pb::MessageParser<PokemonScaleSetting>(() => new PokemonScaleSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PokemonScaleSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.PokemonScaleSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonScaleSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonScaleSetting(PokemonScaleSetting other) : this() {
      pokemonScaleMode_ = other.pokemonScaleMode_;
      minHeight_ = other.minHeight_;
      maxHeight_ = other.maxHeight_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokemonScaleSetting Clone() {
      return new PokemonScaleSetting(this);
    }

    /// <summary>Field number for the "pokemon_scale_mode" field.</summary>
    public const int PokemonScaleModeFieldNumber = 1;
    private global::POGOProtos.Settings.Master.PokemonScaleSetting.Types.PokemonScaleMode pokemonScaleMode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Settings.Master.PokemonScaleSetting.Types.PokemonScaleMode PokemonScaleMode {
      get { return pokemonScaleMode_; }
      set {
        pokemonScaleMode_ = value;
      }
    }

    /// <summary>Field number for the "min_height" field.</summary>
    public const int MinHeightFieldNumber = 2;
    private float minHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float MinHeight {
      get { return minHeight_; }
      set {
        minHeight_ = value;
      }
    }

    /// <summary>Field number for the "max_height" field.</summary>
    public const int MaxHeightFieldNumber = 3;
    private float maxHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float MaxHeight {
      get { return maxHeight_; }
      set {
        maxHeight_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PokemonScaleSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PokemonScaleSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonScaleMode != other.PokemonScaleMode) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MinHeight, other.MinHeight)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MaxHeight, other.MaxHeight)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PokemonScaleMode != 0) hash ^= PokemonScaleMode.GetHashCode();
      if (MinHeight != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MinHeight);
      if (MaxHeight != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MaxHeight);
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
      if (PokemonScaleMode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) PokemonScaleMode);
      }
      if (MinHeight != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(MinHeight);
      }
      if (MaxHeight != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(MaxHeight);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PokemonScaleMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonScaleMode);
      }
      if (MinHeight != 0F) {
        size += 1 + 4;
      }
      if (MaxHeight != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PokemonScaleSetting other) {
      if (other == null) {
        return;
      }
      if (other.PokemonScaleMode != 0) {
        PokemonScaleMode = other.PokemonScaleMode;
      }
      if (other.MinHeight != 0F) {
        MinHeight = other.MinHeight;
      }
      if (other.MaxHeight != 0F) {
        MaxHeight = other.MaxHeight;
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
            pokemonScaleMode_ = (global::POGOProtos.Settings.Master.PokemonScaleSetting.Types.PokemonScaleMode) input.ReadEnum();
            break;
          }
          case 21: {
            MinHeight = input.ReadFloat();
            break;
          }
          case 29: {
            MaxHeight = input.ReadFloat();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the PokemonScaleSetting message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum PokemonScaleMode {
        [pbr::OriginalName("NaturalScale")] NaturalScale = 0,
        [pbr::OriginalName("GuiScale")] GuiScale = 1,
        [pbr::OriginalName("BattlePokemonScale")] BattlePokemonScale = 2,
        [pbr::OriginalName("RaidBossScale")] RaidBossScale = 3,
        [pbr::OriginalName("GymTopperScale")] GymTopperScale = 4,
        [pbr::OriginalName("MapPokemonScale")] MapPokemonScale = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code