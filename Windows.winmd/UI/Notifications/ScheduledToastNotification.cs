// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ScheduledToastNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IScheduledToastNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  public sealed class ScheduledToastNotification : 
    IScheduledToastNotification,
    IScheduledToastNotification2,
    IScheduledToastNotification3
  {
    [MethodImpl]
    public extern ScheduledToastNotification(XmlDocument content, DateTime deliveryTime);

    [MethodImpl]
    public extern ScheduledToastNotification(
      XmlDocument content,
      DateTime deliveryTime,
      TimeSpan snoozeInterval,
      uint maximumSnoozeCount);

    public extern XmlDocument Content { [MethodImpl] get; }

    public extern DateTime DeliveryTime { [MethodImpl] get; }

    public extern IReference<TimeSpan> SnoozeInterval { [MethodImpl] get; }

    public extern uint MaximumSnoozeCount { [MethodImpl] get; }

    public extern string Id { [MethodImpl] set; [MethodImpl] get; }

    public extern string Tag { [MethodImpl] set; [MethodImpl] get; }

    public extern string Group { [MethodImpl] set; [MethodImpl] get; }

    public extern bool SuppressPopup { [MethodImpl] set; [MethodImpl] get; }

    public extern NotificationMirroring NotificationMirroring { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }
  }
}
