// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompass2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Display;

namespace Windows.Devices.Sensors
{
  [Guid(921857289, 51159, 17231, 180, 97, 151, 157, 223, 194, 50, 47)]
  [ExclusiveTo(typeof (Compass))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompass2
  {
    DisplayOrientations ReadingTransform { set; get; }
  }
}
