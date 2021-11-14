// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Hosting.IElementCompositionPreviewStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Hosting
{
  [ExclusiveTo(typeof (ElementCompositionPreview))]
  [WebHostHidden]
  [Guid(605327291, 9174, 20279, 186, 12, 7, 51, 231, 153, 114, 45)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IElementCompositionPreviewStatics2
  {
    void SetImplicitShowAnimation(UIElement element, ICompositionAnimationBase animation);

    void SetImplicitHideAnimation(UIElement element, ICompositionAnimationBase animation);

    void SetIsTranslationEnabled(UIElement element, bool value);

    CompositionPropertySet GetPointerPositionPropertySet(
      UIElement targetElement);
  }
}
