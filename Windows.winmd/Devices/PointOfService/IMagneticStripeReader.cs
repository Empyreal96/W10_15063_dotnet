// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IMagneticStripeReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(445820949, 18371, 18058, 147, 51, 12, 101, 23, 87, 72, 131)]
  [ExclusiveTo(typeof (MagneticStripeReader))]
  internal interface IMagneticStripeReader
  {
    string DeviceId { get; }

    MagneticStripeReaderCapabilities Capabilities { get; }

    uint[] SupportedCardTypes { get; }

    MagneticStripeReaderAuthenticationProtocol DeviceAuthenticationProtocol { get; }

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<ClaimedMagneticStripeReader> ClaimReaderAsync();

    [RemoteAsync]
    IAsyncOperation<IBuffer> RetrieveStatisticsAsync(
      IIterable<string> statisticsCategories);

    MagneticStripeReaderErrorReportingType GetErrorReportingType();

    event TypedEventHandler<MagneticStripeReader, MagneticStripeReaderStatusUpdatedEventArgs> StatusUpdated;
  }
}
