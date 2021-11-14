// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IReceiptPrintJob
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (ReceiptPrintJob))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2861958766, 44205, 19321, 157, 15, 192, 207, 192, 141, 199, 123)]
  internal interface IReceiptPrintJob : IReceiptOrSlipJob, IPosPrinterJob
  {
    void MarkFeed(PosPrinterMarkFeedKind kind);

    [Overload("CutPaper")]
    void CutPaper(double percentage);

    [Overload("CutPaperDefault")]
    void CutPaper();
  }
}
