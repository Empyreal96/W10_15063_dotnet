// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorDeviceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2146322936, 2811, 20305, 135, 240, 108, 38, 55, 92, 233, 79)]
  [ExclusiveTo(typeof (LightSensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILightSensorDeviceId
  {
    string DeviceId { get; }
  }
}
