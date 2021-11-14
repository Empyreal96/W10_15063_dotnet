// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Sms.SmsFilterRules
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Sms
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (ISmsFilterRulesFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmsFilterRules : ISmsFilterRules
  {
    [MethodImpl]
    public extern SmsFilterRules(SmsFilterActionType actionType);

    public extern SmsFilterActionType ActionType { [MethodImpl] get; }

    public extern IVector<SmsFilterRule> Rules { [MethodImpl] get; }
  }
}
