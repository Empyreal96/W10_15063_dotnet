// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateStoresStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(4226598713, 50942, 19943, 153, 207, 116, 195, 229, 150, 224, 50)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CertificateStores))]
  internal interface ICertificateStoresStatics
  {
    [RemoteAsync]
    [Overload("FindAllAsync")]
    IAsyncOperation<IVectorView<Certificate>> FindAllAsync();

    [RemoteAsync]
    [Overload("FindAllWithQueryAsync")]
    IAsyncOperation<IVectorView<Certificate>> FindAllAsync(
      CertificateQuery query);

    CertificateStore TrustedRootCertificationAuthorities { get; }

    CertificateStore IntermediateCertificationAuthorities { get; }

    CertificateStore GetStoreByName(string storeName);
  }
}
