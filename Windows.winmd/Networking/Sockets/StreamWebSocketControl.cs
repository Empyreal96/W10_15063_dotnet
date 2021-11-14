// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamWebSocketControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public sealed class StreamWebSocketControl : 
    IStreamWebSocketControl,
    IWebSocketControl,
    IWebSocketControl2
  {
    public extern bool NoDelay { [MethodImpl] get; [MethodImpl] set; }

    public extern uint OutboundBufferSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> SupportedProtocols { [MethodImpl] get; }

    public extern IVector<ChainValidationResult> IgnorableServerCertificateErrors { [MethodImpl] get; }
  }
}
