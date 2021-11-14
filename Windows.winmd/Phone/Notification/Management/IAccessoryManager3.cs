// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IAccessoryManager3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ExclusiveTo(typeof (AccessoryManager))]
  [Guid(2180469047, 60871, 18400, 178, 247, 126, 87, 124, 131, 63, 125)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IAccessoryManager3
  {
    void SnoozeAlarmByInstanceId(string instanceId);

    void DismissAlarmByInstanceId(string instanceId);

    void SnoozeReminderByInstanceId(string instanceId);

    void DismissReminderByInstanceId(string instanceId);
  }
}
