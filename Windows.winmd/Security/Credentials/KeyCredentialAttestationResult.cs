// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.KeyCredentialAttestationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class KeyCredentialAttestationResult : IKeyCredentialAttestationResult
  {
    public extern IBuffer CertificateChainBuffer { [MethodImpl] get; }

    public extern IBuffer AttestationBuffer { [MethodImpl] get; }

    public extern KeyCredentialAttestationStatus Status { [MethodImpl] get; }
  }
}
