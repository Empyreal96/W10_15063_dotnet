// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Page
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Composable(typeof (IPageFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IPageStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class Page : UserControl, IPage, IPageOverrides
  {
    [MethodImpl]
    public extern Page();

    public extern Frame Frame { [MethodImpl] get; }

    public extern NavigationCacheMode NavigationCacheMode { [MethodImpl] get; [MethodImpl] set; }

    public extern AppBar TopAppBar { [MethodImpl] get; [MethodImpl] set; }

    public extern AppBar BottomAppBar { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    extern void IPageOverrides.OnNavigatedFrom(NavigationEventArgs e);

    [MethodImpl]
    extern void IPageOverrides.OnNavigatedTo(NavigationEventArgs e);

    [MethodImpl]
    extern void IPageOverrides.OnNavigatingFrom(NavigatingCancelEventArgs e);

    public static extern DependencyProperty FrameProperty { [MethodImpl] get; }

    public static extern DependencyProperty TopAppBarProperty { [MethodImpl] get; }

    public static extern DependencyProperty BottomAppBarProperty { [MethodImpl] get; }
  }
}
