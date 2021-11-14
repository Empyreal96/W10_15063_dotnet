// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.LoopingSelector
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (ILoopingSelectorStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LoopingSelector : Control, ILoopingSelector
  {
    public extern bool ShouldLoop { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<object> Items { [MethodImpl] get; [MethodImpl] set; }

    public extern int SelectedIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern object SelectedItem { [MethodImpl] get; [MethodImpl] set; }

    public extern int ItemWidth { [MethodImpl] get; [MethodImpl] set; }

    public extern int ItemHeight { [MethodImpl] get; [MethodImpl] set; }

    public extern DataTemplate ItemTemplate { [MethodImpl] get; [MethodImpl] set; }

    public extern event SelectionChangedEventHandler SelectionChanged;

    public static extern DependencyProperty ShouldLoopProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemsProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedIndexProperty { [MethodImpl] get; }

    public static extern DependencyProperty SelectedItemProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemWidthProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemHeightProperty { [MethodImpl] get; }

    public static extern DependencyProperty ItemTemplateProperty { [MethodImpl] get; }
  }
}
