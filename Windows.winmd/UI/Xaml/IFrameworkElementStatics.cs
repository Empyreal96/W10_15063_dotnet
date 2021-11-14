// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElementStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (FrameworkElement))]
  [Guid(1211641906, 64491, 20362, 174, 210, 238, 33, 251, 39, 165, 123)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IFrameworkElementStatics
  {
    DependencyProperty TagProperty { get; }

    DependencyProperty LanguageProperty { get; }

    DependencyProperty ActualWidthProperty { get; }

    DependencyProperty ActualHeightProperty { get; }

    DependencyProperty WidthProperty { get; }

    DependencyProperty HeightProperty { get; }

    DependencyProperty MinWidthProperty { get; }

    DependencyProperty MaxWidthProperty { get; }

    DependencyProperty MinHeightProperty { get; }

    DependencyProperty MaxHeightProperty { get; }

    DependencyProperty HorizontalAlignmentProperty { get; }

    DependencyProperty VerticalAlignmentProperty { get; }

    DependencyProperty MarginProperty { get; }

    DependencyProperty NameProperty { get; }

    DependencyProperty DataContextProperty { get; }

    DependencyProperty StyleProperty { get; }

    DependencyProperty FlowDirectionProperty { get; }
  }
}
