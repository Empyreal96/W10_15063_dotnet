// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2575181429, 1438, 20064, 139, 6, 23, 96, 145, 124, 139, 128)]
  [ExclusiveTo(typeof (ToastNotification))]
  internal interface IToastNotification
  {
    XmlDocument Content { get; }

    IReference<DateTime> ExpirationTime { set; get; }

    event TypedEventHandler<ToastNotification, ToastDismissedEventArgs> Dismissed;

    event TypedEventHandler<ToastNotification, object> Activated;

    event TypedEventHandler<ToastNotification, ToastFailedEventArgs> Failed;
  }
}
