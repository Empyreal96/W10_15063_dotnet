// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaStateEnteredArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2266008818, 59391, 20349, 159, 253, 215, 47, 30, 64, 155, 99)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InteractionTrackerInertiaStateEnteredArgs))]
  internal interface IInteractionTrackerInertiaStateEnteredArgs
  {
    IReference<Vector3> ModifiedRestingPosition { get; }

    IReference<float> ModifiedRestingScale { get; }

    Vector3 NaturalRestingPosition { get; }

    float NaturalRestingScale { get; }

    Vector3 PositionVelocityInPixelsPerSecond { get; }

    int RequestId { get; }

    float ScaleVelocityInPercentPerSecond { get; }
  }
}
