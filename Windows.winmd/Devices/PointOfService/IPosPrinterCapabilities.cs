// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.IPosPrinterCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (PosPrinterCapabilities))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3454621473, 17280, 18821, 173, 197, 57, 219, 48, 205, 147, 188)]
  internal interface IPosPrinterCapabilities
  {
    UnifiedPosPowerReportingType PowerReportingType { get; }

    bool IsStatisticsReportingSupported { get; }

    bool IsStatisticsUpdatingSupported { get; }

    uint DefaultCharacterSet { get; }

    bool HasCoverSensor { get; }

    bool CanMapCharacterSet { get; }

    bool IsTransactionSupported { get; }

    ReceiptPrinterCapabilities Receipt { get; }

    SlipPrinterCapabilities Slip { get; }

    JournalPrinterCapabilities Journal { get; }
  }
}
