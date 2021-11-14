// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAltimeter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Altimeter))]
  [Guid(1928353789, 36612, 18929, 180, 167, 244, 227, 99, 183, 1, 162)]
  internal interface IAltimeter
  {
    AltimeterReading GetCurrentReading();

    string DeviceId { get; }

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Altimeter, AltimeterReadingChangedEventArgs> ReadingChanged;
  }
}
