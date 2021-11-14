// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.ICryptographicEngineStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1733904638, 57247, 16785, 146, 199, 108, 230, 245, 132, 32, 224)]
  [ExclusiveTo(typeof (CryptographicEngine))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICryptographicEngineStatics2
  {
    IBuffer SignHashedData(CryptographicKey key, IBuffer data);

    bool VerifySignatureWithHashInput(CryptographicKey key, IBuffer data, IBuffer signature);

    [RemoteAsync]
    IAsyncOperation<IBuffer> DecryptAsync(
      CryptographicKey key,
      IBuffer data,
      IBuffer iv);

    [RemoteAsync]
    IAsyncOperation<IBuffer> SignAsync(CryptographicKey key, IBuffer data);

    [RemoteAsync]
    IAsyncOperation<IBuffer> SignHashedDataAsync(
      CryptographicKey key,
      IBuffer data);
  }
}
