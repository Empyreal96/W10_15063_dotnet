// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CertificateStore : ICertificateStore, ICertificateStore2
  {
    [MethodImpl]
    public extern void Add(Certificate certificate);

    [MethodImpl]
    public extern void Delete(Certificate certificate);

    public extern string Name { [MethodImpl] get; }
  }
}
