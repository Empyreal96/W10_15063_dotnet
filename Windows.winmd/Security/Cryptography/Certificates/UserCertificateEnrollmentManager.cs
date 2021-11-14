// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.UserCertificateEnrollmentManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class UserCertificateEnrollmentManager : 
    IUserCertificateEnrollmentManager,
    IUserCertificateEnrollmentManager2
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CreateRequestAsync(
      CertificateRequestProperties request);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction InstallCertificateAsync(
      string certificate,
      InstallOptions installOption);

    [RemoteAsync]
    [Overload("ImportPfxDataAsync")]
    [MethodImpl]
    public extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName);

    [RemoteAsync]
    [Overload("ImportPfxDataToKspAsync")]
    [MethodImpl]
    public extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName,
      string keyStorageProvider);

    [RemoteAsync]
    [Overload("ImportPfxDataToKspWithParametersAsync")]
    [MethodImpl]
    public extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      PfxImportParameters pfxImportParameters);
  }
}
