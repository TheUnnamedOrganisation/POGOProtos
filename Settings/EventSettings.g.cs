// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Settings/EventSettings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/EventSettings.proto</summary>
  public static partial class EventSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/EventSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EventSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL1NldHRpbmdzL0V2ZW50U2V0dGluZ3MucHJvdG8SE1BP",
            "R09Qcm90b3MuU2V0dGluZ3MiMgoNRXZlbnRTZXR0aW5ncxIhChljb25kb2xl",
            "bmNlX3JpYmJvbl9jb3VudHJ5GAEgAygJYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.EventSettings), global::POGOProtos.Settings.EventSettings.Parser, new[]{ "CondolenceRibbonCountry" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EventSettings : pb::IMessage<EventSettings> {
    private static readonly pb::MessageParser<EventSettings> _parser = new pb::MessageParser<EventSettings>(() => new EventSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EventSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.EventSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventSettings(EventSettings other) : this() {
      condolenceRibbonCountry_ = other.condolenceRibbonCountry_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EventSettings Clone() {
      return new EventSettings(this);
    }

    /// <summary>Field number for the "condolence_ribbon_country" field.</summary>
    public const int CondolenceRibbonCountryFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_condolenceRibbonCountry_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> condolenceRibbonCountry_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> CondolenceRibbonCountry {
      get { return condolenceRibbonCountry_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EventSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EventSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!condolenceRibbonCountry_.Equals(other.condolenceRibbonCountry_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= condolenceRibbonCountry_.GetHashCode();
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
      condolenceRibbonCountry_.WriteTo(output, _repeated_condolenceRibbonCountry_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += condolenceRibbonCountry_.CalculateSize(_repeated_condolenceRibbonCountry_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EventSettings other) {
      if (other == null) {
        return;
      }
      condolenceRibbonCountry_.Add(other.condolenceRibbonCountry_);
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
            condolenceRibbonCountry_.AddEntriesFrom(input, _repeated_condolenceRibbonCountry_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
