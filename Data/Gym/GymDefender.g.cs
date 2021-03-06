// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Gym/GymDefender.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Gym {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Gym/GymDefender.proto</summary>
  public static partial class GymDefenderReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Gym/GymDefender.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymDefenderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQT0dPUHJvdG9zL0RhdGEvR3ltL0d5bURlZmVuZGVyLnByb3RvEhNQT0dP",
            "UHJvdG9zLkRhdGEuR3ltGi1QT0dPUHJvdG9zL01hcC9Qb2tlbW9uL01vdGl2",
            "YXRlZFBva2Vtb24ucHJvdG8aMFBPR09Qcm90b3MvRGF0YS9QbGF5ZXIvUGxh",
            "eWVyUHVibGljUHJvZmlsZS5wcm90byLfAgoLR3ltRGVmZW5kZXISQwoRbW90",
            "aXZhdGVkX3Bva2Vtb24YASABKAsyKC5QT0dPUHJvdG9zLk1hcC5Qb2tlbW9u",
            "Lk1vdGl2YXRlZFBva2Vtb24STAoRZGVwbG95bWVudF90b3RhbHMYAiABKAsy",
            "MS5QT0dPUHJvdG9zLkRhdGEuR3ltLkd5bURlZmVuZGVyLkRlcGxveW1lbnRU",
            "b3RhbHMSSwoWdHJhaW5lcl9wdWJsaWNfcHJvZmlsZRgDIAEoCzIrLlBPR09Q",
            "cm90b3MuRGF0YS5QbGF5ZXIuUGxheWVyUHVibGljUHJvZmlsZRpwChBEZXBs",
            "b3ltZW50VG90YWxzEhEKCXRpbWVzX2ZlZBgBIAEoBRITCgtiYXR0bGVzX3dv",
            "bhgCIAEoBRIUCgxiYXR0bGVzX2xvc3QYAyABKAUSHgoWZGVwbG95bWVudF9k",
            "dXJhdGlvbl9tcxgEIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Map.Pokemon.MotivatedPokemonReflection.Descriptor, global::POGOProtos.Data.Player.PlayerPublicProfileReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Gym.GymDefender), global::POGOProtos.Data.Gym.GymDefender.Parser, new[]{ "MotivatedPokemon", "DeploymentTotals", "TrainerPublicProfile" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Gym.GymDefender.Types.DeploymentTotals), global::POGOProtos.Data.Gym.GymDefender.Types.DeploymentTotals.Parser, new[]{ "TimesFed", "BattlesWon", "BattlesLost", "DeploymentDurationMs" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GymDefender : pb::IMessage<GymDefender> {
    private static readonly pb::MessageParser<GymDefender> _parser = new pb::MessageParser<GymDefender>(() => new GymDefender());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GymDefender> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Gym.GymDefenderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDefender() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDefender(GymDefender other) : this() {
      motivatedPokemon_ = other.motivatedPokemon_ != null ? other.motivatedPokemon_.Clone() : null;
      deploymentTotals_ = other.deploymentTotals_ != null ? other.deploymentTotals_.Clone() : null;
      trainerPublicProfile_ = other.trainerPublicProfile_ != null ? other.trainerPublicProfile_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDefender Clone() {
      return new GymDefender(this);
    }

    /// <summary>Field number for the "motivated_pokemon" field.</summary>
    public const int MotivatedPokemonFieldNumber = 1;
    private global::POGOProtos.Map.Pokemon.MotivatedPokemon motivatedPokemon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Map.Pokemon.MotivatedPokemon MotivatedPokemon {
      get { return motivatedPokemon_; }
      set {
        motivatedPokemon_ = value;
      }
    }

    /// <summary>Field number for the "deployment_totals" field.</summary>
    public const int DeploymentTotalsFieldNumber = 2;
    private global::POGOProtos.Data.Gym.GymDefender.Types.DeploymentTotals deploymentTotals_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Gym.GymDefender.Types.DeploymentTotals DeploymentTotals {
      get { return deploymentTotals_; }
      set {
        deploymentTotals_ = value;
      }
    }

    /// <summary>Field number for the "trainer_public_profile" field.</summary>
    public const int TrainerPublicProfileFieldNumber = 3;
    private global::POGOProtos.Data.Player.PlayerPublicProfile trainerPublicProfile_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Player.PlayerPublicProfile TrainerPublicProfile {
      get { return trainerPublicProfile_; }
      set {
        trainerPublicProfile_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GymDefender);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GymDefender other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MotivatedPokemon, other.MotivatedPokemon)) return false;
      if (!object.Equals(DeploymentTotals, other.DeploymentTotals)) return false;
      if (!object.Equals(TrainerPublicProfile, other.TrainerPublicProfile)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (motivatedPokemon_ != null) hash ^= MotivatedPokemon.GetHashCode();
      if (deploymentTotals_ != null) hash ^= DeploymentTotals.GetHashCode();
      if (trainerPublicProfile_ != null) hash ^= TrainerPublicProfile.GetHashCode();
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
      if (motivatedPokemon_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MotivatedPokemon);
      }
      if (deploymentTotals_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(DeploymentTotals);
      }
      if (trainerPublicProfile_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(TrainerPublicProfile);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (motivatedPokemon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MotivatedPokemon);
      }
      if (deploymentTotals_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DeploymentTotals);
      }
      if (trainerPublicProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TrainerPublicProfile);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GymDefender other) {
      if (other == null) {
        return;
      }
      if (other.motivatedPokemon_ != null) {
        if (motivatedPokemon_ == null) {
          motivatedPokemon_ = new global::POGOProtos.Map.Pokemon.MotivatedPokemon();
        }
        MotivatedPokemon.MergeFrom(other.MotivatedPokemon);
      }
      if (other.deploymentTotals_ != null) {
        if (deploymentTotals_ == null) {
          deploymentTotals_ = new global::POGOProtos.Data.Gym.GymDefender.Types.DeploymentTotals();
        }
        DeploymentTotals.MergeFrom(other.DeploymentTotals);
      }
      if (other.trainerPublicProfile_ != null) {
        if (trainerPublicProfile_ == null) {
          trainerPublicProfile_ = new global::POGOProtos.Data.Player.PlayerPublicProfile();
        }
        TrainerPublicProfile.MergeFrom(other.TrainerPublicProfile);
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
            if (motivatedPokemon_ == null) {
              motivatedPokemon_ = new global::POGOProtos.Map.Pokemon.MotivatedPokemon();
            }
            input.ReadMessage(motivatedPokemon_);
            break;
          }
          case 18: {
            if (deploymentTotals_ == null) {
              deploymentTotals_ = new global::POGOProtos.Data.Gym.GymDefender.Types.DeploymentTotals();
            }
            input.ReadMessage(deploymentTotals_);
            break;
          }
          case 26: {
            if (trainerPublicProfile_ == null) {
              trainerPublicProfile_ = new global::POGOProtos.Data.Player.PlayerPublicProfile();
            }
            input.ReadMessage(trainerPublicProfile_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GymDefender message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class DeploymentTotals : pb::IMessage<DeploymentTotals> {
        private static readonly pb::MessageParser<DeploymentTotals> _parser = new pb::MessageParser<DeploymentTotals>(() => new DeploymentTotals());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<DeploymentTotals> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Data.Gym.GymDefender.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DeploymentTotals() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DeploymentTotals(DeploymentTotals other) : this() {
          timesFed_ = other.timesFed_;
          battlesWon_ = other.battlesWon_;
          battlesLost_ = other.battlesLost_;
          deploymentDurationMs_ = other.deploymentDurationMs_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public DeploymentTotals Clone() {
          return new DeploymentTotals(this);
        }

        /// <summary>Field number for the "times_fed" field.</summary>
        public const int TimesFedFieldNumber = 1;
        private int timesFed_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int TimesFed {
          get { return timesFed_; }
          set {
            timesFed_ = value;
          }
        }

        /// <summary>Field number for the "battles_won" field.</summary>
        public const int BattlesWonFieldNumber = 2;
        private int battlesWon_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int BattlesWon {
          get { return battlesWon_; }
          set {
            battlesWon_ = value;
          }
        }

        /// <summary>Field number for the "battles_lost" field.</summary>
        public const int BattlesLostFieldNumber = 3;
        private int battlesLost_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int BattlesLost {
          get { return battlesLost_; }
          set {
            battlesLost_ = value;
          }
        }

        /// <summary>Field number for the "deployment_duration_ms" field.</summary>
        public const int DeploymentDurationMsFieldNumber = 4;
        private long deploymentDurationMs_;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long DeploymentDurationMs {
          get { return deploymentDurationMs_; }
          set {
            deploymentDurationMs_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as DeploymentTotals);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(DeploymentTotals other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (TimesFed != other.TimesFed) return false;
          if (BattlesWon != other.BattlesWon) return false;
          if (BattlesLost != other.BattlesLost) return false;
          if (DeploymentDurationMs != other.DeploymentDurationMs) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (TimesFed != 0) hash ^= TimesFed.GetHashCode();
          if (BattlesWon != 0) hash ^= BattlesWon.GetHashCode();
          if (BattlesLost != 0) hash ^= BattlesLost.GetHashCode();
          if (DeploymentDurationMs != 0L) hash ^= DeploymentDurationMs.GetHashCode();
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
          if (TimesFed != 0) {
            output.WriteRawTag(8);
            output.WriteInt32(TimesFed);
          }
          if (BattlesWon != 0) {
            output.WriteRawTag(16);
            output.WriteInt32(BattlesWon);
          }
          if (BattlesLost != 0) {
            output.WriteRawTag(24);
            output.WriteInt32(BattlesLost);
          }
          if (DeploymentDurationMs != 0L) {
            output.WriteRawTag(32);
            output.WriteInt64(DeploymentDurationMs);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (TimesFed != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesFed);
          }
          if (BattlesWon != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattlesWon);
          }
          if (BattlesLost != 0) {
            size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattlesLost);
          }
          if (DeploymentDurationMs != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(DeploymentDurationMs);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(DeploymentTotals other) {
          if (other == null) {
            return;
          }
          if (other.TimesFed != 0) {
            TimesFed = other.TimesFed;
          }
          if (other.BattlesWon != 0) {
            BattlesWon = other.BattlesWon;
          }
          if (other.BattlesLost != 0) {
            BattlesLost = other.BattlesLost;
          }
          if (other.DeploymentDurationMs != 0L) {
            DeploymentDurationMs = other.DeploymentDurationMs;
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
                TimesFed = input.ReadInt32();
                break;
              }
              case 16: {
                BattlesWon = input.ReadInt32();
                break;
              }
              case 24: {
                BattlesLost = input.ReadInt32();
                break;
              }
              case 32: {
                DeploymentDurationMs = input.ReadInt64();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
