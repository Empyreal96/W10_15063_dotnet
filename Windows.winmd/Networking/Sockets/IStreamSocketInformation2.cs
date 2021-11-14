// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketInformation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StreamSocketInformation))]
  [Guid(314737746, 19420, 20196, 151, 106, 207, 19, 14, 157, 146, 227)]
  internal interface IStreamSocketInformation2
  {
    SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }

    IVectorView<ChainValidationResult> ServerCertificateErrors { get; }

    Certificate ServerCertificate { get; }

    IVectorView<Certificate> ServerIntermediateCertificates { get; }
  }
}
