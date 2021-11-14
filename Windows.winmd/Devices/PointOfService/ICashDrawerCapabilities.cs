// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.ICashDrawerCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.PointOfService
{
  [ExclusiveTo(typeof (CashDrawerCapabilities))]
  [Guid(197582347, 59623, 19231, 177, 209, 62, 80, 26, 208, 130, 71)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICashDrawerCapabilities
  {
    UnifiedPosPowerReportingType PowerReportingType { get; }

    bool IsStatisticsReportingSupported { get; }

    bool IsStatisticsUpdatingSupported { get; }

    bool IsStatusReportingSupported { get; }

    bool IsStatusMultiDrawerDetectSupported { get; }

    bool IsDrawerOpenSensorAvailable { get; }
  }
}
