// Decompiled with JetBrains decompiler
// Type: Windows.Devices.PointOfService.CashDrawerCapabilities
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
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class CashDrawerCapabilities : ICashDrawerCapabilities
  {
    public extern UnifiedPosPowerReportingType PowerReportingType { [MethodImpl] get; }

    public extern bool IsStatisticsReportingSupported { [MethodImpl] get; }

    public extern bool IsStatisticsUpdatingSupported { [MethodImpl] get; }

    public extern bool IsStatusReportingSupported { [MethodImpl] get; }

    public extern bool IsStatusMultiDrawerDetectSupported { [MethodImpl] get; }

    public extern bool IsDrawerOpenSensorAvailable { [MethodImpl] get; }
  }
}
