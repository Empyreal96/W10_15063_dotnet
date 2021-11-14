// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Hosting.IElementCompositionPreviewStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Hosting
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(147401528, 60569, 19541, 188, 133, 161, 193, 128, 178, 118, 70)]
  [ExclusiveTo(typeof (ElementCompositionPreview))]
  [WebHostHidden]
  internal interface IElementCompositionPreviewStatics
  {
    Visual GetElementVisual(UIElement element);

    Visual GetElementChildVisual(UIElement element);

    void SetElementChildVisual(UIElement element, Visual visual);

    CompositionPropertySet GetScrollViewerManipulationPropertySet(
      ScrollViewer scrollViewer);
  }
}
