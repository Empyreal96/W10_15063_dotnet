// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedCashDrawer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ClaimedCashDrawer : IClaimedCashDrawer, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; }

    public extern bool IsDrawerOpen { [MethodImpl] get; }

    public extern CashDrawerCloseAlarm CloseAlarm { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> OpenDrawerAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> EnableAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> DisableAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> RetainDeviceAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ResetStatisticsAsync(
      IIterable<string> statisticsCategories);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> UpdateStatisticsAsync(
      IIterable<IKeyValuePair<string, string>> statistics);

    public extern event TypedEventHandler<ClaimedCashDrawer, object> ReleaseDeviceRequested;

    [MethodImpl]
    public extern void Close();
  }
}
