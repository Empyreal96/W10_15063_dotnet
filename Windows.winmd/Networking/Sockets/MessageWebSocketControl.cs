// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.MessageWebSocketControl
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
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MessageWebSocketControl : 
    IMessageWebSocketControl,
    IWebSocketControl,
    IWebSocketControl2
  {
    public extern uint MaxMessageSize { [MethodImpl] get; [MethodImpl] set; }

    public extern SocketMessageType MessageType { [MethodImpl] get; [MethodImpl] set; }

    public extern uint OutboundBufferSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential ServerCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern PasswordCredential ProxyCredential { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<string> SupportedProtocols { [MethodImpl] get; }

    public extern IVector<ChainValidationResult> IgnorableServerCertificateErrors { [MethodImpl] get; }
  }
}
