// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.AccessoryManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.Notification.Management
{
  [Static(typeof (IAccessoryManager), 65536, "Windows.Phone.PhoneContract")]
  [Static(typeof (IAccessoryManager2), 65536, "Windows.Phone.PhoneContract")]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Static(typeof (IAccessoryManager3), 65536, "Windows.Phone.PhoneContract")]
  public static class AccessoryManager
  {
    [MethodImpl]
    public static extern void SnoozeAlarmByInstanceId(string instanceId);

    [MethodImpl]
    public static extern void DismissAlarmByInstanceId(string instanceId);

    [MethodImpl]
    public static extern void SnoozeReminderByInstanceId(string instanceId);

    [MethodImpl]
    public static extern void DismissReminderByInstanceId(string instanceId);

    [MethodImpl]
    public static extern void RingDevice();

    public static extern IVectorView<SpeedDialEntry> SpeedDialList { [MethodImpl] get; }

    [MethodImpl]
    public static extern void ClearToast(string instanceId);

    public static extern bool IsPhonePinLocked { [MethodImpl] get; }

    [MethodImpl]
    public static extern void IncreaseVolume(int step);

    [MethodImpl]
    public static extern void DecreaseVolume(int step);

    [MethodImpl]
    public static extern void SetMute(bool mute);

    [MethodImpl]
    public static extern void SetRingerVibrate(bool ringer, bool vibrate);

    public static extern VolumeInfo VolumeInfo { [MethodImpl] get; }

    [MethodImpl]
    public static extern IVectorView<EmailAccountInfo> GetAllEmailAccounts();

    [MethodImpl]
    public static extern IVectorView<EmailFolderInfo> GetFolders(
      string emailAccount);

    [MethodImpl]
    public static extern void EnableEmailNotificationEmailAccount(string emailAccount);

    [MethodImpl]
    public static extern void DisableEmailNotificationEmailAccount(string emailAccount);

    [MethodImpl]
    public static extern void EnableEmailNotificationFolderFilter(
      string emailAccount,
      IVectorView<string> folders);

    [MethodImpl]
    public static extern void UpdateEmailReadStatus(BinaryId messageEntryId, bool isRead);

    [MethodImpl]
    public static extern string RegisterAccessoryApp();

    [MethodImpl]
    public static extern IAccessoryNotificationTriggerDetails GetNextTriggerDetails();

    [MethodImpl]
    public static extern void ProcessTriggerDetails(IAccessoryNotificationTriggerDetails pDetails);

    public static extern IVectorView<global::Windows.Phone.Notification.Management.PhoneLineDetails> PhoneLineDetails { [MethodImpl] get; }

    [MethodImpl]
    public static extern global::Windows.Phone.Notification.Management.PhoneLineDetails GetPhoneLineDetails(
      Guid phoneLine);

    [Overload("AcceptPhoneCall")]
    [MethodImpl]
    public static extern void AcceptPhoneCall(uint phoneCallId);

    [Overload("AcceptPhoneCallOnEndpoint")]
    [MethodImpl]
    public static extern void AcceptPhoneCall(uint phoneCallId, PhoneCallAudioEndpoint endPoint);

    [Overload("AcceptPhoneCallWithVideo")]
    [MethodImpl]
    public static extern void AcceptPhoneCallWithVideo(uint phoneCallId);

    [Overload("AcceptPhoneCallWithVideoOnAudioEndpoint")]
    [MethodImpl]
    public static extern void AcceptPhoneCallWithVideo(
      uint phoneCallId,
      PhoneCallAudioEndpoint endPoint);

    [Overload("RejectPhoneCall")]
    [MethodImpl]
    public static extern void RejectPhoneCall(uint phoneCallId);

    [Overload("RejectPhoneCallWithText")]
    [MethodImpl]
    public static extern void RejectPhoneCall(uint phoneCallId, uint textResponseID);

    [Overload("MakePhoneCall")]
    [MethodImpl]
    public static extern void MakePhoneCall(Guid phoneLine, string phoneNumber);

    [Overload("MakePhoneCallOnAudioEndpoint")]
    [MethodImpl]
    public static extern void MakePhoneCall(
      Guid phoneLine,
      string phoneNumber,
      PhoneCallAudioEndpoint endPoint);

    [Overload("MakePhoneCallWithVideo")]
    [MethodImpl]
    public static extern void MakePhoneCallWithVideo(Guid phoneLine, string phoneNumber);

    [Overload("MakePhoneCallWithVideoOnAudioEndpoint")]
    [MethodImpl]
    public static extern void MakePhoneCallWithVideo(
      Guid phoneLine,
      string phoneNumber,
      PhoneCallAudioEndpoint endPoint);

    [MethodImpl]
    public static extern void SwapPhoneCalls(uint phoneCallIdToHold, uint phoneCallIdOnHold);

    [MethodImpl]
    public static extern void HoldPhoneCall(uint phoneCallId, bool holdCall);

    [MethodImpl]
    public static extern void EndPhoneCall(uint phoneCallId);

    public static extern bool PhoneMute { [MethodImpl] set; [MethodImpl] get; }

    public static extern PhoneCallAudioEndpoint PhoneCallAudioEndpoint { [MethodImpl] set; [MethodImpl] get; }

    [Overload("SnoozeAlarm")]
    [MethodImpl]
    public static extern void SnoozeAlarm(Guid alarmId);

    [Overload("SnoozeAlarmForSpecifiedTime")]
    [MethodImpl]
    public static extern void SnoozeAlarm(Guid alarmId, global::Windows.Foundation.TimeSpan timeSpan);

    [MethodImpl]
    public static extern void DismissAlarm(Guid alarmId);

    [Overload("SnoozeReminder")]
    [MethodImpl]
    public static extern void SnoozeReminder(Guid reminderId);

    [Overload("SnoozeReminderForSpecifiedTime")]
    [MethodImpl]
    public static extern void SnoozeReminder(Guid reminderId, global::Windows.Foundation.TimeSpan timeSpan);

    [MethodImpl]
    public static extern void DismissReminder(Guid reminderId);

    [MethodImpl]
    public static extern MediaMetadata GetMediaMetadata();

    public static extern PlaybackCapability MediaPlaybackCapabilities { [MethodImpl] get; }

    public static extern PlaybackStatus MediaPlaybackStatus { [MethodImpl] get; }

    [MethodImpl]
    public static extern void PerformMediaPlaybackCommand(PlaybackCommand command);

    public static extern bool DoNotDisturbEnabled { [MethodImpl] get; }

    public static extern bool DrivingModeEnabled { [MethodImpl] get; }

    public static extern bool BatterySaverState { [MethodImpl] get; }

    [MethodImpl]
    public static extern IMapView<string, AppNotificationInfo> GetApps();

    [MethodImpl]
    public static extern void EnableNotificationsForApplication(string appId);

    [MethodImpl]
    public static extern void DisableNotificationsForApplication(string appId);

    [MethodImpl]
    public static extern bool IsNotificationEnabledForApplication(string appId);

    [MethodImpl]
    public static extern int GetEnabledAccessoryNotificationTypes();

    [MethodImpl]
    public static extern void EnableAccessoryNotificationTypes(int accessoryNotificationTypes);

    [MethodImpl]
    public static extern void DisableAllAccessoryNotificationTypes();

    [MethodImpl]
    public static extern bool GetUserConsent();

    [MethodImpl]
    public static extern IRandomAccessStreamReference GetAppIcon(
      string appId);
  }
}
