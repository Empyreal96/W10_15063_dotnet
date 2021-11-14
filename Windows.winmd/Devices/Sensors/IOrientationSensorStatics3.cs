// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(3626821920, 10103, 16639, 159, 89, 214, 84, 176, 133, 241, 47)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (OrientationSensor))]
  internal interface IOrientationSensorStatics3
  {
    [Overload("GetDefaultWithSensorReadingType")]
    OrientationSensor GetDefault(SensorReadingType sensorReadingtype);

    [Overload("GetDefaultWithSensorReadingTypeAndSensorOptimizationGoal")]
    OrientationSensor GetDefault(
      SensorReadingType sensorReadingType,
      SensorOptimizationGoal optimizationGoal);
  }
}
