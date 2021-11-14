// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.WebBrowserInterop
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using Microsoft.Phone.Interop;
using MS.Internal;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  internal class WebBrowserInterop : IWebBrowserInterop
  {
    private PanZoomContainer.PanZoomState previousPanZoomState;
    private WebBrowserInterop.EditActivationAction editActivationAction;
    private WebBrowserInterop.GestureForwardingState gestureForwarding;
    private Control webBrowser;
    private IntPtr adapter;
    private WebBrowserInteropCanvas _webBrowserInteropCanvas;
    private PanZoomContainer _panZoomContainer;
    private TileHostV2 _tileHostV2;
    private ExternalInputContainer _inputContainer;
    private Grid _rootGrid;
    private WebBrowserInteropCallbacks webBrowserCallbacks;
    private int webBrowserControlId;
    private static WebBrowserInterop.WebBrowserInteropRegistry interopRegistry = new WebBrowserInterop.WebBrowserInteropRegistry();
    private bool isInInteropRegistry;

    [SecuritySafeCritical]
    public WebBrowserInterop(Control webBrowser, WebBrowserInteropCallbacks callbacks)
    {
      TextUtils.AllowTextInput(webBrowser, true);
      try
      {
        this._tileHostV2 = new TileHostV2();
        this._tileHostV2.BindToAgWebBrowserControl();
      }
      catch (UnauthorizedAccessException ex)
      {
        throw new UnauthorizedAccessException(Resources.WebBrowserAccessDeniedException, (Exception) ex);
      }
      this.webBrowserControlId = this._tileHostV2.Id;
      int defaultDocumentBackgroundColorXRGB;
      NativeMethods.ValidateHResult(NativeMethods.GetWebBrowser(this.webBrowserControlId, out defaultDocumentBackgroundColorXRGB, out this.adapter));
      this._panZoomContainer = new PanZoomContainer();
      FrameworkElement frameworkElement = (FrameworkElement) this._tileHostV2;
      bool flag = false;
      uint propertyValue = 0;
      if (Registry.QueryDwordValue(2147483650U, "Software\\Microsoft\\Internet Explorer", "EnableXamlNativeInput", ref propertyValue))
        flag = propertyValue > 0U;
      if (flag)
      {
        this._inputContainer = new ExternalInputContainer();
        this._inputContainer.InputHandlerId = 2;
        this.SetExternalInputIdAndContentScaleFactor(this._inputContainer.InstanceId, 1f);
        Grid grid = new Grid();
        grid.Background = (Brush) new SolidColorBrush(Colors.Transparent);
        ((ContentControl) this._inputContainer).Content = (object) grid;
        this._rootGrid = new Grid();
        this._rootGrid.Children.Add((UIElement) frameworkElement);
        this._rootGrid.Children.Add((UIElement) this._inputContainer);
        frameworkElement = (FrameworkElement) this._rootGrid;
      }
      this._panZoomContainer.Content = (object) frameworkElement;
      this._panZoomContainer.Background = (Brush) this.BrushFromXRGB(defaultDocumentBackgroundColorXRGB);
      this.HookPanZoomContainerEvents();
      this._webBrowserInteropCanvas = new WebBrowserInteropCanvas(this._panZoomContainer);
      this.webBrowserCallbacks = callbacks;
      this.SetInteropCallbacks();
      WebBrowserInterop.interopRegistry.Insert(this.webBrowserControlId, this);
      this.isInInteropRegistry = true;
      this.webBrowser = webBrowser;
    }

    ~WebBrowserInterop()
    {
      if (!this.isInInteropRegistry)
        return;
      WebBrowserInterop.interopRegistry.Remove(this.webBrowserControlId);
      this.isInInteropRegistry = false;
    }

    public void GetWebBrowserUiaProvider(IntPtr windowlessSite, ref IntPtr provider) => NativeMethods.ValidateHResult(NativeMethods.GetWebBrowserUiaProvider(this.adapter, windowlessSite, ref provider));

    private SolidColorBrush BrushFromXRGB(int colorXRGB) => new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte) ((16711680 & colorXRGB) >> 16), (byte) ((65280 & colorXRGB) >> 8), (byte) ((int) byte.MaxValue & colorXRGB)));

    private void HookPanZoomContainerEvents()
    {
      this._panZoomContainer.SizeChanged += new SizeChangedEventHandler(this.OnPanZoomSizeChanged);
      this._panZoomContainer.PanZoomViewportChanged += new EventHandler<PanZoomContainer.PanZoomViewportEventArgs>(this.OnPanZoomViewportChanged);
      this._panZoomContainer.PanZoomStateChanged += new EventHandler<PanZoomContainer.PanZoomStateEventArgs>(this.OnPanZoomStateChanged);
      this._panZoomContainer.PanZoomScaleChanged += new EventHandler<PanZoomContainer.PanZoomScaleEventArgs>(this.OnPanZoomScaleChanged);
      this._panZoomContainer.ManipulationStarted += new EventHandler<ManipulationStartedEventArgs>(this.OnManipulationStarted);
      this._panZoomContainer.ManipulationDelta += new EventHandler<ManipulationDeltaEventArgs>(this.OnManipulationDelta);
      this._panZoomContainer.ManipulationCompleted += new EventHandler<ManipulationCompletedEventArgs>(this.OnManipulationCompleted);
      this._panZoomContainer.Tap += new EventHandler<GestureEventArgs>(this.OnTap);
      this._panZoomContainer.DoubleTap += new EventHandler<GestureEventArgs>(this.OnDoubleTap);
      this._panZoomContainer.Hold += new EventHandler<GestureEventArgs>(this.OnHold);
    }

    private void UnhookPanZoomContainerEvents()
    {
      this._panZoomContainer.SizeChanged -= new SizeChangedEventHandler(this.OnPanZoomSizeChanged);
      this._panZoomContainer.PanZoomViewportChanged -= new EventHandler<PanZoomContainer.PanZoomViewportEventArgs>(this.OnPanZoomViewportChanged);
      this._panZoomContainer.PanZoomStateChanged -= new EventHandler<PanZoomContainer.PanZoomStateEventArgs>(this.OnPanZoomStateChanged);
      this._panZoomContainer.PanZoomScaleChanged -= new EventHandler<PanZoomContainer.PanZoomScaleEventArgs>(this.OnPanZoomScaleChanged);
      this._panZoomContainer.ManipulationStarted -= new EventHandler<ManipulationStartedEventArgs>(this.OnManipulationStarted);
      this._panZoomContainer.ManipulationDelta -= new EventHandler<ManipulationDeltaEventArgs>(this.OnManipulationDelta);
      this._panZoomContainer.ManipulationCompleted -= new EventHandler<ManipulationCompletedEventArgs>(this.OnManipulationCompleted);
      this._panZoomContainer.Tap -= new EventHandler<GestureEventArgs>(this.OnTap);
      this._panZoomContainer.DoubleTap -= new EventHandler<GestureEventArgs>(this.OnDoubleTap);
      this._panZoomContainer.Hold -= new EventHandler<GestureEventArgs>(this.OnHold);
    }

    private void Pulse() => this._panZoomContainer.Pulse();

    [SecuritySafeCritical]
    public void Suppress()
    {
      this.UnhookPanZoomContainerEvents();
      WebBrowserInterop.interopRegistry.Remove(this.webBrowserControlId);
      this.isInInteropRegistry = false;
      NativeMethods.InteropAbandoned(this.adapter);
      this.adapter = IntPtr.Zero;
    }

    [SecuritySafeCritical]
    public FrameworkElement GetPresentation() => (FrameworkElement) this._webBrowserInteropCanvas;

    [SecuritySafeCritical]
    public void NavigateCustom(Uri uri, byte[] postData, string pszHeaders)
    {
      this.EnsureOnUiThread();
      if (uri == (Uri) null || string.IsNullOrEmpty(uri.ToString()))
        throw WebBrowserExceptionHelper.GetUriArgumentException();
      if (postData == null)
        postData = new byte[0];
      NativeMethods.ValidateHResult(NativeMethods.NavigateCustom(this.adapter, !uri.IsAbsoluteUri ? uri.OriginalString : uri.AbsoluteUri, postData.GetLength(0), postData, pszHeaders));
    }

    [SecuritySafeCritical]
    public void NavigateToString(string pszHtml)
    {
      this.EnsureOnUiThread();
      NativeMethods.ValidateHResult(NativeMethods.NavigateToString(this.adapter, pszHtml));
    }

    [SecuritySafeCritical]
    public void NavigateBack()
    {
      this.EnsureOnUiThread();
      NativeMethods.NavigateBack(this.adapter);
    }

    [SecuritySafeCritical]
    public void NavigateForward()
    {
      this.EnsureOnUiThread();
      NativeMethods.NavigateForward(this.adapter);
    }

    [SecuritySafeCritical]
    public string SaveToString()
    {
      this.EnsureOnUiThread();
      string pbstrDocumentText = (string) null;
      NativeMethods.ValidateHResult(NativeMethods.SaveToString(this.adapter, out pbstrDocumentText));
      return pbstrDocumentText;
    }

    [SecuritySafeCritical]
    public object InvokeScript(string scriptName, params string[] args)
    {
      this.EnsureOnUiThread();
      string result = (string) null;
      NativeMethods.ValidateHResult(NativeMethods.InvokeScript(this.adapter, scriptName, args.GetLength(0), args, out result));
      return (object) result;
    }

    [SecuritySafeCritical]
    private void SetInteropCallbacks()
    {
      this.EnsureOnUiThread();
      NativeMethods.ValidateHResult(NativeMethods.SetInteropCallbacks(this.adapter, WebBrowserInterop.ReversePInvokeThunk.InNavigating, WebBrowserInterop.ReversePInvokeThunk.InNavigateError, WebBrowserInterop.ReversePInvokeThunk.InNavigated, WebBrowserInterop.ReversePInvokeThunk.InLoadCompleted, WebBrowserInterop.ReversePInvokeThunk.InScriptNotify, WebBrowserInterop.ReversePInvokeThunk.InFullScreenChanged, WebBrowserInterop.ReversePInvokeThunk.InDocumentSizeChange, WebBrowserInterop.ReversePInvokeThunk.InBeginDocumentSwitch, WebBrowserInterop.ReversePInvokeThunk.InEndDocumentSwitch, WebBrowserInterop.ReversePInvokeThunk.InZoomAndScroll, WebBrowserInterop.ReversePInvokeThunk.InZoomConstraintsChange, WebBrowserInterop.ReversePInvokeThunk.InTransformRectUOZtoScreen, WebBrowserInterop.ReversePInvokeThunk.InTransformPointUOZtoScreen, WebBrowserInterop.ReversePInvokeThunk.InSIPStateChange, WebBrowserInterop.ReversePInvokeThunk.InPulse, WebBrowserInterop.ReversePInvokeThunk.InCanNavigateBackChange, WebBrowserInterop.ReversePInvokeThunk.InCanNavigateForwardChange));
    }

    [SecuritySafeCritical]
    public void SetBackgroundColor(Color color) => NativeMethods.SetBackgroundColor(this.adapter, -16777216 | (int) color.R << 16 | (int) color.G << 8 | (int) color.B);

    public Uri Source
    {
      [SecuritySafeCritical] get
      {
        this.EnsureOnUiThread();
        string pszUri;
        NativeMethods.ValidateHResult(NativeMethods.GetSource(this.adapter, out pszUri));
        return WebBrowserInterop.UriFromString(pszUri);
      }
      [SecuritySafeCritical] set
      {
        this.EnsureOnUiThread();
        this.NavigateCustom(value, (byte[]) null, (string) null);
      }
    }

    public string Base
    {
      [SecuritySafeCritical] get
      {
        this.EnsureOnUiThread();
        string pszRelativeBase = (string) null;
        NativeMethods.ValidateHResult(NativeMethods.GetBase(this.adapter, out pszRelativeBase));
        return pszRelativeBase;
      }
      [SecuritySafeCritical] set
      {
        this.EnsureOnUiThread();
        NativeMethods.ValidateHResult(NativeMethods.SetBase(this.adapter, value));
      }
    }

    public bool IsScriptEnabled
    {
      get => throw new Exception("This should never be called.  From WebBrowser, IsScriptEnabled getter uses cached value via DependencyObject.GetValue().");
      [SecuritySafeCritical] set
      {
        this.EnsureOnUiThread();
        NativeMethods.SetIsScriptEnabled(this.adapter, value);
      }
    }

    public bool IsGeolocationEnabled
    {
      get => throw new Exception("This should never be called.  From WebBrowser, IsGeolocationEnabled getter uses cached value via DependencyObject.GetValue().");
      [SecuritySafeCritical] set
      {
        this.EnsureOnUiThread();
        NativeMethods.SetIsGeolocationEnabled(this.adapter, value);
      }
    }

    public static Uri UriFromString(string uriText) => !string.IsNullOrEmpty(uriText) ? new Uri(uriText, UriKind.RelativeOrAbsolute) : (Uri) null;

    private void EnsureOnUiThread()
    {
      if (!Deployment.Current.Dispatcher.CheckAccess())
        throw WebBrowserExceptionHelper.GetThreadAccessException();
    }

    [SecuritySafeCritical]
    private void DocumentSizeChangedEventHandler(
      int widthAtUOZ,
      int heightAtUOZ,
      float minimumZoom,
      float maximumZoom,
      bool isRTL)
    {
      Size contentSize = this._panZoomContainer.ContentSize;
      this.SetTileHostSize((double) widthAtUOZ, (double) heightAtUOZ);
      double num = this._panZoomContainer.ContentSize.Width - contentSize.Width;
      if (isRTL && num != 0.0)
      {
        Rect viewportAtSoz = this._panZoomContainer.ViewportAtSOZ;
        this._panZoomContainer.SetViewTopLeft(this._panZoomContainer.CurrentScale, viewportAtSoz.Left + num, viewportAtSoz.Top);
      }
      this.UpdateScale((double) minimumZoom, (double) maximumZoom, this._panZoomContainer.CurrentScale);
    }

    [SecuritySafeCritical]
    private void DocumentBackgroundColorChangedEventHandler(int backgroundColorXRGB) => this._panZoomContainer.Background = (Brush) this.BrushFromXRGB(backgroundColorXRGB);

    [SecuritySafeCritical]
    private void BeginDocumentSwitchEventHandler(
      float minimumZoom,
      float maximumZoom,
      float initialZoom,
      int widthAtUOZ,
      int heightAtUOZ,
      int backgroundColorXRGB)
    {
      this.DocumentBackgroundColorChangedEventHandler(backgroundColorXRGB);
      this.UpdateSizeAndViewport(minimumZoom, maximumZoom, initialZoom, widthAtUOZ, heightAtUOZ);
    }

    [SecuritySafeCritical]
    private void EndDocumentSwitchEventHandler(
      float minimumZoom,
      float maximumZoom,
      float initialZoom,
      int widthAtUOZ,
      int heightAtUOZ)
    {
      this.UpdateSizeAndViewport(minimumZoom, maximumZoom, initialZoom, widthAtUOZ, heightAtUOZ);
      this.OnPanZoomStateOrViewportOrScaleChanged();
    }

    [SecuritySafeCritical]
    private void SetTileHostSize(double widthAtUOZ, double heightAtUOZ)
    {
      this._tileHostV2.ContentSize = new Size(widthAtUOZ, heightAtUOZ);
      this._panZoomContainer.ContentSize = new Size(widthAtUOZ, heightAtUOZ);
    }

    [SecuritySafeCritical]
    private void UpdateSizeAndViewport(
      float minimumZoom,
      float maximumZoom,
      float initialZoom,
      int widthAtUOZ,
      int heightAtUOZ)
    {
      this.SetTileHostSize((double) widthAtUOZ, (double) heightAtUOZ);
      this._panZoomContainer.MinimumScale = (double) minimumZoom;
      this._panZoomContainer.MaximumScale = (double) maximumZoom;
      this._panZoomContainer.SetViewTopLeft((double) initialZoom, 0.0, 0.0);
    }

    private void UpdateScale(double minimumZoom, double maximumZoom, double initialZoom)
    {
      this._panZoomContainer.MinimumScale = minimumZoom;
      this._panZoomContainer.MaximumScale = maximumZoom;
      double zoomFactor = Math.Min(Math.Max(initialZoom, minimumZoom), maximumZoom);
      if (zoomFactor == this._panZoomContainer.CurrentScale)
        return;
      this._panZoomContainer.SetScale(zoomFactor);
    }

    [SecuritySafeCritical]
    private void ZoomAndScrollEventHandler(
      int centerXAtSOZ,
      int centerYAtSOZ,
      float zoomFactor,
      bool animate)
    {
      if (animate)
        this._panZoomContainer.AnimateViewportCenter((double) zoomFactor, (double) centerXAtSOZ, (double) centerYAtSOZ, 0.25);
      else
        this._panZoomContainer.SetViewCenter((double) zoomFactor, (double) centerXAtSOZ, (double) centerYAtSOZ);
    }

    [SecuritySafeCritical]
    private void ZoomConstraintsChangedEventHandler(
      float minimumZoom,
      float maximumZoom,
      float initialZoom,
      bool isViewportWidthOrientationDependent)
    {
      if (isViewportWidthOrientationDependent)
        this.UpdateScale((double) minimumZoom, (double) maximumZoom, (double) initialZoom);
      else
        this.UpdateScale((double) minimumZoom, (double) maximumZoom, this._panZoomContainer.CurrentScale);
    }

    [SecuritySafeCritical]
    private void TransformPointUOZtoScreenEventHandler(
      int inX,
      int inY,
      out double outX,
      out double outY)
    {
      if (this._tileHostV2 != null && ((DependencyObject) this._tileHostV2).IsInLiveTree)
      {
        Point point = ((UIElement) this._tileHostV2).TransformToVisual(Application.Current.RootVisual).Transform(new Point((double) inX, (double) inY));
        point.Y += this.webBrowserCallbacks.GetFrameVerticalOffset();
        double num = (double) Application.Current.Host.Content.ActualScaleFactor / 100.0;
        point.X *= num;
        point.Y *= num;
        outX = point.X;
        outY = point.Y;
      }
      else
      {
        outX = 0.0;
        outY = 0.0;
      }
    }

    [SecuritySafeCritical]
    private void OnPanZoomStateOrViewportOrScaleChanged()
    {
      if (!WebBrowserInterop.HasArea(this._panZoomContainer.ViewportAtSOZ))
        return;
      if (this._panZoomContainer.State == PanZoomContainer.PanZoomState.Idle)
      {
        NativeMethods.UpdateZoomerIdle(this.adapter, this._panZoomContainer.ViewportAtSOZ.Left, this._panZoomContainer.ViewportAtSOZ.Top, this._panZoomContainer.ViewportAtSOZ.Width, this._panZoomContainer.ViewportAtSOZ.Height, (float) this._panZoomContainer.CurrentScale);
        if (this.editActivationAction != WebBrowserInterop.EditActivationAction.BounceViewportToBounds)
          return;
        this._panZoomContainer.BounceViewportToBounds(true);
        this.editActivationAction = WebBrowserInterop.EditActivationAction.None;
      }
      else
      {
        if (this.previousPanZoomState != PanZoomContainer.PanZoomState.Idle)
          return;
        NativeMethods.UpdateZoomerActive(this.adapter);
      }
    }

    private static bool HasArea(Rect rect) => rect.Width > 0.0 && rect.Height > 0.0;

    private static bool HasArea(Size size) => size.Width > 0.0 && size.Height > 0.0;

    private void OnPanZoomSizeChanged(object sender, SizeChangedEventArgs e)
    {
      if (!WebBrowserInterop.HasArea(e.PreviousSize) || !WebBrowserInterop.HasArea(e.NewSize))
        return;
      Size size = e.NewSize;
      double width1 = size.Width;
      size = e.PreviousSize;
      double width2 = size.Width;
      double num = width1 / width2;
      double zoomFactor = this._panZoomContainer.CurrentScale * num;
      this._panZoomContainer.MinimumScale *= num;
      this._panZoomContainer.SetScale(zoomFactor);
    }

    [SecuritySafeCritical]
    private void OnPanZoomViewportChanged(
      object sender,
      PanZoomContainer.PanZoomViewportEventArgs e)
    {
      this.OnPanZoomStateOrViewportOrScaleChanged();
    }

    [SecuritySafeCritical]
    private void OnPanZoomStateChanged(object sender, PanZoomContainer.PanZoomStateEventArgs e)
    {
      this.OnPanZoomStateOrViewportOrScaleChanged();
      this.previousPanZoomState = e.State;
    }

    [SecuritySafeCritical]
    private void OnPanZoomScaleChanged(object sender, PanZoomContainer.PanZoomScaleEventArgs e) => this.OnPanZoomStateOrViewportOrScaleChanged();

    [SecuritySafeCritical]
    private void OnManipulationStarted(object sender, ManipulationStartedEventArgs e)
    {
      if (FocusManager.GetFocusedElement() != this.webBrowser)
        this.webBrowser.Focus();
      this._panZoomContainer.HandleManipulationStarted(sender, e);
      e.Handled = true;
    }

    private bool HasValue(Point point) => point.X != 0.0 || point.Y != 0.0;

    [SecuritySafeCritical]
    private void OnManipulationDelta(object sender, ManipulationDeltaEventArgs e)
    {
      bool flag = false;
      if (this.gestureForwarding == WebBrowserInterop.GestureForwardingState.Unknown || this.gestureForwarding == WebBrowserInterop.GestureForwardingState.Browser)
      {
        if (this.HasValue(e.CumulativeManipulation.Scale))
        {
          flag = NativeMethods.PinchStretch(this.adapter);
        }
        else
        {
          Point point = this.TileHostAtUOZFromPanZoomContainer(e.ManipulationOrigin);
          IntPtr adapter = this.adapter;
          double x1 = point.X;
          double y1 = point.Y;
          double x2 = e.CumulativeManipulation.Translation.X;
          double y2 = e.CumulativeManipulation.Translation.Y;
          Point translation = e.DeltaManipulation.Translation;
          double x3 = translation.X;
          translation = e.DeltaManipulation.Translation;
          double y3 = translation.Y;
          double currentScale = this._panZoomContainer.CurrentScale;
          flag = NativeMethods.ManipulationDelta(adapter, x1, y1, x2, y2, x3, y3, (float) currentScale);
        }
      }
      this.gestureForwarding = flag ? WebBrowserInterop.GestureForwardingState.Browser : WebBrowserInterop.GestureForwardingState.Zoomer;
      if (this.gestureForwarding == WebBrowserInterop.GestureForwardingState.Zoomer)
        this._panZoomContainer.HandleManipulationDelta(sender, e);
      e.Handled = true;
    }

    [SecuritySafeCritical]
    private void OnManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
    {
      bool shouldTreatAsInertial = !NativeMethods.ManipulationCompleted(this.adapter) && e.IsInertial;
      this._panZoomContainer.HandleManipulationCompleted(sender, e, shouldTreatAsInertial);
      this.gestureForwarding = WebBrowserInterop.GestureForwardingState.Unknown;
      e.Handled = true;
    }

    [SecuritySafeCritical]
    private void OnHold(object sender, GestureEventArgs e)
    {
      NativeMethods.ShortHold(this.adapter);
      e.Handled = true;
    }

    [SecuritySafeCritical]
    private void OnTap(object sender, GestureEventArgs e)
    {
      if (FocusManager.GetFocusedElement() != this.webBrowser)
        return;
      e.Handled = true;
    }

    [SecuritySafeCritical]
    private void OnDoubleTap(object sender, GestureEventArgs e)
    {
      if (FocusManager.GetFocusedElement() != this.webBrowser)
        return;
      e.Handled = true;
    }

    [SecuritySafeCritical]
    private Point TileHostAtUOZFromPanZoomContainer(Point panZoomContainerPoint) => this._panZoomContainer.TransformToVisual((UIElement) this._tileHostV2).Transform(panZoomContainerPoint);

    [SecuritySafeCritical]
    public void LoseFocus(bool hideSIP) => NativeMethods.LoseFocus(this.adapter, hideSIP);

    [SecuritySafeCritical]
    public void DoPendingEditActivation()
    {
      NativeMethods.DoPendingEditActivation(this.adapter);
      this.editActivationAction = WebBrowserInterop.EditActivationAction.None;
    }

    [SecuritySafeCritical]
    public void UpdateOrientation(int rotationAngle) => NativeMethods.UpdateOrientation(this.adapter, rotationAngle);

    [SecuritySafeCritical]
    public void Copy() => NativeMethods.Copy(this.adapter);

    [SecuritySafeCritical]
    public void Paste() => NativeMethods.Paste(this.adapter);

    [SecuritySafeCritical]
    public void SetExternalInputIdAndContentScaleFactor(int id, float factor) => NativeMethods.SetExternalInputIdAndContentScaleFactor(this.adapter, id, factor);

    [SecuritySafeCritical]
    public void BounceViewportToBounds() => this.editActivationAction = WebBrowserInterop.EditActivationAction.BounceViewportToBounds;

    private enum EditActivationAction
    {
      None,
      BounceViewportToBounds,
    }

    private enum GestureForwardingState
    {
      Unknown,
      Browser,
      Zoomer,
    }

    private static class ReversePInvokeThunk
    {
      public static NativeMethods.NavigatingCallback InNavigating = new NativeMethods.NavigatingCallback(WebBrowserInterop.ReversePInvokeThunk.OnNavigating);
      public static NativeMethods.NavigateErrorCallback InNavigateError = new NativeMethods.NavigateErrorCallback(WebBrowserInterop.ReversePInvokeThunk.OnNavigateError);
      public static NativeMethods.NavigatedCallback InNavigated = new NativeMethods.NavigatedCallback(WebBrowserInterop.ReversePInvokeThunk.OnNavigated);
      public static NativeMethods.LoadCompletedCallback InLoadCompleted = new NativeMethods.LoadCompletedCallback(WebBrowserInterop.ReversePInvokeThunk.OnLoadCompleted);
      public static NativeMethods.ScriptNotifyCallback InScriptNotify = new NativeMethods.ScriptNotifyCallback(WebBrowserInterop.ReversePInvokeThunk.OnScriptNotify);
      public static NativeMethods.FullScreenChangedCallback InFullScreenChanged = new NativeMethods.FullScreenChangedCallback(WebBrowserInterop.ReversePInvokeThunk.OnFullScreenChangedCallback);
      public static NativeMethods.DocumentSizeChangeCallback InDocumentSizeChange = new NativeMethods.DocumentSizeChangeCallback(WebBrowserInterop.ReversePInvokeThunk.OnDocumentSizeChanged);
      public static NativeMethods.BeginDocumentSwitchCallback InBeginDocumentSwitch = new NativeMethods.BeginDocumentSwitchCallback(WebBrowserInterop.ReversePInvokeThunk.OnBeginDocumentSwitch);
      public static NativeMethods.EndDocumentSwitchCallback InEndDocumentSwitch = new NativeMethods.EndDocumentSwitchCallback(WebBrowserInterop.ReversePInvokeThunk.OnEndDocumentSwitch);
      public static NativeMethods.ZoomAndScrollCallback InZoomAndScroll = new NativeMethods.ZoomAndScrollCallback(WebBrowserInterop.ReversePInvokeThunk.OnZoomAndScroll);
      public static NativeMethods.ZoomConstraintsChangeCallback InZoomConstraintsChange = new NativeMethods.ZoomConstraintsChangeCallback(WebBrowserInterop.ReversePInvokeThunk.OnZoomConstraintsChanged);
      public static NativeMethods.TransformRectUOZtoScreenCallback InTransformRectUOZtoScreen = new NativeMethods.TransformRectUOZtoScreenCallback(WebBrowserInterop.ReversePInvokeThunk.OnTransformRectUOZtoScreen);
      public static NativeMethods.TransformPointUOZtoScreenCallback InTransformPointUOZtoScreen = new NativeMethods.TransformPointUOZtoScreenCallback(WebBrowserInterop.ReversePInvokeThunk.OnTransformPointUOZtoScreen);
      public static NativeMethods.SIPStateChangeCallback InSIPStateChange = new NativeMethods.SIPStateChangeCallback(WebBrowserInterop.ReversePInvokeThunk.OnSIPStateChange);
      public static NativeMethods.PulseCallback InPulse = new NativeMethods.PulseCallback(WebBrowserInterop.ReversePInvokeThunk.OnPulse);
      public static NativeMethods.CanNavigateBackChangeCallback InCanNavigateBackChange = new NativeMethods.CanNavigateBackChangeCallback(WebBrowserInterop.ReversePInvokeThunk.OnCanNavigateBackChange);
      public static NativeMethods.CanNavigateForwardChangeCallback InCanNavigateForwardChange = new NativeMethods.CanNavigateForwardChangeCallback(WebBrowserInterop.ReversePInvokeThunk.OnCanNavigateForwardChange);

      [SecuritySafeCritical]
      private static void OnUnhandledCallbackException(Exception ex)
      {
        if (!Application.ShouldIgnoreUnhandledException(ex))
          throw ex;
      }

      [AllowReversePInvokeCalls]
      private static void OnNavigating(int webBrowserControlId, string uri, out bool cancel)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop != null)
        {
          Uri uri1 = WebBrowserInterop.UriFromString(uri);
          try
          {
            interop.webBrowserCallbacks.Navigating(uri1, out cancel);
          }
          catch (Exception ex)
          {
            WebBrowserInterop.ReversePInvokeThunk.OnUnhandledCallbackException(ex);
            cancel = false;
          }
        }
        else
          cancel = true;
      }

      [AllowReversePInvokeCalls]
      private static void OnNavigateError(
        int webBrowserControlId,
        string uri,
        int statusCode,
        out bool cancel)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop != null)
        {
          Uri uri1 = WebBrowserInterop.UriFromString(uri);
          try
          {
            interop.webBrowserCallbacks.NavigateError(uri1, statusCode, out cancel);
          }
          catch (Exception ex)
          {
            WebBrowserInterop.ReversePInvokeThunk.OnUnhandledCallbackException(ex);
            cancel = false;
          }
        }
        else
          cancel = true;
      }

      [AllowReversePInvokeCalls]
      private static void OnNavigated(int webBrowserControlId, string uri)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop == null)
          return;
        Uri uri1 = WebBrowserInterop.UriFromString(uri);
        try
        {
          interop.webBrowserCallbacks.Navigated(uri1);
        }
        catch (Exception ex)
        {
          WebBrowserInterop.ReversePInvokeThunk.OnUnhandledCallbackException(ex);
        }
      }

      [AllowReversePInvokeCalls]
      private static void OnLoadCompleted(
        int webBrowserControlId,
        string uri,
        int backgroundColorXRGB)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop == null)
          return;
        interop.DocumentBackgroundColorChangedEventHandler(backgroundColorXRGB);
        Uri uri1 = WebBrowserInterop.UriFromString(uri);
        try
        {
          interop.webBrowserCallbacks.LoadCompleted(uri1);
        }
        catch (Exception ex)
        {
          WebBrowserInterop.ReversePInvokeThunk.OnUnhandledCallbackException(ex);
        }
      }

      [AllowReversePInvokeCalls]
      private static void OnScriptNotify(int webBrowserControlId, string value)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop == null)
          return;
        try
        {
          interop.webBrowserCallbacks.ScriptNotify(value);
        }
        catch (Exception ex)
        {
          WebBrowserInterop.ReversePInvokeThunk.OnUnhandledCallbackException(ex);
        }
      }

      [AllowReversePInvokeCalls]
      private static void OnFullScreenChangedCallback(int webBrowserControlId, bool isFullScreen)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop == null)
          return;
        try
        {
          interop.webBrowserCallbacks.FullScreenChanged(isFullScreen);
        }
        catch (Exception ex)
        {
          WebBrowserInterop.ReversePInvokeThunk.OnUnhandledCallbackException(ex);
        }
      }

      [AllowReversePInvokeCalls]
      private static void OnDocumentSizeChanged(
        int webBrowserControlId,
        int width,
        int height,
        float minimumZoom,
        float maximumZoom,
        bool isRTL)
      {
        WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId)?.DocumentSizeChangedEventHandler(width, height, minimumZoom, maximumZoom, isRTL);
      }

      [AllowReversePInvokeCalls]
      private static void OnBeginDocumentSwitch(
        int webBrowserControlId,
        float minimumZoom,
        float maximumZoom,
        float initialZoom,
        int widthAtUOZ,
        int heightAtUOZ,
        int backgroundColorXRGB)
      {
        WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId)?.BeginDocumentSwitchEventHandler(minimumZoom, maximumZoom, initialZoom, widthAtUOZ, heightAtUOZ, backgroundColorXRGB);
      }

      [AllowReversePInvokeCalls]
      private static void OnEndDocumentSwitch(
        int webBrowserControlId,
        float minimumZoom,
        float maximumZoom,
        float initialZoom,
        int widthAtUOZ,
        int heightAtUOZ)
      {
        WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId)?.EndDocumentSwitchEventHandler(minimumZoom, maximumZoom, initialZoom, widthAtUOZ, heightAtUOZ);
      }

      [AllowReversePInvokeCalls]
      private static void OnZoomAndScroll(
        int webBrowserControlId,
        int x,
        int y,
        float zoom,
        bool animate)
      {
        WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId)?.ZoomAndScrollEventHandler(x, y, zoom, animate);
      }

      [AllowReversePInvokeCalls]
      private static void OnZoomConstraintsChanged(
        int webBrowserControlId,
        float minimumZoom,
        float maximumZoom,
        float initialZoom,
        bool isViewportWidthOrientationDependent)
      {
        WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId)?.ZoomConstraintsChangedEventHandler(minimumZoom, maximumZoom, initialZoom, isViewportWidthOrientationDependent);
      }

      [AllowReversePInvokeCalls]
      private static void OnTransformRectUOZtoScreen(
        int webBrowserControlId,
        int inLeft,
        int inTop,
        int inRight,
        int inBottom,
        out double outLeft,
        out double outTop,
        out double outRight,
        out double outBottom)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop != null)
        {
          interop.TransformPointUOZtoScreenEventHandler(inLeft, inTop, out outLeft, out outTop);
          interop.TransformPointUOZtoScreenEventHandler(inRight, inBottom, out outRight, out outBottom);
        }
        else
        {
          outLeft = 0.0;
          outTop = 0.0;
          outRight = 0.0;
          outBottom = 0.0;
        }
      }

      [AllowReversePInvokeCalls]
      private static void OnTransformPointUOZtoScreen(
        int webBrowserControlId,
        int inX,
        int inY,
        out double outX,
        out double outY)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop != null)
        {
          interop.TransformPointUOZtoScreenEventHandler(inX, inY, out outX, out outY);
        }
        else
        {
          outX = 0.0;
          outY = 0.0;
        }
      }

      [AllowReversePInvokeCalls]
      private static void OnSIPStateChange(int webBrowserControlId, bool visible)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop == null)
          return;
        interop.webBrowserCallbacks.SIPStateChange(visible);
      }

      [AllowReversePInvokeCalls]
      private static void OnPulse(int webBrowserControlId) => WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId)?.Pulse();

      [AllowReversePInvokeCalls]
      private static void OnCanNavigateBackChange(int webBrowserControlId, bool enabled)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop == null)
          return;
        interop.webBrowserCallbacks.CanNavigateBackChange(enabled);
      }

      [AllowReversePInvokeCalls]
      private static void OnCanNavigateForwardChange(int webBrowserControlId, bool enabled)
      {
        WebBrowserInterop interop = WebBrowserInterop.interopRegistry.FindInterop(webBrowserControlId);
        if (interop == null)
          return;
        interop.webBrowserCallbacks.CanNavigateForwardChange(enabled);
      }
    }

    private class WebBrowserInteropRegistry
    {
      private List<WebBrowserInterop.WebBrowserInteropRegistry.WebBrowserInteropRegistration> list = new List<WebBrowserInterop.WebBrowserInteropRegistry.WebBrowserInteropRegistration>();

      public void Insert(int webBrowserControlId, WebBrowserInterop interop)
      {
        lock (this)
          this.list.Add(new WebBrowserInterop.WebBrowserInteropRegistry.WebBrowserInteropRegistration(webBrowserControlId, (IWebBrowserInterop) interop));
      }

      public void Remove(int webBrowserControlId)
      {
        lock (this)
        {
          foreach (WebBrowserInterop.WebBrowserInteropRegistry.WebBrowserInteropRegistration interopRegistration in this.list)
          {
            if (webBrowserControlId == interopRegistration.webBrowserControlId)
            {
              this.list.Remove(interopRegistration);
              break;
            }
          }
        }
      }

      public WebBrowserInterop FindInterop(int webBrowserControlId)
      {
        WebBrowserInterop webBrowserInterop = (WebBrowserInterop) null;
        lock (this)
        {
          foreach (WebBrowserInterop.WebBrowserInteropRegistry.WebBrowserInteropRegistration interopRegistration in this.list)
          {
            if (webBrowserControlId == interopRegistration.webBrowserControlId)
            {
              webBrowserInterop = (WebBrowserInterop) interopRegistration.interop.Target;
              break;
            }
          }
        }
        return webBrowserInterop;
      }

      private class WebBrowserInteropRegistration
      {
        public int webBrowserControlId;
        public WeakReference interop;

        public WebBrowserInteropRegistration(int webBrowserControlId, IWebBrowserInterop interop)
        {
          this.webBrowserControlId = webBrowserControlId;
          this.interop = new WeakReference((object) interop);
        }
      }
    }
  }
}
