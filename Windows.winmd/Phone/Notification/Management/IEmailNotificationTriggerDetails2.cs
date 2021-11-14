// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IEmailNotificationTriggerDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (EmailNotificationTriggerDetails))]
  [Guid(377513955, 50543, 20167, 190, 209, 247, 52, 224, 141, 229, 178)]
  internal interface IEmailNotificationTriggerDetails2 : IAccessoryNotificationTriggerDetails
  {
    BinaryId MessageEntryId { get; }
  }
}
