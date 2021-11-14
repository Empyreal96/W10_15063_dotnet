// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateKeyUsages
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class CertificateKeyUsages : ICertificateKeyUsages
  {
    [MethodImpl]
    public extern CertificateKeyUsages();

    public extern bool EncipherOnly { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CrlSign { [MethodImpl] get; [MethodImpl] set; }

    public extern bool KeyCertificateSign { [MethodImpl] get; [MethodImpl] set; }

    public extern bool KeyAgreement { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DataEncipherment { [MethodImpl] get; [MethodImpl] set; }

    public extern bool KeyEncipherment { [MethodImpl] get; [MethodImpl] set; }

    public extern bool NonRepudiation { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DigitalSignature { [MethodImpl] get; [MethodImpl] set; }
  }
}
