// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ISimpleOrientationSensorOrientationChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SimpleOrientationSensorOrientationChangedEventArgs))]
  [Guid(3168126560, 9172, 19276, 162, 46, 186, 129, 173, 224, 198, 1)]
  internal interface ISimpleOrientationSensorOrientationChangedEventArgs
  {
    DateTime Timestamp { get; }

    SimpleOrientation Orientation { get; }
  }
}
