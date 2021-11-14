// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Hosting.ElementCompositionPreview
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Hosting
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IElementCompositionPreviewStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Static(typeof (IElementCompositionPreviewStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  public sealed class ElementCompositionPreview : IElementCompositionPreview
  {
    [MethodImpl]
    public static extern void SetImplicitShowAnimation(
      UIElement element,
      ICompositionAnimationBase animation);

    [MethodImpl]
    public static extern void SetImplicitHideAnimation(
      UIElement element,
      ICompositionAnimationBase animation);

    [MethodImpl]
    public static extern void SetIsTranslationEnabled(UIElement element, bool value);

    [MethodImpl]
    public static extern CompositionPropertySet GetPointerPositionPropertySet(
      UIElement targetElement);

    [MethodImpl]
    public static extern Visual GetElementVisual(UIElement element);

    [MethodImpl]
    public static extern Visual GetElementChildVisual(UIElement element);

    [MethodImpl]
    public static extern void SetElementChildVisual(UIElement element, Visual visual);

    [MethodImpl]
    public static extern CompositionPropertySet GetScrollViewerManipulationPropertySet(
      ScrollViewer scrollViewer);
  }
}
