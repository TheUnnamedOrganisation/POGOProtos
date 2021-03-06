// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Gift/GiftReceivedNotification.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Gift {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Gift/GiftReceivedNotification.proto</summary>
  public static partial class GiftReceivedNotificationReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Gift/GiftReceivedNotification.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GiftReceivedNotificationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNQT0dPUHJvdG9zL0RhdGEvR2lmdC9HaWZ0UmVjZWl2ZWROb3RpZmljYXRp",
            "b24ucHJvdG8SFFBPR09Qcm90b3MuRGF0YS5HaWZ0IloKGEdpZnRSZWNlaXZl",
            "ZE5vdGlmaWNhdGlvbhISCgpnaWZ0Ym94X2lkGAEgASgEEhEKCXNlbmRlcl9p",
            "ZBgCIAEoCRIXCg9zZW5kZXJfY29kZW5hbWUYAyABKAliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Gift.GiftReceivedNotification), global::POGOProtos.Data.Gift.GiftReceivedNotification.Parser, new[]{ "GiftboxId", "SenderId", "SenderCodename" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GiftReceivedNotification : pb::IMessage<GiftReceivedNotification> {
    private static readonly pb::MessageParser<GiftReceivedNotification> _parser = new pb::MessageParser<GiftReceivedNotification>(() => new GiftReceivedNotification());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GiftReceivedNotification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Gift.GiftReceivedNotificationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GiftReceivedNotification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GiftReceivedNotification(GiftReceivedNotification other) : this() {
      giftboxId_ = other.giftboxId_;
      senderId_ = other.senderId_;
      senderCodename_ = other.senderCodename_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GiftReceivedNotification Clone() {
      return new GiftReceivedNotification(this);
    }

    /// <summary>Field number for the "giftbox_id" field.</summary>
    public const int GiftboxIdFieldNumber = 1;
    private ulong giftboxId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong GiftboxId {
      get { return giftboxId_; }
      set {
        giftboxId_ = value;
      }
    }

    /// <summary>Field number for the "sender_id" field.</summary>
    public const int SenderIdFieldNumber = 2;
    private string senderId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SenderId {
      get { return senderId_; }
      set {
        senderId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "sender_codename" field.</summary>
    public const int SenderCodenameFieldNumber = 3;
    private string senderCodename_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SenderCodename {
      get { return senderCodename_; }
      set {
        senderCodename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GiftReceivedNotification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GiftReceivedNotification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GiftboxId != other.GiftboxId) return false;
      if (SenderId != other.SenderId) return false;
      if (SenderCodename != other.SenderCodename) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (GiftboxId != 0UL) hash ^= GiftboxId.GetHashCode();
      if (SenderId.Length != 0) hash ^= SenderId.GetHashCode();
      if (SenderCodename.Length != 0) hash ^= SenderCodename.GetHashCode();
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
      if (GiftboxId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(GiftboxId);
      }
      if (SenderId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SenderId);
      }
      if (SenderCodename.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SenderCodename);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (GiftboxId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(GiftboxId);
      }
      if (SenderId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SenderId);
      }
      if (SenderCodename.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SenderCodename);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GiftReceivedNotification other) {
      if (other == null) {
        return;
      }
      if (other.GiftboxId != 0UL) {
        GiftboxId = other.GiftboxId;
      }
      if (other.SenderId.Length != 0) {
        SenderId = other.SenderId;
      }
      if (other.SenderCodename.Length != 0) {
        SenderCodename = other.SenderCodename;
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
            GiftboxId = input.ReadUInt64();
            break;
          }
          case 18: {
            SenderId = input.ReadString();
            break;
          }
          case 26: {
            SenderCodename = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
