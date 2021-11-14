// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1577181974, 51498, 18341, 178, 95, 7, 132, 118, 57, 209, 129)]
  public interface IWebSocketInformation
  {
    HostName LocalAddress { get; }

    BandwidthStatistics BandwidthStatistics { get; }

    string Protocol { get; }
  }
}
