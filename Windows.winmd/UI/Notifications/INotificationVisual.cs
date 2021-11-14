// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotificationVisual
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (NotificationVisual))]
  [Guid(1753439118, 43606, 19985, 134, 211, 95, 154, 105, 87, 188, 91)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface INotificationVisual
  {
    string Language { get; set; }

    IVector<NotificationBinding> Bindings { get; }

    NotificationBinding GetBinding(string templateName);
  }
}
