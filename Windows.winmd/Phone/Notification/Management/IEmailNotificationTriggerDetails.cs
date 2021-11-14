// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IEmailNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Email;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ExclusiveTo(typeof (EmailNotificationTriggerDetails))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(4088931858, 18127, 20080, 142, 13, 123, 46, 4, 171, 73, 43)]
  internal interface IEmailNotificationTriggerDetails : IAccessoryNotificationTriggerDetails
  {
    string AccountName { get; }

    string ParentFolderName { get; }

    string SenderName { get; }

    string SenderAddress { get; }

    EmailMessage EmailMessage { get; }

    DateTime Timestamp { get; }
  }
}
