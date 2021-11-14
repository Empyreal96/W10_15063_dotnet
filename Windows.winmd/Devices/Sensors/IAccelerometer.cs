// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IAccelerometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Accelerometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3742909768, 10001, 19879, 128, 152, 75, 130, 32, 93, 60, 125)]
  internal interface IAccelerometer
  {
    AccelerometerReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Accelerometer, AccelerometerReadingChangedEventArgs> ReadingChanged;

    event TypedEventHandler<Accelerometer, AccelerometerShakenEventArgs> Shaken;
  }
}
