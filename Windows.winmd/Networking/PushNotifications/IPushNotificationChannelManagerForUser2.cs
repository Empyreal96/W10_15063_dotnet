// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.IPushNotificationChannelManagerForUser2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Networking.PushNotifications
{
  [ExclusiveTo(typeof (PushNotificationChannelManagerForUser))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3280668266, 31937, 19884, 135, 253, 190, 110, 146, 4, 20, 164)]
  internal interface IPushNotificationChannelManagerForUser2
  {
    [RemoteAsync]
    [Overload("CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync")]
    IAsyncOperation<PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(
      IBuffer appServerKey,
      string channelId);

    [RemoteAsync]
    [Overload("CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsyncWithId")]
    IAsyncOperation<PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(
      IBuffer appServerKey,
      string channelId,
      string appId);
  }
}
