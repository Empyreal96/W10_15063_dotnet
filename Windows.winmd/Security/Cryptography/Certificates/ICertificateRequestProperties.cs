// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateRequestProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1216251126, 38114, 19918, 136, 51, 26, 112, 10, 55, 162, 154)]
  [ExclusiveTo(typeof (CertificateRequestProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateRequestProperties
  {
    string Subject { get; set; }

    string KeyAlgorithmName { get; set; }

    uint KeySize { get; set; }

    string FriendlyName { get; set; }

    string HashAlgorithmName { get; set; }

    ExportOption Exportable { get; set; }

    EnrollKeyUsages KeyUsages { get; set; }

    KeyProtectionLevel KeyProtectionLevel { get; set; }

    string KeyStorageProviderName { get; set; }
  }
}
