// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Networking/Requests/Messages/GetPlayerMessage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetPlayerMessage.proto</summary>
  public static partial class GetPlayerMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/GetPlayerMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetPlayerMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR2V0",
            "UGxheWVyTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
            "cXVlc3RzLk1lc3NhZ2VzItABChBHZXRQbGF5ZXJNZXNzYWdlEl0KDXBsYXll",
            "cl9sb2NhbGUYASABKAsyRi5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVxdWVz",
            "dHMuTWVzc2FnZXMuR2V0UGxheWVyTWVzc2FnZS5QbGF5ZXJMb2NhbGUSGAoQ",
            "cHJldmVudF9jcmVhdGlvbhgCIAEoCBpDCgxQbGF5ZXJMb2NhbGUSDwoHY291",
            "bnRyeRgBIAEoCRIQCghsYW5ndWFnZRgCIAEoCRIQCgh0aW1lem9uZRgDIAEo",
            "CWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage), global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage.Parser, new[]{ "PlayerLocale", "PreventCreation" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage.Types.PlayerLocale), global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage.Types.PlayerLocale.Parser, new[]{ "Country", "Language", "Timezone" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetPlayerMessage : pb::IMessage<GetPlayerMessage> {
    private static readonly pb::MessageParser<GetPlayerMessage> _parser = new pb::MessageParser<GetPlayerMessage>(() => new GetPlayerMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetPlayerMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Requests.Messages.GetPlayerMessageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPlayerMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPlayerMessage(GetPlayerMessage other) : this() {
      playerLocale_ = other.playerLocale_ != null ? other.playerLocale_.Clone() : null;
      preventCreation_ = other.preventCreation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPlayerMessage Clone() {
      return new GetPlayerMessage(this);
    }

    /// <summary>Field number for the "player_locale" field.</summary>
    public const int PlayerLocaleFieldNumber = 1;
    private global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage.Types.PlayerLocale playerLocale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage.Types.PlayerLocale PlayerLocale {
      get { return playerLocale_; }
      set {
        playerLocale_ = value;
      }
    }

    /// <summary>Field number for the "prevent_creation" field.</summary>
    public const int PreventCreationFieldNumber = 2;
    private bool preventCreation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PreventCreation {
      get { return preventCreation_; }
      set {
        preventCreation_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetPlayerMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetPlayerMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PlayerLocale, other.PlayerLocale)) return false;
      if (PreventCreation != other.PreventCreation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (playerLocale_ != null) hash ^= PlayerLocale.GetHashCode();
      if (PreventCreation != false) hash ^= PreventCreation.GetHashCode();
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
      if (playerLocale_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PlayerLocale);
      }
      if (PreventCreation != false) {
        output.WriteRawTag(16);
        output.WriteBool(PreventCreation);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (playerLocale_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerLocale);
      }
      if (PreventCreation != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetPlayerMessage other) {
      if (other == null) {
        return;
      }
      if (other.playerLocale_ != null) {
        if (playerLocale_ == null) {
          playerLocale_ = new global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage.Types.PlayerLocale();
        }
        PlayerLocale.MergeFrom(other.PlayerLocale);
      }
      if (other.PreventCreation != false) {
        PreventCreation = other.PreventCreation;
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
            if (playerLocale_ == null) {
              playerLocale_ = new global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage.Types.PlayerLocale();
            }
            input.ReadMessage(playerLocale_);
            break;
          }
          case 16: {
            PreventCreation = input.ReadBool();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GetPlayerMessage message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class PlayerLocale : pb::IMessage<PlayerLocale> {
        private static readonly pb::MessageParser<PlayerLocale> _parser = new pb::MessageParser<PlayerLocale>(() => new PlayerLocale());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PlayerLocale> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::POGOProtos.Networking.Requests.Messages.GetPlayerMessage.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlayerLocale() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlayerLocale(PlayerLocale other) : this() {
          country_ = other.country_;
          language_ = other.language_;
          timezone_ = other.timezone_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PlayerLocale Clone() {
          return new PlayerLocale(this);
        }

        /// <summary>Field number for the "country" field.</summary>
        public const int CountryFieldNumber = 1;
        private string country_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Country {
          get { return country_; }
          set {
            country_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "language" field.</summary>
        public const int LanguageFieldNumber = 2;
        private string language_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Language {
          get { return language_; }
          set {
            language_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "timezone" field.</summary>
        public const int TimezoneFieldNumber = 3;
        private string timezone_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Timezone {
          get { return timezone_; }
          set {
            timezone_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PlayerLocale);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PlayerLocale other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Country != other.Country) return false;
          if (Language != other.Language) return false;
          if (Timezone != other.Timezone) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Country.Length != 0) hash ^= Country.GetHashCode();
          if (Language.Length != 0) hash ^= Language.GetHashCode();
          if (Timezone.Length != 0) hash ^= Timezone.GetHashCode();
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
          if (Country.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Country);
          }
          if (Language.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Language);
          }
          if (Timezone.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Timezone);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Country.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Country);
          }
          if (Language.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Language);
          }
          if (Timezone.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Timezone);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PlayerLocale other) {
          if (other == null) {
            return;
          }
          if (other.Country.Length != 0) {
            Country = other.Country;
          }
          if (other.Language.Length != 0) {
            Language = other.Language;
          }
          if (other.Timezone.Length != 0) {
            Timezone = other.Timezone;
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
                Country = input.ReadString();
                break;
              }
              case 18: {
                Language = input.ReadString();
                break;
              }
              case 26: {
                Timezone = input.ReadString();
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
