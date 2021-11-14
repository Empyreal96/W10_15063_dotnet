// Decompiled with JetBrains decompiler
// Type: Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.System;

namespace Windows.Networking.PushNotifications
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class PushNotificationChannelManagerForUser : 
    IPushNotificationChannelManagerForUser,
    IPushNotificationChannelManagerForUser2
  {
    [Overload("CreatePushNotificationChannelForApplicationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync();

    [RemoteAsync]
    [Overload("CreatePushNotificationChannelForApplicationAsyncWithId")]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForApplicationAsync(
      string applicationId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreatePushNotificationChannelForSecondaryTileAsync(
      string tileId);

    public extern User User { [MethodImpl] get; }

    [Overload("CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(
      IBuffer appServerKey,
      string channelId);

    [Overload("CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsyncWithId")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<PushNotificationChannel> CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(
      IBuffer appServerKey,
      string channelId,
      string appId);
  }
}
