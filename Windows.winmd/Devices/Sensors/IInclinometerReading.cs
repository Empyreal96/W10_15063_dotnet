// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometerReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2672095317, 46838, 18815, 177, 39, 26, 119, 94, 80, 20, 88)]
  [ExclusiveTo(typeof (InclinometerReading))]
  internal interface IInclinometerReading
  {
    DateTime Timestamp { get; }

    float PitchDegrees { get; }

    float RollDegrees { get; }

    float YawDegrees { get; }
  }
}
