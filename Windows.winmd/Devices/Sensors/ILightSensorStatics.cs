// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (LightSensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1172016260, 50088, 18206, 154, 83, 100, 87, 250, 216, 124, 14)]
  internal interface ILightSensorStatics
  {
    LightSensor GetDefault();
  }
}
