// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapItemsControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContentProperty(Name = "Items")]
  [Static(typeof (IMapItemsControlStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MapItemsControl : DependencyObject, IMapItemsControl
  {
    [MethodImpl]
    public extern MapItemsControl();

    public extern object ItemsSource { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<DependencyObject> Items { [MethodImpl] get; }

    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ItemsSourceProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemsProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }
  }
}
