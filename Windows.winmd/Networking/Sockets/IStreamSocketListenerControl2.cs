// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListenerControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocketListenerControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2492184165, 11326, 16459, 184, 176, 142, 178, 73, 162, 176, 161)]
  internal interface IStreamSocketListenerControl2
  {
    bool NoDelay { get; set; }

    bool KeepAlive { get; set; }

    uint OutboundBufferSizeInBytes { get; set; }

    byte OutboundUnicastHopLimit { get; set; }
  }
}
