// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/PokemonClass.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonClass.proto</summary>
  public static partial class PokemonClassReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/PokemonClass.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonClassReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25DbGFzcy5wcm90bxIQUE9HT1By",
            "b3Rvcy5FbnVtcypfCgxQb2tlbW9uQ2xhc3MSGAoUUE9LRU1PTl9DTEFTU19O",
            "T1JNQUwQABIbChdQT0tFTU9OX0NMQVNTX0xFR0VOREFSWRABEhgKFFBPS0VN",
            "T05fQ0xBU1NfTVlUSElDEAJiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.PokemonClass), }, null));
    }
    #endregion

  }
  #region Enums
  public enum PokemonClass {
    [pbr::OriginalName("POKEMON_CLASS_NORMAL")] Normal = 0,
    [pbr::OriginalName("POKEMON_CLASS_LEGENDARY")] Legendary = 1,
    [pbr::OriginalName("POKEMON_CLASS_MYTHIC")] Mythic = 2,
  }

  #endregion

}

#endregion Designer generated code