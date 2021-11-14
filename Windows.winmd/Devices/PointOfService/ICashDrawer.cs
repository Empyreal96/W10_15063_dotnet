// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(2676553160, 56916, 19182, 168, 144, 146, 11, 203, 254, 48, 252)]
  [ExclusiveTo(typeof (CashDrawer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICashDrawer
  {
    string DeviceId { get; }

    CashDrawerCapabilities Capabilities { get; }

    CashDrawerStatus Status { get; }

    bool IsDrawerOpen { get; }

    CashDrawerEventSource DrawerEventSource { get; }

    [RemoteAsync]
    IAsyncOperation<ClaimedCashDrawer> ClaimDrawerAsync();

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<string> GetStatisticsAsync(IIterable<string> statisticsCategories);

    event TypedEventHandler<CashDrawer, CashDrawerStatusUpdatedEventArgs> StatusUpdated;
  }
}
