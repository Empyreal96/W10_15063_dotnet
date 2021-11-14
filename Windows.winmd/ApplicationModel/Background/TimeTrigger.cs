// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.TimeTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Activatable(typeof (ITimeTriggerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Standard)]
  public sealed class TimeTrigger : ITimeTrigger, IBackgroundTrigger
  {
    [MethodImpl]
    public extern TimeTrigger(uint freshnessTime, bool oneShot);

    public extern uint FreshnessTime { [MethodImpl] get; }

    public extern bool OneShot { [MethodImpl] get; }
  }
}
