// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: POGOProtos/Enums/IdentityProvider.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/IdentityProvider.proto</summary>
  public static partial class IdentityProviderReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/IdentityProvider.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IdentityProviderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CidQT0dPUHJvdG9zL0VudW1zL0lkZW50aXR5UHJvdmlkZXIucHJvdG8SEFBP",
            "R09Qcm90b3MuRW51bXMqjgEKEElkZW50aXR5UHJvdmlkZXISGwoXVU5TRVRf",
            "SURFTlRJVFlfUFJPVklERVIQABIKCgZHT09HTEUQARIHCgNQVEMQAhIMCghG",
            "QUNFQk9PSxADEg4KCkJBQ0tHUk9VTkQQBBIMCghJTlRFUk5BTBAFEgkKBVNG",
            "SURBEAYSEQoNU1VQRVJfQVdFU09NRRAHYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.IdentityProvider), }, null));
    }
    #endregion

  }
  #region Enums
  public enum IdentityProvider {
    [pbr::OriginalName("UNSET_IDENTITY_PROVIDER")] UnsetIdentityProvider = 0,
    [pbr::OriginalName("GOOGLE")] Google = 1,
    [pbr::OriginalName("PTC")] Ptc = 2,
    [pbr::OriginalName("FACEBOOK")] Facebook = 3,
    [pbr::OriginalName("BACKGROUND")] Background = 4,
    [pbr::OriginalName("INTERNAL")] Internal = 5,
    [pbr::OriginalName("SFIDA")] Sfida = 6,
    [pbr::OriginalName("SUPER_AWESOME")] SuperAwesome = 7,
  }

  #endregion

}

#endregion Designer generated code
