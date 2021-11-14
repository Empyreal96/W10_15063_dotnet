// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedPosPrinter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(1835322892, 57406, 19220, 163, 142, 194, 140, 52, 184, 99, 83)]
  [ExclusiveTo(typeof (ClaimedPosPrinter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClaimedPosPrinter : IClosable
  {
    string DeviceId { get; }

    bool IsEnabled { get; }

    uint CharacterSet { set; get; }

    bool IsCoverOpen { get; }

    bool IsCharacterSetMappingEnabled { set; get; }

    PosPrinterMapMode MapMode { set; get; }

    ClaimedReceiptPrinter Receipt { get; }

    ClaimedSlipPrinter Slip { get; }

    ClaimedJournalPrinter Journal { get; }

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

    event TypedEventHandler<ClaimedPosPrinter, PosPrinterReleaseDeviceRequestedEventArgs> ReleaseDeviceRequested;
  }
}
