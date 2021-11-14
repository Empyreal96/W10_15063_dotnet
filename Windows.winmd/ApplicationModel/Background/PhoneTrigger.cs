// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.PhoneTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Calls.Background;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IPhoneTriggerFactory), 65536, "Windows.ApplicationModel.Calls.CallsPhoneContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [PreviousContractVersion("Windows.ApplicationModel.Calls.CallsPhoneContract", 65536, 131072)]
  [ContractVersion(typeof (CallsBackgroundContract), 65536)]
  public sealed class PhoneTrigger : IPhoneTrigger, IBackgroundTrigger
  {
    [MethodImpl]
    public extern PhoneTrigger(PhoneTriggerType type, bool oneShot);

    public extern bool OneShot { [MethodImpl] get; }

    public extern PhoneTriggerType TriggerType { [MethodImpl] get; }
  }
}
