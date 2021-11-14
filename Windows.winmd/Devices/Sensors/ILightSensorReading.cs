// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ILightSensorReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LightSensorReading))]
  [Guid(4292829952, 8828, 19755, 179, 2, 252, 1, 66, 72, 92, 104)]
  internal interface ILightSensorReading
  {
    DateTime Timestamp { get; }

    float IlluminanceInLux { get; }
  }
}
