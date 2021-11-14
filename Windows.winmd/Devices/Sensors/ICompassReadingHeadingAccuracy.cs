// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassReadingHeadingAccuracy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (CompassReading))]
  [Guid(3881907534, 35089, 16631, 158, 22, 110, 204, 125, 174, 197, 222)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompassReadingHeadingAccuracy
  {
    MagnetometerAccuracy HeadingAccuracy { get; }
  }
}
