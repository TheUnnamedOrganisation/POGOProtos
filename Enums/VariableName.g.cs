// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/VariableName.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/VariableName.proto</summary>
  public static partial class VariableNameReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/VariableName.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VariableNameReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQT0dPUHJvdG9zL0VudW1zL1ZhcmlhYmxlTmFtZS5wcm90bxIQUE9HT1By",
            "b3Rvcy5FbnVtcyqWBgoMVmFyaWFibGVOYW1lEhYKElVOU0VUX1ZhcmlhYmxl",
            "TmFtZRAAEg0KCUNPREVfTkFNRRABEggKBFRFQU0QAhIJCgVMRVZFTBADEg4K",
            "CkVYUEVSSUVOQ0UQBBIUChBQT0tFQ09JTl9CQUxBTkNFEAUSFAoQU1RBUkRV",
            "U1RfQkFMQU5DRRAGEgkKBUVNQUlMEAcSEAoMTE9HSU5fTUVUSE9EEAgSCwoG",
            "R1lNX0lEEOgHEg0KCEdZTV9OQU1FEOkHEhQKD1BPS0VNT05fRElTUExBWRDq",
            "BxIZChRQT0tFREVYX0VOVFJZX05VTUJFUhDrBxIPCgpQT0tFTU9OX0lEEOwH",
            "EhUKEFBPS0VNT05fTklDS05BTUUQ7QcSHAoXR1lNX0JBREdFX0VBUk5FRF9Q",
            "T0lOVFMQ7gcSFwoSR1lNX0JBREdFX1BST0dSRVNTEO8HEhMKDkdZTV9CQURH",
            "RV9SQU5LEPAHEhgKE0dZTV9CQURHRV9JTUFHRV9VUkwQ8QcSFwoSR1lNX0JB",
            "REdFX0xFVkVMX1VQEPIHEhUKEFBPS0VDT0lOX0FXQVJERUQQ8wcSGwoWUE9L",
            "RUNPSU5fQVdBUkRFRF9UT0RBWRD0BxIXChJNQVhfREFJTFlfUE9LRUNPSU4Q",
            "9QcSEAoLQkFUVExFU19XT04Q9gcSEQoMQkFUVExFU19MT1NUEPcHEhQKD0RF",
            "UExPWUVEX01JTExJUxD4BxIOCglSQUlEX1NFRUQQ+QcSJQogRVhDTFVTSVZF",
            "X1JBSURfQ0FOQ0VMTEFUSU9OX0lORk8Q+gcSFAoPR0lGVEJPWF9ERVRBSUxT",
            "EPsHEhIKDUZSSUVORF9BVkFUQVIQ/AcSEAoLRlJJRU5EX1RFQU0Q/QcSFAoP",
            "RlJJRU5EX0NPREVOQU1FEP4HEhQKD0dJRlRfTE9PVF9JVEVNUxD/BxINCghH",
            "SUZUX0VHRxCACBIoCiNGUklFTkRTSElQX01JTEVTVE9ORV9SRVdBUkRfREVU",
            "QUlMUxCBCBIdChhGUklFTkRTSElQX0xFVkVMX0RJU1BMQVkQgghiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.VariableName), }, null));
    }
    #endregion

  }
  #region Enums
  public enum VariableName {
    [pbr::OriginalName("UNSET_VariableName")] UnsetVariableName = 0,
    [pbr::OriginalName("CODE_NAME")] CodeName = 1,
    [pbr::OriginalName("TEAM")] Team = 2,
    [pbr::OriginalName("LEVEL")] Level = 3,
    [pbr::OriginalName("EXPERIENCE")] Experience = 4,
    [pbr::OriginalName("POKECOIN_BALANCE")] PokecoinBalance = 5,
    [pbr::OriginalName("STARDUST_BALANCE")] StardustBalance = 6,
    [pbr::OriginalName("EMAIL")] Email = 7,
    [pbr::OriginalName("LOGIN_METHOD")] LoginMethod = 8,
    [pbr::OriginalName("GYM_ID")] GymId = 1000,
    [pbr::OriginalName("GYM_NAME")] GymName = 1001,
    [pbr::OriginalName("POKEMON_DISPLAY")] PokemonDisplay = 1002,
    [pbr::OriginalName("POKEDEX_ENTRY_NUMBER")] PokedexEntryNumber = 1003,
    [pbr::OriginalName("POKEMON_ID")] PokemonId = 1004,
    [pbr::OriginalName("POKEMON_NICKNAME")] PokemonNickname = 1005,
    [pbr::OriginalName("GYM_BADGE_EARNED_POINTS")] GymBadgeEarnedPoints = 1006,
    [pbr::OriginalName("GYM_BADGE_PROGRESS")] GymBadgeProgress = 1007,
    [pbr::OriginalName("GYM_BADGE_RANK")] GymBadgeRank = 1008,
    [pbr::OriginalName("GYM_BADGE_IMAGE_URL")] GymBadgeImageUrl = 1009,
    [pbr::OriginalName("GYM_BADGE_LEVEL_UP")] GymBadgeLevelUp = 1010,
    [pbr::OriginalName("POKECOIN_AWARDED")] PokecoinAwarded = 1011,
    [pbr::OriginalName("POKECOIN_AWARDED_TODAY")] PokecoinAwardedToday = 1012,
    [pbr::OriginalName("MAX_DAILY_POKECOIN")] MaxDailyPokecoin = 1013,
    [pbr::OriginalName("BATTLES_WON")] BattlesWon = 1014,
    [pbr::OriginalName("BATTLES_LOST")] BattlesLost = 1015,
    [pbr::OriginalName("DEPLOYED_MILLIS")] DeployedMillis = 1016,
    [pbr::OriginalName("RAID_SEED")] RaidSeed = 1017,
    [pbr::OriginalName("EXCLUSIVE_RAID_CANCELLATION_INFO")] ExclusiveRaidCancellationInfo = 1018,
    [pbr::OriginalName("GIFTBOX_DETAILS")] GiftboxDetails = 1019,
    [pbr::OriginalName("FRIEND_AVATAR")] FriendAvatar = 1020,
    [pbr::OriginalName("FRIEND_TEAM")] FriendTeam = 1021,
    [pbr::OriginalName("FRIEND_CODENAME")] FriendCodename = 1022,
    [pbr::OriginalName("GIFT_LOOT_ITEMS")] GiftLootItems = 1023,
    [pbr::OriginalName("GIFT_EGG")] GiftEgg = 1024,
    [pbr::OriginalName("FRIENDSHIP_MILESTONE_REWARD_DETAILS")] FriendshipMilestoneRewardDetails = 1025,
    [pbr::OriginalName("FRIENDSHIP_LEVEL_DISPLAY")] FriendshipLevelDisplay = 1026,
  }

  #endregion

}

#endregion Designer generated code
