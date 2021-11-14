// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPivotStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3995256820, 49501, 20467, 138, 148, 245, 13, 253, 251, 232, 153)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Pivot))]
  internal interface IPivotStatics
  {
    DependencyProperty TitleProperty { get; }

    DependencyProperty TitleTemplateProperty { get; }

    DependencyProperty HeaderTemplateProperty { get; }

    DependencyProperty SelectedIndexProperty { get; }

    DependencyProperty SelectedItemProperty { get; }

    DependencyProperty IsLockedProperty { get; }

    DependencyProperty SlideInAnimationGroupProperty { get; }

    PivotSlideInAnimationGroup GetSlideInAnimationGroup(
      FrameworkElement element);

    void SetSlideInAnimationGroup(FrameworkElement element, PivotSlideInAnimationGroup value);
  }
}
