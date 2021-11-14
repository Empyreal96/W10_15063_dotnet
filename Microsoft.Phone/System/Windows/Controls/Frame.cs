// Decompiled with JetBrains decompiler
// Type: System.Windows.Controls.Frame
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell.Interop;
using Microsoft.Phone.TaskModel.Interop;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Automation.Peers;
using System.Windows.Controls.Common;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;

namespace System.Windows.Controls
{
  [TemplatePart(Name = "PrevButton", Type = typeof (ButtonBase))]
  [TemplatePart(Name = "NextButton", Type = typeof (ButtonBase))]
  public class Frame : ContentControl, INavigate
  {
    private const string PART_FrameNextButton = "NextButton";
    private const string PART_FramePreviousButton = "PrevButton";
    private const int DefaultCacheSize = 10;
    private ButtonBase _nextButton;
    private ButtonBase _previousButton;
    internal NavigationService _navigationService;
    private bool _loaded;
    private bool _updatingSourceFromNavigationService;
    private Uri _deferredNavigation;
    public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(nameof (Source), typeof (Uri), typeof (Frame), new PropertyMetadata(new PropertyChangedCallback(Frame.SourcePropertyChanged)));
    public static readonly DependencyProperty JournalOwnershipProperty = DependencyProperty.Register(nameof (JournalOwnership), typeof (JournalOwnership), typeof (Frame), new PropertyMetadata((object) JournalOwnership.Automatic, new PropertyChangedCallback(Frame.JournalOwnershipPropertyChanged)));
    public static readonly DependencyProperty CanGoBackProperty = DependencyProperty.Register(nameof (CanGoBack), typeof (bool), typeof (Frame), new PropertyMetadata(new PropertyChangedCallback(Frame.OnReadOnlyPropertyChanged)));
    public static readonly DependencyProperty CanGoForwardProperty = DependencyProperty.Register(nameof (CanGoForward), typeof (bool), typeof (Frame), new PropertyMetadata(new PropertyChangedCallback(Frame.OnReadOnlyPropertyChanged)));
    public static readonly DependencyProperty CurrentSourceProperty = DependencyProperty.Register(nameof (CurrentSource), typeof (Uri), typeof (Frame), new PropertyMetadata(new PropertyChangedCallback(Frame.OnReadOnlyPropertyChanged)));
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "Property name is from Silverlight.")]
    public static readonly DependencyProperty UriMapperProperty = DependencyProperty.Register(nameof (UriMapper), typeof (UriMapperBase), typeof (Frame), (PropertyMetadata) null);
    public static readonly DependencyProperty CacheSizeProperty = DependencyProperty.Register(nameof (CacheSize), typeof (int), typeof (Frame), new PropertyMetadata((object) 10, new PropertyChangedCallback(Frame.CacheSizePropertyChanged)));

    internal Frame()
    {
      this.DefaultStyleKey = (object) typeof (Frame);
      this.Loaded += new RoutedEventHandler(this.Frame_Loaded);
    }

    internal void NavigateToDefaultTaskPage(object sender, EventArgs args)
    {
      if (!this.Dispatcher.CheckAccess())
        this.Dispatcher.BeginInvoke((Action) (() => this.NavigateToDefaultTaskPage(sender, args)));
      else if (!Frame.IsInDesignMode())
      {
        UriMapperBase uriMapper = this.UriMapper;
        string uriString = this.ApplyDeepLinks();
        if (uriString == null)
        {
          if (this._deferredNavigation != (Uri) null)
          {
            this.Navigate(this._deferredNavigation);
            this._deferredNavigation = (Uri) null;
          }
          else if (this.Source != (Uri) null)
          {
            this.Navigate(this.Source);
          }
          else
          {
            if (uriMapper == null)
              return;
            Uri uri1 = new Uri(string.Empty, UriKind.Relative);
            Uri uri2 = uriMapper.MapUri(uri1);
            if (!(uri2 != (Uri) null) || string.IsNullOrEmpty(uri2.OriginalString))
              return;
            this.Navigate(uri1);
          }
        }
        else
          this.Navigate(new Uri(uriString, UriKind.Relative));
      }
      else if (this.Source != (Uri) null)
        this.Content = (object) string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.Frame_DefaultContent, (object) this.Source.ToString());
      else
        this.Content = (object) typeof (Frame).Name;
    }

    public event NavigatedEventHandler Navigated
    {
      add => this._navigationService.Navigated += value;
      remove => this._navigationService.Navigated -= value;
    }

    public event NavigatingCancelEventHandler Navigating
    {
      add => this._navigationService.Navigating += value;
      remove => this._navigationService.Navigating -= value;
    }

    public event NavigationFailedEventHandler NavigationFailed
    {
      add => this._navigationService.NavigationFailed += value;
      remove => this._navigationService.NavigationFailed -= value;
    }

    public event NavigationStoppedEventHandler NavigationStopped
    {
      add => this._navigationService.NavigationStopped += value;
      remove => this._navigationService.NavigationStopped -= value;
    }

    public event FragmentNavigationEventHandler FragmentNavigation
    {
      add => this._navigationService.FragmentNavigation += value;
      remove => this._navigationService.FragmentNavigation -= value;
    }

    public Uri Source
    {
      get => this.GetValue(Frame.SourceProperty) as Uri;
      set => this.SetValue(Frame.SourceProperty, (object) value);
    }

    private static void SourcePropertyChanged(
      DependencyObject depObj,
      DependencyPropertyChangedEventArgs e)
    {
      if (depObj is Frame frame1 && !Frame.IsInDesignMode() && (frame1._loaded && !frame1._updatingSourceFromNavigationService))
        frame1.Navigate(e.NewValue as Uri);
      if (!Frame.IsInDesignMode())
        return;
      if (e.NewValue != null)
      {
        frame1.Content = (object) string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.Frame_DefaultContent, (object) e.NewValue.ToString());
      }
      else
      {
        Frame frame2 = frame1;
        frame2.Content = (object) frame2.GetType().Name;
      }
    }

    public JournalOwnership JournalOwnership
    {
      get => (JournalOwnership) this.GetValue(Frame.JournalOwnershipProperty);
      set => this.SetValue(Frame.JournalOwnershipProperty, (Enum) value);
    }

    private static void JournalOwnershipPropertyChanged(
      DependencyObject depObj,
      DependencyPropertyChangedEventArgs e)
    {
      Frame frame = depObj as Frame;
      if (depObj == null)
        return;
      try
      {
        frame.NavigationService.InitializeJournal();
      }
      catch (Exception ex)
      {
        frame.JournalOwnership = (JournalOwnership) e.OldValue;
        throw;
      }
    }

    public bool CanGoBack
    {
      get => (bool) this.GetValue(Frame.CanGoBackProperty);
      internal set => this.SetValueNoCallback(Frame.CanGoBackProperty, (object) value);
    }

    public bool CanGoForward
    {
      get => (bool) this.GetValue(Frame.CanGoForwardProperty);
      internal set => this.SetValueNoCallback(Frame.CanGoForwardProperty, (object) value);
    }

    public Uri CurrentSource
    {
      get => this.GetValue(Frame.CurrentSourceProperty) as Uri;
      internal set => this.SetValueNoCallback(Frame.CurrentSourceProperty, (object) value);
    }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "Property name is from Silverlight.")]
    public UriMapperBase UriMapper
    {
      get => this.GetValue(Frame.UriMapperProperty) as UriMapperBase;
      set => this.SetValue(Frame.UriMapperProperty, (object) value);
    }

    public int CacheSize
    {
      get => (int) this.GetValue(Frame.CacheSizeProperty);
      set => this.SetValue(Frame.CacheSizeProperty, value);
    }

    private static void CacheSizePropertyChanged(
      DependencyObject depObj,
      DependencyPropertyChangedEventArgs e)
    {
      Frame frame = (Frame) depObj;
      if (frame.AreHandlersSuspended())
        return;
      int newValue = (int) e.NewValue;
      if (newValue < 0)
      {
        frame.SetValueNoCallback(Frame.CacheSizeProperty, e.OldValue);
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.Frame_CacheSizeMustBeGreaterThanOrEqualToZero, (object) "CacheSize"));
      }
      if (frame._navigationService == null || frame._navigationService.Cache == null)
        return;
      frame._navigationService.Cache.ChangeCacheSize(newValue);
    }

    internal NavigationService NavigationService => this._navigationService;

    internal bool IsObscured { get; set; }

    internal static void FireEventHandler<T>(EventHandler<T> handler, object sender, T args) where T : EventArgs
    {
      EventHandler<T> eventHandler = handler;
      if (eventHandler == null)
        return;
      eventHandler(sender, args);
    }

    internal static void FireEventHandler(EventHandler handler, object sender)
    {
      EventHandler eventHandler = handler;
      if (eventHandler == null)
        return;
      eventHandler(sender, (EventArgs) null);
    }

    internal virtual void OnBeginLayoutChanged(object sender, OrientationChangedEventArgs args)
    {
    }

    internal virtual void OnBeginOrientationChanged(object sender, OrientationChangedEventArgs args)
    {
    }

    internal virtual void InternalUpdateOrientationAndMarginForPage(PhoneApplicationPage visiblePage)
    {
    }

    internal virtual void OnBackKeyPress(object sender, CancelEventArgs args)
    {
    }

    internal virtual void OnVisibleRegionChange(object sender, VisibleRegionChangeEventArgs args)
    {
    }

    internal static bool IsInDesignMode() => DesignerProperties.IsInDesignTool;

    internal string ApplyDeepLinks() => this.NavigationService.Journal.CheckForDeeplinks();

    public void StopLoading() => this._navigationService.StopLoading();

    public void GoBack() => this._navigationService.GoBack();

    public void GoForward() => this._navigationService.GoForward();

    public bool Navigate(Uri source)
    {
      if (this._loaded)
        return this._navigationService.Navigate(source);
      this._deferredNavigation = source;
      return true;
    }

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      if (this._nextButton != null)
        this._nextButton.Click -= new RoutedEventHandler(this.PART_nextButton_Click);
      this._nextButton = this.GetTemplateChild("NextButton") as ButtonBase;
      if (this._nextButton != null)
        this._nextButton.Click += new RoutedEventHandler(this.PART_nextButton_Click);
      if (this._previousButton != null)
        this._previousButton.Click -= new RoutedEventHandler(this.PART_previousButton_Click);
      this._previousButton = this.GetTemplateChild("PrevButton") as ButtonBase;
      if (this._previousButton == null)
        return;
      this._previousButton.Click += new RoutedEventHandler(this.PART_previousButton_Click);
    }

    protected override AutomationPeer OnCreateAutomationPeer() => (AutomationPeer) new FrameAutomationPeer(this);

    internal void UpdateSourceFromNavigationService(Uri newSource)
    {
      if (!(this.Source != newSource))
        return;
      this._updatingSourceFromNavigationService = true;
      this.SetValue(Frame.SourceProperty, (object) newSource);
      this._updatingSourceFromNavigationService = false;
    }

    private static void OnReadOnlyPropertyChanged(
      DependencyObject depObj,
      DependencyPropertyChangedEventArgs e)
    {
      if (depObj is Frame frame && !frame.AreHandlersSuspended())
      {
        frame.SetValueNoCallback(e.Property, e.OldValue);
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.InvariantCulture, Resource.UnderlyingPropertyIsReadOnly, (object) e.Property.ToString()));
      }
    }

    private void Frame_Loaded(object sender, RoutedEventArgs e) => this.Load();

    internal void Load()
    {
      if (this._loaded)
        return;
      this._navigationService.InitializeJournal();
      this._navigationService.InitializeContentLoader();
      this._navigationService.InitializeNavigationCache();
      this._loaded = true;
      ApplicationHost.Current.RootTask.ReadyToNavigate();
    }

    private void PART_nextButton_Click(object sender, RoutedEventArgs e) => this.GoForward();

    private void PART_previousButton_Click(object sender, RoutedEventArgs e) => this.GoBack();
  }
}
