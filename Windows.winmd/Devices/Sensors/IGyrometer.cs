// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IGyrometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(4256803268, 33969, 19618, 151, 99, 155, 88, 149, 6, 199, 12)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Gyrometer))]
  internal interface IGyrometer
  {
    GyrometerReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Gyrometer, GyrometerReadingChangedEventArgs> ReadingChanged;
  }
}
