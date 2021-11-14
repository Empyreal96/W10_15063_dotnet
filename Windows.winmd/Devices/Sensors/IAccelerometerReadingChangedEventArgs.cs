// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometerReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AccelerometerReadingChangedEventArgs))]
  [Guid(9815643, 46764, 18266, 159, 68, 139, 50, 211, 90, 63, 37)]
  internal interface IAccelerometerReadingChangedEventArgs
  {
    AccelerometerReading Reading { get; }
  }
}
