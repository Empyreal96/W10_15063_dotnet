// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IPedometerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (Pedometer))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2046150331, 52750, 16691, 180, 126, 134, 39, 234, 114, 246, 119)]
  internal interface IPedometerStatics2
  {
    IVectorView<PedometerReading> GetReadingsFromTriggerDetails(
      SensorDataThresholdTriggerDetails triggerDetails);
  }
}
