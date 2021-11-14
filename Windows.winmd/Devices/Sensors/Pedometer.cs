// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Pedometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Static(typeof (IPedometerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPedometerStatics2), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Pedometer : IPedometer, IPedometer2
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern double PowerInMilliwatts { [MethodImpl] get; }

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<Pedometer, PedometerReadingChangedEventArgs> ReadingChanged;

    [MethodImpl]
    public extern IMapView<PedometerStepKind, PedometerReading> GetCurrentReadings();

    [MethodImpl]
    public static extern IVectorView<PedometerReading> GetReadingsFromTriggerDetails(
      SensorDataThresholdTriggerDetails triggerDetails);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Pedometer> FromIdAsync(
      string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Pedometer> GetDefaultAsync();

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [RemoteAsync]
    [Overload("GetSystemHistoryAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PedometerReading>> GetSystemHistoryAsync(
      DateTime fromTime);

    [RemoteAsync]
    [Overload("GetSystemHistoryWithDurationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<PedometerReading>> GetSystemHistoryAsync(
      DateTime fromTime,
      TimeSpan duration);
  }
}
