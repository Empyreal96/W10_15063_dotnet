// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Accelerometer))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3301213231, 55403, 18053, 178, 215, 51, 150, 247, 152, 213, 123)]
  internal interface IAccelerometerStatics2
  {
    [Overload("GetDefaultWithAccelerometerReadingType")]
    Accelerometer GetDefault(AccelerometerReadingType readingType);
  }
}
