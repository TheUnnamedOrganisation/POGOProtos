// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/Form.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/Form.proto</summary>
  public static partial class FormReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/Form.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FormReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQT0dPUHJvdG9zL0VudW1zL0Zvcm0ucHJvdG8SEFBPR09Qcm90b3MuRW51",
            "bXMq8QoKBEZvcm0SDgoKRk9STV9VTlNFVBAAEgsKB1VOT1dOX0EQARILCgdV",
            "Tk9XTl9CEAISCwoHVU5PV05fQxADEgsKB1VOT1dOX0QQBBILCgdVTk9XTl9F",
            "EAUSCwoHVU5PV05fRhAGEgsKB1VOT1dOX0cQBxILCgdVTk9XTl9IEAgSCwoH",
            "VU5PV05fSRAJEgsKB1VOT1dOX0oQChILCgdVTk9XTl9LEAsSCwoHVU5PV05f",
            "TBAMEgsKB1VOT1dOX00QDRILCgdVTk9XTl9OEA4SCwoHVU5PV05fTxAPEgsK",
            "B1VOT1dOX1AQEBILCgdVTk9XTl9REBESCwoHVU5PV05fUhASEgsKB1VOT1dO",
            "X1MQExILCgdVTk9XTl9UEBQSCwoHVU5PV05fVRAVEgsKB1VOT1dOX1YQFhIL",
            "CgdVTk9XTl9XEBcSCwoHVU5PV05fWBAYEgsKB1VOT1dOX1kQGRILCgdVTk9X",
            "Tl9aEBoSGwoXVU5PV05fRVhDTEFNQVRJT05fUE9JTlQQGxIXChNVTk9XTl9R",
            "VUVTVElPTl9NQVJLEBwSEwoPQ0FTVEZPUk1fTk9STUFMEB0SEgoOQ0FTVEZP",
            "Uk1fU1VOTlkQHhISCg5DQVNURk9STV9SQUlOWRAfEhIKDkNBU1RGT1JNX1NO",
            "T1dZECASEQoNREVPWFlTX05PUk1BTBAhEhEKDURFT1hZU19BVFRBQ0sQIhIS",
            "Cg5ERU9YWVNfREVGRU5TRRAjEhAKDERFT1hZU19TUEVFRBAkEg0KCVNQSU5E",
            "QV8wMBAlEg0KCVNQSU5EQV8wMRAmEg0KCVNQSU5EQV8wMhAnEg0KCVNQSU5E",
            "QV8wMxAoEg0KCVNQSU5EQV8wNBApEg0KCVNQSU5EQV8wNRAqEg0KCVNQSU5E",
            "QV8wNhArEg0KCVNQSU5EQV8wNxAsEhIKDlJBVFRBVEFfTk9STUFMEC0SEQoN",
            "UkFUVEFUQV9BTE9MQRAuEhMKD1JBVElDQVRFX05PUk1BTBAvEhIKDlJBVElD",
            "QVRFX0FMT0xBEDASEQoNUkFJQ0hVX05PUk1BTBAxEhAKDFJBSUNIVV9BTE9M",
            "QRAyEhQKEFNBTkRTSFJFV19OT1JNQUwQMxITCg9TQU5EU0hSRVdfQUxPTEEQ",
            "NBIUChBTQU5EU0xBU0hfTk9STUFMEDUSEwoPU0FORFNMQVNIX0FMT0xBEDYS",
            "EQoNVlVMUElYX05PUk1BTBA3EhAKDFZVTFBJWF9BTE9MQRA4EhQKEE5JTkVU",
            "QUxFU19OT1JNQUwQORITCg9OSU5FVEFMRVNfQUxPTEEQOhISCg5ESUdMRVRU",
            "X05PUk1BTBA7EhEKDURJR0xFVFRfQUxPTEEQPBISCg5EVUdUUklPX05PUk1B",
            "TBA9EhEKDURVR1RSSU9fQUxPTEEQPhIRCg1NRU9XVEhfTk9STUFMED8SEAoM",
            "TUVPV1RIX0FMT0xBEEASEgoOUEVSU0lBTl9OT1JNQUwQQRIRCg1QRVJTSUFO",
            "X0FMT0xBEEISEgoOR0VPRFVERV9OT1JNQUwQQxIRCg1HRU9EVURFX0FMT0xB",
            "EEQSEwoPR1JBVkVMRVJfTk9STUFMEEUSEgoOR1JBVkVMRVJfQUxPTEEQRhIQ",
            "CgxHT0xFTV9OT1JNQUwQRxIPCgtHT0xFTV9BTE9MQRBIEhEKDUdSSU1FUl9O",
            "T1JNQUwQSRIQCgxHUklNRVJfQUxPTEEQShIOCgpNVUtfTk9STUFMEEsSDQoJ",
            "TVVLX0FMT0xBEEwSFAoQRVhFR0dVVE9SX05PUk1BTBBNEhMKD0VYRUdHVVRP",
            "Ul9BTE9MQRBOEhIKDk1BUk9XQUtfTk9STUFMEE8SEQoNTUFST1dBS19BTE9M",
            "QRBQYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.Form), }, null));
    }
    #endregion

  }
  #region Enums
  public enum Form {
    [pbr::OriginalName("FORM_UNSET")] Unset = 0,
    [pbr::OriginalName("UNOWN_A")] UnownA = 1,
    [pbr::OriginalName("UNOWN_B")] UnownB = 2,
    [pbr::OriginalName("UNOWN_C")] UnownC = 3,
    [pbr::OriginalName("UNOWN_D")] UnownD = 4,
    [pbr::OriginalName("UNOWN_E")] UnownE = 5,
    [pbr::OriginalName("UNOWN_F")] UnownF = 6,
    [pbr::OriginalName("UNOWN_G")] UnownG = 7,
    [pbr::OriginalName("UNOWN_H")] UnownH = 8,
    [pbr::OriginalName("UNOWN_I")] UnownI = 9,
    [pbr::OriginalName("UNOWN_J")] UnownJ = 10,
    [pbr::OriginalName("UNOWN_K")] UnownK = 11,
    [pbr::OriginalName("UNOWN_L")] UnownL = 12,
    [pbr::OriginalName("UNOWN_M")] UnownM = 13,
    [pbr::OriginalName("UNOWN_N")] UnownN = 14,
    [pbr::OriginalName("UNOWN_O")] UnownO = 15,
    [pbr::OriginalName("UNOWN_P")] UnownP = 16,
    [pbr::OriginalName("UNOWN_Q")] UnownQ = 17,
    [pbr::OriginalName("UNOWN_R")] UnownR = 18,
    [pbr::OriginalName("UNOWN_S")] UnownS = 19,
    [pbr::OriginalName("UNOWN_T")] UnownT = 20,
    [pbr::OriginalName("UNOWN_U")] UnownU = 21,
    [pbr::OriginalName("UNOWN_V")] UnownV = 22,
    [pbr::OriginalName("UNOWN_W")] UnownW = 23,
    [pbr::OriginalName("UNOWN_X")] UnownX = 24,
    [pbr::OriginalName("UNOWN_Y")] UnownY = 25,
    [pbr::OriginalName("UNOWN_Z")] UnownZ = 26,
    [pbr::OriginalName("UNOWN_EXCLAMATION_POINT")] UnownExclamationPoint = 27,
    [pbr::OriginalName("UNOWN_QUESTION_MARK")] UnownQuestionMark = 28,
    [pbr::OriginalName("CASTFORM_NORMAL")] CastformNormal = 29,
    [pbr::OriginalName("CASTFORM_SUNNY")] CastformSunny = 30,
    [pbr::OriginalName("CASTFORM_RAINY")] CastformRainy = 31,
    [pbr::OriginalName("CASTFORM_SNOWY")] CastformSnowy = 32,
    [pbr::OriginalName("DEOXYS_NORMAL")] DeoxysNormal = 33,
    [pbr::OriginalName("DEOXYS_ATTACK")] DeoxysAttack = 34,
    [pbr::OriginalName("DEOXYS_DEFENSE")] DeoxysDefense = 35,
    [pbr::OriginalName("DEOXYS_SPEED")] DeoxysSpeed = 36,
    [pbr::OriginalName("SPINDA_00")] Spinda00 = 37,
    [pbr::OriginalName("SPINDA_01")] Spinda01 = 38,
    [pbr::OriginalName("SPINDA_02")] Spinda02 = 39,
    [pbr::OriginalName("SPINDA_03")] Spinda03 = 40,
    [pbr::OriginalName("SPINDA_04")] Spinda04 = 41,
    [pbr::OriginalName("SPINDA_05")] Spinda05 = 42,
    [pbr::OriginalName("SPINDA_06")] Spinda06 = 43,
    [pbr::OriginalName("SPINDA_07")] Spinda07 = 44,
    [pbr::OriginalName("RATTATA_NORMAL")] RattataNormal = 45,
    [pbr::OriginalName("RATTATA_ALOLA")] RattataAlola = 46,
    [pbr::OriginalName("RATICATE_NORMAL")] RaticateNormal = 47,
    [pbr::OriginalName("RATICATE_ALOLA")] RaticateAlola = 48,
    [pbr::OriginalName("RAICHU_NORMAL")] RaichuNormal = 49,
    [pbr::OriginalName("RAICHU_ALOLA")] RaichuAlola = 50,
    [pbr::OriginalName("SANDSHREW_NORMAL")] SandshrewNormal = 51,
    [pbr::OriginalName("SANDSHREW_ALOLA")] SandshrewAlola = 52,
    [pbr::OriginalName("SANDSLASH_NORMAL")] SandslashNormal = 53,
    [pbr::OriginalName("SANDSLASH_ALOLA")] SandslashAlola = 54,
    [pbr::OriginalName("VULPIX_NORMAL")] VulpixNormal = 55,
    [pbr::OriginalName("VULPIX_ALOLA")] VulpixAlola = 56,
    [pbr::OriginalName("NINETALES_NORMAL")] NinetalesNormal = 57,
    [pbr::OriginalName("NINETALES_ALOLA")] NinetalesAlola = 58,
    [pbr::OriginalName("DIGLETT_NORMAL")] DiglettNormal = 59,
    [pbr::OriginalName("DIGLETT_ALOLA")] DiglettAlola = 60,
    [pbr::OriginalName("DUGTRIO_NORMAL")] DugtrioNormal = 61,
    [pbr::OriginalName("DUGTRIO_ALOLA")] DugtrioAlola = 62,
    [pbr::OriginalName("MEOWTH_NORMAL")] MeowthNormal = 63,
    [pbr::OriginalName("MEOWTH_ALOLA")] MeowthAlola = 64,
    [pbr::OriginalName("PERSIAN_NORMAL")] PersianNormal = 65,
    [pbr::OriginalName("PERSIAN_ALOLA")] PersianAlola = 66,
    [pbr::OriginalName("GEODUDE_NORMAL")] GeodudeNormal = 67,
    [pbr::OriginalName("GEODUDE_ALOLA")] GeodudeAlola = 68,
    [pbr::OriginalName("GRAVELER_NORMAL")] GravelerNormal = 69,
    [pbr::OriginalName("GRAVELER_ALOLA")] GravelerAlola = 70,
    [pbr::OriginalName("GOLEM_NORMAL")] GolemNormal = 71,
    [pbr::OriginalName("GOLEM_ALOLA")] GolemAlola = 72,
    [pbr::OriginalName("GRIMER_NORMAL")] GrimerNormal = 73,
    [pbr::OriginalName("GRIMER_ALOLA")] GrimerAlola = 74,
    [pbr::OriginalName("MUK_NORMAL")] MukNormal = 75,
    [pbr::OriginalName("MUK_ALOLA")] MukAlola = 76,
    [pbr::OriginalName("EXEGGUTOR_NORMAL")] ExeggutorNormal = 77,
    [pbr::OriginalName("EXEGGUTOR_ALOLA")] ExeggutorAlola = 78,
    [pbr::OriginalName("MAROWAK_NORMAL")] MarowakNormal = 79,
    [pbr::OriginalName("MAROWAK_ALOLA")] MarowakAlola = 80,
  }

  #endregion

}

#endregion Designer generated code
