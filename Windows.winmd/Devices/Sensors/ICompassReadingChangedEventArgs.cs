// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassReadingChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (CompassReadingChangedEventArgs))]
  [Guid(2400537008, 59580, 19582, 176, 9, 78, 65, 223, 19, 112, 114)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompassReadingChangedEventArgs
  {
    CompassReading Reading { get; }
  }
}
