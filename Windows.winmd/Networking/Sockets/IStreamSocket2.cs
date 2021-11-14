// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocket2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocket))]
  [Guid(701556085, 62228, 19721, 173, 240, 15, 189, 150, 127, 189, 159)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocket2 : IClosable
  {
    [RemoteAsync]
    [Overload("ConnectWithProtectionLevelAndAdapterAsync")]
    IAsyncAction ConnectAsync(
      HostName remoteHostName,
      string remoteServiceName,
      SocketProtectionLevel protectionLevel,
      NetworkAdapter adapter);
  }
}
