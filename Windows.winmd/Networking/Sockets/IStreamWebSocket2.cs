// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamWebSocket2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamWebSocket))]
  [Guid(2857175243, 37877, 18040, 130, 54, 87, 204, 229, 65, 126, 213)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IStreamWebSocket2 : IStreamWebSocket, IWebSocket, IClosable
  {
    event TypedEventHandler<StreamWebSocket, WebSocketServerCustomValidationRequestedEventArgs> ServerCustomValidationRequested;
  }
}
