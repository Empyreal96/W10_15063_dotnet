// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IPosPrinterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPosPrinterStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class PosPrinter : IPosPrinter, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern PosPrinterCapabilities Capabilities { [MethodImpl] get; }

    public extern IVectorView<uint> SupportedCharacterSets { [MethodImpl] get; }

    public extern IVectorView<string> SupportedTypeFaces { [MethodImpl] get; }

    public extern PosPrinterStatus Status { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedPosPrinter> ClaimPrinterAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetStatisticsAsync(
      IIterable<string> statisticsCategories);

    public extern event TypedEventHandler<PosPrinter, PosPrinterStatusUpdatedEventArgs> StatusUpdated;

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PosPrinter> GetDefaultAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<PosPrinter> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
