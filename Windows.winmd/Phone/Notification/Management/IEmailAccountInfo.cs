// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IEmailAccountInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(3753640619, 48544, 17768, 146, 126, 178, 237, 227, 88, 24, 161)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (EmailAccountInfo))]
  internal interface IEmailAccountInfo
  {
    string DisplayName { get; }

    bool IsNotificationEnabled { get; }
  }
}
