// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.OrientationSensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IOrientationSensorStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IOrientationSensorStatics3), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IOrientationSensorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class OrientationSensor : 
    IOrientationSensor,
    IOrientationSensorDeviceId,
    IOrientationSensor2
  {
    [MethodImpl]
    public extern OrientationSensorReading GetCurrentReading();

    public extern uint MinimumReportInterval { [MethodImpl] get; }

    public extern uint ReportInterval { [MethodImpl] set; [MethodImpl] get; }

    public extern event TypedEventHandler<OrientationSensor, OrientationSensorReadingChangedEventArgs> ReadingChanged;

    public extern string DeviceId { [MethodImpl] get; }

    public extern DisplayOrientations ReadingTransform { [MethodImpl] set; [MethodImpl] get; }

    public extern SensorReadingType ReadingType { [MethodImpl] get; }

    [Overload("GetDefaultWithSensorReadingType")]
    [MethodImpl]
    public static extern OrientationSensor GetDefault(
      SensorReadingType sensorReadingtype);

    [Overload("GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal")]
    [MethodImpl]
    public static extern OrientationSensor GetDefault(
      SensorReadingType sensorReadingType,
      SensorOptimizationGoal optimizationGoal);

    [MethodImpl]
    public static extern OrientationSensor GetDefaultForRelativeReadings();

    [Overload("GetDefault")]
    [MethodImpl]
    public static extern OrientationSensor GetDefault();
  }
}
