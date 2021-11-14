// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SensorDataThresholdTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Sensors;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (ISensorDataThresholdTriggerFactory), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class SensorDataThresholdTrigger : ISensorDataThresholdTrigger, IBackgroundTrigger
  {
    [MethodImpl]
    public extern SensorDataThresholdTrigger(ISensorDataThreshold threshold);
  }
}
