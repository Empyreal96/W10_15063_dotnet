// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedSlipPrinter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3177050098, 44944, 20106, 183, 123, 227, 174, 156, 166, 58, 127)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ClaimedSlipPrinter))]
  internal interface IClaimedSlipPrinter : ICommonClaimedPosPrinterStation
  {
    uint SidewaysMaxLines { get; }

    uint SidewaysMaxChars { get; }

    uint MaxLines { get; }

    uint LinesNearEndToEnd { get; }

    PosPrinterPrintSide PrintSide { get; }

    Size PageSize { get; }

    Rect PrintArea { get; }

    void OpenJaws();

    void CloseJaws();

    [RemoteAsync]
    IAsyncOperation<bool> InsertSlipAsync(TimeSpan timeout);

    [RemoteAsync]
    IAsyncOperation<bool> RemoveSlipAsync(TimeSpan timeout);

    void ChangePrintSide(PosPrinterPrintSide printSide);

    SlipPrintJob CreateJob();
  }
}
