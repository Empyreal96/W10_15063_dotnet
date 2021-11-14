// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedPosPrinter
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class ClaimedPosPrinter : IClaimedPosPrinter, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; }

    public extern uint CharacterSet { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsCoverOpen { [MethodImpl] get; }

    public extern bool IsCharacterSetMappingEnabled { [MethodImpl] set; [MethodImpl] get; }

    public extern PosPrinterMapMode MapMode { [MethodImpl] set; [MethodImpl] get; }

    public extern ClaimedReceiptPrinter Receipt { [MethodImpl] get; }

    public extern ClaimedSlipPrinter Slip { [MethodImpl] get; }

    public extern ClaimedJournalPrinter Journal { [MethodImpl] get; }

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

    public extern event TypedEventHandler<ClaimedPosPrinter, PosPrinterReleaseDeviceRequestedEventArgs> ReleaseDeviceRequested;

    [MethodImpl]
    public extern void Close();
  }
}
