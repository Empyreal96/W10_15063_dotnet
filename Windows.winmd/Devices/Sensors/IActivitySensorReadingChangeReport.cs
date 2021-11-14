// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorReadingChangeReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (ActivitySensorReadingChangeReport))]
  [Guid(1329342741, 55611, 18365, 150, 10, 242, 15, 178, 243, 34, 185)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IActivitySensorReadingChangeReport
  {
    ActivitySensorReading Reading { get; }
  }
}
