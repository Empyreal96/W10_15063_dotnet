// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.Custom.ICustomSensorReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors.Custom
{
  [Guid(1677741901, 17514, 17254, 168, 122, 95, 150, 50, 104, 236, 83)]
  [ExclusiveTo(typeof (CustomSensorReading))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICustomSensorReading
  {
    DateTime Timestamp { get; }

    IMapView<string, object> Properties { get; }
  }
}
