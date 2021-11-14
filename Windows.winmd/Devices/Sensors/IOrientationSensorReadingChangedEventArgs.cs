// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensorReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(19665286, 50106, 18108, 174, 101, 122, 152, 153, 108, 191, 184)]
  [ExclusiveTo(typeof (OrientationSensorReadingChangedEventArgs))]
  internal interface IOrientationSensorReadingChangedEventArgs
  {
    OrientationSensorReading Reading { get; }
  }
}
