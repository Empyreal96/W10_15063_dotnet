// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerDeviceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Accelerometer))]
  [Guid(2125227177, 38869, 17517, 171, 90, 145, 125, 249, 185, 106, 44)]
  internal interface IAccelerometerDeviceId
  {
    string DeviceId { get; }
  }
}
