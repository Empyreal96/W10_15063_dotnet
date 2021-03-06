// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.ReminderNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Appointments;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class ReminderNotificationTriggerDetails : 
    IReminderNotificationTriggerDetails,
    IAccessoryNotificationTriggerDetails,
    IReminderNotificationTriggerDetails2
  {
    public extern Guid ReminderId { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern string Details { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime Timestamp { [MethodImpl] get; }

    public extern Appointment Appointment { [MethodImpl] get; }

    public extern ReminderState ReminderState { [MethodImpl] get; }

    public extern global::Windows.Foundation.DateTime TimeCreated { [MethodImpl] get; }

    public extern string AppDisplayName { [MethodImpl] get; }

    public extern string AppId { [MethodImpl] get; }

    public extern AccessoryNotificationType AccessoryNotificationType { [MethodImpl] get; }

    public extern bool StartedProcessing { [MethodImpl] get; [MethodImpl] set; }

    public extern string InstanceId { [MethodImpl] get; }
  }
}
