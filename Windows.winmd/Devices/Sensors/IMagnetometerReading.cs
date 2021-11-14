// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(204260365, 60413, 20060, 187, 17, 175, 194, 155, 60, 174, 97)]
  [ExclusiveTo(typeof (MagnetometerReading))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMagnetometerReading
  {
    DateTime Timestamp { get; }

    float MagneticFieldX { get; }

    float MagneticFieldY { get; }

    float MagneticFieldZ { get; }

    MagnetometerAccuracy DirectionalAccuracy { get; }
  }
}
