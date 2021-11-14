// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateQuery
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CertificateQuery : ICertificateQuery, ICertificateQuery2
  {
    [MethodImpl]
    public extern CertificateQuery();

    public extern IVector<string> EnhancedKeyUsages { [MethodImpl] get; }

    public extern string IssuerName { [MethodImpl] get; [MethodImpl] set; }

    public extern string FriendlyName { [MethodImpl] get; [MethodImpl] set; }

    public extern byte[] Thumbprint { [MethodImpl] get; [MethodImpl] set; }

    public extern bool HardwareOnly { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IncludeDuplicates { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IncludeExpiredCertificates { [MethodImpl] get; [MethodImpl] set; }

    public extern string StoreName { [MethodImpl] get; [MethodImpl] set; }
  }
}
