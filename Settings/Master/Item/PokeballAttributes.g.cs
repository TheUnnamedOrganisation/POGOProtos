// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Settings/Master/Item/PokeballAttributes.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master.Item {

  /// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/PokeballAttributes.proto</summary>
  public static partial class PokeballAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Settings/Master/Item/PokeballAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokeballAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjhQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL1Bva2ViYWxsQXR0",
            "cmlidXRlcy5wcm90bxIfUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIuSXRl",
            "bRohUE9HT1Byb3Rvcy9FbnVtcy9JdGVtRWZmZWN0LnByb3RvIpUBChJQb2tl",
            "YmFsbEF0dHJpYnV0ZXMSMQoLaXRlbV9lZmZlY3QYASABKA4yHC5QT0dPUHJv",
            "dG9zLkVudW1zLkl0ZW1FZmZlY3QSFQoNY2FwdHVyZV9tdWx0aRgCIAEoAhIc",
            "ChRjYXB0dXJlX211bHRpX2VmZmVjdBgDIAEoAhIXCg9pdGVtX2VmZmVjdF9t",
            "b2QYBCABKAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.ItemEffectReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.Item.PokeballAttributes), global::POGOProtos.Settings.Master.Item.PokeballAttributes.Parser, new[]{ "ItemEffect", "CaptureMulti", "CaptureMultiEffect", "ItemEffectMod" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PokeballAttributes : pb::IMessage<PokeballAttributes> {
    private static readonly pb::MessageParser<PokeballAttributes> _parser = new pb::MessageParser<PokeballAttributes>(() => new PokeballAttributes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PokeballAttributes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.Item.PokeballAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokeballAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokeballAttributes(PokeballAttributes other) : this() {
      itemEffect_ = other.itemEffect_;
      captureMulti_ = other.captureMulti_;
      captureMultiEffect_ = other.captureMultiEffect_;
      itemEffectMod_ = other.itemEffectMod_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokeballAttributes Clone() {
      return new PokeballAttributes(this);
    }

    /// <summary>Field number for the "item_effect" field.</summary>
    public const int ItemEffectFieldNumber = 1;
    private global::POGOProtos.Enums.ItemEffect itemEffect_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.ItemEffect ItemEffect {
      get { return itemEffect_; }
      set {
        itemEffect_ = value;
      }
    }

    /// <summary>Field number for the "capture_multi" field.</summary>
    public const int CaptureMultiFieldNumber = 2;
    private float captureMulti_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float CaptureMulti {
      get { return captureMulti_; }
      set {
        captureMulti_ = value;
      }
    }

    /// <summary>Field number for the "capture_multi_effect" field.</summary>
    public const int CaptureMultiEffectFieldNumber = 3;
    private float captureMultiEffect_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float CaptureMultiEffect {
      get { return captureMultiEffect_; }
      set {
        captureMultiEffect_ = value;
      }
    }

    /// <summary>Field number for the "item_effect_mod" field.</summary>
    public const int ItemEffectModFieldNumber = 4;
    private float itemEffectMod_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float ItemEffectMod {
      get { return itemEffectMod_; }
      set {
        itemEffectMod_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PokeballAttributes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PokeballAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemEffect != other.ItemEffect) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CaptureMulti, other.CaptureMulti)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CaptureMultiEffect, other.CaptureMultiEffect)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ItemEffectMod, other.ItemEffectMod)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemEffect != 0) hash ^= ItemEffect.GetHashCode();
      if (CaptureMulti != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CaptureMulti);
      if (CaptureMultiEffect != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CaptureMultiEffect);
      if (ItemEffectMod != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ItemEffectMod);
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
      if (ItemEffect != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) ItemEffect);
      }
      if (CaptureMulti != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(CaptureMulti);
      }
      if (CaptureMultiEffect != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(CaptureMultiEffect);
      }
      if (ItemEffectMod != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(ItemEffectMod);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemEffect != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ItemEffect);
      }
      if (CaptureMulti != 0F) {
        size += 1 + 4;
      }
      if (CaptureMultiEffect != 0F) {
        size += 1 + 4;
      }
      if (ItemEffectMod != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PokeballAttributes other) {
      if (other == null) {
        return;
      }
      if (other.ItemEffect != 0) {
        ItemEffect = other.ItemEffect;
      }
      if (other.CaptureMulti != 0F) {
        CaptureMulti = other.CaptureMulti;
      }
      if (other.CaptureMultiEffect != 0F) {
        CaptureMultiEffect = other.CaptureMultiEffect;
      }
      if (other.ItemEffectMod != 0F) {
        ItemEffectMod = other.ItemEffectMod;
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
            itemEffect_ = (global::POGOProtos.Enums.ItemEffect) input.ReadEnum();
            break;
          }
          case 21: {
            CaptureMulti = input.ReadFloat();
            break;
          }
          case 29: {
            CaptureMultiEffect = input.ReadFloat();
            break;
          }
          case 37: {
            ItemEffectMod = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
