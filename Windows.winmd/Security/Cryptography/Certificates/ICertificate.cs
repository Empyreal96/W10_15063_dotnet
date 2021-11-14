// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(859796492, 1240, 17331, 178, 120, 140, 95, 204, 155, 229, 160)]
  [ExclusiveTo(typeof (Certificate))]
  internal interface ICertificate
  {
    [RemoteAsync]
    [Overload("BuildChainAsync")]
    IAsyncOperation<CertificateChain> BuildChainAsync(
      IIterable<Certificate> certificates);

    [Overload("BuildChainWithParametersAsync")]
    [RemoteAsync]
    IAsyncOperation<CertificateChain> BuildChainAsync(
      IIterable<Certificate> certificates,
      ChainBuildingParameters parameters);

    byte[] SerialNumber { get; }

    [Overload("GetHashValue")]
    byte[] GetHashValue();

    [Overload("GetHashValueWithAlgorithm")]
    byte[] GetHashValue(string hashAlgorithmName);

    IBuffer GetCertificateBlob();

    string Subject { get; }

    string Issuer { get; }

    bool HasPrivateKey { get; }

    bool IsStronglyProtected { get; }

    DateTime ValidFrom { get; }

    DateTime ValidTo { get; }

    IVectorView<string> EnhancedKeyUsages { get; }

    string FriendlyName { set; get; }
  }
}
