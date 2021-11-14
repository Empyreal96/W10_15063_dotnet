// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTracker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Static(typeof (IInteractionTrackerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class InteractionTracker : 
    CompositionObject,
    IInteractionTracker,
    IInteractionTracker2
  {
    public extern CompositionInteractionSourceCollection InteractionSources { [MethodImpl] get; }

    public extern bool IsPositionRoundingSuggested { [MethodImpl] get; }

    public extern Vector3 MaxPosition { [MethodImpl] get; [MethodImpl] set; }

    public extern float MaxScale { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 MinPosition { [MethodImpl] get; [MethodImpl] set; }

    public extern float MinScale { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 NaturalRestingPosition { [MethodImpl] get; }

    public extern float NaturalRestingScale { [MethodImpl] get; }

    public extern IInteractionTrackerOwner Owner { [MethodImpl] get; }

    public extern Vector3 Position { [MethodImpl] get; }

    public extern IReference<Vector3> PositionInertiaDecayRate { [MethodImpl] get; [MethodImpl] set; }

    public extern Vector3 PositionVelocityInPixelsPerSecond { [MethodImpl] get; }

    public extern float Scale { [MethodImpl] get; }

    public extern IReference<float> ScaleInertiaDecayRate { [MethodImpl] get; [MethodImpl] set; }

    public extern float ScaleVelocityInPercentPerSecond { [MethodImpl] get; }

    [MethodImpl]
    public extern void AdjustPositionXIfGreaterThanThreshold(
      float adjustment,
      float positionThreshold);

    [MethodImpl]
    public extern void AdjustPositionYIfGreaterThanThreshold(
      float adjustment,
      float positionThreshold);

    [MethodImpl]
    public extern void ConfigurePositionXInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    [MethodImpl]
    public extern void ConfigurePositionYInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    [MethodImpl]
    public extern void ConfigureScaleInertiaModifiers(
      IIterable<InteractionTrackerInertiaModifier> modifiers);

    [MethodImpl]
    public extern int TryUpdatePosition(Vector3 value);

    [MethodImpl]
    public extern int TryUpdatePositionBy(Vector3 amount);

    [MethodImpl]
    public extern int TryUpdatePositionWithAnimation(CompositionAnimation animation);

    [MethodImpl]
    public extern int TryUpdatePositionWithAdditionalVelocity(Vector3 velocityInPixelsPerSecond);

    [MethodImpl]
    public extern int TryUpdateScale(float value, Vector3 centerPoint);

    [MethodImpl]
    public extern int TryUpdateScaleWithAnimation(
      CompositionAnimation animation,
      Vector3 centerPoint);

    [MethodImpl]
    public extern int TryUpdateScaleWithAdditionalVelocity(
      float velocityInPercentPerSecond,
      Vector3 centerPoint);

    [MethodImpl]
    public extern void ConfigureCenterPointXInertiaModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureCenterPointYInertiaModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public static extern InteractionTracker Create(Compositor compositor);

    [MethodImpl]
    public static extern InteractionTracker CreateWithOwner(
      Compositor compositor,
      IInteractionTrackerOwner owner);
  }
}
