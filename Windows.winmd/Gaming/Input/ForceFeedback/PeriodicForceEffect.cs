// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.PeriodicForceEffect
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
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772162)]
  [Activatable(typeof (IPeriodicForceEffectFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PeriodicForceEffect : IForceFeedbackEffect, IPeriodicForceEffect
  {
    [MethodImpl]
    public extern PeriodicForceEffect(PeriodicForceEffectKind effectKind);

    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }

    public extern ForceFeedbackEffectState State { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    public extern PeriodicForceEffectKind Kind { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetParameters(
      Vector3 vector,
      float frequency,
      float phase,
      float bias,
      TimeSpan duration);

    [MethodImpl]
    public extern void SetParametersWithEnvelope(
      Vector3 vector,
      float frequency,
      float phase,
      float bias,
      float attackGain,
      float sustainGain,
      float releaseGain,
      TimeSpan startDelay,
      TimeSpan attackDuration,
      TimeSpan sustainDuration,
      TimeSpan releaseDuration,
      uint repeatCount);
  }
}
