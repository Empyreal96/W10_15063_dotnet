// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2704734637, 16436, 19277, 153, 221, 83, 26, 172, 100, 156, 9)]
  [ExclusiveTo(typeof (CustomSensor))]
  internal interface ICustomSensor
  {
    CustomSensorReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    string DeviceId { get; }

    event TypedEventHandler<CustomSensor, CustomSensorReadingChangedEventArgs> ReadingChanged;
  }
}
