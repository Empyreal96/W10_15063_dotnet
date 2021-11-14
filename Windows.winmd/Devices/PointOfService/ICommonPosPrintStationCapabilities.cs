// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICommonPosPrintStationCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3730526922, 57390, 16617, 158, 94, 27, 72, 142, 106, 172, 252)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICommonPosPrintStationCapabilities
  {
    bool IsPrinterPresent { get; }

    bool IsDualColorSupported { get; }

    PosPrinterColorCapabilities ColorCartridgeCapabilities { get; }

    PosPrinterCartridgeSensors CartridgeSensors { get; }

    bool IsBoldSupported { get; }

    bool IsItalicSupported { get; }

    bool IsUnderlineSupported { get; }

    bool IsDoubleHighPrintSupported { get; }

    bool IsDoubleWidePrintSupported { get; }

    bool IsDoubleHighDoubleWidePrintSupported { get; }

    bool IsPaperEmptySensorSupported { get; }

    bool IsPaperNearEndSensorSupported { get; }

    IVectorView<uint> SupportedCharactersPerLine { get; }
  }
}
