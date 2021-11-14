// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ISubjectAlternativeNameInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1479039473, 22173, 19488, 190, 123, 78, 28, 154, 11, 197, 43)]
  [ExclusiveTo(typeof (SubjectAlternativeNameInfo))]
  internal interface ISubjectAlternativeNameInfo
  {
    IVectorView<string> EmailName { get; }

    IVectorView<string> IPAddress { get; }

    IVectorView<string> Url { get; }

    IVectorView<string> DnsName { get; }

    IVectorView<string> DistinguishedName { get; }

    IVectorView<string> PrincipalName { get; }
  }
}
