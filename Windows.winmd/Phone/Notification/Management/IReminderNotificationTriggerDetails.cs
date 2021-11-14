// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IReminderNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(1541253725, 40801, 19440, 159, 235, 16, 80, 43, 192, 176, 194)]
  [ExclusiveTo(typeof (ReminderNotificationTriggerDetails))]
  internal interface IReminderNotificationTriggerDetails : IAccessoryNotificationTriggerDetails
  {
    Guid ReminderId { get; }

    string Title { get; }

    string Description { get; }

    string Details { get; }

    global::Windows.Foundation.DateTime Timestamp { get; }

    Appointment Appointment { get; }

    ReminderState ReminderState { get; }
  }
}
