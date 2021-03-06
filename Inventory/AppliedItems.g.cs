// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Inventory/AppliedItems.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Inventory {

  /// <summary>Holder for reflection information generated from POGOProtos/Inventory/AppliedItems.proto</summary>
  public static partial class AppliedItemsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Inventory/AppliedItems.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppliedItemsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL0ludmVudG9yeS9BcHBsaWVkSXRlbXMucHJvdG8SFFBP",
            "R09Qcm90b3MuSW52ZW50b3J5GiZQT0dPUHJvdG9zL0ludmVudG9yeS9BcHBs",
            "aWVkSXRlbS5wcm90byI/CgxBcHBsaWVkSXRlbXMSLwoEaXRlbRgEIAMoCzIh",
            "LlBPR09Qcm90b3MuSW52ZW50b3J5LkFwcGxpZWRJdGVtYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Inventory.AppliedItemReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Inventory.AppliedItems), global::POGOProtos.Inventory.AppliedItems.Parser, new[]{ "Item" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AppliedItems : pb::IMessage<AppliedItems> {
    private static readonly pb::MessageParser<AppliedItems> _parser = new pb::MessageParser<AppliedItems>(() => new AppliedItems());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppliedItems> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Inventory.AppliedItemsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppliedItems() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppliedItems(AppliedItems other) : this() {
      item_ = other.item_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppliedItems Clone() {
      return new AppliedItems(this);
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 4;
    private static readonly pb::FieldCodec<global::POGOProtos.Inventory.AppliedItem> _repeated_item_codec
        = pb::FieldCodec.ForMessage(34, global::POGOProtos.Inventory.AppliedItem.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Inventory.AppliedItem> item_ = new pbc::RepeatedField<global::POGOProtos.Inventory.AppliedItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Inventory.AppliedItem> Item {
      get { return item_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppliedItems);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppliedItems other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!item_.Equals(other.item_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= item_.GetHashCode();
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
      item_.WriteTo(output, _repeated_item_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += item_.CalculateSize(_repeated_item_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppliedItems other) {
      if (other == null) {
        return;
      }
      item_.Add(other.item_);
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
          case 34: {
            item_.AddEntriesFrom(input, _repeated_item_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
