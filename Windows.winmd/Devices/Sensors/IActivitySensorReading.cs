// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorReading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(2232572566, 5234, 16546, 178, 174, 225, 239, 41, 34, 108, 120)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ActivitySensorReading))]
  internal interface IActivitySensorReading
  {
    DateTime Timestamp { get; }

    ActivityType Activity { get; }

    ActivitySensorReadingConfidence Confidence { get; }
  }
}
