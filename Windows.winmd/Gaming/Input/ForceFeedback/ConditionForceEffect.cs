// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.ConditionForceEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IConditionForceEffectFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class ConditionForceEffect : IForceFeedbackEffect, IConditionForceEffect
  {
    [MethodImpl]
    public extern ConditionForceEffect(ConditionForceEffectKind effectKind);

    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }

    public extern ForceFeedbackEffectState State { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern ConditionForceEffectKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetParameters(
      Vector3 direction,
      float positiveCoefficient,
      float negativeCoefficient,
      float maxPositiveMagnitude,
      float maxNegativeMagnitude,
      float deadZone,
      float bias);
  }
}
