// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IAccessoryManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Phone.Notification.Management
{
  [ExclusiveTo(typeof (AccessoryManager))]
  [Guid(218407212, 34877, 19111, 188, 167, 250, 75, 184, 191, 254, 230)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IAccessoryManager
  {
    string RegisterAccessoryApp();

    IAccessoryNotificationTriggerDetails GetNextTriggerDetails();

    void ProcessTriggerDetails(IAccessoryNotificationTriggerDetails pDetails);

    IVectorView<global::Windows.Phone.Notification.Management.PhoneLineDetails> PhoneLineDetails { get; }

    global::Windows.Phone.Notification.Management.PhoneLineDetails GetPhoneLineDetails(
      Guid phoneLine);

    [Overload("AcceptPhoneCall")]
    void AcceptPhoneCall(uint phoneCallId);

    [Overload("AcceptPhoneCallOnEndpoint")]
    void AcceptPhoneCall(uint phoneCallId, PhoneCallAudioEndpoint endPoint);

    [Overload("AcceptPhoneCallWithVideo")]
    void AcceptPhoneCallWithVideo(uint phoneCallId);

    [Overload("AcceptPhoneCallWithVideoOnAudioEndpoint")]
    void AcceptPhoneCallWithVideo(uint phoneCallId, PhoneCallAudioEndpoint endPoint);

    [Overload("RejectPhoneCall")]
    void RejectPhoneCall(uint phoneCallId);

    [Overload("RejectPhoneCallWithText")]
    void RejectPhoneCall(uint phoneCallId, uint textResponseID);

    [Overload("MakePhoneCall")]
    void MakePhoneCall(Guid phoneLine, string phoneNumber);

    [Overload("MakePhoneCallOnAudioEndpoint")]
    void MakePhoneCall(Guid phoneLine, string phoneNumber, PhoneCallAudioEndpoint endPoint);

    [Overload("MakePhoneCallWithVideo")]
    void MakePhoneCallWithVideo(Guid phoneLine, string phoneNumber);

    [Overload("MakePhoneCallWithVideoOnAudioEndpoint")]
    void MakePhoneCallWithVideo(
      Guid phoneLine,
      string phoneNumber,
      PhoneCallAudioEndpoint endPoint);

    void SwapPhoneCalls(uint phoneCallIdToHold, uint phoneCallIdOnHold);

    void HoldPhoneCall(uint phoneCallId, bool holdCall);

    void EndPhoneCall(uint phoneCallId);

    bool PhoneMute { set; get; }

    PhoneCallAudioEndpoint PhoneCallAudioEndpoint { set; get; }

    [Overload("SnoozeAlarm")]
    void SnoozeAlarm(Guid alarmId);

    [Overload("SnoozeAlarmForSpecifiedTime")]
    void SnoozeAlarm(Guid alarmId, global::Windows.Foundation.TimeSpan timeSpan);

    void DismissAlarm(Guid alarmId);

    [Overload("SnoozeReminder")]
    void SnoozeReminder(Guid reminderId);

    [Overload("SnoozeReminderForSpecifiedTime")]
    void SnoozeReminder(Guid reminderId, global::Windows.Foundation.TimeSpan timeSpan);

    void DismissReminder(Guid reminderId);

    MediaMetadata GetMediaMetadata();

    PlaybackCapability MediaPlaybackCapabilities { get; }

    PlaybackStatus MediaPlaybackStatus { get; }

    void PerformMediaPlaybackCommand(PlaybackCommand command);

    bool DoNotDisturbEnabled { get; }

    bool DrivingModeEnabled { get; }

    bool BatterySaverState { get; }

    IMapView<string, AppNotificationInfo> GetApps();

    void EnableNotificationsForApplication(string appId);

    void DisableNotificationsForApplication(string appId);

    bool IsNotificationEnabledForApplication(string appId);

    int GetEnabledAccessoryNotificationTypes();

    void EnableAccessoryNotificationTypes(int accessoryNotificationTypes);

    void DisableAllAccessoryNotificationTypes();

    bool GetUserConsent();

    IRandomAccessStreamReference GetAppIcon(string appId);
  }
}
