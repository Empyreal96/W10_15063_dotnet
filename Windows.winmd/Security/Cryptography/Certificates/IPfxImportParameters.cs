// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IPfxImportParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1745696017, 39432, 18376, 134, 74, 46, 221, 77, 142, 180, 108)]
  [ExclusiveTo(typeof (PfxImportParameters))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPfxImportParameters
  {
    ExportOption Exportable { get; set; }

    KeyProtectionLevel KeyProtectionLevel { get; set; }

    InstallOptions InstallOptions { get; set; }

    string FriendlyName { get; set; }

    string KeyStorageProviderName { get; set; }

    string ContainerNamePrefix { get; set; }

    string ReaderName { get; set; }
  }
}
