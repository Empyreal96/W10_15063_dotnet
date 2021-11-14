// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTracker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [ExclusiveTo(typeof (InteractionTracker))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(713985201, 4096, 17430, 131, 99, 204, 39, 251, 135, 115, 8)]
  [WebHostHidden]
  internal interface IInteractionTracker
  {
    CompositionInteractionSourceCollection InteractionSources { get; }

    bool IsPositionRoundingSuggested { get; }

    Vector3 MaxPosition { get; set; }

    float MaxScale { get; set; }

    Vector3 MinPosition { get; set; }

    float MinScale { get; set; }

    Vector3 NaturalRestingPosition { get; }

    float NaturalRestingScale { get; }

    IInteractionTrackerOwner Owner { get; }

    Vector3 Position { get; }

    IReference<Vector3> PositionInertiaDecayRate { get; set; }

    Vector3 PositionVelocityInPixelsPerSecond { get; }

    float Scale { get; }

    IReference<float> ScaleInertiaDecayRate { get; set; }

    float ScaleVelocityInPercentPerSecond { get; }

    void AdjustPositionXIfGreaterThanThreshold(float adjustment, float positionThreshold);

    void AdjustPositionYIfGreaterThanThreshold(float adjustment, float positionThreshold);

    void ConfigurePositionXInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    void ConfigurePositionYInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    void ConfigureScaleInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    int TryUpdatePosition(Vector3 value);

    int TryUpdatePositionBy(Vector3 amount);

    int TryUpdatePositionWithAnimation(CompositionAnimation animation);

    int TryUpdatePositionWithAdditionalVelocity(Vector3 velocityInPixelsPerSecond);

    int TryUpdateScale(float value, Vector3 centerPoint);

    int TryUpdateScaleWithAnimation(CompositionAnimation animation, Vector3 centerPoint);

    int TryUpdateScaleWithAdditionalVelocity(float velocityInPercentPerSecond, Vector3 centerPoint);
  }
}
