// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastNotificationManager))]
  [Guid(3606443369, 54285, 16508, 137, 137, 136, 202, 180, 44, 253, 20)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IToastNotificationManagerStatics5
  {
    ToastNotificationManagerForUser GetDefault();
  }
}
