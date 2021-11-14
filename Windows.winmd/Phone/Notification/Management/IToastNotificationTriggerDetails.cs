// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.IToastNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [Guid(3375450261, 20077, 20125, 175, 236, 158, 146, 27, 135, 90, 232)]
  [ExclusiveTo(typeof (ToastNotificationTriggerDetails))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  internal interface IToastNotificationTriggerDetails : IAccessoryNotificationTriggerDetails
  {
    string Text1 { get; }

    string Text2 { get; }

    string Text3 { get; }

    string Text4 { get; }

    bool SuppressPopup { get; }
  }
}
