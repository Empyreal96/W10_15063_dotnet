// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Frame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [Static(typeof (IFrameStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IFrameFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public class Frame : ContentControl, IFrame, INavigate, IFrame2, IFrame3, IFrame4
  {
    [MethodImpl]
    public extern Frame();

    public extern int CacheSize { [MethodImpl] get; [MethodImpl] set; }

    public extern bool CanGoBack { [MethodImpl] get; }

    public extern bool CanGoForward { [MethodImpl] get; }

    public extern TypeName CurrentSourcePageType { [MethodImpl] get; }

    public extern TypeName SourcePageType { [MethodImpl] get; [MethodImpl] set; }

    public extern int BackStackDepth { [MethodImpl] get; }

    public extern event NavigatedEventHandler Navigated;

    public extern event NavigatingCancelEventHandler Navigating;

    public extern event NavigationFailedEventHandler NavigationFailed;

    public extern event NavigationStoppedEventHandler NavigationStopped;

    [MethodImpl]
    public extern void GoBack();

    [MethodImpl]
    public extern void GoForward();

    [MethodImpl]
    public extern bool Navigate(TypeName sourcePageType, object parameter);

    [MethodImpl]
    public extern string GetNavigationState();

    [Overload("SetNavigationState")]
    [MethodImpl]
    public extern void SetNavigationState(string navigationState);

    [MethodImpl]
    public extern bool Navigate(TypeName sourcePageType);

    public extern IVector<PageStackEntry> BackStack { [MethodImpl] get; }

    public extern IVector<PageStackEntry> ForwardStack { [MethodImpl] get; }

    [MethodImpl]
    public extern bool Navigate(
      TypeName sourcePageType,
      object parameter,
      NavigationTransitionInfo infoOverride);

    [MethodImpl]
    public extern void GoBack(NavigationTransitionInfo transitionInfoOverride);

    [Overload("SetNavigationStateWithNavigationControl")]
    [MethodImpl]
    public extern void SetNavigationState(string navigationState, bool suppressNavigate);

    public static extern DependencyProperty BackStackProperty { [MethodImpl] get; }

    public static extern DependencyProperty ForwardStackProperty { [MethodImpl] get; }

    public static extern DependencyProperty CacheSizeProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanGoBackProperty { [MethodImpl] get; }

    public static extern DependencyProperty CanGoForwardProperty { [MethodImpl] get; }

    public static extern DependencyProperty CurrentSourcePageTypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty SourcePageTypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty BackStackDepthProperty { [MethodImpl] get; }
  }
}
