// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.PosPrinterCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class PosPrinterCapabilities : IPosPrinterCapabilities
  {
    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    public extern uint DefaultCharacterSet { [MethodImpl] get; }

    public extern bool HasCoverSensor { [MethodImpl] get; }

    public extern bool CanMapCharacterSet { [MethodImpl] get; }

    public extern bool IsTransactionSupported { [MethodImpl] get; }

    public extern ReceiptPrinterCapabilities Receipt { [MethodImpl] get; }

    public extern SlipPrinterCapabilities Slip { [MethodImpl] get; }

    public extern JournalPrinterCapabilities Journal { [MethodImpl] get; }
  }
}
