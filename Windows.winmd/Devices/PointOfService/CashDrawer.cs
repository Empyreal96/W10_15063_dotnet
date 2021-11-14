// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICashDrawerStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ICashDrawerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class CashDrawer : ICashDrawer, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern CashDrawerCapabilities Capabilities { [MethodImpl] get; }

    public extern CashDrawerStatus Status { [MethodImpl] get; }

    public extern bool IsDrawerOpen { [MethodImpl] get; }

    public extern CashDrawerEventSource DrawerEventSource { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedCashDrawer> ClaimDrawerAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetStatisticsAsync(
      IIterable<string> statisticsCategories);

    public extern event TypedEventHandler<CashDrawer, CashDrawerStatusUpdatedEventArgs> StatusUpdated;

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CashDrawer> GetDefaultAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CashDrawer> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
