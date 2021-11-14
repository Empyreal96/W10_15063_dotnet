// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(1387020078, 13466, 16693, 187, 88, 183, 155, 38, 71, 211, 144)]
  [ExclusiveTo(typeof (DatagramSocketControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDatagramSocketControl
  {
    SocketQualityOfService QualityOfService { get; set; }

    byte OutboundUnicastHopLimit { get; set; }
  }
}
