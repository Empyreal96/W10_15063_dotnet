// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Inclinometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(43987859, 10418, 17912, 187, 22, 97, 232, 106, 127, 174, 110)]
  internal interface IInclinometer2
  {
    DisplayOrientations ReadingTransform { set; get; }

    SensorReadingType ReadingType { get; }
  }
}
