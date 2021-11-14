// Decompiled with JetBrains decompiler
// Type: Windows.Phone.StartScreen.DualSimTile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Notifications;

namespace Windows.Phone.StartScreen
{
  [Activatable(65536, "Windows.Phone.StartScreen.DualSimTileContract")]
  [ContractVersion(typeof (DualSimTileContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [Static(typeof (IDualSimTileStatics), 65536, "Windows.Phone.StartScreen.DualSimTileContract")]
  public sealed class DualSimTile : IDualSimTile
  {
    [MethodImpl]
    public extern DualSimTile();

    public extern string DisplayName { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsPinnedToStart { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> CreateAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> UpdateAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> DeleteAsync();

    [MethodImpl]
    public static extern DualSimTile GetTileForSim2();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> UpdateDisplayNameForSim1Async(
      string name);

    [MethodImpl]
    public static extern TileUpdater CreateTileUpdaterForSim1();

    [MethodImpl]
    public static extern TileUpdater CreateTileUpdaterForSim2();

    [MethodImpl]
    public static extern BadgeUpdater CreateBadgeUpdaterForSim1();

    [MethodImpl]
    public static extern BadgeUpdater CreateBadgeUpdaterForSim2();

    [MethodImpl]
    public static extern ToastNotifier CreateToastNotifierForSim1();

    [MethodImpl]
    public static extern ToastNotifier CreateToastNotifierForSim2();
  }
}
