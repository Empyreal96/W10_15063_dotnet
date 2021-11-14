// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ISocketErrorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(2189637620, 32086, 19854, 183, 180, 160, 125, 215, 193, 188, 169)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SocketError))]
  internal interface ISocketErrorStatics
  {
    SocketErrorStatus GetStatus(int hresult);
  }
}
