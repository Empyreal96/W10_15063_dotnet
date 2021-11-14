// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IUserCertificateEnrollmentManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (UserCertificateEnrollmentManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2519807768, 8929, 18457, 178, 11, 171, 70, 166, 236, 160, 110)]
  internal interface IUserCertificateEnrollmentManager
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

    [RemoteAsync]
    [Overload("ImportPfxDataToKspAsync")]
    IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName,
      string keyStorageProvider);
  }
}
