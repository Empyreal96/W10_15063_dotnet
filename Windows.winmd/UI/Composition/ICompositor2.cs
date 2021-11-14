// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositor2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Guid(1934655964, 24100, 17882, 163, 143, 227, 44, 195, 73, 169, 160)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Compositor))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICompositor2
  {
    AmbientLight CreateAmbientLight();

    CompositionAnimationGroup CreateAnimationGroup();

    CompositionBackdropBrush CreateBackdropBrush();

    DistantLight CreateDistantLight();

    DropShadow CreateDropShadow();

    ImplicitAnimationCollection CreateImplicitAnimationCollection();

    LayerVisual CreateLayerVisual();

    CompositionMaskBrush CreateMaskBrush();

    CompositionNineGridBrush CreateNineGridBrush();

    PointLight CreatePointLight();

    SpotLight CreateSpotLight();

    [Overload("CreateStepEasingFunction")]
    StepEasingFunction CreateStepEasingFunction();

    [Overload("CreateStepEasingFunctionWithStepCount")]
    StepEasingFunction CreateStepEasingFunction(int stepCount);
  }
}
