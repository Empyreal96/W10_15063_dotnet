// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.INotification
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(276838398, 60278, 20354, 151, 188, 218, 7, 83, 10, 46, 32)]
  [ExclusiveTo(typeof (Notification))]
  internal interface INotification
  {
    IReference<DateTime> ExpirationTime { get; set; }

    NotificationVisual Visual { get; set; }
  }
}
