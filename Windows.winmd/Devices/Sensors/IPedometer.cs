// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2585657661, 15768, 17912, 137, 32, 142, 78, 202, 202, 95, 151)]
  [ExclusiveTo(typeof (Pedometer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPedometer
  {
    string DeviceId { get; }

    double PowerInMilliwatts { get; }

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Pedometer, PedometerReadingChangedEventArgs> ReadingChanged;
  }
}
