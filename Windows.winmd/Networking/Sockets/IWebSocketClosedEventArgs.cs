// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketClosedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3468135687, 53416, 18179, 160, 145, 200, 194, 192, 145, 91, 195)]
  [ExclusiveTo(typeof (WebSocketClosedEventArgs))]
  internal interface IWebSocketClosedEventArgs
  {
    ushort Code { get; }

    string Reason { get; }
  }
}
