// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometer4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Accelerometer))]
  [Guid(490159183, 17107, 17842, 129, 68, 171, 127, 182, 101, 235, 89)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAccelerometer4
  {
    AccelerometerReadingType ReadingType { get; }
  }
}
