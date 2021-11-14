// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IVisualInteractionSource2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2861648019, 42812, 16717, 128, 208, 36, 155, 173, 47, 189, 147)]
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualInteractionSource))]
  internal interface IVisualInteractionSource2
  {
    Vector3 DeltaPosition { get; }

    float DeltaScale { get; }

    Vector3 Position { get; }

    Vector3 PositionVelocity { get; }

    float Scale { get; }

    float ScaleVelocity { get; }

    void ConfigureCenterPointXModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureCenterPointYModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureDeltaPositionXModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureDeltaPositionYModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureDeltaScaleModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);
  }
}
