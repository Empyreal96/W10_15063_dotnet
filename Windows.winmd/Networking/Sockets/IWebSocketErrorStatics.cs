// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketErrorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (WebSocketError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(667808603, 8033, 18185, 142, 2, 97, 40, 58, 218, 78, 157)]
  internal interface IWebSocketErrorStatics
  {
    WebErrorStatus GetStatus(int hresult);
  }
}
