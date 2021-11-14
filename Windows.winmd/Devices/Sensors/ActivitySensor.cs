// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ActivitySensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IActivitySensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class ActivitySensor : IActivitySensor
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ActivitySensorReading> GetCurrentReadingAsync();

    public extern IVector<ActivityType> SubscribedActivities { [MethodImpl] get; }

    public extern double PowerInMilliwatts { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }

    public extern IVectorView<ActivityType> SupportedActivities { [MethodImpl] get; }

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern event TypedEventHandler<ActivitySensor, ActivitySensorReadingChangedEventArgs> ReadingChanged;

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ActivitySensor> GetDefaultAsync();

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<ActivitySensor> FromIdAsync(
      string deviceId);

    [Overload("GetSystemHistoryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<ActivitySensorReading>> GetSystemHistoryAsync(
      DateTime fromTime);

    [Overload("GetSystemHistoryWithDurationAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<ActivitySensorReading>> GetSystemHistoryAsync(
      DateTime fromTime,
      TimeSpan duration);
  }
}
