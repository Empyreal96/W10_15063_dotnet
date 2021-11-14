// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IPeriodicForceEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Guid(1548826839, 64629, 19794, 154, 10, 239, 228, 202, 181, 254, 100)]
  [ExclusiveTo(typeof (PeriodicForceEffect))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IPeriodicForceEffect : IForceFeedbackEffect
  {
    PeriodicForceEffectKind Kind { get; }

    void SetParameters(
      Vector3 vector,
      float frequency,
      float phase,
      float bias,
      TimeSpan duration);

    void SetParametersWithEnvelope(
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
