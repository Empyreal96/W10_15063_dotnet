// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISimpleOrientationSensorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (SimpleOrientationSensor))]
  [Guid(1928136303, 28842, 16582, 155, 27, 52, 51, 247, 69, 155, 78)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISimpleOrientationSensorStatics
  {
    SimpleOrientationSensor GetDefault();
  }
}
