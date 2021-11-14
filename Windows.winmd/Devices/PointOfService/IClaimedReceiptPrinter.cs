// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IClaimedReceiptPrinter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(2597485172, 56673, 20194, 152, 55, 91, 93, 114, 213, 56, 185)]
  [ExclusiveTo(typeof (ClaimedReceiptPrinter))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IClaimedReceiptPrinter : ICommonClaimedPosPrinterStation
  {
    uint SidewaysMaxLines { get; }

    uint SidewaysMaxChars { get; }

    uint LinesToPaperCut { get; }

    Size PageSize { get; }

    Rect PrintArea { get; }

    ReceiptPrintJob CreateJob();
  }
}
