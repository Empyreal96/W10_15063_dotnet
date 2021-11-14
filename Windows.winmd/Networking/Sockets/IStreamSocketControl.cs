// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(4263882225, 37547, 19187, 153, 146, 15, 76, 133, 227, 108, 196)]
  [ExclusiveTo(typeof (StreamSocketControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketControl
  {
    bool NoDelay { get; set; }

    bool KeepAlive { get; set; }

    uint OutboundBufferSizeInBytes { get; set; }

    SocketQualityOfService QualityOfService { get; set; }

    byte OutboundUnicastHopLimit { get; set; }
  }
}
