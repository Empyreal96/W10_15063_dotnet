// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.AsymmetricKeyAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IAsymmetricKeyAlgorithmProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class AsymmetricKeyAlgorithmProvider : 
    IAsymmetricKeyAlgorithmProvider,
    IAsymmetricKeyAlgorithmProvider2
  {
    public extern string AlgorithmName { [MethodImpl] get; }

    [MethodImpl]
    public extern CryptographicKey CreateKeyPair(uint keySize);

    [Overload("ImportDefaultPrivateKeyBlob")]
    [MethodImpl]
    public extern CryptographicKey ImportKeyPair(IBuffer keyBlob);

    [Overload("ImportKeyPairWithBlobType")]
    [MethodImpl]
    public extern CryptographicKey ImportKeyPair(
      IBuffer keyBlob,
      CryptographicPrivateKeyBlobType BlobType);

    [Overload("ImportDefaultPublicKeyBlob")]
    [MethodImpl]
    public extern CryptographicKey ImportPublicKey(IBuffer keyBlob);

    [Overload("ImportPublicKeyWithBlobType")]
    [MethodImpl]
    public extern CryptographicKey ImportPublicKey(
      IBuffer keyBlob,
      CryptographicPublicKeyBlobType BlobType);

    [MethodImpl]
    public extern CryptographicKey CreateKeyPairWithCurveName(string curveName);

    [MethodImpl]
    public extern CryptographicKey CreateKeyPairWithCurveParameters(
      [Range(0, 65536)] byte[] parameters);

    [MethodImpl]
    public static extern AsymmetricKeyAlgorithmProvider OpenAlgorithm(
      string algorithm);
  }
}
