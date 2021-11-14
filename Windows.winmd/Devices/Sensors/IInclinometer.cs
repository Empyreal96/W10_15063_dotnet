// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IInclinometer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(642304623, 8838, 16495, 145, 97, 240, 196, 189, 128, 110, 191)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Inclinometer))]
  internal interface IInclinometer
  {
    InclinometerReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Inclinometer, InclinometerReadingChangedEventArgs> ReadingChanged;
  }
}
