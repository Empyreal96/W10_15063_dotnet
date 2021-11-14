// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListener2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Networking.Connectivity;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocketListener))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1703788862, 47934, 17496, 178, 50, 237, 16, 136, 105, 75, 152)]
  internal interface IStreamSocketListener2 : IClosable
  {
    [Overload("BindServiceNameWithProtectionLevelAsync")]
    [RemoteAsync]
    IAsyncAction BindServiceNameAsync(
      string localServiceName,
      SocketProtectionLevel protectionLevel);

    [RemoteAsync]
    [Overload("BindServiceNameWithProtectionLevelAndAdapterAsync")]
    IAsyncAction BindServiceNameAsync(
      string localServiceName,
      SocketProtectionLevel protectionLevel,
      NetworkAdapter adapter);
  }
}
