// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(1353453631, 53813, 17816, 187, 239, 152, 254, 77, 26, 58, 212)]
  [ExclusiveTo(typeof (ToastNotificationManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastNotificationManagerStatics
  {
    [Overload("CreateToastNotifier")]
    ToastNotifier CreateToastNotifier();

    [Overload("CreateToastNotifierWithId")]
    ToastNotifier CreateToastNotifier(string applicationId);

    XmlDocument GetTemplateContent(ToastTemplateType type);
  }
}
