// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamWebSocketControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamWebSocketControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3035920561, 42074, 18651, 149, 58, 100, 91, 125, 150, 76, 7)]
  internal interface IStreamWebSocketControl : IWebSocketControl
  {
    bool NoDelay { get; set; }
  }
}
