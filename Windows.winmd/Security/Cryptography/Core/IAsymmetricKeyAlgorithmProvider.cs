// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IAsymmetricKeyAlgorithmProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3906142007, 25177, 20104, 183, 224, 148, 25, 31, 222, 105, 158)]
  [ExclusiveTo(typeof (AsymmetricKeyAlgorithmProvider))]
  internal interface IAsymmetricKeyAlgorithmProvider
  {
    string AlgorithmName { get; }

    CryptographicKey CreateKeyPair(uint keySize);

    [Overload("ImportDefaultPrivateKeyBlob")]
    CryptographicKey ImportKeyPair(IBuffer keyBlob);

    [Overload("ImportKeyPairWithBlobType")]
    CryptographicKey ImportKeyPair(
      IBuffer keyBlob,
      CryptographicPrivateKeyBlobType BlobType);

    [Overload("ImportDefaultPublicKeyBlob")]
    CryptographicKey ImportPublicKey(IBuffer keyBlob);

    [Overload("ImportPublicKeyWithBlobType")]
    CryptographicKey ImportPublicKey(
      IBuffer keyBlob,
      CryptographicPublicKeyBlobType BlobType);
  }
}
