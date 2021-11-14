// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IOrientationSensor2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (OrientationSensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(227691769, 12063, 18889, 128, 66, 74, 24, 19, 214, 119, 96)]
  internal interface IOrientationSensor2
  {
    DisplayOrientations ReadingTransform { set; get; }

    SensorReadingType ReadingType { get; }
  }
}
