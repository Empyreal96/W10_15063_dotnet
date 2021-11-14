// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateExtension
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(2228160086, 43494, 17741, 142, 69, 46, 167, 196, 188, 213, 59)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CertificateExtension))]
  internal interface ICertificateExtension
  {
    string ObjectId { get; set; }

    bool IsCritical { get; set; }

    void EncodeValue(string value);

    byte[] Value { get; set; }
  }
}
