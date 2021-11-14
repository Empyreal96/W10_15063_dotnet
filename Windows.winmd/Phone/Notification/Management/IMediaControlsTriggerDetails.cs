// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IMediaControlsTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ExclusiveTo(typeof (MediaControlsTriggerDetails))]
  [Guid(4206126219, 44613, 17736, 145, 202, 74, 176, 84, 142, 51, 181)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IMediaControlsTriggerDetails : IAccessoryNotificationTriggerDetails
  {
    PlaybackStatus PlaybackStatus { get; }

    MediaMetadata MediaMetadata { get; }
  }
}
