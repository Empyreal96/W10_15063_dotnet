// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateEnrollmentManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICertificateEnrollmentManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICertificateEnrollmentManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (ICertificateEnrollmentManagerStatics3), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class CertificateEnrollmentManager
  {
    [RemoteAsync]
    [Overload("ImportPfxDataToKspWithParametersAsync")]
    [MethodImpl]
    public static extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      PfxImportParameters pfxImportParameters);

    public static extern UserCertificateEnrollmentManager UserCertificateEnrollmentManager { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("ImportPfxDataToKspAsync")]
    [MethodImpl]
    public static extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName,
      string keyStorageProvider);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> CreateRequestAsync(
      CertificateRequestProperties request);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction InstallCertificateAsync(
      string certificate,
      InstallOptions installOption);

    [Overload("ImportPfxDataAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ImportPfxDataAsync(
      string pfxData,
      string password,
      ExportOption exportable,
      KeyProtectionLevel keyProtectionLevel,
      InstallOptions installOption,
      string friendlyName);
  }
}
