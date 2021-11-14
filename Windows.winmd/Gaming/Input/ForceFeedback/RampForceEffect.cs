// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.RampForceEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Threading(ThreadingModel.Both)]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772162)]
  public sealed class RampForceEffect : IForceFeedbackEffect, IRampForceEffect
  {
    [MethodImpl]
    public extern RampForceEffect();

    public extern double Gain { [MethodImpl] get; [MethodImpl] set; }

    public extern ForceFeedbackEffectState State { [MethodImpl] get; }

    [MethodImpl]
    public extern void Start();

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern void SetParameters(Vector3 startVector, Vector3 endVector, TimeSpan duration);

    [MethodImpl]
    public extern void SetParametersWithEnvelope(
      Vector3 startVector,
      Vector3 endVector,
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
