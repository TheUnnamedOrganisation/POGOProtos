// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Settings/GpsSettings.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/GpsSettings.proto</summary>
  public static partial class GpsSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/GpsSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GpsSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQT0dPUHJvdG9zL1NldHRpbmdzL0dwc1NldHRpbmdzLnByb3RvEhNQT0dP",
            "UHJvdG9zLlNldHRpbmdzIrsBCgtHcHNTZXR0aW5ncxIvCidkcml2aW5nX3dh",
            "cm5pbmdfc3BlZWRfbWV0ZXJzX3Blcl9zZWNvbmQYASABKAISKAogZHJpdmlu",
            "Z193YXJuaW5nX2Nvb2xkb3duX21pbnV0ZXMYAiABKAISLQolZHJpdmluZ19z",
            "cGVlZF9zYW1wbGVfaW50ZXJ2YWxfc2Vjb25kcxgDIAEoAhIiChpkcml2aW5n",
            "X3NwZWVkX3NhbXBsZV9jb3VudBgEIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.GpsSettings), global::POGOProtos.Settings.GpsSettings.Parser, new[]{ "DrivingWarningSpeedMetersPerSecond", "DrivingWarningCooldownMinutes", "DrivingSpeedSampleIntervalSeconds", "DrivingSpeedSampleCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GpsSettings : pb::IMessage<GpsSettings> {
    private static readonly pb::MessageParser<GpsSettings> _parser = new pb::MessageParser<GpsSettings>(() => new GpsSettings());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GpsSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.GpsSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GpsSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GpsSettings(GpsSettings other) : this() {
      drivingWarningSpeedMetersPerSecond_ = other.drivingWarningSpeedMetersPerSecond_;
      drivingWarningCooldownMinutes_ = other.drivingWarningCooldownMinutes_;
      drivingSpeedSampleIntervalSeconds_ = other.drivingSpeedSampleIntervalSeconds_;
      drivingSpeedSampleCount_ = other.drivingSpeedSampleCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GpsSettings Clone() {
      return new GpsSettings(this);
    }

    /// <summary>Field number for the "driving_warning_speed_meters_per_second" field.</summary>
    public const int DrivingWarningSpeedMetersPerSecondFieldNumber = 1;
    private float drivingWarningSpeedMetersPerSecond_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DrivingWarningSpeedMetersPerSecond {
      get { return drivingWarningSpeedMetersPerSecond_; }
      set {
        drivingWarningSpeedMetersPerSecond_ = value;
      }
    }

    /// <summary>Field number for the "driving_warning_cooldown_minutes" field.</summary>
    public const int DrivingWarningCooldownMinutesFieldNumber = 2;
    private float drivingWarningCooldownMinutes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DrivingWarningCooldownMinutes {
      get { return drivingWarningCooldownMinutes_; }
      set {
        drivingWarningCooldownMinutes_ = value;
      }
    }

    /// <summary>Field number for the "driving_speed_sample_interval_seconds" field.</summary>
    public const int DrivingSpeedSampleIntervalSecondsFieldNumber = 3;
    private float drivingSpeedSampleIntervalSeconds_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DrivingSpeedSampleIntervalSeconds {
      get { return drivingSpeedSampleIntervalSeconds_; }
      set {
        drivingSpeedSampleIntervalSeconds_ = value;
      }
    }

    /// <summary>Field number for the "driving_speed_sample_count" field.</summary>
    public const int DrivingSpeedSampleCountFieldNumber = 4;
    private int drivingSpeedSampleCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int DrivingSpeedSampleCount {
      get { return drivingSpeedSampleCount_; }
      set {
        drivingSpeedSampleCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GpsSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GpsSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DrivingWarningSpeedMetersPerSecond, other.DrivingWarningSpeedMetersPerSecond)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DrivingWarningCooldownMinutes, other.DrivingWarningCooldownMinutes)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(DrivingSpeedSampleIntervalSeconds, other.DrivingSpeedSampleIntervalSeconds)) return false;
      if (DrivingSpeedSampleCount != other.DrivingSpeedSampleCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (DrivingWarningSpeedMetersPerSecond != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DrivingWarningSpeedMetersPerSecond);
      if (DrivingWarningCooldownMinutes != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DrivingWarningCooldownMinutes);
      if (DrivingSpeedSampleIntervalSeconds != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(DrivingSpeedSampleIntervalSeconds);
      if (DrivingSpeedSampleCount != 0) hash ^= DrivingSpeedSampleCount.GetHashCode();
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
      if (DrivingWarningSpeedMetersPerSecond != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(DrivingWarningSpeedMetersPerSecond);
      }
      if (DrivingWarningCooldownMinutes != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(DrivingWarningCooldownMinutes);
      }
      if (DrivingSpeedSampleIntervalSeconds != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(DrivingSpeedSampleIntervalSeconds);
      }
      if (DrivingSpeedSampleCount != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(DrivingSpeedSampleCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (DrivingWarningSpeedMetersPerSecond != 0F) {
        size += 1 + 4;
      }
      if (DrivingWarningCooldownMinutes != 0F) {
        size += 1 + 4;
      }
      if (DrivingSpeedSampleIntervalSeconds != 0F) {
        size += 1 + 4;
      }
      if (DrivingSpeedSampleCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DrivingSpeedSampleCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GpsSettings other) {
      if (other == null) {
        return;
      }
      if (other.DrivingWarningSpeedMetersPerSecond != 0F) {
        DrivingWarningSpeedMetersPerSecond = other.DrivingWarningSpeedMetersPerSecond;
      }
      if (other.DrivingWarningCooldownMinutes != 0F) {
        DrivingWarningCooldownMinutes = other.DrivingWarningCooldownMinutes;
      }
      if (other.DrivingSpeedSampleIntervalSeconds != 0F) {
        DrivingSpeedSampleIntervalSeconds = other.DrivingSpeedSampleIntervalSeconds;
      }
      if (other.DrivingSpeedSampleCount != 0) {
        DrivingSpeedSampleCount = other.DrivingSpeedSampleCount;
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
          case 13: {
            DrivingWarningSpeedMetersPerSecond = input.ReadFloat();
            break;
          }
          case 21: {
            DrivingWarningCooldownMinutes = input.ReadFloat();
            break;
          }
          case 29: {
            DrivingSpeedSampleIntervalSeconds = input.ReadFloat();
            break;
          }
          case 32: {
            DrivingSpeedSampleCount = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
