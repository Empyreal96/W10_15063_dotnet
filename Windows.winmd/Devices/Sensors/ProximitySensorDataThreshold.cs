// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sensors.ProximitySensorDataThreshold
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sensors
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Activatable(typeof (IProximitySensorDataThresholdFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class ProximitySensorDataThreshold : ISensorDataThreshold
  {
    [MethodImpl]
    public extern ProximitySensorDataThreshold(ProximitySensor sensor);
  }
}
