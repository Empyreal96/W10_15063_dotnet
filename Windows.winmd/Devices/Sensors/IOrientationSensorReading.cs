// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (OrientationSensorReading))]
  [Guid(1196870035, 26005, 18583, 188, 198, 213, 55, 238, 117, 117, 100)]
  internal interface IOrientationSensorReading
  {
    DateTime Timestamp { get; }

    SensorRotationMatrix RotationMatrix { get; }

    SensorQuaternion Quaternion { get; }
  }
}
