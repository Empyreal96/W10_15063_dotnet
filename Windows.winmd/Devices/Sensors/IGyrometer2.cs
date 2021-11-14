// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1675568195, 36072, 16835, 172, 68, 134, 152, 129, 11, 85, 127)]
  [ExclusiveTo(typeof (Gyrometer))]
  internal interface IGyrometer2
  {
    DisplayOrientations ReadingTransform { set; get; }
  }
}
