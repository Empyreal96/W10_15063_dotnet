// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(871028162, 38812, 17429, 130, 161, 60, 250, 246, 70, 193, 146)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatagramSocketControl))]
  internal interface IDatagramSocketControl2
  {
    uint InboundBufferSizeInBytes { get; set; }

    bool DontFragment { get; set; }
  }
}
