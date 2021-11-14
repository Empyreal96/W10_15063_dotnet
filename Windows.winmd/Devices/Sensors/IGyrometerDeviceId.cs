// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometerDeviceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(518383992, 35234, 17013, 158, 149, 113, 38, 244, 112, 135, 96)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Gyrometer))]
  internal interface IGyrometerDeviceId
  {
    string DeviceId { get; }
  }
}
