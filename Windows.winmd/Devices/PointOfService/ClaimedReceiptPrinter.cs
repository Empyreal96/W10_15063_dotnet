// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ClaimedReceiptPrinter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ClaimedReceiptPrinter : IClaimedReceiptPrinter, ICommonClaimedPosPrinterStation
  {
    public extern uint SidewaysMaxLines { [MethodImpl] get; }

    public extern uint SidewaysMaxChars { [MethodImpl] get; }

    public extern uint LinesToPaperCut { [MethodImpl] get; }

    public extern Size PageSize { [MethodImpl] get; }

    public extern Rect PrintArea { [MethodImpl] get; }

    [MethodImpl]
    public extern ReceiptPrintJob CreateJob();

    public extern uint CharactersPerLine { [MethodImpl] set; [MethodImpl] get; }

    public extern uint LineHeight { [MethodImpl] set; [MethodImpl] get; }

    public extern uint LineSpacing { [MethodImpl] set; [MethodImpl] get; }

    public extern uint LineWidth { [MethodImpl] get; }

    public extern bool IsLetterQuality { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsPaperNearEnd { [MethodImpl] get; }

    public extern PosPrinterColorCartridge ColorCartridge { [MethodImpl] set; [MethodImpl] get; }

    public extern bool IsCoverOpen { [MethodImpl] get; }

    public extern bool IsCartridgeRemoved { [MethodImpl] get; }

    public extern bool IsCartridgeEmpty { [MethodImpl] get; }

    public extern bool IsHeadCleaning { [MethodImpl] get; }

    public extern bool IsPaperEmpty { [MethodImpl] get; }

    public extern bool IsReadyToPrint { [MethodImpl] get; }

    [MethodImpl]
    public extern bool ValidateData(string data);
  }
}
