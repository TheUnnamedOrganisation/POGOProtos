// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Data/Trading/Trading.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Trading {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Trading/Trading.proto</summary>
  public static partial class TradingReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Trading/Trading.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TradingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQT0dPUHJvdG9zL0RhdGEvVHJhZGluZy9UcmFkaW5nLnByb3RvEhdQT0dP",
            "UHJvdG9zLkRhdGEuVHJhZGluZxorUE9HT1Byb3Rvcy9EYXRhL1RyYWRpbmcv",
            "VHJhZGluZ1BsYXllci5wcm90bxoxUE9HT1Byb3Rvcy9EYXRhL0ZyaWVuZHMv",
            "RnJpZW5kc2hpcExldmVsRGF0YS5wcm90byKeBAoHVHJhZGluZxI8CgVzdGF0",
            "ZRgBIAEoDjItLlBPR09Qcm90b3MuRGF0YS5UcmFkaW5nLlRyYWRpbmcuVHJh",
            "ZGluZ1N0YXRlEhUKDWV4cGlyYXRpb25fbXMYAiABKAQSNgoGcGxheWVyGAMg",
            "ASgLMiYuUE9HT1Byb3Rvcy5EYXRhLlRyYWRpbmcuVHJhZGluZ1BsYXllchI2",
            "CgZmcmllbmQYBCABKAsyJi5QT0dPUHJvdG9zLkRhdGEuVHJhZGluZy5UcmFk",
            "aW5nUGxheWVyEhoKEnRyYWRpbmdfczJfY2VsbF9pZBgFIAEoAxIXCg90cmFu",
            "c2FjdGlvbl9sb2cYBiABKAkSSwoVZnJpZW5kc2hpcF9sZXZlbF9kYXRhGAcg",
            "ASgLMiwuUE9HT1Byb3Rvcy5EYXRhLkZyaWVuZHMuRnJpZW5kc2hpcExldmVs",
            "RGF0YRIaChJpc19zcGVjaWFsX3RyYWRpbmcYCCABKAgSUgoccHJlX3RyYWRp",
            "bmdfZnJpZW5kc2hpcF9sZXZlbBgJIAEoCzIsLlBPR09Qcm90b3MuRGF0YS5G",
            "cmllbmRzLkZyaWVuZHNoaXBMZXZlbERhdGEiXAoMVHJhZGluZ1N0YXRlEgkK",
            "BVVOU0VUEAASDgoKUFJJTU9SRElBTBABEggKBFdBSVQQAhIKCgZBQ1RJVkUQ",
            "AxINCglDT05GSVJNRUQQBBIMCghGSU5JU0hFRBAFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Trading.TradingPlayerReflection.Descriptor, global::POGOProtos.Data.Friends.FriendshipLevelDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Trading.Trading), global::POGOProtos.Data.Trading.Trading.Parser, new[]{ "State", "ExpirationMs", "Player", "Friend", "TradingS2CellId", "TransactionLog", "FriendshipLevelData", "IsSpecialTrading", "PreTradingFriendshipLevel" }, null, new[]{ typeof(global::POGOProtos.Data.Trading.Trading.Types.TradingState) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Trading : pb::IMessage<Trading> {
    private static readonly pb::MessageParser<Trading> _parser = new pb::MessageParser<Trading>(() => new Trading());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Trading> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Trading.TradingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trading() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trading(Trading other) : this() {
      state_ = other.state_;
      expirationMs_ = other.expirationMs_;
      player_ = other.player_ != null ? other.player_.Clone() : null;
      friend_ = other.friend_ != null ? other.friend_.Clone() : null;
      tradingS2CellId_ = other.tradingS2CellId_;
      transactionLog_ = other.transactionLog_;
      friendshipLevelData_ = other.friendshipLevelData_ != null ? other.friendshipLevelData_.Clone() : null;
      isSpecialTrading_ = other.isSpecialTrading_;
      preTradingFriendshipLevel_ = other.preTradingFriendshipLevel_ != null ? other.preTradingFriendshipLevel_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Trading Clone() {
      return new Trading(this);
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 1;
    private global::POGOProtos.Data.Trading.Trading.Types.TradingState state_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Trading.Trading.Types.TradingState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "expiration_ms" field.</summary>
    public const int ExpirationMsFieldNumber = 2;
    private ulong expirationMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ExpirationMs {
      get { return expirationMs_; }
      set {
        expirationMs_ = value;
      }
    }

    /// <summary>Field number for the "player" field.</summary>
    public const int PlayerFieldNumber = 3;
    private global::POGOProtos.Data.Trading.TradingPlayer player_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Trading.TradingPlayer Player {
      get { return player_; }
      set {
        player_ = value;
      }
    }

    /// <summary>Field number for the "friend" field.</summary>
    public const int FriendFieldNumber = 4;
    private global::POGOProtos.Data.Trading.TradingPlayer friend_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Trading.TradingPlayer Friend {
      get { return friend_; }
      set {
        friend_ = value;
      }
    }

    /// <summary>Field number for the "trading_s2_cell_id" field.</summary>
    public const int TradingS2CellIdFieldNumber = 5;
    private long tradingS2CellId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TradingS2CellId {
      get { return tradingS2CellId_; }
      set {
        tradingS2CellId_ = value;
      }
    }

    /// <summary>Field number for the "transaction_log" field.</summary>
    public const int TransactionLogFieldNumber = 6;
    private string transactionLog_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TransactionLog {
      get { return transactionLog_; }
      set {
        transactionLog_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "friendship_level_data" field.</summary>
    public const int FriendshipLevelDataFieldNumber = 7;
    private global::POGOProtos.Data.Friends.FriendshipLevelData friendshipLevelData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Friends.FriendshipLevelData FriendshipLevelData {
      get { return friendshipLevelData_; }
      set {
        friendshipLevelData_ = value;
      }
    }

    /// <summary>Field number for the "is_special_trading" field.</summary>
    public const int IsSpecialTradingFieldNumber = 8;
    private bool isSpecialTrading_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsSpecialTrading {
      get { return isSpecialTrading_; }
      set {
        isSpecialTrading_ = value;
      }
    }

    /// <summary>Field number for the "pre_trading_friendship_level" field.</summary>
    public const int PreTradingFriendshipLevelFieldNumber = 9;
    private global::POGOProtos.Data.Friends.FriendshipLevelData preTradingFriendshipLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Friends.FriendshipLevelData PreTradingFriendshipLevel {
      get { return preTradingFriendshipLevel_; }
      set {
        preTradingFriendshipLevel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Trading);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Trading other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (State != other.State) return false;
      if (ExpirationMs != other.ExpirationMs) return false;
      if (!object.Equals(Player, other.Player)) return false;
      if (!object.Equals(Friend, other.Friend)) return false;
      if (TradingS2CellId != other.TradingS2CellId) return false;
      if (TransactionLog != other.TransactionLog) return false;
      if (!object.Equals(FriendshipLevelData, other.FriendshipLevelData)) return false;
      if (IsSpecialTrading != other.IsSpecialTrading) return false;
      if (!object.Equals(PreTradingFriendshipLevel, other.PreTradingFriendshipLevel)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (State != 0) hash ^= State.GetHashCode();
      if (ExpirationMs != 0UL) hash ^= ExpirationMs.GetHashCode();
      if (player_ != null) hash ^= Player.GetHashCode();
      if (friend_ != null) hash ^= Friend.GetHashCode();
      if (TradingS2CellId != 0L) hash ^= TradingS2CellId.GetHashCode();
      if (TransactionLog.Length != 0) hash ^= TransactionLog.GetHashCode();
      if (friendshipLevelData_ != null) hash ^= FriendshipLevelData.GetHashCode();
      if (IsSpecialTrading != false) hash ^= IsSpecialTrading.GetHashCode();
      if (preTradingFriendshipLevel_ != null) hash ^= PreTradingFriendshipLevel.GetHashCode();
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
      if (State != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) State);
      }
      if (ExpirationMs != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(ExpirationMs);
      }
      if (player_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Player);
      }
      if (friend_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Friend);
      }
      if (TradingS2CellId != 0L) {
        output.WriteRawTag(40);
        output.WriteInt64(TradingS2CellId);
      }
      if (TransactionLog.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(TransactionLog);
      }
      if (friendshipLevelData_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FriendshipLevelData);
      }
      if (IsSpecialTrading != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsSpecialTrading);
      }
      if (preTradingFriendshipLevel_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(PreTradingFriendshipLevel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (State != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (ExpirationMs != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ExpirationMs);
      }
      if (player_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Player);
      }
      if (friend_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Friend);
      }
      if (TradingS2CellId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TradingS2CellId);
      }
      if (TransactionLog.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TransactionLog);
      }
      if (friendshipLevelData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FriendshipLevelData);
      }
      if (IsSpecialTrading != false) {
        size += 1 + 1;
      }
      if (preTradingFriendshipLevel_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PreTradingFriendshipLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Trading other) {
      if (other == null) {
        return;
      }
      if (other.State != 0) {
        State = other.State;
      }
      if (other.ExpirationMs != 0UL) {
        ExpirationMs = other.ExpirationMs;
      }
      if (other.player_ != null) {
        if (player_ == null) {
          player_ = new global::POGOProtos.Data.Trading.TradingPlayer();
        }
        Player.MergeFrom(other.Player);
      }
      if (other.friend_ != null) {
        if (friend_ == null) {
          friend_ = new global::POGOProtos.Data.Trading.TradingPlayer();
        }
        Friend.MergeFrom(other.Friend);
      }
      if (other.TradingS2CellId != 0L) {
        TradingS2CellId = other.TradingS2CellId;
      }
      if (other.TransactionLog.Length != 0) {
        TransactionLog = other.TransactionLog;
      }
      if (other.friendshipLevelData_ != null) {
        if (friendshipLevelData_ == null) {
          friendshipLevelData_ = new global::POGOProtos.Data.Friends.FriendshipLevelData();
        }
        FriendshipLevelData.MergeFrom(other.FriendshipLevelData);
      }
      if (other.IsSpecialTrading != false) {
        IsSpecialTrading = other.IsSpecialTrading;
      }
      if (other.preTradingFriendshipLevel_ != null) {
        if (preTradingFriendshipLevel_ == null) {
          preTradingFriendshipLevel_ = new global::POGOProtos.Data.Friends.FriendshipLevelData();
        }
        PreTradingFriendshipLevel.MergeFrom(other.PreTradingFriendshipLevel);
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
            state_ = (global::POGOProtos.Data.Trading.Trading.Types.TradingState) input.ReadEnum();
            break;
          }
          case 16: {
            ExpirationMs = input.ReadUInt64();
            break;
          }
          case 26: {
            if (player_ == null) {
              player_ = new global::POGOProtos.Data.Trading.TradingPlayer();
            }
            input.ReadMessage(player_);
            break;
          }
          case 34: {
            if (friend_ == null) {
              friend_ = new global::POGOProtos.Data.Trading.TradingPlayer();
            }
            input.ReadMessage(friend_);
            break;
          }
          case 40: {
            TradingS2CellId = input.ReadInt64();
            break;
          }
          case 50: {
            TransactionLog = input.ReadString();
            break;
          }
          case 58: {
            if (friendshipLevelData_ == null) {
              friendshipLevelData_ = new global::POGOProtos.Data.Friends.FriendshipLevelData();
            }
            input.ReadMessage(friendshipLevelData_);
            break;
          }
          case 64: {
            IsSpecialTrading = input.ReadBool();
            break;
          }
          case 74: {
            if (preTradingFriendshipLevel_ == null) {
              preTradingFriendshipLevel_ = new global::POGOProtos.Data.Friends.FriendshipLevelData();
            }
            input.ReadMessage(preTradingFriendshipLevel_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Trading message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum TradingState {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("PRIMORDIAL")] Primordial = 1,
        [pbr::OriginalName("WAIT")] Wait = 2,
        [pbr::OriginalName("ACTIVE")] Active = 3,
        [pbr::OriginalName("CONFIRMED")] Confirmed = 4,
        [pbr::OriginalName("FINISHED")] Finished = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
