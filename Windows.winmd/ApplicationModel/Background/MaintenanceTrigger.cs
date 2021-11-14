// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.MaintenanceTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IMaintenanceTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Threading(ThreadingModel.MTA)]
  public sealed class MaintenanceTrigger : IMaintenanceTrigger, IBackgroundTrigger
  {
    [MethodImpl]
    public extern MaintenanceTrigger(uint freshnessTime, bool oneShot);

    public extern uint FreshnessTime { [MethodImpl] get; }

    public extern bool OneShot { [MethodImpl] get; }
  }
}
