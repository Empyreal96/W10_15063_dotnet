// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml
{
  [Guid(2744242331, 19097, 19324, 157, 141, 111, 165, 208, 31, 111, 191)]
  [WebHostHidden]
  [ExclusiveTo(typeof (FrameworkElement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameworkElement
  {
    TriggerCollection Triggers { get; }

    ResourceDictionary Resources { get; set; }

    object Tag { get; set; }

    string Language { get; set; }

    double ActualWidth { get; }

    double ActualHeight { get; }

    double Width { get; set; }

    double Height { get; set; }

    double MinWidth { get; set; }

    double MaxWidth { get; set; }

    double MinHeight { get; set; }

    double MaxHeight { get; set; }

    HorizontalAlignment HorizontalAlignment { get; set; }

    VerticalAlignment VerticalAlignment { get; set; }

    Thickness Margin { get; set; }

    string Name { get; set; }

    Uri BaseUri { get; }

    object DataContext { get; set; }

    Style Style { get; set; }

    DependencyObject Parent { get; }

    FlowDirection FlowDirection { get; set; }

    event RoutedEventHandler Loaded;

    event RoutedEventHandler Unloaded;

    event SizeChangedEventHandler SizeChanged;

    event EventHandler<object> LayoutUpdated;

    object FindName(string name);

    void SetBinding(DependencyProperty dp, BindingBase binding);
  }
}
