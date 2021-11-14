// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedCashDrawer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3393165743, 43960, 17089, 138, 132, 92, 102, 81, 47, 90, 117)]
  [ExclusiveTo(typeof (ClaimedCashDrawer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClaimedCashDrawer : IClosable
  {
    string DeviceId { get; }

    bool IsEnabled { get; }

    bool IsDrawerOpen { get; }

    CashDrawerCloseAlarm CloseAlarm { get; }

    [RemoteAsync]
    IAsyncOperation<bool> OpenDrawerAsync();

    [RemoteAsync]
    IAsyncOperation<bool> EnableAsync();

    [RemoteAsync]
    IAsyncOperation<bool> DisableAsync();

    [RemoteAsync]
    IAsyncOperation<bool> RetainDeviceAsync();

    [RemoteAsync]
    IAsyncOperation<bool> ResetStatisticsAsync(IIterable<string> statisticsCategories);

    [RemoteAsync]
    IAsyncOperation<bool> UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    event TypedEventHandler<ClaimedCashDrawer, object> ReleaseDeviceRequested;
  }
}
