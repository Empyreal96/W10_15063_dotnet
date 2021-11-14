// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.StreamSocketInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StreamSocketInformation : IStreamSocketInformation, IStreamSocketInformation2
  {
    public extern HostName LocalAddress { [MethodImpl] get; }

    public extern string LocalPort { [MethodImpl] get; }

    public extern HostName RemoteHostName { [MethodImpl] get; }

    public extern HostName RemoteAddress { [MethodImpl] get; }

    public extern string RemoteServiceName { [MethodImpl] get; }

    public extern string RemotePort { [MethodImpl] get; }

    public extern RoundTripTimeStatistics RoundTripTimeStatistics { [MethodImpl] get; }

    public extern BandwidthStatistics BandwidthStatistics { [MethodImpl] get; }

    public extern SocketProtectionLevel ProtectionLevel { [MethodImpl] get; }

    public extern IBuffer SessionKey { [MethodImpl] get; }

    public extern SocketSslErrorSeverity ServerCertificateErrorSeverity { [MethodImpl] get; }

    public extern IVectorView<ChainValidationResult> ServerCertificateErrors { [MethodImpl] get; }

    public extern Certificate ServerCertificate { [MethodImpl] get; }

    public extern IVectorView<Certificate> ServerIntermediateCertificates { [MethodImpl] get; }
  }
}
