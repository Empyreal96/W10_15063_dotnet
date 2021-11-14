// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IMagnetometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(1213162094, 54217, 16657, 179, 246, 44, 241, 250, 164, 24, 213)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Magnetometer))]
  internal interface IMagnetometer
  {
    MagnetometerReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Magnetometer, MagnetometerReadingChangedEventArgs> ReadingChanged;
  }
}
