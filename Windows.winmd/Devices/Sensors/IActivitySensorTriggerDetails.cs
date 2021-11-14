// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IActivitySensorTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [Guid(748578322, 47562, 18039, 178, 99, 36, 50, 151, 247, 157, 58)]
  [ExclusiveTo(typeof (ActivitySensorTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IActivitySensorTriggerDetails
  {
    IVectorView<ActivitySensorReadingChangeReport> ReadReports();
  }
}
