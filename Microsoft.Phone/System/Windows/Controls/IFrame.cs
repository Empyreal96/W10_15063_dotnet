// Decompiled with JetBrains decompiler
// Type: System.Windows.Controls.IFrame
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell.Interop;
using System.ComponentModel;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace System.Windows.Controls
{
  internal interface IFrame
  {
    JournalOwnership JournalOwnership { get; set; }

    bool IsInDesignModeX();

    object Content { get; set; }

    int CacheSize { get; set; }

    Dispatcher Dispatcher { get; }

    void UpdateSourceFromNavigationService(Uri newSource);

    Uri CurrentSource { get; set; }

    bool CanGoBack { get; set; }

    bool CanGoForward { get; set; }

    void InternalUpdateOrientationAndMarginForPage(IPhoneApplicationPage visiblePage);

    void InternalOnVisibleRegionChange(object sender, VisibleRegionChangeEventArgs args);

    void InternalOnBackKeyPress(object sender, CancelEventArgs args);

    void InternalOnBackKeyPressPreview(object sender, CancelEventArgs args);

    void InternalNavigateToDefaultTaskPage(object sender, EventArgs args);

    void InternalOnBeginLayoutChanged(object sender, OrientationChangedEventArgs args);

    void InternalOnBeginOrientationChanged(object sender, OrientationChangedEventArgs args);

    void InternalRaiseFocusChangedAutomationEvent();

    UriMapperBase UriMapper { get; set; }

    void Load();

    bool RotateOnClientArea { get; }

    double VerticalOffset { get; set; }

    bool IsNavigationInProgress { get; }

    event NavigatedEventHandler Navigated;

    event NavigatingCancelEventHandler Navigating;

    event NavigationFailedEventHandler NavigationFailed;

    event NavigationStoppedEventHandler NavigationStopped;

    event FragmentNavigationEventHandler FragmentNavigation;
  }
}
