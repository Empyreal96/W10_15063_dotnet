// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorReadingYawAccuracy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (OrientationSensorReading))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3517749284, 16218, 18850, 188, 123, 17, 128, 188, 56, 205, 43)]
  internal interface IOrientationSensorReadingYawAccuracy
  {
    MagnetometerAccuracy YawAccuracy { get; }
  }
}
