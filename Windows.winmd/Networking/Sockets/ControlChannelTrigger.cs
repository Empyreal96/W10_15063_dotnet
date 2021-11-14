// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.ControlChannelTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (ControlChannelTriggerContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (IControlChannelTriggerFactory), 65536, "Windows.Networking.Sockets.ControlChannelTriggerContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ControlChannelTrigger : 
    IControlChannelTrigger,
    IClosable,
    IControlChannelTrigger2
  {
    [MethodImpl]
    public extern ControlChannelTrigger(string channelId, uint serverKeepAliveIntervalInMinutes);

    [MethodImpl]
    public extern ControlChannelTrigger(
      string channelId,
      uint serverKeepAliveIntervalInMinutes,
      ControlChannelTriggerResourceType resourceRequestType);

    public extern string ControlChannelTriggerId { [MethodImpl] get; }

    public extern uint ServerKeepAliveIntervalInMinutes { [MethodImpl] get; [MethodImpl] set; }

    public extern uint CurrentKeepAliveIntervalInMinutes { [MethodImpl] get; }

    public extern object TransportObject { [MethodImpl] get; }

    public extern IBackgroundTrigger KeepAliveTrigger { [MethodImpl] get; }

    public extern IBackgroundTrigger PushNotificationTrigger { [MethodImpl] get; }

    [MethodImpl]
    public extern void UsingTransport(object transport);

    [MethodImpl]
    public extern ControlChannelTriggerStatus WaitForPushEnabled();

    [MethodImpl]
    public extern void DecreaseNetworkKeepAliveInterval();

    [MethodImpl]
    public extern void FlushTransport();

    [MethodImpl]
    public extern void Close();

    public extern bool IsWakeFromLowPowerSupported { [MethodImpl] get; }
  }
}
