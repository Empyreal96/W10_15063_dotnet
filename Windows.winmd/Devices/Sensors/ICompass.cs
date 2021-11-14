// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ICompass
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(691010196, 6981, 16444, 186, 6, 177, 6, 219, 166, 154, 100)]
  [ExclusiveTo(typeof (Compass))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICompass
  {
    CompassReading GetCurrentReading();

    uint MinimumReportInterval { get; }

    uint ReportInterval { set; get; }

    event TypedEventHandler<Compass, CompassReadingChangedEventArgs> ReadingChanged;
  }
}
