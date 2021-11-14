// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastNotificationManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Notifications
{
  [Guid(2058959954, 3656, 18256, 186, 157, 26, 65, 19, 152, 24, 71)]
  [ExclusiveTo(typeof (ToastNotificationManager))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IToastNotificationManagerStatics2
  {
    ToastNotificationHistory History { get; }
  }
}
