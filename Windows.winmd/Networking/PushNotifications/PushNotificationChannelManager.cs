// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.PushNotificationChannelManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Networking.PushNotifications
{
  [Static(typeof (IPushNotificationChannelManagerStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPushNotificationChannelManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (IPushNotificationChannelManagerStatics3), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class PushNotificationChannelManager
  {
    [MethodImpl]
    public static extern PushNotificationChannelManagerForUser GetDefault();

    [MethodImpl]
    public static extern PushNotificationChannelManagerForUser GetForUser(
      User user);

    [Overload("CreatePushNotificationChannelForApplicationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();

    [Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(
      string applicationId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(
      string tileId);
  }
}
