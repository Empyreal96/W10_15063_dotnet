// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateEnrollmentManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(3696958515, 25641, 16404, 153, 156, 93, 151, 53, 128, 45, 29)]
  [ExclusiveTo(typeof (CertificateEnrollmentManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateEnrollmentManagerStatics2
  {
    UserCertificateEnrollmentManager UserCertificateEnrollmentManager { get; }

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
