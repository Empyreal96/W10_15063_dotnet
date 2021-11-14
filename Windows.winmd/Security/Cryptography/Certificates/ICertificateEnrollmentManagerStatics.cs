// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateEnrollmentManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(2286350143, 43398, 18683, 159, 215, 154, 236, 6, 147, 91, 241)]
  [ExclusiveTo(typeof (CertificateEnrollmentManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateEnrollmentManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<string> CreateRequestAsync(CertificateRequestProperties request);

    [RemoteAsync]
    IAsyncAction InstallCertificateAsync(
      string certificate,
      InstallOptions installOption);

    [Overload("ImportPfxDataAsync")]
    [RemoteAsync]
    IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName);
  }
}
