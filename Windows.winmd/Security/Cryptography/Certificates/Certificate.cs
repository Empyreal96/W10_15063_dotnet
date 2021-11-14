// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.Certificate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Certificates
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (ICertificateFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Certificate : ICertificate, ICertificate2, ICertificate3
  {
    [MethodImpl]
    public extern Certificate(IBuffer certBlob);

    [RemoteAsync]
    [Overload("BuildChainAsync")]
    [MethodImpl]
    public extern IAsyncOperation<CertificateChain> BuildChainAsync(
      IIterable<Certificate> certificates);

    [RemoteAsync]
    [Overload("BuildChainWithParametersAsync")]
    [MethodImpl]
    public extern IAsyncOperation<CertificateChain> BuildChainAsync(
      IIterable<Certificate> certificates,
      ChainBuildingParameters parameters);

    public extern byte[] SerialNumber { [MethodImpl] get; }

    [Overload("GetHashValue")]
    [MethodImpl]
    public extern byte[] GetHashValue();

    [Overload("GetHashValueWithAlgorithm")]
    [MethodImpl]
    public extern byte[] GetHashValue(string hashAlgorithmName);

    [MethodImpl]
    public extern IBuffer GetCertificateBlob();

    public extern string Subject { [MethodImpl] get; }

    public extern string Issuer { [MethodImpl] get; }

    public extern bool HasPrivateKey { [MethodImpl] get; }

    public extern bool IsStronglyProtected { [MethodImpl] get; }

    public extern DateTime ValidFrom { [MethodImpl] get; }

    public extern DateTime ValidTo { [MethodImpl] get; }

    public extern IVectorView<string> EnhancedKeyUsages { [MethodImpl] get; }

    public extern string FriendlyName { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsSecurityDeviceBound { [MethodImpl] get; }

    public extern CertificateKeyUsages KeyUsages { [MethodImpl] get; }

    public extern string KeyAlgorithmName { [MethodImpl] get; }

    public extern string SignatureAlgorithmName { [MethodImpl] get; }

    public extern string SignatureHashAlgorithmName { [MethodImpl] get; }

    public extern SubjectAlternativeNameInfo SubjectAlternativeName { [MethodImpl] get; }

    public extern bool IsPerUser { [MethodImpl] get; }

    public extern string StoreName { [MethodImpl] get; }

    public extern string KeyStorageProviderName { [MethodImpl] get; }
  }
}
