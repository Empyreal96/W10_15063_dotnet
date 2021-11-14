// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ILoopingSelectorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [Guid(65583866, 35965, 20421, 185, 42, 240, 73, 251, 147, 60, 197)]
  [ExclusiveTo(typeof (LoopingSelector))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILoopingSelectorStatics
  {
    DependencyProperty ShouldLoopProperty { get; }

    DependencyProperty ItemsProperty { get; }

    DependencyProperty SelectedIndexProperty { get; }

    DependencyProperty SelectedItemProperty { get; }

    DependencyProperty ItemWidthProperty { get; }

    DependencyProperty ItemHeightProperty { get; }

    DependencyProperty ItemTemplateProperty { get; }
  }
}
