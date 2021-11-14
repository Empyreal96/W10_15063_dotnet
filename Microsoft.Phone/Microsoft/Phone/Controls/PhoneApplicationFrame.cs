// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.PhoneApplicationFrame
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Devices;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using MS.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace Microsoft.Phone.Controls
{
  [TemplatePart(Name = "ClientArea", Type = typeof (FrameworkElement))]
  public class PhoneApplicationFrame : Frame, IPhoneApplicationFrame, IFrame
  {
    private PageOrientation _layoutOrientation;
    public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register(nameof (Orientation), typeof (PageOrientation), typeof (PhoneApplicationFrame), new PropertyMetadata(new PropertyChangedCallback(PhoneApplicationFrame.OrientationPropertyChanged)));
    internal static readonly DependencyProperty VerticalOffsetProperty = DependencyProperty.Register(nameof (VerticalOffset), typeof (double), typeof (PhoneApplicationFrame), new PropertyMetadata(new PropertyChangedCallback(PhoneApplicationFrame.VerticalOffsetPropertyChanged)));
    private const double logicalNavBarHeight = 53.3333333333333;
    private const string PART_ClientArea = "ClientArea";
    private FrameworkElement _clientArea;
    private RotateTransform _orientationRotateTransform;
    private TranslateTransform _offsetTranslateTransform;
    private TranslateTransform _orientationTranslateTransform;
    private TransformGroup _orientationTransforms;
    private const PageOrientation DefaultFrameOrientation = PageOrientation.PortraitUp;
    private Thickness _visibleRegion;
    private bool _quirkShouldNotIgnoreEventsFromBackgroundPages;

    public PhoneApplicationFrame()
    {
      PerfUtil.BeginLogMarker(MarkerEvents.TH_INIT_FRAME, "Frame initialized");
      if (PhoneApplicationFrame.Current != null)
      {
        if (Microsoft.Phone.QuirksMode.ShouldThrowOnMultiplePhoneApplicationFramesCreated())
          throw new InvalidOperationException();
        PhoneApplicationFrame current = PhoneApplicationFrame.Current;
        PhoneApplicationFrame.Current = (PhoneApplicationFrame) null;
        Task rootTask1 = ApplicationHost.Current.RootTask;
        rootTask1.OnObscurityChange = rootTask1.OnObscurityChange - new ITask.ObscurityChanged(current.OnObscurityChange);
        Task rootTask2 = ApplicationHost.Current.RootTask;
        rootTask2.OnLockScreenVisibilityChange = rootTask2.OnLockScreenVisibilityChange - new ITask.LockScreenVisibilityChanged(current.OnLockStateChange);
        Task rootTask3 = ApplicationHost.Current.RootTask;
        rootTask3.OnMinimizedOverlayVisibleRegionChange = rootTask3.OnMinimizedOverlayVisibleRegionChange - new ITask.MinimizedOverlayVisibleRegionChanged(current.OnMinimizedOverlayVisibleRegionChange);
        Task rootTask4 = ApplicationHost.Current.RootTask;
        rootTask4.OnRequestOverlayStateChange = rootTask4.OnRequestOverlayStateChange - new ITask.RequestOverlayStateChange(current.OnRequestOverlayStateChange);
        Task rootTask5 = ApplicationHost.Current.RootTask;
        rootTask5.OnStartKeyPress = rootTask5.OnStartKeyPress - new ITask.StartKeyPressed(current.OnStartKeyPress);
        Task rootTask6 = ApplicationHost.Current.RootTask;
        rootTask6.OnNavBarVisibilityChange = rootTask6.OnNavBarVisibilityChange - new ITask.NavBarVisibilityChange(current.OnNavBarVisibilityChanged);
      }
      if (PhoneApplicationFrame.Current == null)
      {
        PhoneApplicationFrame.Current = this;
        Task rootTask1 = ApplicationHost.Current.RootTask;
        rootTask1.OnObscurityChange = rootTask1.OnObscurityChange + new ITask.ObscurityChanged(this.OnObscurityChange);
        Task rootTask2 = ApplicationHost.Current.RootTask;
        rootTask2.OnLockScreenVisibilityChange = rootTask2.OnLockScreenVisibilityChange + new ITask.LockScreenVisibilityChanged(this.OnLockStateChange);
        Task rootTask3 = ApplicationHost.Current.RootTask;
        rootTask3.OnMinimizedOverlayVisibleRegionChange = rootTask3.OnMinimizedOverlayVisibleRegionChange + new ITask.MinimizedOverlayVisibleRegionChanged(this.OnMinimizedOverlayVisibleRegionChange);
        Task rootTask4 = ApplicationHost.Current.RootTask;
        rootTask4.OnRequestOverlayStateChange = rootTask4.OnRequestOverlayStateChange + new ITask.RequestOverlayStateChange(this.OnRequestOverlayStateChange);
        Task rootTask5 = ApplicationHost.Current.RootTask;
        rootTask5.OnStartKeyPress = rootTask5.OnStartKeyPress + new ITask.StartKeyPressed(this.OnStartKeyPress);
        Task rootTask6 = ApplicationHost.Current.RootTask;
        rootTask6.OnNavBarVisibilityChange = rootTask6.OnNavBarVisibilityChange + new ITask.NavBarVisibilityChange(this.OnNavBarVisibilityChanged);
      }
      this._quirkShouldNotIgnoreEventsFromBackgroundPages = Microsoft.Phone.QuirksMode.ShouldNotIgnoreEventsFromBackgroundPages();
      this.DefaultStyleKey = (object) typeof (PhoneApplicationFrame);
      this._orientationTransforms = new TransformGroup();
      this._offsetTranslateTransform = new TranslateTransform();
      this._orientationTranslateTransform = new TranslateTransform();
      this._orientationRotateTransform = new RotateTransform();
      this._orientationTransforms.Children.Add((Transform) this._offsetTranslateTransform);
      this._orientationTransforms.Children.Add((Transform) this._orientationRotateTransform);
      this._orientationTransforms.Children.Add((Transform) this._orientationTranslateTransform);
      this.RenderTransform = (Transform) this._orientationTransforms;
      this.Orientation = PageOrientation.PortraitUp;
      this._visibleRegion = new Thickness(0.0);
      this._navigationService = new NavigationService((IPhoneApplicationFrame) this);
      if (Frame.IsInDesignMode())
        return;
      Deployment.Current.Dispatcher.BeginInvoke((Action) (() =>
      {
        if (PhoneApplicationFrame.Current != this)
          return;
        this.Load();
      }));
    }

    ~PhoneApplicationFrame() => PerfUtil.EndLogMarker(MarkerEvents.TH_INIT_FRAME, "Frame uninitialized");

    public JournalEntry RemoveBackEntry() => this._navigationService.RemoveBackEntry();

    bool IFrame.IsNavigationInProgress => this.NavigationService.IsNavigationInProgress;

    bool IFrame.IsInDesignModeX() => Frame.IsInDesignMode();

    void IFrame.InternalUpdateOrientationAndMarginForPage(IPhoneApplicationPage visiblePage) => this.InternalUpdateOrientationAndMarginForPage(visiblePage as PhoneApplicationPage);

    bool IFrame.CanGoBack
    {
      get => this.CanGoBack;
      set => this.CanGoBack = value;
    }

    bool IFrame.CanGoForward
    {
      get => this.CanGoForward;
      set => this.CanGoForward = value;
    }

    Uri IFrame.CurrentSource
    {
      get => this.CurrentSource;
      set => this.CurrentSource = value;
    }

    void IFrame.UpdateSourceFromNavigationService(Uri newSource) => this.UpdateSourceFromNavigationService(newSource);

    double IFrame.VerticalOffset
    {
      get => this.VerticalOffset;
      set => this.VerticalOffset = value;
    }

    void IFrame.Load() => this.Load();

    bool IFrame.RotateOnClientArea => this.RotateOnClientArea;

    void IFrame.InternalOnVisibleRegionChange(
      object sender,
      VisibleRegionChangeEventArgs args)
    {
      this.OnVisibleRegionChange(sender, args);
    }

    void IFrame.InternalOnBackKeyPress(object sender, CancelEventArgs args) => this.OnBackKeyPress(sender, args);

    void IFrame.InternalOnBackKeyPressPreview(object sender, CancelEventArgs args) => this.OnBackKeyPressPreview(sender, args);

    void IFrame.InternalNavigateToDefaultTaskPage(object sender, EventArgs args) => this.NavigateToDefaultTaskPage(sender, args);

    void IFrame.InternalRaiseFocusChangedAutomationEvent()
    {
      if (!AutomationPeer.ListenerExists(AutomationEvents.AutomationFocusChanged) || !(this.GetOrCreateAutomationPeer() is FrameAutomationPeer automationPeer))
        return;
      automationPeer.RaiseFocusChangedAutomationEvent();
    }

    internal static PhoneApplicationFrame Current { get; private set; }

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      this._clientArea = this.GetTemplateChild("ClientArea") as FrameworkElement;
      this.UpdateMargin(this._visibleRegion, this.Orientation);
    }

    protected override Size MeasureOverride(Size availableSize)
    {
      if (!this.RotateOnClientArea)
        return base.MeasureOverride(availableSize);
      this._clientArea.Measure(new Size()
      {
        Height = availableSize.Width,
        Width = availableSize.Height
      });
      return this.GetMaxFiniteRotatedSize(this._clientArea.DesiredSize, availableSize);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      if (!this.RotateOnClientArea)
        return base.ArrangeOverride(finalSize);
      this._clientArea.Arrange(new Rect()
      {
        Height = finalSize.Width,
        Width = finalSize.Height
      });
      return finalSize;
    }

    public event EventHandler<OrientationChangedEventArgs> OrientationChanged;

    public event EventHandler<ObscuredEventArgs> Obscured;

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "Name has been approved by api review.")]
    public event EventHandler Unobscured;

    public event EventHandler<CancelEventArgs> BackKeyPress;

    internal event EventHandler<CancelEventArgs> BackKeyPressPreview;

    public event EventHandler<JournalEntryRemovedEventArgs> JournalEntryRemoved
    {
      add => this._navigationService.JournalEntryRemoved += value;
      remove => this._navigationService.JournalEntryRemoved -= value;
    }

    public PageOrientation Orientation
    {
      get => (PageOrientation) this.GetValue(PhoneApplicationFrame.OrientationProperty);
      internal set
      {
        if (this.Orientation == value)
          return;
        this.SetValue(PhoneApplicationFrame.OrientationProperty, (Enum) value);
      }
    }

    public bool FullScreen
    {
      get => ApplicationHost.Current.RootTask.FullScreen;
      set
      {
        if (this.FullScreen == value)
          return;
        ApplicationHost.Current.RootTask.FullScreen = value;
      }
    }

    public IEnumerable<JournalEntry> BackStack => this._navigationService.BackStack;

    internal PageOrientation LayoutOrientation
    {
      get => this._layoutOrientation;
      set
      {
        if (this._layoutOrientation == value)
          return;
        this._layoutOrientation = value;
        this.UpdateOrientationTransform();
      }
    }

    internal double VerticalOffset
    {
      get => (double) this.GetValue(PhoneApplicationFrame.VerticalOffsetProperty);
      set
      {
        if (this.VerticalOffset == value)
          return;
        this.SetValue(PhoneApplicationFrame.VerticalOffsetProperty, value);
      }
    }

    private TranslateTransform OffsetTranslateTransform => this._offsetTranslateTransform;

    private static void VerticalOffsetPropertyChanged(
      DependencyObject obj,
      DependencyPropertyChangedEventArgs e)
    {
      (obj as PhoneApplicationFrame).OffsetTranslateTransform.Y = (double) e.NewValue;
    }

    private static void OrientationPropertyChanged(
      DependencyObject obj,
      DependencyPropertyChangedEventArgs e)
    {
      PhoneApplicationFrame applicationFrame = obj as PhoneApplicationFrame;
      applicationFrame.FireOrientationChanged(applicationFrame.Orientation);
    }

    internal void UpdateOrientationTransform()
    {
      if (!this.Dispatcher.CheckAccess())
      {
        this.Dispatcher.BeginInvoke((Action) (() => this.UpdateOrientationTransform()));
      }
      else
      {
        switch (this.Orientation)
        {
          case PageOrientation.PortraitUp:
            this._orientationRotateTransform.Angle = 0.0;
            this._orientationTranslateTransform.X = 0.0;
            this._orientationTranslateTransform.Y = 0.0;
            break;
          case PageOrientation.LandscapeLeft:
            this._orientationRotateTransform.Angle = 90.0;
            this._orientationTranslateTransform.X = Application.Current.Host.Content.ActualWidth;
            this._orientationTranslateTransform.Y = 0.0;
            break;
          case PageOrientation.LandscapeRight:
            this._orientationRotateTransform.Angle = 270.0;
            this._orientationTranslateTransform.X = 0.0;
            this._orientationTranslateTransform.Y = Application.Current.Host.Content.ActualHeight;
            break;
        }
        this.InvalidateMeasure();
        this.UpdateLayout();
      }
    }

    internal override void OnBackKeyPress(object sender, CancelEventArgs args)
    {
      EventHandler<CancelEventArgs> backKeyPress = this.BackKeyPress;
      if (backKeyPress == null)
        return;
      backKeyPress((object) this, args);
    }

    internal void OnBackKeyPressPreview(object sender, CancelEventArgs args)
    {
      EventHandler<CancelEventArgs> backKeyPressPreview = this.BackKeyPressPreview;
      if (backKeyPressPreview == null)
        return;
      backKeyPressPreview((object) this, args);
    }

    void IFrame.InternalOnBeginLayoutChanged(object sender, OrientationChangedEventArgs args)
    {
      if (sender != this.Content && !this._quirkShouldNotIgnoreEventsFromBackgroundPages)
        return;
      this.LayoutOrientation = args.Orientation;
    }

    void IFrame.InternalOnBeginOrientationChanged(
      object sender,
      OrientationChangedEventArgs args)
    {
      if (sender != this.Content && !this._quirkShouldNotIgnoreEventsFromBackgroundPages)
        return;
      this.Orientation = args.Orientation;
    }

    internal override void OnVisibleRegionChange(object sender, VisibleRegionChangeEventArgs args)
    {
      if (args == null || sender != this.Content && !this._quirkShouldNotIgnoreEventsFromBackgroundPages)
        return;
      this.UpdateMargin(args.region, this.Orientation);
    }

    internal void UpdateMargin(Thickness region, PageOrientation orientation)
    {
      if (this._clientArea != null && !this._clientArea.Margin.Equals(region))
        this._clientArea.Margin = region;
      this._visibleRegion = region;
      if (!Microsoft.Phone.QuirksMode.ShouldCoverMargin())
        return;
      float num = 0.0f;
      switch (orientation)
      {
        case PageOrientation.PortraitUp:
          num = (float) region.Top;
          break;
        case PageOrientation.LandscapeLeft:
          num = (float) region.Left;
          break;
        case PageOrientation.LandscapeRight:
          num = (float) region.Right;
          break;
      }
      color2 = Colors.Transparent;
      PhoneApplicationPage activePage = PhoneApplicationPage.GetActivePage();
      if (activePage != null)
        color2 = SystemTray.GetBackgroundColor((DependencyObject) activePage);
      if (color2.A != byte.MaxValue)
      {
        object resource = Application.Current.Resources[(object) "PhoneBackgroundColor"];
        if (resource == null || !(resource is Color color2))
          ;
      }
      XcpImports.Frame_UpdateMargin(num, color2.ToUInt32());
    }

    internal override void InternalUpdateOrientationAndMarginForPage(
      PhoneApplicationPage visiblePage)
    {
      if (visiblePage == null)
        return;
      visiblePage.UpdateCurrentVisualState();
      this.UpdateMargin(visiblePage.VisibleRegion, visiblePage.Orientation);
      this.Orientation = visiblePage.Orientation;
      this.LayoutOrientation = visiblePage.Orientation;
      PhoneApplicationPage.SetOrientationOnPage(visiblePage.SupportedOrientations);
    }

    internal void FireOrientationChanged(PageOrientation value)
    {
      OrientationChangedEventArgs e = new OrientationChangedEventArgs(value);
      EventHandler<OrientationChangedEventArgs> orientationChanged = this.OrientationChanged;
      if (orientationChanged == null)
        return;
      this.SetHandlingOrientationChange(true);
      try
      {
        orientationChanged((object) this, e);
      }
      finally
      {
        this.SetHandlingOrientationChange(false);
      }
    }

    internal bool RotateOnClientArea => this._orientationRotateTransform.Angle == 90.0 || this._orientationRotateTransform.Angle == 270.0;

    private Size GetMaxFiniteRotatedSize(Size desired, Size actual)
    {
      if (double.IsInfinity(actual.Width))
        actual.Width = 0.0;
      if (double.IsInfinity(actual.Height))
        actual.Height = 0.0;
      return new Size()
      {
        Width = Math.Max(actual.Width, desired.Height),
        Height = Math.Max(actual.Height, desired.Width)
      };
    }

    private void OnObscurityChange(bool isObscured)
    {
      if (!this.Dispatcher.CheckAccess())
      {
        this.Dispatcher.BeginInvoke((Action) (() => this.OnObscurityChange(isObscured)));
      }
      else
      {
        if (isObscured == this.IsObscured)
          return;
        this.IsObscured = isObscured;
        if (isObscured)
        {
          Frame.FireEventHandler<ObscuredEventArgs>(this.Obscured, (object) this, new ObscuredEventArgs(false));
          PerfUtil.BeginLogMarker(MarkerEvents.TH_OBSCURE_SCREEN, "App obscured");
        }
        else
        {
          PerfUtil.EndLogMarker(MarkerEvents.TH_OBSCURE_SCREEN, "App unobscured");
          Frame.FireEventHandler(this.Unobscured, (object) this);
        }
      }
    }

    private void OnLockStateChange(bool isLocked)
    {
      if (!this.Dispatcher.CheckAccess())
        this.Dispatcher.BeginInvoke((Action) (() => this.OnLockStateChange(isLocked)));
      else if (isLocked)
      {
        PerfUtil.BeginLogMarker(MarkerEvents.TH_LOCK_SCREEN, "Phone locked");
        if (ApplicationHost.Current.RootTask.AppLayer == NavigationApplicationLayer.Foreground)
        {
          this.IsObscured = true;
          Frame.FireEventHandler<ObscuredEventArgs>(this.Obscured, (object) this, new ObscuredEventArgs(true));
        }
        else
        {
          if (ApplicationHost.Current.RootTask.AppLayer != NavigationApplicationLayer.Overlay)
            return;
          OverlayApplicationService.OnRequestOverlayStateChange(OverlayState.Minimize);
        }
      }
      else
        PerfUtil.EndLogMarker(MarkerEvents.TH_LOCK_SCREEN, "Phone unlocked");
    }

    private void OnMinimizedOverlayVisibleRegionChange()
    {
      if (!this.Dispatcher.CheckAccess())
      {
        this.Dispatcher.BeginInvoke((Action) (() => this.OnMinimizedOverlayVisibleRegionChange()));
      }
      else
      {
        PerfUtil.InfoLogMarker(MarkerEvents.TH_MINIMIZED_OVERLAY_VISIBLE_REGION_CHANGED, "MinimizedOverlay VisibleRegionChanged");
        OverlayApplicationService.OnMinimizedOverlayVisibleRegionChanged();
      }
    }

    private void OnRequestOverlayStateChange(uint state)
    {
      if (!this.Dispatcher.CheckAccess())
      {
        this.Dispatcher.BeginInvoke((Action) (() => this.OnRequestOverlayStateChange(state)));
      }
      else
      {
        PerfUtil.InfoLogMarker(MarkerEvents.TH_OVERLAY_STATE_CHANGED, "Overlay State Change requested.State: " + (object) state);
        OverlayApplicationService.OnRequestOverlayStateChange((OverlayState) state);
      }
    }

    private void OnStartKeyPress()
    {
      if (!this.Dispatcher.CheckAccess())
      {
        this.Dispatcher.BeginInvoke((Action) (() => this.OnStartKeyPress()));
      }
      else
      {
        PerfUtil.InfoLogMarker(MarkerEvents.TH_START_KEY_PRESSED, "Start Key pressed.");
        StartButton.OnStartKeyPress();
      }
    }

    public event EventHandler NavigationBarVisibilityChanged;

    private void OnNavBarVisibilityChanged(bool isVisible, int height)
    {
      if (!PhoneApplicationPage.IsUserManagedNavBarFrozen())
        return;
      double num1 = (double) Application.Current.Host.Content.ActualScaleFactor / 100.0;
      double num2 = (double) height / num1;
      double num3 = isVisible ? num2 - 160.0 / 3.0 : -160.0 / 3.0;
      EventHandler visibilityChanged = this.NavigationBarVisibilityChanged;
      if (visibilityChanged == null)
        return;
      visibilityChanged((object) this, (EventArgs) new NavigationBarVisibilityChangedEventArgs()
      {
        IsVisible = isVisible,
        Height = num2,
        OccludedHeight = num3
      });
    }

    [SpecialName]
    object IFrame.get_Content() => this.Content;

    [SpecialName]
    void IFrame.set_Content(object value) => this.Content = value;

    [SpecialName]
    Dispatcher IFrame.get_Dispatcher() => this.Dispatcher;
  }
}
