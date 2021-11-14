// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IUserCertificateEnrollmentManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserCertificateEnrollmentManager))]
  [Guid(229481649, 26078, 18730, 184, 109, 252, 92, 72, 44, 55, 71)]
  internal interface IUserCertificateEnrollmentManager2
  {
    [RemoteAsync]
    [Overload("ImportPfxDataToKspWithParametersAsync")]
    IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      PfxImportParameters pfxImportParameters);
  }
}
