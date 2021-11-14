// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerDeviceId
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(32053634, 16895, 17414, 174, 131, 98, 33, 15, 241, 111, 227)]
  [ExclusiveTo(typeof (Inclinometer))]
  internal interface IInclinometerDeviceId
  {
    string DeviceId { get; }
  }
}
