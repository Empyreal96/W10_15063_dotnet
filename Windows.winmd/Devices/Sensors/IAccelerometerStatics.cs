// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2783087476, 23175, 18989, 190, 204, 15, 144, 110, 160, 97, 221)]
  [ExclusiveTo(typeof (Accelerometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAccelerometerStatics
  {
    [Overload("GetDefault")]
    Accelerometer GetDefault();
  }
}
