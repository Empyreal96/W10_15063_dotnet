// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Frame))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1760186379, 16361, 18229, 182, 160, 231, 96, 25, 51, 176, 137)]
  internal interface IFrame
  {
    int CacheSize { get; set; }

    bool CanGoBack { get; }

    bool CanGoForward { get; }

    TypeName CurrentSourcePageType { get; }

    TypeName SourcePageType { get; set; }

    int BackStackDepth { get; }

    event NavigatedEventHandler Navigated;

    event NavigatingCancelEventHandler Navigating;

    event NavigationFailedEventHandler NavigationFailed;

    event NavigationStoppedEventHandler NavigationStopped;

    void GoBack();

    void GoForward();

    bool Navigate(TypeName sourcePageType, object parameter);

    string GetNavigationState();

    [Overload("SetNavigationState")]
    void SetNavigationState(string navigationState);
  }
}
