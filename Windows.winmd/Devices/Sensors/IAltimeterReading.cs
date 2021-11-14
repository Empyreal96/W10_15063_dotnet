// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAltimeterReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AltimeterReading))]
  [Guid(4226346867, 32606, 18632, 170, 26, 241, 243, 190, 252, 17, 68)]
  internal interface IAltimeterReading
  {
    DateTime Timestamp { get; }

    double AltitudeChangeInMeters { get; }
  }
}
