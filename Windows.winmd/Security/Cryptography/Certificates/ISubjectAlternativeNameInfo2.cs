// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ISubjectAlternativeNameInfo2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SubjectAlternativeNameInfo))]
  [Guid(1132099782, 7249, 16874, 179, 74, 61, 101, 67, 152, 163, 112)]
  internal interface ISubjectAlternativeNameInfo2
  {
    IVector<string> EmailNames { get; }

    IVector<string> IPAddresses { get; }

    IVector<string> Urls { get; }

    IVector<string> DnsNames { get; }

    IVector<string> DistinguishedNames { get; }

    IVector<string> PrincipalNames { get; }

    CertificateExtension Extension { get; }
  }
}
