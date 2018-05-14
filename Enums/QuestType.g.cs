// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/QuestType.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/QuestType.proto</summary>
  public static partial class QuestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/QuestType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static QuestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBQT0dPUHJvdG9zL0VudW1zL1F1ZXN0VHlwZS5wcm90bxIQUE9HT1Byb3Rv",
            "cy5FbnVtcyrWBAoJUXVlc3RUeXBlEhYKElFVRVNUX1VOS05PV05fVFlQRRAA",
            "EiAKHFFVRVNUX0ZJUlNUX0NBVENIX09GX1RIRV9EQVkQARIjCh9RVUVTVF9G",
            "SVJTVF9QT0tFU1RPUF9PRl9USEVfREFZEAISFAoQUVVFU1RfTVVMVElfUEFS",
            "VBADEhcKE1FVRVNUX0NBVENIX1BPS0VNT04QBBIXChNRVUVTVF9TUElOX1BP",
            "S0VTVE9QEAUSEwoPUVVFU1RfSEFUQ0hfRUdHEAYSHQoZUVVFU1RfQ09NUExF",
            "VEVfR1lNX0JBVFRMRRAHEh4KGlFVRVNUX0NPTVBMRVRFX1JBSURfQkFUVExF",
            "EAgSGAoUUVVFU1RfQ09NUExFVEVfUVVFU1QQCRIaChZRVUVTVF9UUkFOU0ZF",
            "Ul9QT0tFTU9OEAoSGgoWUVVFU1RfRkFWT1JJVEVfUE9LRU1PThALEhYKElFV",
            "RVNUX0FVVE9DT01QTEVURRAMEiAKHFFVRVNUX1VTRV9CRVJSWV9JTl9FTkNP",
            "VU5URVIQDRIZChVRVUVTVF9VUEdSQURFX1BPS0VNT04QDhIYChRRVUVTVF9F",
            "Vk9MVkVfUE9LRU1PThAPEhQKEFFVRVNUX0xBTkRfVEhST1cQEBIZChVRVUVT",
            "VF9HRVRfQlVERFlfQ0FORFkQERIUChBRVUVTVF9CQURHRV9SQU5LEBISFgoS",
            "UVVFU1RfUExBWUVSX0xFVkVMEBMSEwoPUVVFU1RfSk9JTl9SQUlEEBQSGQoV",
            "UVVFU1RfQ09NUExFVEVfQkFUVExFEBViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.QuestType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum QuestType {
    [pbr::OriginalName("QUEST_UNKNOWN_TYPE")] QuestUnknownType = 0,
    [pbr::OriginalName("QUEST_FIRST_CATCH_OF_THE_DAY")] QuestFirstCatchOfTheDay = 1,
    [pbr::OriginalName("QUEST_FIRST_POKESTOP_OF_THE_DAY")] QuestFirstPokestopOfTheDay = 2,
    [pbr::OriginalName("QUEST_MULTI_PART")] QuestMultiPart = 3,
    [pbr::OriginalName("QUEST_CATCH_POKEMON")] QuestCatchPokemon = 4,
    [pbr::OriginalName("QUEST_SPIN_POKESTOP")] QuestSpinPokestop = 5,
    [pbr::OriginalName("QUEST_HATCH_EGG")] QuestHatchEgg = 6,
    [pbr::OriginalName("QUEST_COMPLETE_GYM_BATTLE")] QuestCompleteGymBattle = 7,
    [pbr::OriginalName("QUEST_COMPLETE_RAID_BATTLE")] QuestCompleteRaidBattle = 8,
    [pbr::OriginalName("QUEST_COMPLETE_QUEST")] QuestCompleteQuest = 9,
    [pbr::OriginalName("QUEST_TRANSFER_POKEMON")] QuestTransferPokemon = 10,
    [pbr::OriginalName("QUEST_FAVORITE_POKEMON")] QuestFavoritePokemon = 11,
    [pbr::OriginalName("QUEST_AUTOCOMPLETE")] QuestAutocomplete = 12,
    [pbr::OriginalName("QUEST_USE_BERRY_IN_ENCOUNTER")] QuestUseBerryInEncounter = 13,
    [pbr::OriginalName("QUEST_UPGRADE_POKEMON")] QuestUpgradePokemon = 14,
    [pbr::OriginalName("QUEST_EVOLVE_POKEMON")] QuestEvolvePokemon = 15,
    [pbr::OriginalName("QUEST_LAND_THROW")] QuestLandThrow = 16,
    [pbr::OriginalName("QUEST_GET_BUDDY_CANDY")] QuestGetBuddyCandy = 17,
    [pbr::OriginalName("QUEST_BADGE_RANK")] QuestBadgeRank = 18,
    [pbr::OriginalName("QUEST_PLAYER_LEVEL")] QuestPlayerLevel = 19,
    [pbr::OriginalName("QUEST_JOIN_RAID")] QuestJoinRaid = 20,
    [pbr::OriginalName("QUEST_COMPLETE_BATTLE")] QuestCompleteBattle = 21,
  }

  #endregion

}

#endregion Designer generated code
