// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/GymDeployMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GymDeployMessage.proto</summary>
  public static partial class GymDeployMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/GymDeployMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GymDeployMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR3lt",
            "RGVwbG95TWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "cXVlc3RzLk1lc3NhZ2VzImoKEEd5bURlcGxveU1lc3NhZ2USDwoHZm9ydF9p",
            "ZBgBIAEoCRISCgpwb2tlbW9uX2lkGAIgASgGEhcKD3BsYXllcl9sYXRpdHVk",
            "ZRgDIAEoARIYChBwbGF5ZXJfbG9uZ2l0dWRlGAQgASgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.GymDeployMessage), global::POGOProtos.Networking.Requests.Messages.GymDeployMessage.Parser, new[]{ "FortId", "PokemonId", "PlayerLatitude", "PlayerLongitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GymDeployMessage : pb::IMessage<GymDeployMessage> {
    private static readonly pb::MessageParser<GymDeployMessage> _parser = new pb::MessageParser<GymDeployMessage>(() => new GymDeployMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GymDeployMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.GymDeployMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDeployMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDeployMessage(GymDeployMessage other) : this() {
      fortId_ = other.fortId_;
      pokemonId_ = other.pokemonId_;
      playerLatitude_ = other.playerLatitude_;
      playerLongitude_ = other.playerLongitude_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GymDeployMessage Clone() {
      return new GymDeployMessage(this);
    }

    /// <summary>Field number for the "fort_id" field.</summary>
    public const int FortIdFieldNumber = 1;
    private string fortId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortId {
      get { return fortId_; }
      set {
        fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private ulong pokemonId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "player_latitude" field.</summary>
    public const int PlayerLatitudeFieldNumber = 3;
    private double playerLatitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLatitude {
      get { return playerLatitude_; }
      set {
        playerLatitude_ = value;
      }
    }

    /// <summary>Field number for the "player_longitude" field.</summary>
    public const int PlayerLongitudeFieldNumber = 4;
    private double playerLongitude_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double PlayerLongitude {
      get { return playerLongitude_; }
      set {
        playerLongitude_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GymDeployMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GymDeployMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FortId != other.FortId) return false;
      if (PokemonId != other.PokemonId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerLatitude, other.PlayerLatitude)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(PlayerLongitude, other.PlayerLongitude)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
      if (PokemonId != 0UL) hash ^= PokemonId.GetHashCode();
      if (PlayerLatitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerLatitude);
      if (PlayerLongitude != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(PlayerLongitude);
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
      if (FortId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(FortId);
      }
      if (PokemonId != 0UL) {
        output.WriteRawTag(17);
        output.WriteFixed64(PokemonId);
      }
      if (PlayerLatitude != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(PlayerLatitude);
      }
      if (PlayerLongitude != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(PlayerLongitude);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      if (PokemonId != 0UL) {
        size += 1 + 8;
      }
      if (PlayerLatitude != 0D) {
        size += 1 + 8;
      }
      if (PlayerLongitude != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GymDeployMessage other) {
      if (other == null) {
        return;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
      }
      if (other.PokemonId != 0UL) {
        PokemonId = other.PokemonId;
      }
      if (other.PlayerLatitude != 0D) {
        PlayerLatitude = other.PlayerLatitude;
      }
      if (other.PlayerLongitude != 0D) {
        PlayerLongitude = other.PlayerLongitude;
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
            FortId = input.ReadString();
            break;
          }
          case 17: {
            PokemonId = input.ReadFixed64();
            break;
          }
          case 25: {
            PlayerLatitude = input.ReadDouble();
            break;
          }
          case 33: {
            PlayerLongitude = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
