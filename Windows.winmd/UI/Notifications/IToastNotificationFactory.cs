// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(68307744, 33478, 16937, 177, 9, 253, 158, 212, 102, 43, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToastNotification))]
  internal interface IToastNotificationFactory
  {
    ToastNotification CreateToastNotification(XmlDocument content);
  }
}
