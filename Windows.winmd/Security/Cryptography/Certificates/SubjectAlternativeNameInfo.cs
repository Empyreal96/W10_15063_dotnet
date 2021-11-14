// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.SubjectAlternativeNameInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SubjectAlternativeNameInfo : 
    ISubjectAlternativeNameInfo,
    ISubjectAlternativeNameInfo2
  {
    [MethodImpl]
    public extern SubjectAlternativeNameInfo();

    public extern IVectorView<string> EmailName { [MethodImpl] get; }

    public extern IVectorView<string> IPAddress { [MethodImpl] get; }

    public extern IVectorView<string> Url { [MethodImpl] get; }

    public extern IVectorView<string> DnsName { [MethodImpl] get; }

    public extern IVectorView<string> DistinguishedName { [MethodImpl] get; }

    public extern IVectorView<string> PrincipalName { [MethodImpl] get; }

    public extern IVector<string> EmailNames { [MethodImpl] get; }

    public extern IVector<string> IPAddresses { [MethodImpl] get; }

    public extern IVector<string> Urls { [MethodImpl] get; }

    public extern IVector<string> DnsNames { [MethodImpl] get; }

    public extern IVector<string> DistinguishedNames { [MethodImpl] get; }

    public extern IVector<string> PrincipalNames { [MethodImpl] get; }

    public extern CertificateExtension Extension { [MethodImpl] get; }
  }
}
