// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.HttpServerCustomValidationRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http.Filters
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772160)]
  public sealed class HttpServerCustomValidationRequestedEventArgs : 
    IHttpServerCustomValidationRequestedEventArgs
  {
    public extern HttpRequestMessage RequestMessage { [MethodImpl] get; }

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
