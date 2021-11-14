// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Notification.Management.ToastNotificationTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Notification.Management
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class ToastNotificationTriggerDetails : 
    IToastNotificationTriggerDetails,
    IAccessoryNotificationTriggerDetails,
    IToastNotificationTriggerDetails2
  {
    public extern string Text1 { [MethodImpl] get; }

    public extern string Text2 { [MethodImpl] get; }

    public extern string Text3 { [MethodImpl] get; }

    public extern string Text4 { [MethodImpl] get; }

    public extern bool SuppressPopup { [MethodImpl] get; }

    public extern DateTime TimeCreated { [MethodImpl] get; }

    public extern string AppDisplayName { [MethodImpl] get; }

    public extern string AppId { [MethodImpl] get; }

    public extern AccessoryNotificationType AccessoryNotificationType { [MethodImpl] get; }

    public extern bool StartedProcessing { [MethodImpl] get; [MethodImpl] set; }

    public extern string InstanceId { [MethodImpl] get; }
  }
}
