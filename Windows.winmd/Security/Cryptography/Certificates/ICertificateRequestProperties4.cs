// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateRequestProperties4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1312987858, 7265, 20458, 184, 254, 19, 95, 177, 156, 220, 228)]
  [ExclusiveTo(typeof (CertificateRequestProperties))]
  internal interface ICertificateRequestProperties4
  {
    IVector<string> SuppressedDefaults { get; }

    SubjectAlternativeNameInfo SubjectAlternativeName { get; }

    IVector<CertificateExtension> Extensions { get; }
  }
}
