// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IEmailFolderInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(3255244046, 57911, 18134, 144, 230, 79, 82, 158, 234, 193, 226)]
  [ExclusiveTo(typeof (EmailFolderInfo))]
  internal interface IEmailFolderInfo
  {
    string DisplayName { get; }

    bool IsNotificationEnabled { get; }
  }
}
