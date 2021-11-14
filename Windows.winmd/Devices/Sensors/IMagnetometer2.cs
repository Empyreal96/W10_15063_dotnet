// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Magnetometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3026545797, 9974, 17483, 169, 226, 162, 63, 150, 108, 211, 104)]
  internal interface IMagnetometer2
  {
    DisplayOrientations ReadingTransform { set; get; }
  }
}
