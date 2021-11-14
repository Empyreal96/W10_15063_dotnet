// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.ICalendarChangedNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(1267350524, 10141, 17067, 156, 104, 62, 135, 151, 123, 242, 22)]
  [ExclusiveTo(typeof (CalendarChangedNotificationTriggerDetails))]
  internal interface ICalendarChangedNotificationTriggerDetails : 
    IAccessoryNotificationTriggerDetails
  {
    CalendarChangedEvent EventType { get; }

    string ItemId { get; }
  }
}
