// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorDeviceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (OrientationSensor))]
  [Guid(1516877384, 19497, 18924, 178, 143, 234, 29, 17, 123, 102, 240)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOrientationSensorDeviceId
  {
    string DeviceId { get; }
  }
}
