// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IRampForceEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Guid(4059566681, 7334, 16512, 181, 109, 180, 63, 51, 84, 208, 82)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RampForceEffect))]
  internal interface IRampForceEffect : IForceFeedbackEffect
  {
    void SetParameters(Vector3 startVector, Vector3 endVector, TimeSpan duration);

    void SetParametersWithEnvelope(
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
