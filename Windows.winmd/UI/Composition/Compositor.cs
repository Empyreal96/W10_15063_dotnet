// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Compositor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Activatable(131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class Compositor : ICompositor, IClosable, ICompositor2, ICompositor3
  {
    [MethodImpl]
    public extern Compositor();

    [MethodImpl]
    public extern ColorKeyFrameAnimation CreateColorKeyFrameAnimation();

    [Overload("CreateColorBrush")]
    [MethodImpl]
    public extern CompositionColorBrush CreateColorBrush();

    [Overload("CreateColorBrushWithColor")]
    [MethodImpl]
    public extern CompositionColorBrush CreateColorBrush(Color color);

    [MethodImpl]
    public extern ContainerVisual CreateContainerVisual();

    [MethodImpl]
    public extern CubicBezierEasingFunction CreateCubicBezierEasingFunction(
      Vector2 controlPoint1,
      Vector2 controlPoint2);

    [Overload("CreateEffectFactory")]
    [MethodImpl]
    public extern CompositionEffectFactory CreateEffectFactory(
      IGraphicsEffect graphicsEffect);

    [Overload("CreateEffectFactoryWithProperties")]
    [MethodImpl]
    public extern CompositionEffectFactory CreateEffectFactory(
      IGraphicsEffect graphicsEffect,
      IIterable<string> animatableProperties);

    [Overload("CreateExpressionAnimation")]
    [MethodImpl]
    public extern ExpressionAnimation CreateExpressionAnimation();

    [Overload("CreateExpressionAnimationWithExpression")]
    [MethodImpl]
    public extern ExpressionAnimation CreateExpressionAnimation(string expression);

    [Overload("CreateInsetClip")]
    [MethodImpl]
    public extern InsetClip CreateInsetClip();

    [Overload("CreateInsetClipWithInsets")]
    [MethodImpl]
    public extern InsetClip CreateInsetClip(
      float leftInset,
      float topInset,
      float rightInset,
      float bottomInset);

    [MethodImpl]
    public extern LinearEasingFunction CreateLinearEasingFunction();

    [MethodImpl]
    public extern CompositionPropertySet CreatePropertySet();

    [MethodImpl]
    public extern QuaternionKeyFrameAnimation CreateQuaternionKeyFrameAnimation();

    [MethodImpl]
    public extern ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation();

    [MethodImpl]
    public extern CompositionScopedBatch CreateScopedBatch(
      CompositionBatchTypes batchType);

    [MethodImpl]
    public extern SpriteVisual CreateSpriteVisual();

    [Overload("CreateSurfaceBrush")]
    [MethodImpl]
    public extern CompositionSurfaceBrush CreateSurfaceBrush();

    [Overload("CreateSurfaceBrushWithSurface")]
    [MethodImpl]
    public extern CompositionSurfaceBrush CreateSurfaceBrush(
      ICompositionSurface surface);

    [MethodImpl]
    public extern CompositionTarget CreateTargetForCurrentView();

    [MethodImpl]
    public extern Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation();

    [MethodImpl]
    public extern Vector3KeyFrameAnimation CreateVector3KeyFrameAnimation();

    [MethodImpl]
    public extern Vector4KeyFrameAnimation CreateVector4KeyFrameAnimation();

    [MethodImpl]
    public extern CompositionCommitBatch GetCommitBatch(
      CompositionBatchTypes batchType);

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public extern AmbientLight CreateAmbientLight();

    [MethodImpl]
    public extern CompositionAnimationGroup CreateAnimationGroup();

    [MethodImpl]
    public extern CompositionBackdropBrush CreateBackdropBrush();

    [MethodImpl]
    public extern DistantLight CreateDistantLight();

    [MethodImpl]
    public extern DropShadow CreateDropShadow();

    [MethodImpl]
    public extern ImplicitAnimationCollection CreateImplicitAnimationCollection();

    [MethodImpl]
    public extern LayerVisual CreateLayerVisual();

    [MethodImpl]
    public extern CompositionMaskBrush CreateMaskBrush();

    [MethodImpl]
    public extern CompositionNineGridBrush CreateNineGridBrush();

    [MethodImpl]
    public extern PointLight CreatePointLight();

    [MethodImpl]
    public extern SpotLight CreateSpotLight();

    [Overload("CreateStepEasingFunction")]
    [MethodImpl]
    public extern StepEasingFunction CreateStepEasingFunction();

    [Overload("CreateStepEasingFunctionWithStepCount")]
    [MethodImpl]
    public extern StepEasingFunction CreateStepEasingFunction(int stepCount);

    [MethodImpl]
    public extern CompositionBackdropBrush CreateHostBackdropBrush();
  }
}
