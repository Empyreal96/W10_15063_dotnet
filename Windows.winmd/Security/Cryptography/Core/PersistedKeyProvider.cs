// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.PersistedKeyProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Security.Cryptography.Core
{
  [Static(typeof (IPersistedKeyProviderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class PersistedKeyProvider
  {
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CryptographicKey> OpenKeyPairFromCertificateAsync(
      Certificate certificate,
      string hashAlgorithmName,
      CryptographicPadding padding);

    [MethodImpl]
    public static extern CryptographicKey OpenPublicKeyFromCertificate(
      Certificate certificate,
      string hashAlgorithmName,
      CryptographicPadding padding);
  }
}
