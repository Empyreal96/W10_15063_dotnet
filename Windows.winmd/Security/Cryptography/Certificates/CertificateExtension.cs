// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateExtension
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Threading(ThreadingModel.Both)]
  [Activatable(262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772163)]
  public sealed class CertificateExtension : ICertificateExtension
  {
    [MethodImpl]
    public extern CertificateExtension();

    public extern string ObjectId { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCritical { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void EncodeValue(string value);

    public extern byte[] Value { [MethodImpl] get; [MethodImpl] set; }
  }
}
