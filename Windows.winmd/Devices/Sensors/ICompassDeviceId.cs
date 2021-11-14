// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassDeviceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3514944041, 45189, 19229, 135, 10, 79, 245, 123, 167, 79, 212)]
  [ExclusiveTo(typeof (Compass))]
  internal interface ICompassDeviceId
  {
    string DeviceId { get; }
  }
}
