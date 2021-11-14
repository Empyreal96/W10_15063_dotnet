// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.IProximitySensorDataThresholdFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [ExclusiveTo(typeof (ProximitySensorDataThreshold))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(2421866785, 27943, 19155, 157, 181, 100, 103, 242, 165, 173, 157)]
  internal interface IProximitySensorDataThresholdFactory
  {
    ProximitySensorDataThreshold Create(ProximitySensor sensor);
  }
}
