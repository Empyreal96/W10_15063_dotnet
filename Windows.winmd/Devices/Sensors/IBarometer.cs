// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IBarometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2470737320, 30911, 17711, 176, 23, 240, 32, 156, 230, 218, 180)]
  [ExclusiveTo(typeof (Barometer))]
  internal interface IBarometer
  {
    BarometerReading GetCurrentReading();

    string DeviceId { get; }

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Barometer, BarometerReadingChangedEventArgs> ReadingChanged;
  }
}
