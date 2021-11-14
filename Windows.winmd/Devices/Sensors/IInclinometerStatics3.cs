// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3181003392, 47386, 18473, 147, 146, 171, 192, 182, 189, 242, 180)]
  [ExclusiveTo(typeof (Inclinometer))]
  internal interface IInclinometerStatics3
  {
    [Overload("GetDefaultWithSensorReadingType")]
    Inclinometer GetDefault(SensorReadingType sensorReadingtype);
  }
}
