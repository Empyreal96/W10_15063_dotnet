// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ReceiptPrinterCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ReceiptPrinterCapabilities : 
    IReceiptPrinterCapabilities,
    ICommonReceiptSlipCapabilities,
    ICommonPosPrintStationCapabilities
  {
    public extern bool CanCutPaper { [MethodImpl] get; }

    public extern bool IsStampSupported { [MethodImpl] get; }

    public extern PosPrinterMarkFeedCapabilities MarkFeedCapabilities { [MethodImpl] get; }

    public extern bool IsBarcodeSupported { [MethodImpl] get; }

    public extern bool IsBitmapSupported { [MethodImpl] get; }

    public extern bool IsLeft90RotationSupported { [MethodImpl] get; }

    public extern bool IsRight90RotationSupported { [MethodImpl] get; }

    public extern bool Is180RotationSupported { [MethodImpl] get; }

    public extern bool IsPrintAreaSupported { [MethodImpl] get; }

    public extern PosPrinterRuledLineCapabilities RuledLineCapabilities { [MethodImpl] get; }

    public extern IVectorView<PosPrinterRotation> SupportedBarcodeRotations { [MethodImpl] get; }

    public extern IVectorView<PosPrinterRotation> SupportedBitmapRotations { [MethodImpl] get; }

    public extern bool IsPrinterPresent { [MethodImpl] get; }

    public extern bool IsDualColorSupported { [MethodImpl] get; }

    public extern PosPrinterColorCapabilities ColorCartridgeCapabilities { [MethodImpl] get; }

    public extern PosPrinterCartridgeSensors CartridgeSensors { [MethodImpl] get; }

    public extern bool IsBoldSupported { [MethodImpl] get; }

    public extern bool IsItalicSupported { [MethodImpl] get; }

    public extern bool IsUnderlineSupported { [MethodImpl] get; }

    public extern bool IsDoubleHighPrintSupported { [MethodImpl] get; }

    public extern bool IsDoubleWidePrintSupported { [MethodImpl] get; }

    public extern bool IsDoubleHighDoubleWidePrintSupported { [MethodImpl] get; }

    public extern bool IsPaperEmptySensorSupported { [MethodImpl] get; }

    public extern bool IsPaperNearEndSensorSupported { [MethodImpl] get; }

    public extern IVectorView<uint> SupportedCharactersPerLine { [MethodImpl] get; }
  }
}
