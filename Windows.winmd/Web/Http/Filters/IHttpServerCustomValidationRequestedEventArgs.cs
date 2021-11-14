// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Filters.IHttpServerCustomValidationRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http.Filters
{
  [Guid(828767794, 59357, 18615, 163, 97, 147, 156, 117, 14, 99, 204)]
  [ExclusiveTo(typeof (HttpServerCustomValidationRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IHttpServerCustomValidationRequestedEventArgs
  {
    HttpRequestMessage RequestMessage { get; }

    Certificate ServerCertificate { get; }

    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    IVectorView<Certificate> ServerIntermediateCertificates { get; }

    void Reject();

    Deferral GetDeferral();
  }
}
