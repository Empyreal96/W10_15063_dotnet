// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowser
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Automation.Peers;
using Microsoft.Phone.Interop;
using System;
using System.ComponentModel;
using System.Net;
using System.Security;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Microsoft.Phone.Controls
{
  [TemplateVisualState(GroupName = "WebBrowserStates", Name = "Disabled")]
  [TemplatePart(Name = "StateContainer", Type = typeof (Border))]
  [TemplatePart(Name = "PresentationContainer", Type = typeof (Border))]
  [TemplateVisualState(GroupName = "WebBrowserStates", Name = "Normal")]
  [EditorBrowsable(EditorBrowsableState.Always)]
  public sealed class WebBrowser : WebBrowserBase, ISupportInitialize
  {
    public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(nameof (Source), typeof (Uri), typeof (WebBrowser), new PropertyMetadata((object) null, new PropertyChangedCallback(WebBrowser.OnSourceChanged)));
    public static readonly DependencyProperty BaseProperty = DependencyProperty.Register(nameof (Base), typeof (string), typeof (WebBrowser), new PropertyMetadata((object) "", new PropertyChangedCallback(WebBrowser.OnBaseChanged)));
    public static readonly DependencyProperty IsScriptEnabledProperty = DependencyProperty.Register(nameof (IsScriptEnabled), typeof (bool), typeof (WebBrowser), new PropertyMetadata((object) false, new PropertyChangedCallback(WebBrowser.OnIsScriptEnabledChanged)));
    public static readonly DependencyProperty IsGeolocationEnabledProperty = DependencyProperty.Register(nameof (IsGeolocationEnabled), typeof (bool), typeof (WebBrowser), new PropertyMetadata((object) false, new PropertyChangedCallback(WebBrowser.OnIsGeolocationEnabledChanged)));
    public static readonly DependencyProperty CanGoBackProperty = DependencyProperty.RegisterReadOnly(nameof (CanGoBack), typeof (bool), typeof (WebBrowser), new PropertyMetadata((object) false));
    public static readonly DependencyProperty CanGoForwardProperty = DependencyProperty.RegisterReadOnly(nameof (CanGoForward), typeof (bool), typeof (WebBrowser), new PropertyMetadata((object) false));
    public static readonly DependencyProperty ContainsFullScreenElementProperty = DependencyProperty.Register(nameof (ContainsFullScreenElement), typeof (bool), typeof (WebBrowser), new PropertyMetadata((object) false));
    private static Regex c_quirkAdMobExceptionPattern = new Regex("[LlEeGgOo]{6}.AdMob.Ads.WindowsPhone7.WPF.DisplayAdBase.ScriptCommandHandler");
    private const string NormalState = "Normal";
    private const string DisabledState = "Disabled";
    private const string WebBrowserStates = "WebBrowserStates";
    private InteropLifetime lifetime;
    private Border presentationContainer;
    private bool hasSIPFocus;
    private bool shouldDoEditActivation;
    private bool isControlInitializing;
    private Uri deferredSourceUri;

    public WebBrowser()
    {
      this.DefaultStyleKey = (object) typeof (WebBrowser);
      this.Loaded += new RoutedEventHandler(this.OnLoaded);
      this.Unloaded += new RoutedEventHandler(this.OnUnloaded);
      this.IsEnabledChanged += new DependencyPropertyChangedEventHandler(this.OnIsEnabledChanged);
      this.lifetime = WebBrowserCompatibility.GetLifetimeManager((QuirksMode.ShouldUseQuirkMax7_0() ? 1 : 0) != 0, (Control) this, new WebBrowserInteropCallbacks()
      {
        Navigating = new NavigatingCallback(this.FireNavigatingEvent),
        NavigateError = new NavigateErrorCallback(this.FireNavigationFailedEvent),
        Navigated = new NavigatedCallback(this.FireNavigatedEvent),
        LoadCompleted = new LoadCompletedCallback(this.FireLoadCompletedEvent),
        ScriptNotify = new ScriptNotifyCallback(this.FireScriptNotifyEvent),
        FullScreenChanged = new FullScreenChangedCallback(this.FireContentFullScreenChanged),
        GetFrameVerticalOffset = new GetFrameVerticalOffsetCallback(this.OnGetFrameVerticalOffset),
        SIPStateChange = new SIPStateChangeCallback(this.OnSIPStateChange),
        CanNavigateBackChange = new CanNavigateBackChangeCallback(this.OnCanGoBackChange),
        CanNavigateForwardChange = new CanNavigateForwardChangeCallback(this.OnCanGoForwardChange)
      }, new GetCachedWebBrowserPropertiesCallback(this.OnGetCachedWebBrowserProperties));
      if (QuirksMode.ShouldUseQuirkMax7_1())
        return;
      Binding binding = new Binding("Background")
      {
        Source = (object) this
      };
      this.SetBinding(DependencyProperty.RegisterAttached("ListenAttachedBackground", typeof (object), typeof (Control), new PropertyMetadata(new PropertyChangedCallback(WebBrowser.OnBackgroundChanged))), binding);
    }

    private void OnLoaded(object sender, RoutedEventArgs e)
    {
      this.ApplyTemplate();
      this.lifetime.OnLoaded(this.presentationContainer);
      this.presentationContainer.Child.Visibility = Visibility.Visible;
      if (!(Application.Current.RootVisual is PhoneApplicationFrame rootVisual))
        return;
      this.NotifyOrientation(rootVisual.Orientation);
      rootVisual.OrientationChanged += new EventHandler<OrientationChangedEventArgs>(this.OnOrientationChanged);
    }

    private void OnUnloaded(object sender, RoutedEventArgs e)
    {
      this.presentationContainer.Child.Visibility = Visibility.Collapsed;
      this.lifetime.OnUnloaded();
      if (Application.Current.RootVisual is PhoneApplicationFrame rootVisual)
        rootVisual.OrientationChanged -= new EventHandler<OrientationChangedEventArgs>(this.OnOrientationChanged);
      this.Dispatcher.BeginInvoke((Action) (() => GC.Collect()));
    }

    protected override AutomationPeer OnCreateAutomationPeer() => (AutomationPeer) new WebBrowserAutomationPeer(this);

    [SecuritySafeCritical]
    internal bool IsTesterBorderEnabled()
    {
      uint propertyValue = 0;
      Registry.QueryDwordValue(2147483650U, "Software\\Microsoft\\TaskHost", "EnableWebBrowserBorder", ref propertyValue);
      return propertyValue > 0U;
    }

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      this.presentationContainer = (Border) this.GetTemplateChild("PresentationContainer");
      this.ChangeVisualState(false);
      this.lifetime.OnApplyTemplate(this.presentationContainer);
      if (!this.IsTesterBorderEnabled())
        return;
      this.presentationContainer.BorderBrush = (Brush) new SolidColorBrush(Colors.Yellow);
      this.presentationContainer.BorderThickness = new Thickness(5.0);
    }

    void ISupportInitialize.BeginInit() => this.isControlInitializing = true;

    void ISupportInitialize.EndInit()
    {
      this.isControlInitializing = false;
      if (!(this.deferredSourceUri != (Uri) null))
        return;
      this.lifetime.Interop.Source = this.deferredSourceUri;
      this.deferredSourceUri = (Uri) null;
    }

    private void OnGetCachedWebBrowserProperties(
      out bool isScriptEnabledVal,
      out string baseVal,
      out Uri sourceVal)
    {
      isScriptEnabledVal = (bool) this.GetValue(WebBrowser.IsScriptEnabledProperty);
      baseVal = this.GetValue(WebBrowser.BaseProperty) as string;
      sourceVal = this.lifetime.Interop.Source;
    }

    public void GetHostedProvider(IntPtr windowlessSite, ref IntPtr provider) => this.lifetime.Interop.GetWebBrowserUiaProvider(windowlessSite, ref provider);

    public void Navigate(Uri uri) => this.Navigate(uri, (byte[]) null, string.Empty);

    public void Navigate(Uri uri, byte[] postData, string additionalHeaders) => this.lifetime.Interop.NavigateCustom(uri, postData, additionalHeaders);

    public void NavigateToString(string html) => this.lifetime.Interop.NavigateToString(html);

    public void GoBack() => this.lifetime.Interop.NavigateBack();

    public void GoForward() => this.lifetime.Interop.NavigateForward();

    public object InvokeScript(string scriptName, params string[] args) => this.lifetime.Interop.InvokeScript(scriptName, args);

    public object InvokeScript(string scriptName) => this.lifetime.Interop.InvokeScript(scriptName);

    public string SaveToString() => this.lifetime.Interop.SaveToString();

    public event EventHandler<NavigatingEventArgs> Navigating;

    public event EventHandler<NavigationEventArgs> Navigated;

    public event LoadCompletedEventHandler LoadCompleted;

    public event NavigationFailedEventHandler NavigationFailed;

    public event EventHandler<NotifyEventArgs> ScriptNotify;

    public event EventHandler ContainsFullScreenElementChanged;

    private static void OnBackgroundChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      if (!(e.NewValue is SolidColorBrush newValue) || newValue.Opacity != 1.0 || newValue.Color.A != byte.MaxValue)
        throw new NotSupportedException(Resources.NotSupportedBackgroundPropertyException);
      (d as WebBrowser).lifetime.Interop.SetBackgroundColor(newValue.Color);
    }

    private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
      WebBrowser webBrowser = (WebBrowser) d;
      Uri uri = (Uri) e.NewValue;
      if (uri == (Uri) null)
        uri = new Uri("about:blank");
      if (!webBrowser.isControlInitializing)
        webBrowser.lifetime.Interop.Source = uri;
      else
        webBrowser.deferredSourceUri = uri;
    }

    [Category("Common Properties")]
    public Uri Source
    {
      get => this.lifetime.Interop.Source;
      set => this.SetValue(WebBrowser.SourceProperty, (object) value);
    }

    private static void OnBaseChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) => ((WebBrowser) d).lifetime.Interop.Base = (string) e.NewValue;

    [Category("Common Properties")]
    public string Base
    {
      get => (string) this.GetValue(WebBrowser.BaseProperty);
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (Base));
        this.SetValue(WebBrowser.BaseProperty, (object) value);
      }
    }

    private static void OnIsScriptEnabledChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      ((WebBrowser) d).lifetime.Interop.IsScriptEnabled = (bool) e.NewValue;
    }

    [Category("Common Properties")]
    public bool IsScriptEnabled
    {
      get => (bool) this.GetValue(WebBrowser.IsScriptEnabledProperty);
      set => this.SetValue(WebBrowser.IsScriptEnabledProperty, value);
    }

    private static void OnIsGeolocationEnabledChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      ((WebBrowser) d).lifetime.Interop.IsGeolocationEnabled = (bool) e.NewValue;
    }

    [Category("Common Properties")]
    public bool IsGeolocationEnabled
    {
      get => (bool) this.GetValue(WebBrowser.IsGeolocationEnabledProperty);
      set => this.SetValue(WebBrowser.IsGeolocationEnabledProperty, value);
    }

    [Category("Common Properties")]
    public bool CanGoBack
    {
      get => (bool) this.GetValue(WebBrowser.CanGoBackProperty);
      internal set => this.SetValueInternal(WebBrowser.CanGoBackProperty, (object) value, true);
    }

    private void OnCanGoBackChange(bool enabled) => this.CanGoBack = enabled;

    [Category("Common Properties")]
    public bool CanGoForward
    {
      get => (bool) this.GetValue(WebBrowser.CanGoForwardProperty);
      internal set => this.SetValueInternal(WebBrowser.CanGoForwardProperty, (object) value, true);
    }

    [Category("Common Properties")]
    public bool ContainsFullScreenElement
    {
      get => (bool) this.GetValue(WebBrowser.ContainsFullScreenElementProperty);
      internal set => this.SetValueInternal(WebBrowser.ContainsFullScreenElementProperty, (object) value, true);
    }

    private void OnCanGoForwardChange(bool enabled) => this.CanGoForward = enabled;

    private void FireNavigatingEvent(Uri uri, out bool cancel)
    {
      cancel = false;
      if (this.Navigating == null)
        return;
      NavigatingEventArgs e = new NavigatingEventArgs();
      e.Uri = uri;
      this.Navigating((object) this, e);
      cancel = e.Cancel;
    }

    private void FireNavigatedEvent(Uri uri)
    {
      if (this.Navigated == null)
        return;
      this.Navigated((object) this, new NavigationEventArgs((object) null, uri));
    }

    private void FireLoadCompletedEvent(Uri uri)
    {
      if (this.LoadCompleted == null)
        return;
      this.LoadCompleted((object) this, new NavigationEventArgs((object) null, uri));
    }

    private void FireNavigationFailedEvent(Uri uri, int httpStatusCode, out bool cancel)
    {
      cancel = false;
      if (this.NavigationFailed == null)
        return;
      WebBrowserNavigationException navigationException = (WebBrowserNavigationException) null;
      string name = Enum.GetName(typeof (HttpStatusCode), (object) httpStatusCode);
      if (!string.IsNullOrEmpty(name))
        navigationException = new WebBrowserNavigationException((HttpStatusCode) Enum.Parse(typeof (HttpStatusCode), name, false));
      NavigationFailedEventArgs e = new NavigationFailedEventArgs(uri, (Exception) navigationException);
      this.NavigationFailed((object) this, e);
      cancel = e.Handled;
    }

    private void FireScriptNotifyEvent(string value)
    {
      if (this.ScriptNotify == null)
        return;
      NotifyEventArgs e = new NotifyEventArgs();
      e.Value = value;
      try
      {
        this.ScriptNotify((object) this, e);
      }
      catch (NullReferenceException ex)
      {
        if (this.ShouldIgnoreAdMobExceptions(ex))
          return;
        throw;
      }
    }

    private void FireContentFullScreenChanged(bool isFullScreen)
    {
      this.ContainsFullScreenElement = isFullScreen;
      EventHandler screenElementChanged = this.ContainsFullScreenElementChanged;
      if (screenElementChanged == null)
        return;
      screenElementChanged((object) this, EventArgs.Empty);
    }

    private bool ShouldIgnoreAdMobExceptions(NullReferenceException ex)
    {
      bool flag = false;
      if (ex != null && QuirksMode.ShouldIgnoreAdMobExceptionFromScriptNotify())
      {
        string stackTrace = ex.StackTrace;
        flag = stackTrace != null && WebBrowser.c_quirkAdMobExceptionPattern.IsMatch(stackTrace);
      }
      return flag;
    }

    protected override void OnGotFocus(RoutedEventArgs e) => base.OnGotFocus(e);

    private bool IsFocusedElementEditable()
    {
      object focusedElement = FocusManager.GetFocusedElement();
      return focusedElement is TextBox || focusedElement is PasswordBox;
    }

    protected override void OnLostFocus(RoutedEventArgs e)
    {
      base.OnLostFocus(e);
      this.lifetime.Interop.LoseFocus(!this.IsFocusedElementEditable());
    }

    private void OnOrientationChanged(object sender, OrientationChangedEventArgs e)
    {
      this.NotifyOrientation(e.Orientation);
      if (!this.hasSIPFocus)
        return;
      this.shouldDoEditActivation = true;
    }

    private void NotifyOrientation(PageOrientation orientation)
    {
      int rotationAngle = 0;
      if ((orientation & PageOrientation.LandscapeLeft) == PageOrientation.LandscapeLeft)
        rotationAngle = 90;
      else if ((orientation & PageOrientation.LandscapeRight) == PageOrientation.LandscapeRight)
        rotationAngle = 270;
      this.lifetime.Interop.UpdateOrientation(rotationAngle);
    }

    private void OnSIPStateChange(bool visible)
    {
      if (visible)
        return;
      this.OnLostSipFocusFromYamanotePage();
    }

    internal override double GetMinimumEditActivationHeight() => Math.Min(100.0, this.RenderSize.Height);

    internal override void OnGotSipFocusFromYamanotePage(double bottomObscuredBySIP)
    {
      this.SetShrinkAmount(bottomObscuredBySIP);
      if (this.shouldDoEditActivation)
      {
        this.lifetime.Interop.DoPendingEditActivation();
        this.shouldDoEditActivation = false;
      }
      this.hasSIPFocus = true;
    }

    internal override void OnLostSipFocusFromYamanotePage()
    {
      if (!this.hasSIPFocus)
        return;
      this.SetShrinkAmount(0.0);
      this.lifetime.Interop.BounceViewportToBounds();
      this.hasSIPFocus = false;
    }

    private void SetShrinkAmount(double bottomObscuredBySIP) => this.presentationContainer.Padding = new Thickness(0.0, 0.0, 0.0, Math.Max(bottomObscuredBySIP - this.BorderThickness.Bottom, 0.0));

    internal virtual void OnCopy() => this.lifetime.Interop.Copy();

    internal virtual void OnPaste() => this.lifetime.Interop.Paste();

    internal override double GetNormalHeight() => this.RenderSize.Height;

    private void ChangeVisualState(bool useTransitions)
    {
      if (!this.IsEnabled)
        VisualStateManager.GoToState((Control) this, "Disabled", useTransitions);
      else
        VisualStateManager.GoToState((Control) this, "Normal", useTransitions);
    }

    private void OnIsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e) => this.ChangeVisualState(false);

    private double OnGetFrameVerticalOffset()
    {
      double num = 0.0;
      if (Application.Current.RootVisual is IPhoneApplicationFrame rootVisual)
        num = rootVisual.VerticalOffset;
      return num;
    }
  }
}
