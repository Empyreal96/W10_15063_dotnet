// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IBarometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4122596070, 7670, 18970, 167, 173, 50, 29, 79, 93, 178, 71)]
  [ExclusiveTo(typeof (BarometerReading))]
  internal interface IBarometerReading
  {
    DateTime Timestamp { get; }

    double StationPressureInHectopascals { get; }
  }
}
