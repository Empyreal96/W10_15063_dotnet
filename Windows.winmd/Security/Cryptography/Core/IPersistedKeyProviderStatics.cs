// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IPersistedKeyProviderStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Security.Cryptography.Core
{
  [Guid(1999063060, 55764, 19701, 182, 104, 224, 69, 125, 243, 8, 148)]
  [ExclusiveTo(typeof (PersistedKeyProvider))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPersistedKeyProviderStatics
  {
    [RemoteAsync]
    IAsyncOperation<CryptographicKey> OpenKeyPairFromCertificateAsync(
      Certificate certificate,
      string hashAlgorithmName,
      CryptographicPadding padding);

    CryptographicKey OpenPublicKeyFromCertificate(
      Certificate certificate,
      string hashAlgorithmName,
      CryptographicPadding padding);
  }
}
