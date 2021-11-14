// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (LightSensor))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4165732120, 3156, 18350, 146, 46, 120, 159, 87, 251, 3, 160)]
  internal interface ILightSensor
  {
    LightSensorReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<LightSensor, LightSensorReadingChangedEventArgs> ReadingChanged;
  }
}
