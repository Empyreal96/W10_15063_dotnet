// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IAccessoryNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(1768466388, 58314, 18891, 140, 135, 44, 17, 205, 255, 150, 70)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public interface IAccessoryNotificationTriggerDetails
  {
    DateTime TimeCreated { get; }

    string AppDisplayName { get; }

    string AppId { get; }

    AccessoryNotificationType AccessoryNotificationType { get; }

    bool StartedProcessing { get; set; }
  }
}
