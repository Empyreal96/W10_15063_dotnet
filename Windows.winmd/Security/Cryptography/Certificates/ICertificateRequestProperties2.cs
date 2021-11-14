// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateRequestProperties2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(1033947476, 55103, 20467, 160, 166, 6, 119, 192, 173, 160, 91)]
  [ExclusiveTo(typeof (CertificateRequestProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateRequestProperties2
  {
    string SmartcardReaderName { get; set; }

    Certificate SigningCertificate { get; set; }

    Certificate AttestationCredentialCertificate { get; set; }
  }
}
