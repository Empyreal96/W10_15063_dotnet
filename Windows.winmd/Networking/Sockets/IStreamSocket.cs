// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocket
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocket))]
  [Guid(1772236019, 64635, 18519, 175, 56, 246, 231, 222, 106, 91, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocket : IClosable
  {
    StreamSocketControl Control { get; }

    StreamSocketInformation Information { get; }

    IInputStream InputStream { get; }

    IOutputStream OutputStream { get; }

    [Overload("ConnectWithEndpointPairAsync")]
    IAsyncAction ConnectAsync(EndpointPair endpointPair);

    [DefaultOverload]
    [Overload("ConnectAsync")]
    [RemoteAsync]
    IAsyncAction ConnectAsync(HostName remoteHostName, string remoteServiceName);

    [Overload("ConnectWithEndpointPairAndProtectionLevelAsync")]
    IAsyncAction ConnectAsync(
      EndpointPair endpointPair,
      SocketProtectionLevel protectionLevel);

    [Overload("ConnectWithProtectionLevelAsync")]
    [RemoteAsync]
    IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName,
      SocketProtectionLevel protectionLevel);

    [RemoteAsync]
    IAsyncAction UpgradeToSslAsync(
      SocketProtectionLevel protectionLevel,
      HostName validationHostName);
  }
}
