// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricAlgorithmNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(3405184228, 26560, 18090, 132, 249, 117, 46, 119, 68, 159, 155)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AsymmetricAlgorithmNames))]
  internal interface IAsymmetricAlgorithmNamesStatics
  {
    string RsaPkcs1 { get; }

    string RsaOaepSha1 { get; }

    string RsaOaepSha256 { get; }

    string RsaOaepSha384 { get; }

    string RsaOaepSha512 { get; }

    string EcdsaP256Sha256 { get; }

    string EcdsaP384Sha384 { get; }

    string EcdsaP521Sha512 { get; }

    string DsaSha1 { get; }

    string DsaSha256 { get; }

    string RsaSignPkcs1Sha1 { get; }

    string RsaSignPkcs1Sha256 { get; }

    string RsaSignPkcs1Sha384 { get; }

    string RsaSignPkcs1Sha512 { get; }

    string RsaSignPssSha1 { get; }

    string RsaSignPssSha256 { get; }

    string RsaSignPssSha384 { get; }

    string RsaSignPssSha512 { get; }
  }
}
