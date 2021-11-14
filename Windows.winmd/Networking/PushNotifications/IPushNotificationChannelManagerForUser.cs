// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.Networking.PushNotifications
{
  [ExclusiveTo(typeof (PushNotificationChannelManagerForUser))]
  [Guid(2764330756, 4482, 17095, 136, 144, 245, 99, 196, 137, 13, 196)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPushNotificationChannelManagerForUser
  {
    [RemoteAsync]
    [Overload("CreatePushNotificationChannelForApplicationAsync")]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();

    [RemoteAsync]
    [Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(
      string applicationId);

    [RemoteAsync]
    IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(
      string tileId);

    User User { get; }
  }
}
