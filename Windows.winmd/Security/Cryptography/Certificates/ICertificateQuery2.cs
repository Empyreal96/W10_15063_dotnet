// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateQuery2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateQuery))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2472151799, 3033, 20341, 184, 194, 226, 122, 127, 116, 238, 205)]
  internal interface ICertificateQuery2
  {
    bool IncludeDuplicates { get; set; }

    bool IncludeExpiredCertificates { get; set; }

    string StoreName { get; set; }
  }
}
