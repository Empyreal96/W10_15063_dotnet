// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.SlipPrintJob
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Imaging;

namespace Windows.Devices.PointOfService
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  public sealed class SlipPrintJob : IReceiptOrSlipJob, IPosPrinterJob
  {
    [MethodImpl]
    public extern void SetBarcodeRotation(PosPrinterRotation value);

    [MethodImpl]
    public extern void SetPrintRotation(PosPrinterRotation value, bool includeBitmaps);

    [MethodImpl]
    public extern void SetPrintArea(Rect value);

    [Overload("SetBitmap")]
    [MethodImpl]
    public extern void SetBitmap(
      uint bitmapNumber,
      BitmapFrame bitmap,
      PosPrinterAlignment alignment);

    [Overload("SetBitmapCustomWidthStandardAlign")]
    [MethodImpl]
    public extern void SetBitmap(
      uint bitmapNumber,
      BitmapFrame bitmap,
      PosPrinterAlignment alignment,
      uint width);

    [Overload("SetCustomAlignedBitmap")]
    [MethodImpl]
    public extern void SetCustomAlignedBitmap(
      uint bitmapNumber,
      BitmapFrame bitmap,
      uint alignmentDistance);

    [Overload("SetBitmapCustomWidthCustomAlign")]
    [MethodImpl]
    public extern void SetCustomAlignedBitmap(
      uint bitmapNumber,
      BitmapFrame bitmap,
      uint alignmentDistance,
      uint width);

    [MethodImpl]
    public extern void PrintSavedBitmap(uint bitmapNumber);

    [MethodImpl]
    public extern void DrawRuledLine(
      string positionList,
      PosPrinterLineDirection lineDirection,
      uint lineWidth,
      PosPrinterLineStyle lineStyle,
      uint lineColor);

    [MethodImpl]
    public extern void PrintBarcode(
      string data,
      uint symbology,
      uint height,
      uint width,
      PosPrinterBarcodeTextPosition textPosition,
      PosPrinterAlignment alignment);

    [MethodImpl]
    public extern void PrintBarcodeCustomAlign(
      string data,
      uint symbology,
      uint height,
      uint width,
      PosPrinterBarcodeTextPosition textPosition,
      uint alignmentDistance);

    [Overload("PrintBitmap")]
    [MethodImpl]
    public extern void PrintBitmap(BitmapFrame bitmap, PosPrinterAlignment alignment);

    [Overload("PrintBitmapCustomWidthStandardAlign")]
    [MethodImpl]
    public extern void PrintBitmap(BitmapFrame bitmap, PosPrinterAlignment alignment, uint width);

    [Overload("PrintCustomAlignedBitmap")]
    [MethodImpl]
    public extern void PrintCustomAlignedBitmap(BitmapFrame bitmap, uint alignmentDistance);

    [Overload("PrintBitmapCustomWidthCustomAlign")]
    [MethodImpl]
    public extern void PrintCustomAlignedBitmap(
      BitmapFrame bitmap,
      uint alignmentDistance,
      uint width);

    [MethodImpl]
    public extern void Print(string data);

    [Overload("PrintLine")]
    [MethodImpl]
    public extern void PrintLine(string data);

    [Overload("PrintNewline")]
    [MethodImpl]
    public extern void PrintLine();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> ExecuteAsync();
  }
}
