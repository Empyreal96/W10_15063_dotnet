// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketServerCustomValidationRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [Guid(4293918280, 554, 19127, 139, 54, 225, 10, 244, 100, 14, 107)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (WebSocketServerCustomValidationRequestedEventArgs))]
  internal interface IWebSocketServerCustomValidationRequestedEventArgs
  {
    Certificate ServerCertificate { get; }

    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    IVectorView<Certificate> ServerIntermediateCertificates { get; }

    void Reject();

    Deferral GetDeferral();
  }
}
