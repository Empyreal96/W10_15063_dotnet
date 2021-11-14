// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateKeyUsages
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateKeyUsages))]
  [Guid(1791369327, 57807, 18538, 180, 133, 166, 156, 131, 228, 111, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICertificateKeyUsages
  {
    bool EncipherOnly { get; set; }

    bool CrlSign { get; set; }

    bool KeyCertificateSign { get; set; }

    bool KeyAgreement { get; set; }

    bool DataEncipherment { get; set; }

    bool KeyEncipherment { get; set; }

    bool NonRepudiation { get; set; }

    bool DigitalSignature { get; set; }
  }
}
