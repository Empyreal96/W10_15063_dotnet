// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IAppNotificationInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ExclusiveTo(typeof (AppNotificationInfo))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(559398565, 57990, 17875, 155, 234, 247, 144, 252, 33, 110, 14)]
  internal interface IAppNotificationInfo
  {
    string Id { get; }

    string Name { get; }
  }
}
