// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IConstantForceEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ExclusiveTo(typeof (ConstantForceEffect))]
  [Guid(2616852800, 62407, 16732, 176, 104, 15, 6, 135, 52, 188, 224)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IConstantForceEffect : IForceFeedbackEffect
  {
    void SetParameters(Vector3 vector, TimeSpan duration);

    void SetParametersWithEnvelope(
      Vector3 vector,
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
