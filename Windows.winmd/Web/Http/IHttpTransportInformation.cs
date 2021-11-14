// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.IHttpTransportInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking.Sockets;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Web.Http
{
  [ExclusiveTo(typeof (HttpTransportInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1880256920, 50855, 20176, 131, 58, 131, 253, 139, 143, 23, 141)]
  internal interface IHttpTransportInformation
  {
    Certificate ServerCertificate { get; }

    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    IVectorView<Certificate> ServerIntermediateCertificates { get; }
  }
}
