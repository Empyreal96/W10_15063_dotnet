// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IToastNotificationTriggerDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [ExclusiveTo(typeof (ToastNotificationTriggerDetails))]
  [Guid(1040480733, 51908, 20320, 175, 163, 185, 37, 217, 216, 60, 147)]
  internal interface IToastNotificationTriggerDetails2
  {
    string InstanceId { get; }
  }
}
