// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IToastNotificationManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IToastNotificationManagerStatics4), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (IToastNotificationManagerStatics5), 262144, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IToastNotificationManagerStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  public static class ToastNotificationManager
  {
    [MethodImpl]
    public static extern ToastNotificationManagerForUser GetDefault();

    [MethodImpl]
    public static extern ToastNotificationManagerForUser GetForUser(
      User user);

    [MethodImpl]
    public static extern void ConfigureNotificationMirroring(NotificationMirroring value);

    public static extern ToastNotificationHistory History { [MethodImpl] get; }

    [Overload("CreateToastNotifier")]
    [MethodImpl]
    public static extern ToastNotifier CreateToastNotifier();

    [Overload("CreateToastNotifierWithId")]
    [MethodImpl]
    public static extern ToastNotifier CreateToastNotifier(string applicationId);

    [MethodImpl]
    public static extern XmlDocument GetTemplateContent(ToastTemplateType type);
  }
}
