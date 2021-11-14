// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IReceiptOrSlipJob
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1394710974, 51395, 19906, 137, 233, 92, 74, 55, 179, 77, 220)]
  public interface IReceiptOrSlipJob : IPosPrinterJob
  {
    void SetBarcodeRotation(PosPrinterRotation value);

    void SetPrintRotation(PosPrinterRotation value, bool includeBitmaps);

    void SetPrintArea(Rect value);

    [Overload("SetBitmap")]
    void SetBitmap(uint bitmapNumber, BitmapFrame bitmap, PosPrinterAlignment alignment);

    [Overload("SetBitmapCustomWidthStandardAlign")]
    void SetBitmap(
      uint bitmapNumber,
      BitmapFrame bitmap,
      PosPrinterAlignment alignment,
      uint width);

    [Overload("SetCustomAlignedBitmap")]
    void SetCustomAlignedBitmap(uint bitmapNumber, BitmapFrame bitmap, uint alignmentDistance);

    [Overload("SetBitmapCustomWidthCustomAlign")]
    void SetCustomAlignedBitmap(
      uint bitmapNumber,
      BitmapFrame bitmap,
      uint alignmentDistance,
      uint width);

    void PrintSavedBitmap(uint bitmapNumber);

    void DrawRuledLine(
      string positionList,
      PosPrinterLineDirection lineDirection,
      uint lineWidth,
      PosPrinterLineStyle lineStyle,
      uint lineColor);

    void PrintBarcode(
      string data,
      uint symbology,
      uint height,
      uint width,
      PosPrinterBarcodeTextPosition textPosition,
      PosPrinterAlignment alignment);

    void PrintBarcodeCustomAlign(
      string data,
      uint symbology,
      uint height,
      uint width,
      PosPrinterBarcodeTextPosition textPosition,
      uint alignmentDistance);

    [Overload("PrintBitmap")]
    void PrintBitmap(BitmapFrame bitmap, PosPrinterAlignment alignment);

    [Overload("PrintBitmapCustomWidthStandardAlign")]
    void PrintBitmap(BitmapFrame bitmap, PosPrinterAlignment alignment, uint width);

    [Overload("PrintCustomAlignedBitmap")]
    void PrintCustomAlignedBitmap(BitmapFrame bitmap, uint alignmentDistance);

    [Overload("PrintBitmapCustomWidthCustomAlign")]
    void PrintCustomAlignedBitmap(BitmapFrame bitmap, uint alignmentDistance, uint width);
  }
}
