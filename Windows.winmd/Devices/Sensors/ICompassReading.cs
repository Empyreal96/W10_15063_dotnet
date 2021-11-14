// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompassReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CompassReading))]
  [Guid(2190545192, 20797, 19913, 183, 129, 94, 237, 251, 240, 45, 12)]
  internal interface ICompassReading
  {
    DateTime Timestamp { get; }

    double HeadingMagneticNorth { get; }

    IReference<double> HeadingTrueNorth { get; }
  }
}
