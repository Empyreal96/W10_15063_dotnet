// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IAlarmNotificationTriggerDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(3474382954, 29013, 16638, 169, 194, 123, 210, 18, 126, 248, 83)]
  [ExclusiveTo(typeof (AlarmNotificationTriggerDetails))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IAlarmNotificationTriggerDetails2
  {
    string InstanceId { get; }
  }
}
