// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.MagneticStripeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [Static(typeof (IMagneticStripeReaderStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMagneticStripeReaderStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class MagneticStripeReader : IMagneticStripeReader, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern MagneticStripeReaderCapabilities Capabilities { [MethodImpl] get; }

    public extern uint[] SupportedCardTypes { [MethodImpl] get; }

    public extern MagneticStripeReaderAuthenticationProtocol DeviceAuthenticationProtocol { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> CheckHealthAsync(
      UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ClaimedMagneticStripeReader> ClaimReaderAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IBuffer> RetrieveStatisticsAsync(
      IIterable<string> statisticsCategories);

    [MethodImpl]
    public extern MagneticStripeReaderErrorReportingType GetErrorReportingType();

    public extern event TypedEventHandler<MagneticStripeReader, MagneticStripeReaderStatusUpdatedEventArgs> StatusUpdated;

    [MethodImpl]
    public extern void Close();

    [Overload("GetDeviceSelectorWithConnectionTypes")]
    [MethodImpl]
    public static extern string GetDeviceSelector(PosConnectionTypes connectionTypes);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MagneticStripeReader> GetDefaultAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<MagneticStripeReader> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
