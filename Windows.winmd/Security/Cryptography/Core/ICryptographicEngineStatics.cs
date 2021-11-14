// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ICryptographicEngineStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2682914361, 28663, 19589, 160, 149, 149, 235, 49, 113, 94, 185)]
  [ExclusiveTo(typeof (CryptographicEngine))]
  internal interface ICryptographicEngineStatics
  {
    IBuffer Encrypt(CryptographicKey key, IBuffer data, IBuffer iv);

    IBuffer Decrypt(CryptographicKey key, IBuffer data, IBuffer iv);

    EncryptedAndAuthenticatedData EncryptAndAuthenticate(
      CryptographicKey key,
      IBuffer data,
      IBuffer nonce,
      IBuffer authenticatedData);

    IBuffer DecryptAndAuthenticate(
      CryptographicKey key,
      IBuffer data,
      IBuffer nonce,
      IBuffer authenticationTag,
      IBuffer authenticatedData);

    IBuffer Sign(CryptographicKey key, IBuffer data);

    bool VerifySignature(CryptographicKey key, IBuffer data, IBuffer signature);

    IBuffer DeriveKeyMaterial(
      CryptographicKey key,
      KeyDerivationParameters parameters,
      uint desiredKeySize);
  }
}
