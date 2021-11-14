// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IEmailReadNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(4122452103, 1779, 20030, 140, 66, 50, 94, 103, 1, 4, 19)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (EmailReadNotificationTriggerDetails))]
  internal interface IEmailReadNotificationTriggerDetails : IAccessoryNotificationTriggerDetails
  {
    string AccountName { get; }

    string ParentFolderName { get; }

    BinaryId MessageEntryId { get; }

    bool IsRead { get; }
  }
}
