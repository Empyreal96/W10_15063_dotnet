// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICommonClaimedPosPrinterStation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [Guid(3085657768, 65162, 19707, 139, 66, 227, 91, 40, 12, 178, 124)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICommonClaimedPosPrinterStation
  {
    uint CharactersPerLine { set; get; }

    uint LineHeight { set; get; }

    uint LineSpacing { set; get; }

    uint LineWidth { get; }

    bool IsLetterQuality { set; get; }

    bool IsPaperNearEnd { get; }

    PosPrinterColorCartridge ColorCartridge { set; get; }

    bool IsCoverOpen { get; }

    bool IsCartridgeRemoved { get; }

    bool IsCartridgeEmpty { get; }

    bool IsHeadCleaning { get; }

    bool IsPaperEmpty { get; }

    bool IsReadyToPrint { get; }

    bool ValidateData(string data);
  }
}
