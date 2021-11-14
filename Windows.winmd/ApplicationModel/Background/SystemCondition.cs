// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.SystemCondition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [Threading(ThreadingModel.MTA)]
  [Activatable(typeof (ISystemConditionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SystemCondition : ISystemCondition, IBackgroundCondition
  {
    [MethodImpl]
    public extern SystemCondition(SystemConditionType conditionType);

    public extern SystemConditionType ConditionType { [MethodImpl] get; }
  }
}
