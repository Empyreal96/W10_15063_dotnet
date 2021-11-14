// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotification3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ToastNotification))]
  [Guid(837332696, 33089, 20377, 188, 10, 196, 237, 33, 41, 125, 119)]
  internal interface IToastNotification3
  {
    NotificationMirroring NotificationMirroring { get; set; }

    string RemoteId { get; set; }
  }
}
