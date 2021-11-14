// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.PhoneApplicationPage
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Info;
using Microsoft.Phone.Interop;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Microsoft.Phone.Controls
{
  public class PhoneApplicationPage : Page, IPhoneApplicationPage
  {
    private ISysTrayInterop mSysTrayInterop;
    public static readonly DependencyProperty SupportedOrientationsProperty = DependencyProperty.Register(nameof (SupportedOrientations), typeof (SupportedPageOrientation), typeof (PhoneApplicationPage), new PropertyMetadata((object) SupportedPageOrientation.Portrait, new PropertyChangedCallback(PhoneApplicationPage.SupportedOrientationsPropertyChanged)));
    public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register(nameof (Orientation), typeof (PageOrientation), typeof (PhoneApplicationPage), (PropertyMetadata) null);
    private PageOrientation mLayoutOrientation;
    private RECT mUnorientedVisibleRegion = new RECT()
    {
      left = 0,
      top = 0,
      right = 0,
      bottom = 0
    };
    private Thickness mVisibleRegion = new Thickness(0.0);
    private bool mIsOrientationChanged;
    private Thickness mVisibleBounds = new Thickness(0.0);
    private bool mSuppressUnorientedBottomMargin;
    public static readonly DependencyProperty ApplicationBarProperty = DependencyProperty.Register(nameof (ApplicationBar), typeof (IApplicationBar), typeof (PhoneApplicationPage), new PropertyMetadata(new PropertyChangedCallback(PhoneApplicationPage.ApplicationBarPropertyChanged)));
    private IDictionary<string, object> _dictionary;
    private EventHandler<OrientationChangedEventArgs> _beginOrientationChanged;
    private EventHandler<VisibleRegionChangeEventArgs> _internalVisibleRegionChanged;
    private EventHandler _visibleBoundsChanged;
    private bool _sipIsVisible;
    private bool _sipPropertyChanged;
    private bool _navbarPropertyChanged;
    private FrameworkElement _currentlyFocusedElement;
    private bool _systemTrayIsVisible;
    private bool _isScreenCaptureEnabled = true;
    private bool _systemTrayReservesSpace = true;
    private bool _suppressUnorientedBottomMarginChanged;
    private float _systemTrayOpacity = 1f;
    private bool _systemTrayForegroundColorSet;
    private Color _systemTrayForegroundColor = Colors.White;
    private bool _systemTrayBackgroundColorSet;
    private Color _systemTrayBackgroundColor = Colors.Black;
    private ProgressIndicator _progressIndicator;

    public PhoneApplicationPage()
    {
      PerfUtil.BeginLogMarker(MarkerEvents.TH_INIT_PAGE, "Page initialized: " + (this.Title == null ? "" : this.Title));
      this.NavigationCacheMode = NavigationCacheMode.Disabled;
      this.InitializePageOrientation();
      this.IsTabStop = true;
      this.mSysTrayInterop = !PhoneApplicationPage.IsInDesignMode() ? (ISysTrayInterop) new NativeSystemTrayInteropWrapper() : (ISysTrayInterop) new DesignSystemTrayWrapper();
      this.mSysTrayInterop.CreateSystemTray();
      this.SystemTrayIsVisible = this._systemTrayIsVisible;
      this.IsScreenCaptureEnabled = this._isScreenCaptureEnabled;
    }

    private void InitializePageOrientation()
    {
      PageOrientation desiredPageOrientation = this.ComputeDesiredPageOrientation(ApplicationHost.Current.RootTask.GetCurrentOrientation());
      if (desiredPageOrientation == PageOrientation.None || desiredPageOrientation == this.Orientation)
        return;
      this.SetValue(PhoneApplicationPage.OrientationProperty, (Enum) desiredPageOrientation);
      this.LayoutOrientation = desiredPageOrientation;
    }

    private PageOrientation ComputeDesiredPageOrientation(Orientations orientation)
    {
      PageOrientation pageOrientation = PageOrientation.None;
      switch (orientation)
      {
        case Orientations.PortraitUp:
          pageOrientation = PageOrientation.PortraitUp;
          break;
        case Orientations.LandscapeLeft:
          pageOrientation = PageOrientation.LandscapeLeft;
          break;
        case Orientations.LandscapeRight:
          pageOrientation = PageOrientation.LandscapeRight;
          break;
      }
      return pageOrientation;
    }

    ~PhoneApplicationPage() => PerfUtil.EndLogMarker(MarkerEvents.TH_INIT_PAGE, "Page uninitialized");

    private static bool IsInDesignMode() => Application.Current == null || Application.Current.GetType() == typeof (Application) || DesignerProperties.IsInDesignTool;

    public SupportedPageOrientation SupportedOrientations
    {
      get => (SupportedPageOrientation) this.GetValue(PhoneApplicationPage.SupportedOrientationsProperty);
      set
      {
        if (value == this.SupportedOrientations)
          return;
        this.SetValue(PhoneApplicationPage.SupportedOrientationsProperty, (Enum) value);
      }
    }

    public PageOrientation Orientation
    {
      get => (PageOrientation) this.GetValue(PhoneApplicationPage.OrientationProperty);
      [EditorBrowsable(EditorBrowsableState.Never)] set
      {
        if (!Frame.IsInDesignMode())
          return;
        this.SetValue(PhoneApplicationPage.OrientationProperty, (Enum) value);
      }
    }

    internal PageOrientation LayoutOrientation
    {
      get => this.mLayoutOrientation;
      set
      {
        if (this.mLayoutOrientation == value)
          return;
        this.mIsOrientationChanged = true;
        if (this.mLayoutOrientation == PageOrientation.LandscapeLeft && value == PageOrientation.LandscapeRight || this.mLayoutOrientation == PageOrientation.LandscapeRight && value == PageOrientation.LandscapeLeft)
          this._sipPropertyChanged = true;
        else
          SipHelper.FlickOut();
        this.mLayoutOrientation = value;
        if (this._currentlyFocusedElement != null)
        {
          this._currentlyFocusedElement.LostFocus -= new RoutedEventHandler(this.SipFocusOrSizeChanged);
          this._currentlyFocusedElement.SizeChanged -= new SizeChangedEventHandler(this.SipFocusOrSizeChanged);
          this._currentlyFocusedElement = (FrameworkElement) null;
        }
        this.UpdateCurrentVisualState();
        if (!PhoneApplicationPage.IsInDesignMode())
          NativeLetterboxWrapper.UpdateSysTrayIsLandscape(this.mSysTrayInterop as NativeSystemTrayInteropWrapper, this.mLayoutOrientation != PageOrientation.PortraitUp);
        Frame.FireEventHandler<OrientationChangedEventArgs>(this.BeginLayoutChanged, (object) this, new OrientationChangedEventArgs(value));
      }
    }

    internal Thickness VisibleRegion => this.mVisibleRegion;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public Thickness VisibleBounds => this.mVisibleBounds;

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool SuppressUnorientedBottomMargin
    {
      get => this.mSuppressUnorientedBottomMargin;
      set
      {
        if (this.mSuppressUnorientedBottomMargin == value)
          return;
        this.mSuppressUnorientedBottomMargin = value;
        this._suppressUnorientedBottomMarginChanged = true;
        this.UpdateCurrentVisualState();
      }
    }

    private RECT VisibleRegionInPhysicalPixels
    {
      set
      {
        if (this.mUnorientedVisibleRegion.Equals(value) && !this.mIsOrientationChanged && !this._suppressUnorientedBottomMarginChanged)
          return;
        bool flag1 = false;
        bool flag2 = false;
        if (this.SuppressTopMarginChange)
          value.top = this.mUnorientedVisibleRegion.top;
        this.mUnorientedVisibleRegion = value;
        Thickness regionInLogicalPixels = this.GetVisibleRegionInLogicalPixels(value);
        if (!PhoneApplicationPage.IsInDesignMode() && regionInLogicalPixels.Bottom > 0.0)
          regionInLogicalPixels.Bottom -= this.GetHeightExcludedFromFrame();
        Thickness thickness = this.OrientThickness(regionInLogicalPixels);
        if (!this.mVisibleBounds.Equals(thickness))
        {
          this.mVisibleBounds = thickness;
          flag1 = true;
        }
        if (this.mSuppressUnorientedBottomMargin)
        {
          this.mUnorientedVisibleRegion.bottom = 0;
          regionInLogicalPixels.Bottom = 0.0;
          thickness = this.OrientThickness(regionInLogicalPixels);
        }
        if (!this.mVisibleRegion.Equals(thickness))
        {
          this.mVisibleRegion = thickness;
          flag2 = true;
          regionInLogicalPixels.Bottom = !this.mSuppressUnorientedBottomMargin ? ((IPhoneApplicationPage) this).GetBottomChromeElementsHeightWithoutSIP() : 0.0;
          regionInLogicalPixels.Right = 0.0;
          regionInLogicalPixels.Left = 0.0;
        }
        if (!this.mIsOrientationChanged && (this._sipPropertyChanged || this._navbarPropertyChanged))
        {
          if (!this.mSuppressUnorientedBottomMargin)
            this.SipAndNavBarChange();
          this._sipPropertyChanged = false;
          this._navbarPropertyChanged = false;
        }
        this.mIsOrientationChanged = false;
        this._suppressUnorientedBottomMarginChanged = false;
        if (flag2)
          Frame.FireEventHandler<VisibleRegionChangeEventArgs>(this._internalVisibleRegionChanged, (object) this, new VisibleRegionChangeEventArgs()
          {
            region = this.OrientThickness(regionInLogicalPixels)
          });
        if (!flag1)
          return;
        Frame.FireEventHandler(this._visibleBoundsChanged, (object) this);
      }
    }

    public IApplicationBar ApplicationBar
    {
      get => (IApplicationBar) this.GetValue(PhoneApplicationPage.ApplicationBarProperty);
      set => this.SetValue(PhoneApplicationPage.ApplicationBarProperty, (object) value);
    }

    void IPhoneApplicationPage.SetAppChromeProperties()
    {
      this.mSysTrayInterop.SetSystemTrayVisible(this._systemTrayIsVisible);
      this.mSysTrayInterop.SetSystemTrayOpacity(this._systemTrayOpacity);
      if (this._systemTrayForegroundColorSet)
        this.mSysTrayInterop.SetSystemTrayForegroundColor(this._systemTrayForegroundColor);
      if (this._systemTrayBackgroundColorSet)
        this.mSysTrayInterop.SetSystemTrayBackgroundColor(this._systemTrayBackgroundColor);
      this.mSysTrayInterop.MakeVisibleSysTray();
      if (!PhoneApplicationPage.IsInDesignMode())
      {
        NativeLetterboxWrapper.UpdateSysTrayReservesSpace(this.mSysTrayInterop as NativeSystemTrayInteropWrapper, this._systemTrayReservesSpace);
        NativeLetterboxWrapper.UpdateSysTrayIsLandscape(this.mSysTrayInterop as NativeSystemTrayInteropWrapper, this.mLayoutOrientation != PageOrientation.PortraitUp);
      }
      this.MakeApplicationBarVisible();
      this.MakeProgressIndicatorVisible();
      this.SetIsScreenCaptureEnabled(this._isScreenCaptureEnabled);
    }

    private static void ApplicationBarPropertyChanged(
      DependencyObject obj,
      DependencyPropertyChangedEventArgs e)
    {
      (obj as PhoneApplicationPage).MakeApplicationBarVisible();
    }

    public IDictionary<string, object> State => this._dictionary != null ? this._dictionary : throw new InvalidOperationException("You can only use State between OnNavigatedTo and OnNavigatedFrom");

    object IPhoneApplicationPage.AppBar => (object) this.ApplicationBar;

    bool IPhoneApplicationPage.IsBackground => this.NavigationService.IsBackground;

    void IPhoneApplicationPage.InternalOnNavigatedToX(NavigationEventArgs e) => this.InternalOnNavigatedTo(e);

    void IPhoneApplicationPage.InternalOnNavigatingFromX(
      NavigatingCancelEventArgs e)
    {
      this.InternalOnNavigatingFrom(e);
    }

    void IPhoneApplicationPage.InternalOnNavigatedFromX(NavigationEventArgs e) => this.InternalOnNavigatedFrom(e);

    void IPhoneApplicationPage.InternalOnBackKeyPress(CancelEventArgs e)
    {
      this.OnBackKeyPress(e);
      EventHandler<CancelEventArgs> backKeyPress = this.BackKeyPress;
      if (backKeyPress == null)
        return;
      backKeyPress((object) this, e);
    }

    void IPhoneApplicationPage.InternalOnFragmentNavigation(string fragment) => this.OnFragmentNavigation(new FragmentNavigationEventArgs(fragment));

    void IPhoneApplicationPage.InternalOnRemovedFromJournal(
      string name,
      Uri removedPageUri)
    {
      JournalEntryRemovedEventArgs e = new JournalEntryRemovedEventArgs(new JournalEntry(name, removedPageUri));
      PerfUtil.BeginLogMarker(MarkerEvents.TH_ONNAVIGATIONREMOVED_PAGE, string.Format("{0}", (object) name));
      this.OnRemovedFromJournal(e);
      PerfUtil.EndLogMarker(MarkerEvents.TH_ONNAVIGATIONREMOVED_PAGE, string.Format("{0}", (object) name));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool IsScreenCaptureEnabled
    {
      get => NativeProtectedContentWrapper.IsScreenCaptureEnabled;
      set => this.SetIsScreenCaptureEnabled(value);
    }

    private static void SupportedOrientationsPropertyChanged(
      DependencyObject obj,
      DependencyPropertyChangedEventArgs e)
    {
      PhoneApplicationPage phoneApplicationPage = obj as PhoneApplicationPage;
      if (!Enum.IsDefined(typeof (SupportedPageOrientation), (object) phoneApplicationPage.SupportedOrientations))
        throw new ArgumentException("At least one orientation must be supported.");
      if (phoneApplicationPage != PhoneApplicationPage.GetActivePage())
        return;
      PhoneApplicationPage.SetOrientationOnPage(phoneApplicationPage.SupportedOrientations);
    }

    private void MakeApplicationBarVisible()
    {
      if (this != PhoneApplicationPage.GetActivePage())
        return;
      applicationBar = (Microsoft.Phone.Shell.ApplicationBar) null;
      if (this.ApplicationBar != null && !(this.ApplicationBar is Microsoft.Phone.Shell.ApplicationBar applicationBar))
        throw new InvalidOperationException("PhoneApplicationPage only accepts the ApplicationBar implementation of IApplicationBar");
      if (applicationBar != null)
      {
        applicationBar.MakeVisibleAppBar();
        PerfUtil.InfoLogMarker(MarkerEvents.TH_ENTER_MENU, "");
      }
      else
      {
        NativeAppBarInteropWrapper.ClearVisibleAppBar();
        PerfUtil.InfoLogMarker(MarkerEvents.TH_EXIT_MENU, "");
      }
    }

    internal static void SetOrientationOnPage(SupportedPageOrientation supported)
    {
      Orientations orientations = Orientations.None;
      if ((supported & SupportedPageOrientation.Portrait) == SupportedPageOrientation.Portrait)
        orientations |= Orientations.PortraitUp;
      if ((supported & SupportedPageOrientation.Landscape) == SupportedPageOrientation.Landscape)
        orientations |= Orientations.LandscapeLeft | Orientations.LandscapeRight;
      ApplicationHost.Current.RootTask.SetSupportedOrientations(orientations);
    }

    private Thickness OrientThickness(Thickness thickness)
    {
      Thickness thickness1 = new Thickness(0.0);
      switch (this.LayoutOrientation)
      {
        case PageOrientation.PortraitUp:
          thickness1.Left = thickness.Left;
          thickness1.Top = thickness.Top;
          thickness1.Right = thickness.Right;
          thickness1.Bottom = thickness.Bottom;
          break;
        case PageOrientation.LandscapeLeft:
          thickness1.Left = thickness.Top;
          thickness1.Top = thickness.Right;
          thickness1.Right = thickness.Bottom;
          thickness1.Bottom = thickness.Left;
          break;
        case PageOrientation.LandscapeRight:
          thickness1.Left = thickness.Bottom;
          thickness1.Top = thickness.Left;
          thickness1.Right = thickness.Top;
          thickness1.Bottom = thickness.Right;
          break;
      }
      return thickness1;
    }

    private Thickness GetVisibleRegionInLogicalPixels(RECT visibleRegionFromShell)
    {
      Thickness thickness = new Thickness(0.0);
      double num = (double) Application.Current.Host.Content.ActualScaleFactor / 100.0;
      thickness.Top = (double) visibleRegionFromShell.top / num;
      thickness.Bottom = (double) visibleRegionFromShell.bottom / num;
      thickness.Left = (double) visibleRegionFromShell.left / num;
      thickness.Right = (double) visibleRegionFromShell.right / num;
      return thickness;
    }

    double IPhoneApplicationPage.GetApplicationBarSize()
    {
      if (this.ApplicationBar == null || !this.ApplicationBar.IsVisible || this.ApplicationBar.Opacity != 1.0)
        return 0.0;
      int height = 0;
      double num = (double) Application.Current.Host.Content.ActualScaleFactor / 100.0;
      PhoneApplicationPage.GetApplicationBarHeight(this.ApplicationBar.Mode, out height);
      return Math.Round((double) height / num);
    }

    [DllImport("AppChromeAPI.dll", PreserveSig = false)]
    internal static extern void GetApplicationBarHeight([MarshalAs(UnmanagedType.I4)] Microsoft.Phone.Shell.ApplicationBarMode eMode, out int height);

    double IPhoneApplicationPage.GetNavBarPushUpHeight()
    {
      double num1 = 0.0;
      if (!PhoneApplicationPage.IsInDesignMode())
      {
        double bottomLetterboxHeight = NativeLetterboxWrapper.BottomLetterboxHeight;
        double num2 = NativeNavBarWrapper.IsVisible ? NativeNavBarWrapper.Height : 0.0;
        num1 = num2 > bottomLetterboxHeight ? num2 - bottomLetterboxHeight : 0.0;
      }
      return num1;
    }

    double IPhoneApplicationPage.GetBottomChromeElementsHeightWithoutSIP()
    {
      double num = 0.0;
      if (!PhoneApplicationPage.IsInDesignMode())
        num = NativeLetterboxWrapper.BottomLetterboxHeight - this.GetHeightExcludedFromFrame();
      return ((IPhoneApplicationPage) this).GetApplicationBarSize() + ((IPhoneApplicationPage) this).GetNavBarPushUpHeight() + num;
    }

    private void SipFocusOrSizeChanged(object sender, RoutedEventArgs e)
    {
      if (sender is FrameworkElement frameworkElement)
      {
        frameworkElement.LostFocus -= new RoutedEventHandler(this.SipFocusOrSizeChanged);
        frameworkElement.SizeChanged -= new SizeChangedEventHandler(this.SipFocusOrSizeChanged);
        this._currentlyFocusedElement = (FrameworkElement) null;
        if (frameworkElement is WebBrowserBase webBrowserBase2)
          webBrowserBase2.OnLostSipFocusFromYamanotePage();
      }
      this.SipAndNavBarChange();
    }

    private void SipAndNavBarChange()
    {
      Thickness visibleRegion = this.VisibleRegion;
      FrameworkElement focusedElement = FocusManager.GetFocusedElement() as FrameworkElement;
      int num;
      switch (focusedElement)
      {
        case TextBox _:
        case PasswordBox _:
          num = 1;
          break;
        default:
          num = focusedElement is WebBrowserBase ? 1 : 0;
          break;
      }
      bool flag1 = num != 0;
      bool flag2 = ((IPhoneApplicationPage) this).GetNavBarPushUpHeight() > 0.0 && (this.Orientation == PageOrientation.Portrait || this.Orientation == PageOrientation.PortraitUp);
      if (((focusedElement == null || this.LayoutOrientation != this.Orientation ? 0 : (this._sipIsVisible | flag2 ? 1 : 0)) & (flag1 ? 1 : 0)) != 0)
      {
        SipHelper.FlickIn(focusedElement, visibleRegion.Bottom);
        if (this._currentlyFocusedElement != null)
          return;
        this._currentlyFocusedElement = focusedElement;
        this._currentlyFocusedElement.LostFocus += new RoutedEventHandler(this.SipFocusOrSizeChanged);
        this._currentlyFocusedElement.SizeChanged += new SizeChangedEventHandler(this.SipFocusOrSizeChanged);
      }
      else
        SipHelper.FlickOut();
    }

    private void OnVisibleRegionChange() => this.HandleVisibleRegionChange();

    private void HandleVisibleRegionChange()
    {
      if (this.Dispatcher.CheckAccess())
        this.UpdateCurrentVisualState();
      else
        this.Dispatcher.BeginInvoke((Action) (() => this.HandleVisibleRegionChange()));
    }

    private void OnSipVisibilityChange(bool isVisible, int height)
    {
      this._sipIsVisible = isVisible;
      this._sipPropertyChanged = true;
      PerfUtil.InfoLogMarker(MarkerEvents.TH_PAGE_STATE_LOST, string.Format("{0}", (object) this._sipIsVisible));
    }

    private void OnNavBarVisibilityChange(bool isVisible, int height)
    {
      this._navbarPropertyChanged = true;
      PerfUtil.InfoLogMarker(MarkerEvents.TH_NAVBAR_STATE, string.Format("{0}", (object) isVisible));
    }

    void IPhoneApplicationPage.InternalOnUIOrientationChange(
      Orientations orientation)
    {
      if (this.Dispatcher.CheckAccess())
        this.UIOrientationChange(orientation);
      else
        this.Dispatcher.BeginInvoke((Action) (() => ((IPhoneApplicationPage) this).InternalOnUIOrientationChange(orientation)));
    }

    private void UIOrientationChange(Orientations orientation)
    {
      if (!this.IsOrientationSupported(orientation))
        return;
      PageOrientation desiredPageOrientation = this.ComputeDesiredPageOrientation(orientation);
      if (desiredPageOrientation == PageOrientation.None || desiredPageOrientation == this.Orientation)
        return;
      this.SetValue(PhoneApplicationPage.OrientationProperty, (Enum) desiredPageOrientation);
      OrientationChangedEventArgs changedEventArgs = new OrientationChangedEventArgs(desiredPageOrientation);
      Frame.FireEventHandler<OrientationChangedEventArgs>(this._beginOrientationChanged, (object) this, changedEventArgs);
      PerfUtil.BeginLogMarker(MarkerEvents.TH_ONORIENTATIONCHANGED_PAGE, this.Title == null ? "" : this.Title);
      this.OnOrientationChanged(changedEventArgs);
      PerfUtil.EndLogMarker(MarkerEvents.TH_ONORIENTATIONCHANGED_PAGE, this.Title == null ? "" : this.Title);
      Frame.FireEventHandler<OrientationChangedEventArgs>(this.OrientationChanged, (object) this, new OrientationChangedEventArgs(this.LayoutOrientation));
    }

    private bool IsOrientationSupported(Orientations targetOrientation)
    {
      bool flag;
      switch (targetOrientation)
      {
        case Orientations.PortraitUp:
        case Orientations.PortraitDown:
          flag = (this.SupportedOrientations & SupportedPageOrientation.Portrait) == SupportedPageOrientation.Portrait;
          break;
        case Orientations.LandscapeLeft:
        case Orientations.LandscapeRight:
          flag = (this.SupportedOrientations & SupportedPageOrientation.Landscape) == SupportedPageOrientation.Landscape;
          break;
        default:
          flag = true;
          break;
      }
      return flag;
    }

    private void OnKeyboardDeployedChanged(object source, EventArgs e)
    {
      if (!this.Dispatcher.CheckAccess())
      {
        this.Dispatcher.BeginInvoke((Action) (() => this.OnKeyboardDeployedChanged(source, e)));
      }
      else
      {
        if (DeviceStatus.IsKeyboardDeployed || !QuirksMode.ShouldPhysicalKeyboardUndeployClearFocusFromTextOrPasswordBox())
          return;
        switch (FocusManager.GetFocusedElement() as FrameworkElement)
        {
          case TextBox _:
          case PasswordBox _:
            this.Focus();
            break;
        }
      }
    }

    internal override void InternalOnNavigatedTo(NavigationEventArgs e)
    {
      ((IPhoneApplicationPage) this).SetAppChromeProperties();
      DeviceStatus.KeyboardDeployedChanged += new EventHandler(this.OnKeyboardDeployedChanged);
      Task rootTask1 = ApplicationHost.Current.RootTask;
      rootTask1.OnVisibleRegionChange = rootTask1.OnVisibleRegionChange + new ITask.VisibleRegionChanged(this.OnVisibleRegionChange);
      Task rootTask2 = ApplicationHost.Current.RootTask;
      rootTask2.OnSipVisibilityChange = rootTask2.OnSipVisibilityChange + new ITask.SipVisibilityChange(this.OnSipVisibilityChange);
      Task rootTask3 = ApplicationHost.Current.RootTask;
      rootTask3.OnNavBarVisibilityChange = rootTask3.OnNavBarVisibilityChange + new ITask.NavBarVisibilityChange(this.OnNavBarVisibilityChange);
      NavigationService navigationService = this.NavigationService;
      string str = string.Empty;
      if (navigationService != null)
      {
        JournalEntry currentEntry = navigationService.Journal.CurrentEntry;
        IJournalEntry journalEntry1 = (IJournalEntry) currentEntry;
        bool flag = false;
        if (this != currentEntry.PageInstance)
        {
          journalEntry1 = navigationService.Journal.GetMatchingEntry((IPhoneApplicationPage) this);
          flag = true;
        }
        if (journalEntry1 != null)
        {
          this._dictionary = journalEntry1.JournalEntryData.State;
        }
        else
        {
          PerfUtil.InfoLogMarker(MarkerEvents.TH_PAGE_STATE_LOST, string.Format("Page state was lost for page {0}, likely due to backstack being cleared prematurely.", (object) this));
          this._dictionary = (IDictionary<string, object>) new Dictionary<string, object>();
        }
        PhoneApplicationPage phoneApplicationPage = (PhoneApplicationPage) null;
        if (navigationService.BackStack != null && navigationService.BackStack.Count<JournalEntry>() > 0 && !flag)
        {
          JournalEntry journalEntry2 = navigationService.BackStack.First<JournalEntry>();
          if (journalEntry2 != null)
            phoneApplicationPage = journalEntry2.PageInstance as PhoneApplicationPage;
        }
        str = phoneApplicationPage == null || phoneApplicationPage.Title == null ? string.Empty : phoneApplicationPage.Title;
      }
      PerfUtil.BeginLogMarker(MarkerEvents.TH_ONNAVIGATEDTO_PAGE, string.Format("{0},{1},{2},{3}", this.Title == null ? (object) "" : (object) this.Title, (object) e.NavigationMode, (object) e.Uri, (object) str));
      this.OnNavigatedTo(e);
      PerfUtil.EndLogMarker(MarkerEvents.TH_ONNAVIGATEDTO_PAGE, string.Format("{0},{1},{2},{3}", this.Title == null ? (object) "" : (object) this.Title, (object) e.NavigationMode, (object) e.Uri, (object) str));
      this.MakeProgressIndicatorVisible();
      this.UpdatePageOrientation();
      this.TestNotifyPageShowComplete();
    }

    private void UpdatePageOrientation()
    {
      Orientations currentOrientation = ApplicationHost.Current.RootTask.GetCurrentOrientation();
      if (SupportedPageOrientation.PortraitOrLandscape == this.SupportedOrientations)
      {
        this.UIOrientationChange(currentOrientation);
      }
      else
      {
        if (SupportedPageOrientation.Landscape != this.SupportedOrientations)
          return;
        this.UIOrientationChange(Orientations.LandscapeRight == currentOrientation ? Orientations.LandscapeRight : Orientations.LandscapeLeft);
      }
    }

    internal override void InternalOnNavigatedFrom(NavigationEventArgs e)
    {
      string str = !(e.Content is PhoneApplicationPage content) || content.Title == null ? string.Empty : content.Title;
      PerfUtil.BeginLogMarker(MarkerEvents.TH_ONNAVIGATEDFROM_PAGE, string.Format("{0},{1},{2}", this.Title == null ? (object) "" : (object) this.Title, (object) e.NavigationMode, (object) str));
      this.OnNavigatedFrom(e);
      PerfUtil.EndLogMarker(MarkerEvents.TH_ONNAVIGATEDFROM_PAGE, string.Format("{0},{1},{2}", this.Title == null ? (object) "" : (object) this.Title, (object) e.NavigationMode, (object) str));
      DeviceStatus.KeyboardDeployedChanged -= new EventHandler(this.OnKeyboardDeployedChanged);
      Task rootTask1 = ApplicationHost.Current.RootTask;
      rootTask1.OnVisibleRegionChange = rootTask1.OnVisibleRegionChange - new ITask.VisibleRegionChanged(this.OnVisibleRegionChange);
      Task rootTask2 = ApplicationHost.Current.RootTask;
      rootTask2.OnSipVisibilityChange = rootTask2.OnSipVisibilityChange - new ITask.SipVisibilityChange(this.OnSipVisibilityChange);
      Task rootTask3 = ApplicationHost.Current.RootTask;
      rootTask3.OnNavBarVisibilityChange = rootTask3.OnNavBarVisibilityChange - new ITask.NavBarVisibilityChange(this.OnNavBarVisibilityChange);
      this._dictionary = (IDictionary<string, object>) null;
    }

    internal void UpdateCurrentVisualState()
    {
      if (this.Dispatcher.CheckAccess())
      {
        this.UpdatePageOrientation();
        Orientations orientation = Orientations.None;
        switch (this.LayoutOrientation)
        {
          case PageOrientation.PortraitUp:
            orientation = Orientations.PortraitUp;
            break;
          case PageOrientation.LandscapeLeft:
            orientation = Orientations.LandscapeLeft;
            break;
          case PageOrientation.LandscapeRight:
            orientation = Orientations.LandscapeRight;
            break;
        }
        this.VisibleRegionInPhysicalPixels = NativeSystemTrayInteropWrapper.GetVisibleRegion(orientation);
      }
      else
        this.Dispatcher.BeginInvoke((Action) (() => this.UpdateCurrentVisualState()));
    }

    [SecuritySafeCritical]
    private void TestNotifyPageShowComplete()
    {
      if (!(ApplicationHost.Current.TestPageCompleteEvent != IntPtr.Zero) || PageNativeMethods.SetEvent(ApplicationHost.Current.TestPageCompleteEvent))
        return;
      Marshal.GetLastWin32Error();
    }

    private void SetIsScreenCaptureEnabled(bool enabled)
    {
      if (this._isScreenCaptureEnabled != enabled)
        this._isScreenCaptureEnabled = enabled;
      NativeProtectedContentWrapper.IsScreenCaptureEnabled = this._isScreenCaptureEnabled;
    }

    public event EventHandler<OrientationChangedEventArgs> BeginLayoutChanged;

    event EventHandler<OrientationChangedEventArgs> IPhoneApplicationPage.BeginOrientationChanged
    {
      add => this._beginOrientationChanged += value;
      remove => this._beginOrientationChanged -= value;
    }

    public event EventHandler<OrientationChangedEventArgs> OrientationChanged;

    public event EventHandler<CancelEventArgs> BackKeyPress;

    event EventHandler<VisibleRegionChangeEventArgs> IPhoneApplicationPage.InternalVisibleRegionChanged
    {
      add => this._internalVisibleRegionChanged += value;
      remove => this._internalVisibleRegionChanged -= value;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    public event EventHandler VisibleBoundsChanged
    {
      add => this._visibleBoundsChanged += value;
      remove => this._visibleBoundsChanged -= value;
    }

    internal bool SystemTrayIsVisible
    {
      set
      {
        int num = this._systemTrayIsVisible != value ? 1 : 0;
        this._systemTrayIsVisible = value;
        this.mSysTrayInterop.SetSystemTrayVisible(this._systemTrayIsVisible);
        this.UpdateSystemTrayReservesSpace();
        if (num == 0)
          return;
        this.UpdateCurrentVisualState();
      }
    }

    internal float SystemTrayOpacity
    {
      set
      {
        this._systemTrayOpacity = value;
        this.mSysTrayInterop.SetSystemTrayOpacity(this._systemTrayOpacity);
        this.UpdateSystemTrayReservesSpace();
      }
    }

    internal Color SystemTrayForegroundColor
    {
      set
      {
        this._systemTrayForegroundColorSet = true;
        this._systemTrayForegroundColor = value;
        this.mSysTrayInterop.SetSystemTrayForegroundColor(this._systemTrayForegroundColor);
      }
    }

    internal Color SystemTrayBackgroundColor
    {
      set
      {
        this._systemTrayBackgroundColorSet = true;
        this._systemTrayBackgroundColor = value;
        this.mSysTrayInterop.SetSystemTrayBackgroundColor(this._systemTrayBackgroundColor);
      }
    }

    private void UpdateSystemTrayReservesSpace()
    {
      bool flag = this._systemTrayIsVisible && (double) this._systemTrayOpacity >= 1.0;
      if (flag == this._systemTrayReservesSpace)
        return;
      this._systemTrayReservesSpace = flag;
      if (PhoneApplicationPage.IsInDesignMode())
        return;
      NativeLetterboxWrapper.UpdateSysTrayReservesSpace(this.mSysTrayInterop as NativeSystemTrayInteropWrapper, this._systemTrayReservesSpace);
    }

    internal ProgressIndicator ProgressIndicator
    {
      get => this._progressIndicator;
      set
      {
        this._progressIndicator = value;
        if (this != PhoneApplicationPage.GetActivePage())
          return;
        this.MakeProgressIndicatorVisible();
      }
    }

    internal void MakeProgressIndicatorVisible()
    {
      if (this._progressIndicator == null)
      {
        NativeSystemTrayInteropWrapper.ProgressIndicatorIsVisible = false;
      }
      else
      {
        NativeSystemTrayInteropWrapper.ProgressIndicatorText = this._progressIndicator.Text;
        NativeSystemTrayInteropWrapper.ProgressIndicatorValue = (float) this._progressIndicator.Value;
        NativeSystemTrayInteropWrapper.ProgressIndicatorIsIndeterminate = this._progressIndicator.IsIndeterminate;
        NativeSystemTrayInteropWrapper.ProgressIndicatorIsVisible = this._progressIndicator.IsVisible;
      }
    }

    internal static PhoneApplicationPage GetActivePage()
    {
      PhoneApplicationPage phoneApplicationPage = (PhoneApplicationPage) null;
      Application current = Application.Current;
      if (current != null && current.RootVisual is PhoneApplicationFrame rootVisual)
        phoneApplicationPage = rootVisual.Content as PhoneApplicationPage;
      return phoneApplicationPage;
    }

    private double GetHeightExcludedFromFrame()
    {
      double val1 = NativeLetterboxWrapper.BottomAspectRatioLetterboxHeight;
      if (PhoneApplicationPage.IsUserManagedNavBarFrozen())
        val1 = Math.Max(val1, NativeNavBarWrapper.Height);
      return val1;
    }

    [DllImport("PlatformInterop.dll", EntryPoint = "IsUserManagedNavBarFrozen", PreserveSig = false)]
    internal static extern int IsUserManagedNavBarFrozenNative(out bool val);

    internal static bool IsUserManagedNavBarFrozen()
    {
      bool val;
      Marshal.ThrowExceptionForHR(PhoneApplicationPage.IsUserManagedNavBarFrozenNative(out val));
      return val;
    }

    protected virtual void OnOrientationChanged(OrientationChangedEventArgs e) => this.LayoutOrientation = e.Orientation;

    protected virtual void OnBackKeyPress(CancelEventArgs e)
    {
    }

    protected virtual void OnRemovedFromJournal(JournalEntryRemovedEventArgs e)
    {
    }

    internal bool SuppressTopMarginChange { get; set; }

    bool IPhoneApplicationPage.Focus() => this.Focus();
  }
}
