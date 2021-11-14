// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IReminderNotificationTriggerDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(3876977088, 20557, 19471, 166, 179, 188, 185, 114, 44, 108, 221)]
  [ExclusiveTo(typeof (ReminderNotificationTriggerDetails))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IReminderNotificationTriggerDetails2
  {
    string InstanceId { get; }
  }
}
