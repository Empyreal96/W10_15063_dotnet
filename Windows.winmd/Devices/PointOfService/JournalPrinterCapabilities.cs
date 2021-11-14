// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.JournalPrinterCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class JournalPrinterCapabilities : 
    IJournalPrinterCapabilities,
    ICommonPosPrintStationCapabilities
  {
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
