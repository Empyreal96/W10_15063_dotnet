// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IPhoneNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(3435331063, 2499, 16664, 145, 188, 202, 99, 35, 168, 211, 131)]
  [ExclusiveTo(typeof (PhoneNotificationTriggerDetails))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IPhoneNotificationTriggerDetails : IAccessoryNotificationTriggerDetails
  {
    PhoneNotificationType PhoneNotificationType { get; }

    PhoneCallDetails CallDetails { get; }

    Guid PhoneLineChangedId { get; }
  }
}
