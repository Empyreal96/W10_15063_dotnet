// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.CryptographicEngine
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Static(typeof (ICryptographicEngineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (ICryptographicEngineStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class CryptographicEngine
  {
    [MethodImpl]
    public static extern IBuffer SignHashedData(CryptographicKey key, IBuffer data);

    [MethodImpl]
    public static extern bool VerifySignatureWithHashInput(
      CryptographicKey key,
      IBuffer data,
      IBuffer signature);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> DecryptAsync(
      CryptographicKey key,
      IBuffer data,
      IBuffer iv);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> SignAsync(
      CryptographicKey key,
      IBuffer data);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IBuffer> SignHashedDataAsync(
      CryptographicKey key,
      IBuffer data);

    [MethodImpl]
    public static extern IBuffer Encrypt(CryptographicKey key, IBuffer data, IBuffer iv);

    [MethodImpl]
    public static extern IBuffer Decrypt(CryptographicKey key, IBuffer data, IBuffer iv);

    [MethodImpl]
    public static extern EncryptedAndAuthenticatedData EncryptAndAuthenticate(
      CryptographicKey key,
      IBuffer data,
      IBuffer nonce,
      IBuffer authenticatedData);

    [MethodImpl]
    public static extern IBuffer DecryptAndAuthenticate(
      CryptographicKey key,
      IBuffer data,
      IBuffer nonce,
      IBuffer authenticationTag,
      IBuffer authenticatedData);

    [MethodImpl]
    public static extern IBuffer Sign(CryptographicKey key, IBuffer data);

    [MethodImpl]
    public static extern bool VerifySignature(
      CryptographicKey key,
      IBuffer data,
      IBuffer signature);

    [MethodImpl]
    public static extern IBuffer DeriveKeyMaterial(
      CryptographicKey key,
      KeyDerivationParameters parameters,
      uint desiredKeySize);
  }
}
