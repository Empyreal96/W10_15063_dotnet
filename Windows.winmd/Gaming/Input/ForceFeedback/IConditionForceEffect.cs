// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IConditionForceEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Guid(852617832, 13973, 20073, 133, 192, 205, 25, 68, 24, 145, 64)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ConditionForceEffect))]
  internal interface IConditionForceEffect : IForceFeedbackEffect
  {
    ConditionForceEffectKind Kind { get; }

    void SetParameters(
      Vector3 direction,
      float positiveCoefficient,
      float negativeCoefficient,
      float maxPositiveMagnitude,
      float maxNegativeMagnitude,
      float deadZone,
      float bias);
  }
}
