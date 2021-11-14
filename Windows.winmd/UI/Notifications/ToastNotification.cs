// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Activatable(typeof (IToastNotificationFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [DualApiPartition(version = 100794368)]
  public sealed class ToastNotification : 
    IToastNotification,
    IToastNotification2,
    IToastNotification3,
    IToastNotification4
  {
    [MethodImpl]
    public extern ToastNotification(XmlDocument content);

    public extern XmlDocument Content { [MethodImpl] get; }

    public extern IReference<DateTime> ExpirationTime { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Dismissed;

    public extern event TypedEventHandler<ToastNotification, object> Activated;

    public extern event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Failed;

    public extern string Tag { [MethodImpl] set; [MethodImpl] get; }

    public extern string Group { [MethodImpl] set; [MethodImpl] get; }

    public extern bool SuppressPopup { [MethodImpl] set; [MethodImpl] get; }

    public extern NotificationMirroring NotificationMirroring { [MethodImpl] get; [MethodImpl] set; }

    public extern string RemoteId { [MethodImpl] get; [MethodImpl] set; }

    public extern NotificationData Data { [MethodImpl] get; [MethodImpl] set; }

    public extern ToastNotificationPriority Priority { [MethodImpl] get; [MethodImpl] set; }
  }
}
