// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (Compositor))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(3020147280, 32652, 20099, 152, 95, 204, 69, 6, 0, 54, 216)]
  [WebHostHidden]
  internal interface ICompositor
  {
    ColorKeyFrameAnimation CreateColorKeyFrameAnimation();

    [Overload("CreateColorBrush")]
    CompositionColorBrush CreateColorBrush();

    [Overload("CreateColorBrushWithColor")]
    CompositionColorBrush CreateColorBrush(Color color);

    ContainerVisual CreateContainerVisual();

    CubicBezierEasingFunction CreateCubicBezierEasingFunction(
      Vector2 controlPoint1,
      Vector2 controlPoint2);

    [Overload("CreateEffectFactory")]
    CompositionEffectFactory CreateEffectFactory(
      IGraphicsEffect graphicsEffect);

    [Overload("CreateEffectFactoryWithProperties")]
    CompositionEffectFactory CreateEffectFactory(
      IGraphicsEffect graphicsEffect,
      IIterable<string> animatableProperties);

    [Overload("CreateExpressionAnimation")]
    ExpressionAnimation CreateExpressionAnimation();

    [Overload("CreateExpressionAnimationWithExpression")]
    ExpressionAnimation CreateExpressionAnimation(string expression);

    [Overload("CreateInsetClip")]
    InsetClip CreateInsetClip();

    [Overload("CreateInsetClipWithInsets")]
    InsetClip CreateInsetClip(
      float leftInset,
      float topInset,
      float rightInset,
      float bottomInset);

    LinearEasingFunction CreateLinearEasingFunction();

    CompositionPropertySet CreatePropertySet();

    QuaternionKeyFrameAnimation CreateQuaternionKeyFrameAnimation();

    ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation();

    CompositionScopedBatch CreateScopedBatch(CompositionBatchTypes batchType);

    SpriteVisual CreateSpriteVisual();

    [Overload("CreateSurfaceBrush")]
    CompositionSurfaceBrush CreateSurfaceBrush();

    [Overload("CreateSurfaceBrushWithSurface")]
    CompositionSurfaceBrush CreateSurfaceBrush(ICompositionSurface surface);

    CompositionTarget CreateTargetForCurrentView();

    Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation();

    Vector3KeyFrameAnimation CreateVector3KeyFrameAnimation();

    Vector4KeyFrameAnimation CreateVector4KeyFrameAnimation();

    CompositionCommitBatch GetCommitBatch(CompositionBatchTypes batchType);
  }
}
