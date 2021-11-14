// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IControlChannelTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(2098475431, 61078, 16616, 161, 153, 135, 3, 205, 150, 158, 195)]
  [ContractVersion(typeof (ControlChannelTriggerContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ControlChannelTrigger))]
  internal interface IControlChannelTrigger : IClosable
  {
    string ControlChannelTriggerId { get; }

    uint ServerKeepAliveIntervalInMinutes { get; set; }

    uint CurrentKeepAliveIntervalInMinutes { get; }

    object TransportObject { get; }

    IBackgroundTrigger KeepAliveTrigger { get; }

    IBackgroundTrigger PushNotificationTrigger { get; }

    void UsingTransport(object transport);

    ControlChannelTriggerStatus WaitForPushEnabled();

    void DecreaseNetworkKeepAliveInterval();

    void FlushTransport();
  }
}
