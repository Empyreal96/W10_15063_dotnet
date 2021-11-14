// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IAccessoryManager2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(3133854797, 54163, 18118, 184, 12, 21, 253, 244, 77, 83, 134)]
  [ExclusiveTo(typeof (AccessoryManager))]
  internal interface IAccessoryManager2
  {
    void RingDevice();

    IVectorView<SpeedDialEntry> SpeedDialList { get; }

    void ClearToast(string instanceId);

    bool IsPhonePinLocked { get; }

    void IncreaseVolume(int step);

    void DecreaseVolume(int step);

    void SetMute(bool mute);

    void SetRingerVibrate(bool ringer, bool vibrate);

    VolumeInfo VolumeInfo { get; }

    IVectorView<EmailAccountInfo> GetAllEmailAccounts();

    IVectorView<EmailFolderInfo> GetFolders(string emailAccount);

    void EnableEmailNotificationEmailAccount(string emailAccount);

    void DisableEmailNotificationEmailAccount(string emailAccount);

    void EnableEmailNotificationFolderFilter(string emailAccount, IVectorView<string> folders);

    void UpdateEmailReadStatus(BinaryId messageEntryId, bool isRead);
  }
}
