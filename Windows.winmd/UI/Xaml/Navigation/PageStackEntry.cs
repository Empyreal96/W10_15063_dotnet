// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.PageStackEntry
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [Static(typeof (IPageStackEntryStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Activatable(typeof (IPageStackEntryFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PageStackEntry : DependencyObject, IPageStackEntry
  {
    [MethodImpl]
    public extern PageStackEntry(
      TypeName sourcePageType,
      object parameter,
      NavigationTransitionInfo navigationTransitionInfo);

    public extern TypeName SourcePageType { [MethodImpl] get; }

    public extern object Parameter { [MethodImpl] get; }

    public extern NavigationTransitionInfo NavigationTransitionInfo { [MethodImpl] get; }

    public static extern DependencyProperty SourcePageTypeProperty { [MethodImpl] get; }
  }
}
