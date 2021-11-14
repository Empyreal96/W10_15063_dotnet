// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IAlarmNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(955644464, 51000, 19874, 144, 140, 119, 93, 131, 195, 106, 187)]
  [ExclusiveTo(typeof (AlarmNotificationTriggerDetails))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IAlarmNotificationTriggerDetails : IAccessoryNotificationTriggerDetails
  {
    Guid AlarmId { get; }

    string Title { get; }

    global::Windows.Foundation.DateTime Timestamp { get; }

    ReminderState ReminderState { get; }
  }
}
