// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IControlChannelTriggerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (ControlChannelTriggerContract), 65536)]
  [WebHostHidden]
  [Guid(3662380272, 36209, 17519, 136, 195, 185, 81, 132, 162, 214, 205)]
  [ExclusiveTo(typeof (ControlChannelTrigger))]
  internal interface IControlChannelTriggerFactory
  {
    ControlChannelTrigger CreateControlChannelTrigger(
      string channelId,
      uint serverKeepAliveIntervalInMinutes);

    ControlChannelTrigger CreateControlChannelTriggerEx(
      string channelId,
      uint serverKeepAliveIntervalInMinutes,
      ControlChannelTriggerResourceType resourceRequestType);
  }
}
