// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(704889102, 39449, 18945, 153, 79, 18, 223, 173, 106, 220, 191)]
  [ExclusiveTo(typeof (PosPrinter))]
  internal interface IPosPrinter
  {
    string DeviceId { get; }

    PosPrinterCapabilities Capabilities { get; }

    IVectorView<uint> SupportedCharacterSets { get; }

    IVectorView<string> SupportedTypeFaces { get; }

    PosPrinterStatus Status { get; }

    [RemoteAsync]
    IAsyncOperation<ClaimedPosPrinter> ClaimPrinterAsync();

    [RemoteAsync]
    IAsyncOperation<string> CheckHealthAsync(UnifiedPosHealthCheckLevel level);

    [RemoteAsync]
    IAsyncOperation<string> GetStatisticsAsync(IIterable<string> statisticsCategories);

    event TypedEventHandler<PosPrinter, PosPrinterStatusUpdatedEventArgs> StatusUpdated;
  }
}
