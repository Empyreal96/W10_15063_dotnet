// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.AsymmetricAlgorithmNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Static(typeof (IAsymmetricAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IAsymmetricAlgorithmNamesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class AsymmetricAlgorithmNames
  {
    public static extern string EcdsaSha256 { [MethodImpl] get; }

    public static extern string EcdsaSha384 { [MethodImpl] get; }

    public static extern string EcdsaSha512 { [MethodImpl] get; }

    public static extern string RsaPkcs1 { [MethodImpl] get; }

    public static extern string RsaOaepSha1 { [MethodImpl] get; }

    public static extern string RsaOaepSha256 { [MethodImpl] get; }

    public static extern string RsaOaepSha384 { [MethodImpl] get; }

    public static extern string RsaOaepSha512 { [MethodImpl] get; }

    public static extern string EcdsaP256Sha256 { [MethodImpl] get; }

    public static extern string EcdsaP384Sha384 { [MethodImpl] get; }

    public static extern string EcdsaP521Sha512 { [MethodImpl] get; }

    public static extern string DsaSha1 { [MethodImpl] get; }

    public static extern string DsaSha256 { [MethodImpl] get; }

    public static extern string RsaSignPkcs1Sha1 { [MethodImpl] get; }

    public static extern string RsaSignPkcs1Sha256 { [MethodImpl] get; }

    public static extern string RsaSignPkcs1Sha384 { [MethodImpl] get; }

    public static extern string RsaSignPkcs1Sha512 { [MethodImpl] get; }

    public static extern string RsaSignPssSha1 { [MethodImpl] get; }

    public static extern string RsaSignPssSha256 { [MethodImpl] get; }

    public static extern string RsaSignPssSha384 { [MethodImpl] get; }

    public static extern string RsaSignPssSha512 { [MethodImpl] get; }
  }
}
