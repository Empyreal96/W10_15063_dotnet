// Decompiled with JetBrains decompiler
// Type: Windows.Phone.StartScreen.IToastNotificationManagerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Phone.StartScreen
{
  [ContractVersion(typeof (DualSimTileContract), 65536)]
  [Guid(655881547, 20703, 17493, 142, 110, 65, 224, 252, 142, 19, 206)]
  public interface IToastNotificationManagerStatics3
  {
    ToastNotifier CreateToastNotifierForSecondaryTile(string tileId);
  }
}
