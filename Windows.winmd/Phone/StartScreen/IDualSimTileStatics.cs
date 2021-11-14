// Decompiled with JetBrains decompiler
// Type: Windows.Phone.StartScreen.IDualSimTileStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Phone.StartScreen
{
  [Guid(1347845278, 50575, 19913, 182, 232, 250, 103, 119, 238, 235, 55)]
  [ExclusiveTo(typeof (DualSimTile))]
  [ContractVersion(typeof (DualSimTileContract), 65536)]
  internal interface IDualSimTileStatics
  {
    DualSimTile GetTileForSim2();

    [RemoteAsync]
    IAsyncOperation<bool> UpdateDisplayNameForSim1Async(string name);

    TileUpdater CreateTileUpdaterForSim1();

    TileUpdater CreateTileUpdaterForSim2();

    BadgeUpdater CreateBadgeUpdaterForSim1();

    BadgeUpdater CreateBadgeUpdaterForSim2();

    ToastNotifier CreateToastNotifierForSim1();

    ToastNotifier CreateToastNotifierForSim2();
  }
}
