// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class WebSocketServerCustomValidationRequestedEventArgs : 
    IWebSocketServerCustomValidationRequestedEventArgs
  {
    public extern Certificate ServerCertificate { [MethodImpl] get; }

    public extern SocketSslErrorSeverity ServerCertificateErrorSeverity { [MethodImpl] get; }

    public extern IVectorView<ChainValidationResult> ServerCertificateErrors { [MethodImpl] get; }

    public extern IVectorView<Certificate> ServerIntermediateCertificates { [MethodImpl] get; }

    [MethodImpl]
    public extern void Reject();

    [MethodImpl]
    public extern Deferral GetDeferral();
  }
}
