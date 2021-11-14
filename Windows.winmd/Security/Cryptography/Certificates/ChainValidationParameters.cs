// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ChainValidationParameters
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Security.Cryptography.Certificates
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChainValidationParameters : IChainValidationParameters
  {
    [MethodImpl]
    public extern ChainValidationParameters();

    public extern CertificateChainPolicy CertificateChainPolicy { [MethodImpl] get; [MethodImpl] set; }

    public extern HostName ServerDnsName { [MethodImpl] get; [MethodImpl] set; }
  }
}
