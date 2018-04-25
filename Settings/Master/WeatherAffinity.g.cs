// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Settings/Master/WeatherAffinity.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/WeatherAffinity.proto</summary>
  public static partial class WeatherAffinityReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/WeatherAffinity.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WeatherAffinityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9XZWF0aGVyQWZmaW5pdHku",
            "cHJvdG8SGlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyGiJQT0dPUHJvdG9z",
            "L0VudW1zL1Bva2Vtb25UeXBlLnByb3RvGidQT0dPUHJvdG9zL0VudW1zL1dl",
            "YXRoZXJDb25kaXRpb24ucHJvdG8ihQEKD1dlYXRoZXJBZmZpbml0eRI9ChF3",
            "ZWF0aGVyX2NvbmRpdGlvbhgBIAEoDjIiLlBPR09Qcm90b3MuRW51bXMuV2Vh",
            "dGhlckNvbmRpdGlvbhIzCgxwb2tlbW9uX3R5cGUYAiADKA4yHS5QT0dPUHJv",
            "dG9zLkVudW1zLlBva2Vtb25UeXBlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonTypeReflection.Descriptor, global::POGOProtos.Enums.WeatherConditionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.WeatherAffinity), global::POGOProtos.Settings.Master.WeatherAffinity.Parser, new[]{ "WeatherCondition", "PokemonType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class WeatherAffinity : pb::IMessage<WeatherAffinity> {
    private static readonly pb::MessageParser<WeatherAffinity> _parser = new pb::MessageParser<WeatherAffinity>(() => new WeatherAffinity());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<WeatherAffinity> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.WeatherAffinityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherAffinity() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherAffinity(WeatherAffinity other) : this() {
      weatherCondition_ = other.weatherCondition_;
      pokemonType_ = other.pokemonType_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public WeatherAffinity Clone() {
      return new WeatherAffinity(this);
    }

    /// <summary>Field number for the "weather_condition" field.</summary>
    public const int WeatherConditionFieldNumber = 1;
    private global::POGOProtos.Enums.WeatherCondition weatherCondition_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.WeatherCondition WeatherCondition {
      get { return weatherCondition_; }
      set {
        weatherCondition_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_type" field.</summary>
    public const int PokemonTypeFieldNumber = 2;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.PokemonType> _repeated_pokemonType_codec
        = pb::FieldCodec.ForEnum(18, x => (int) x, x => (global::POGOProtos.Enums.PokemonType) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.PokemonType> pokemonType_ = new pbc::RepeatedField<global::POGOProtos.Enums.PokemonType>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.PokemonType> PokemonType {
      get { return pokemonType_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as WeatherAffinity);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(WeatherAffinity other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (WeatherCondition != other.WeatherCondition) return false;
      if(!pokemonType_.Equals(other.pokemonType_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (WeatherCondition != 0) hash ^= WeatherCondition.GetHashCode();
      hash ^= pokemonType_.GetHashCode();
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
      if (WeatherCondition != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) WeatherCondition);
      }
      pokemonType_.WriteTo(output, _repeated_pokemonType_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (WeatherCondition != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) WeatherCondition);
      }
      size += pokemonType_.CalculateSize(_repeated_pokemonType_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(WeatherAffinity other) {
      if (other == null) {
        return;
      }
      if (other.WeatherCondition != 0) {
        WeatherCondition = other.WeatherCondition;
      }
      pokemonType_.Add(other.pokemonType_);
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
            weatherCondition_ = (global::POGOProtos.Enums.WeatherCondition) input.ReadEnum();
            break;
          }
          case 18:
          case 16: {
            pokemonType_.AddEntriesFrom(input, _repeated_pokemonType_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code