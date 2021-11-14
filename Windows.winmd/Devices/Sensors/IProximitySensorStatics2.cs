// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensorStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (ProximitySensor))]
  [Guid(3421795246, 59850, 16943, 173, 103, 76, 61, 37, 223, 53, 12)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IProximitySensorStatics2
  {
    IVectorView<ProximitySensorReading> GetReadingsFromTriggerDetails(
      SensorDataThresholdTriggerDetails triggerDetails);
  }
}
