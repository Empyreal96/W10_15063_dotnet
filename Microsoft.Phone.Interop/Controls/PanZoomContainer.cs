// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.PanZoomContainer
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using MS.Internal;
using System;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Microsoft.Phone.Controls
{
  internal class PanZoomContainer : ContentControl
  {
    private Size _contentSizeAtUOZ;
    private Rect _viewportAtSOZ;
    private double _minimumScale;
    private double _maximumScale;
    private double _currentScale;
    private PanZoomContainer.PanZoomState _state;
    private CompositeTransform _childTransform;
    private ScaleTransform _viewportTransform;
    private Border _border;
    private ScrollBar _scrollH;
    private ScrollBar _scrollV;
    private Ellipse _statusEllipse;
    private Storyboard _flickStoryboard;
    private Storyboard _animateToStoryboard;
    private bool _isAnimateToRunning;
    private bool _fireStateChanged;
    private bool _fireScaleChanged;
    private bool _fireViewportChanged;
    private const double GesturePanOverage = 150.0;
    private const double GesturePinchStretchOverage = 0.2;
    private const double BounceAnimationDurationSeconds = 0.3;
    private int _manipulationStartedTickCount;
    private PanZoomContainer.PanLock _panLock;
    private Point _manipulationOriginAtStartedEvent;
    private Point _manipulationOriginAtLastDeltaEvent;
    private bool _isPinchStretch;

    public event EventHandler<PanZoomContainer.PanZoomStateEventArgs> PanZoomStateChanged;

    public event EventHandler<PanZoomContainer.PanZoomScaleEventArgs> PanZoomScaleChanged;

    public event EventHandler<PanZoomContainer.PanZoomViewportEventArgs> PanZoomViewportChanged;

    public double MinimumScale
    {
      get => this._minimumScale;
      set => this._minimumScale = value;
    }

    public double MaximumScale
    {
      get => this._maximumScale;
      set => this._maximumScale = value;
    }

    public double CurrentScale
    {
      get => this._currentScale;
      private set
      {
        if (this._currentScale == value)
          return;
        this._currentScale = value;
        this._fireScaleChanged = true;
      }
    }

    public Rect ViewportAtSOZ
    {
      get => this._viewportAtSOZ;
      private set
      {
        if (!(this._viewportAtSOZ != value))
          return;
        this._viewportAtSOZ = value;
        this._fireViewportChanged = true;
      }
    }

    public PanZoomContainer.PanZoomState State
    {
      get => this._state;
      private set
      {
        if (this._state == value)
          return;
        this._state = value;
        this._fireStateChanged = true;
        this.UpdateScrollIndicators();
      }
    }

    public Size ContentSize
    {
      get => this._contentSizeAtUOZ;
      set
      {
        this._contentSizeAtUOZ = value;
        this.RecalculateViewport();
        this.FireEvents();
      }
    }

    private void UpdateScrollIndicators()
    {
      switch (this._state)
      {
        case PanZoomContainer.PanZoomState.Idle:
          this._scrollH.Visibility = Visibility.Collapsed;
          this._scrollV.Visibility = Visibility.Collapsed;
          this._statusEllipse.Fill = (Brush) new SolidColorBrush(Colors.Black);
          break;
        case PanZoomContainer.PanZoomState.Manipulating:
          this._scrollH.Visibility = Visibility.Visible;
          this._scrollV.Visibility = Visibility.Visible;
          this._statusEllipse.Fill = (Brush) new SolidColorBrush(Colors.Green);
          break;
        case PanZoomContainer.PanZoomState.Inertia:
          this._statusEllipse.Fill = (Brush) new SolidColorBrush(Colors.Yellow);
          break;
      }
    }

    [SecuritySafeCritical]
    public PanZoomContainer()
    {
      this._childTransform = new CompositeTransform();
      this._viewportTransform = new ScaleTransform();
      this._flickStoryboard = new Storyboard();
      this._animateToStoryboard = new Storyboard();
      if (Microsoft.Phone.QuirksMode.ShouldApplyScaleFactorToWebBrowserControlContent())
        this.SetAutomaticBitmapCache();
      this._state = PanZoomContainer.PanZoomState.Idle;
      this._currentScale = 1.0;
      this._minimumScale = 0.25;
      this._maximumScale = 4.0;
      this._viewportAtSOZ = new Rect(0.0, 0.0, 100.0, 100.0);
      this._contentSizeAtUOZ = new Size(200.0, 200.0);
      this._fireStateChanged = false;
      this._fireScaleChanged = false;
      this._fireViewportChanged = false;
      this.UseOptimizedManipulationRouting = false;
      if (Microsoft.Phone.QuirksMode.ShouldWebBrowserBlockRoutedEventsFromBubblingToParent())
        XcpImports.DependencyObject_SetBlocksRoutedEventsFromBubblingToParent(this.NativeObject, true);
      this.Template = XamlReader.Load("<ControlTemplate xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation' xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml' TargetType='ContentControl' >   <Grid>         <Border x:Name='border' BorderBrush='Green' BorderThickness='0' Background='{TemplateBinding Background}'>             <ContentPresenter />         </Border>   </Grid></ControlTemplate> ") as ControlTemplate;
      this.LayoutUpdated += new EventHandler(this.PanZoomContainer_LayoutUpdated);
    }

    public void SetScale(double zoomFactor)
    {
      this.RecalculateViewport();
      double currentScale = this.CurrentScale;
      double translateX = this._childTransform.TranslateX;
      double translateY = this._childTransform.TranslateY;
      Point point = new Point(0.0, 0.0);
      double newScale = zoomFactor;
      Point scaleCenter = point;
      ref double local1 = ref translateX;
      ref double local2 = ref translateY;
      PanZoomContainer.AdjustOffsetsForScaleAroundPoint(currentScale, newScale, scaleCenter, ref local1, ref local2);
      this.ClampAndSetView(zoomFactor, translateX, translateY);
    }

    public void SetViewTopLeft(double zoomFactor, double xAtSOZ, double yAtSOZ)
    {
      this.RecalculateViewport();
      double offsetXAtSOZ = -1.0 * xAtSOZ;
      double offsetYAtSOZ = -1.0 * yAtSOZ;
      this.ClampAndSetView(zoomFactor, offsetXAtSOZ, offsetYAtSOZ);
    }

    public void SetViewCenter(double zoomFactor, double xAtSOZ, double yAtSOZ)
    {
      this.RecalculateViewport();
      double offsetXAtSOZ;
      double offsetYAtSOZ;
      this.GetTranslationOffsetsToCenterPointInViewport(zoomFactor, xAtSOZ, yAtSOZ, out offsetXAtSOZ, out offsetYAtSOZ);
      this.ClampAndSetView(zoomFactor, offsetXAtSOZ, offsetYAtSOZ);
    }

    private void ClampAndSetView(double zoomFactor, double offsetXAtSOZ, double offsetYAtSOZ)
    {
      this.ClampToContentBounds(ref zoomFactor, ref offsetXAtSOZ, ref offsetYAtSOZ);
      this.UpdateTransformAndViewport(zoomFactor, offsetXAtSOZ, offsetYAtSOZ);
      this.FireEvents();
    }

    private void GetTranslationOffsetsToCenterPointInViewport(
      double zoomFactor,
      double centerXAtSOZ,
      double centerYAtSOZ,
      out double offsetXAtSOZ,
      out double offsetYAtSOZ)
    {
      double num1 = this._viewportAtSOZ.Width / 2.0;
      double num2 = this._viewportAtSOZ.Height / 2.0;
      offsetXAtSOZ = -1.0 * (centerXAtSOZ - num1);
      offsetYAtSOZ = -1.0 * (centerYAtSOZ - num2);
    }

    private double ClampToRange(double min, ref double val, double max)
    {
      double num1 = val;
      val = Math.Min(val, max);
      val = Math.Max(val, min);
      double num2 = val;
      return Math.Abs(num1 - num2);
    }

    private Size GetContentSizeAtSOZForCurrentScale() => this.GetContentSizeAtSOZ(this._currentScale);

    private Size GetContentSizeAtSOZ(double zoomFactor) => new Size(this._contentSizeAtUOZ.Width * zoomFactor, this._contentSizeAtUOZ.Height * zoomFactor);

    private bool IsContentFitToWidth()
    {
      Size sozForCurrentScale = this.GetContentSizeAtSOZForCurrentScale();
      double num = 3.0;
      return Math.Abs(sozForCurrentScale.Width - this._viewportAtSOZ.Width) <= num;
    }

    public void AnimateViewportTopLeft(
      double zoomFactor,
      double xAtSOZ,
      double yAtSOZ,
      double seconds)
    {
      double offsetXAtSOZ = -1.0 * xAtSOZ;
      double offsetYAtSOZ = -1.0 * yAtSOZ;
      this.ClampAndAnimateViewportInternal(zoomFactor, offsetXAtSOZ, offsetYAtSOZ, seconds);
    }

    public void AnimateViewportCenter(
      double zoomFactor,
      double xAtSOZ,
      double yAtSOZ,
      double seconds)
    {
      double offsetXAtSOZ;
      double offsetYAtSOZ;
      this.GetTranslationOffsetsToCenterPointInViewport(zoomFactor, xAtSOZ, yAtSOZ, out offsetXAtSOZ, out offsetYAtSOZ);
      this.ClampAndAnimateViewportInternal(zoomFactor, offsetXAtSOZ, offsetYAtSOZ, seconds);
    }

    private void ClampAndAnimateViewportInternal(
      double zoomFactor,
      double offsetXAtSOZ,
      double offsetYAtSOZ,
      double seconds)
    {
      this.ClampToContentBounds(ref zoomFactor, ref offsetXAtSOZ, ref offsetYAtSOZ);
      this.AnimateViewportInternal(zoomFactor, offsetXAtSOZ, offsetYAtSOZ, seconds, false, (IEasingFunction) null);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      Size size = base.ArrangeOverride(finalSize);
      this.Clip = (Geometry) new RectangleGeometry()
      {
        Rect = new Rect(new Point(), size)
      };
      return size;
    }

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      this._border = this.GetTemplateChild("border") as Border;
      this._scrollH = new ScrollBar();
      this._scrollV = new ScrollBar();
      this._statusEllipse = new Ellipse();
      this.State = PanZoomContainer.PanZoomState.Idle;
      this.FireEvents();
    }

    internal double ScrollableWidth
    {
      get
      {
        Size contentSizeAtUoz = this._contentSizeAtUOZ;
        return !double.IsNaN(this._contentSizeAtUOZ.Width) && !double.IsNaN(this.ActualWidth) ? Math.Max(0.0, this._currentScale * this._contentSizeAtUOZ.Width - this.ActualWidth) : 0.0;
      }
    }

    internal double ScrollableHeight
    {
      get
      {
        Size contentSizeAtUoz = this._contentSizeAtUOZ;
        return !double.IsNaN(this._contentSizeAtUOZ.Height) && !double.IsNaN(this.ActualHeight) ? Math.Max(0.0, this._currentScale * this._contentSizeAtUOZ.Height - this.ActualHeight) : 0.0;
      }
    }

    public void BounceViewportToBounds(bool shouldAnimate)
    {
      double scaleX = this._childTransform.ScaleX;
      double translateX = this._childTransform.TranslateX;
      double translateY = this._childTransform.TranslateY;
      if (this.ClampToContentBounds(ref scaleX, ref translateX, ref translateY) || !shouldAnimate)
      {
        this.State = PanZoomContainer.PanZoomState.Idle;
        this.UpdateTransformAndViewport(scaleX, translateX, translateY);
      }
      else
      {
        this.State = PanZoomContainer.PanZoomState.Inertia;
        this.AnimateViewportInternal(scaleX, translateX, translateY, 0.3, false, (IEasingFunction) null);
      }
    }

    public void Pulse()
    {
      Point scaleCenter = new Point(this._viewportAtSOZ.Width / 2.0, this._viewportAtSOZ.Height / 2.0);
      double num = this.CurrentScale * 1.1;
      double translateX = this._childTransform.TranslateX;
      double translateY = this._childTransform.TranslateY;
      PanZoomContainer.AdjustOffsetsForScaleAroundPoint(this.CurrentScale, num, scaleCenter, ref translateX, ref translateY);
      IEasingFunction easingFunction = PhysicsConstants.GetEasingFunction(0.12);
      this.AnimateViewportInternal(num, translateX, translateY, 0.12, true, easingFunction);
    }

    private void GetMinMaxOffsetAtSOZ(
      Size contentSizeAtSOZ,
      double panOverage,
      out double minOffsetXAtSOZ,
      out double maxOffsetXAtSOZ,
      out double minOffsetYAtSOZ,
      out double maxOffsetYAtSOZ)
    {
      minOffsetXAtSOZ = this._viewportAtSOZ.Width < contentSizeAtSOZ.Width ? this._viewportAtSOZ.Width - contentSizeAtSOZ.Width : 0.0;
      maxOffsetXAtSOZ = 0.0;
      minOffsetYAtSOZ = this._viewportAtSOZ.Height < contentSizeAtSOZ.Height ? this._viewportAtSOZ.Height - contentSizeAtSOZ.Height : 0.0;
      maxOffsetYAtSOZ = 0.0;
      minOffsetXAtSOZ -= panOverage;
      minOffsetYAtSOZ -= panOverage;
      maxOffsetXAtSOZ += panOverage;
      maxOffsetYAtSOZ += panOverage;
    }

    private bool ClampOffsetsToRange(
      double minOffsetXAtSOZ,
      ref double offsetXAtSOZ,
      double maxOffsetXAtSOZ,
      double minOffsetYAtSOZ,
      ref double offsetYAtSOZ,
      double maxOffsetYAtSOZ)
    {
      bool flag = true;
      double num = 1.0;
      if (this.ClampToRange(minOffsetXAtSOZ, ref offsetXAtSOZ, maxOffsetXAtSOZ) >= num)
        flag = false;
      if (this.ClampToRange(minOffsetYAtSOZ, ref offsetYAtSOZ, maxOffsetYAtSOZ) >= num)
        flag = false;
      return flag;
    }

    private double GetMinimumScaleWithOverage(double pinchStretchOverage) => this._minimumScale * (1.0 - pinchStretchOverage);

    private double GetMaximumScaleWithOverage(double pinchStretchOverage) => this._maximumScale * (1.0 + pinchStretchOverage);

    private bool ClampToGestureBounds(
      ref double gestureZoomFactor,
      ref double gestureOffsetXAtSOZ,
      ref double gestureOffsetYAtSOZ)
    {
      return this.ClampToBounds(150.0, 0.2, ref gestureZoomFactor, ref gestureOffsetXAtSOZ, ref gestureOffsetYAtSOZ);
    }

    private bool ClampToContentBounds(
      ref double zoomFactor,
      ref double offsetXAtSOZ,
      ref double offsetYAtSOZ)
    {
      return this.ClampToBounds(0.0, 0.0, ref zoomFactor, ref offsetXAtSOZ, ref offsetYAtSOZ);
    }

    private bool ClampToBounds(
      double panOverage,
      double pinchStretchOverage,
      ref double zoomFactor,
      ref double offsetXAtSOZ,
      ref double offsetYAtSOZ)
    {
      bool flag = true;
      double oldScale = zoomFactor;
      double scaleWithOverage1 = this.GetMinimumScaleWithOverage(pinchStretchOverage);
      double scaleWithOverage2 = this.GetMaximumScaleWithOverage(pinchStretchOverage);
      if (this.ClampToRange(scaleWithOverage1, ref zoomFactor, scaleWithOverage2) != 0.0)
        flag = false;
      if (oldScale != zoomFactor)
      {
        Point scaleCenter = new Point(this._viewportAtSOZ.Width / 2.0, this._viewportAtSOZ.Height / 2.0);
        PanZoomContainer.AdjustOffsetsForScaleAroundPoint(oldScale, zoomFactor, scaleCenter, ref offsetXAtSOZ, ref offsetYAtSOZ);
      }
      double minOffsetXAtSOZ;
      double maxOffsetXAtSOZ;
      double minOffsetYAtSOZ;
      double maxOffsetYAtSOZ;
      this.GetMinMaxOffsetAtSOZ(this.GetContentSizeAtSOZ(zoomFactor), panOverage, out minOffsetXAtSOZ, out maxOffsetXAtSOZ, out minOffsetYAtSOZ, out maxOffsetYAtSOZ);
      if (!this.ClampOffsetsToRange(minOffsetXAtSOZ, ref offsetXAtSOZ, maxOffsetXAtSOZ, minOffsetYAtSOZ, ref offsetYAtSOZ, maxOffsetYAtSOZ))
        flag = false;
      return flag;
    }

    private void AnimateViewportInternal(
      double zoomFactor,
      double offsetXAtSOZ,
      double offsetYAtSOZ,
      double seconds,
      bool autoReverse,
      IEasingFunction easingFunction)
    {
      this.EnsureTransform();
      CompositeTransform childTransform = this._childTransform;
      DoubleAnimation doubleAnimation1 = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation1, (DependencyObject) childTransform);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation1, new PropertyPath("(CompositeTransform.TranslateX)", new object[0]));
      doubleAnimation1.To = new double?(offsetXAtSOZ);
      doubleAnimation1.Duration = (Duration) TimeSpan.FromSeconds(seconds);
      if (easingFunction != null)
        doubleAnimation1.EasingFunction = easingFunction;
      DoubleAnimation doubleAnimation2 = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation2, (DependencyObject) childTransform);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation2, new PropertyPath("(CompositeTransform.TranslateY)", new object[0]));
      doubleAnimation2.To = new double?(offsetYAtSOZ);
      doubleAnimation2.Duration = (Duration) TimeSpan.FromSeconds(seconds);
      if (easingFunction != null)
        doubleAnimation2.EasingFunction = easingFunction;
      DoubleAnimation doubleAnimation3 = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation3, (DependencyObject) childTransform);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation3, new PropertyPath("(CompositeTransform.ScaleX)", new object[0]));
      doubleAnimation3.To = new double?(zoomFactor);
      doubleAnimation3.Duration = (Duration) TimeSpan.FromSeconds(seconds);
      if (easingFunction != null)
        doubleAnimation3.EasingFunction = easingFunction;
      DoubleAnimation doubleAnimation4 = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation4, (DependencyObject) childTransform);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation4, new PropertyPath("(CompositeTransform.ScaleY)", new object[0]));
      doubleAnimation4.To = new double?(zoomFactor);
      doubleAnimation4.Duration = (Duration) TimeSpan.FromSeconds(seconds);
      if (easingFunction != null)
        doubleAnimation4.EasingFunction = easingFunction;
      this.KillAnimateToStoryboard();
      this._animateToStoryboard = new Storyboard();
      this._animateToStoryboard.AutoReverse = autoReverse;
      this._animateToStoryboard.Completed += new EventHandler(this.sb_AnimateToCompleted);
      this._animateToStoryboard.Children.Add((Timeline) doubleAnimation3);
      this._animateToStoryboard.Children.Add((Timeline) doubleAnimation4);
      this._animateToStoryboard.Children.Add((Timeline) doubleAnimation1);
      this._animateToStoryboard.Children.Add((Timeline) doubleAnimation2);
      this._animateToStoryboard.Begin();
      this._isAnimateToRunning = true;
      this.State = PanZoomContainer.PanZoomState.Inertia;
      this.FireEvents();
    }

    private void GenerateFlicks(Point logicalVelocity)
    {
      this.State = PanZoomContainer.PanZoomState.Inertia;
      Point initialVelocity = new Point(logicalVelocity.X, logicalVelocity.Y);
      CompositeTransform childTransform = this._childTransform;
      Point stopPoint = PhysicsConstants.GetStopPoint(initialVelocity);
      double stopTime = PhysicsConstants.GetStopTime(initialVelocity);
      double num1 = this._childTransform.TranslateX + stopPoint.X;
      double num2 = this._childTransform.TranslateY + stopPoint.Y;
      double minOffsetXAtSOZ;
      double maxOffsetXAtSOZ;
      double minOffsetYAtSOZ;
      double maxOffsetYAtSOZ;
      this.GetMinMaxOffsetAtSOZ(this.GetContentSizeAtSOZForCurrentScale(), 0.0, out minOffsetXAtSOZ, out maxOffsetXAtSOZ, out minOffsetYAtSOZ, out maxOffsetYAtSOZ);
      double offsetXAtSOZ = num1;
      double offsetYAtSOZ = num2;
      if (this._panLock == PanZoomContainer.PanLock.Vertical)
        offsetXAtSOZ = this._childTransform.TranslateX;
      else if (this._panLock == PanZoomContainer.PanLock.Horizontal)
        offsetYAtSOZ = this._childTransform.TranslateY;
      this.ClampOffsetsToRange(minOffsetXAtSOZ, ref offsetXAtSOZ, maxOffsetXAtSOZ, minOffsetYAtSOZ, ref offsetYAtSOZ, maxOffsetYAtSOZ);
      double num3 = offsetXAtSOZ - this._childTransform.TranslateX;
      double num4 = offsetYAtSOZ - this._childTransform.TranslateY;
      double num5 = stopPoint.X != 0.0 ? stopPoint.X : 1.0;
      double position1 = num3 / num5;
      double position2 = num4 / (stopPoint.Y != 0.0 ? stopPoint.Y : 1.0);
      double val1 = PhysicsConstants.InverseEase(position1) * stopTime;
      double val2 = PhysicsConstants.InverseEase(position2) * stopTime;
      if (val1 < stopTime)
        val1 *= 0.7;
      if (val2 < stopTime)
        val2 *= 0.7;
      double num6 = stopTime;
      double num7 = stopTime;
      if (this._childTransform.TranslateX > maxOffsetXAtSOZ)
      {
        num1 = maxOffsetXAtSOZ;
        num6 = val1 = 0.3;
      }
      else if (this._childTransform.TranslateX < minOffsetXAtSOZ)
      {
        num1 = minOffsetXAtSOZ;
        num6 = val1 = 0.3;
      }
      if (this._childTransform.TranslateY > maxOffsetYAtSOZ)
      {
        num2 = maxOffsetYAtSOZ;
        num7 = val2 = 0.3;
      }
      else if (this._childTransform.TranslateY < minOffsetYAtSOZ)
      {
        num2 = minOffsetYAtSOZ;
        num7 = val2 = 0.3;
      }
      double num8 = Math.Max(val1, val2);
      IEasingFunction easingFunction = PhysicsConstants.GetEasingFunction(stopTime);
      DoubleAnimation doubleAnimation1 = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation1, (DependencyObject) childTransform);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation1, new PropertyPath("(CompositeTransform.TranslateX)", new object[0]));
      doubleAnimation1.EasingFunction = easingFunction;
      doubleAnimation1.To = new double?(num1);
      doubleAnimation1.Duration = (Duration) TimeSpan.FromSeconds(num6);
      Storyboard storyboard1 = (Storyboard) null;
      if (val1 > 0.0)
      {
        storyboard1 = new Storyboard();
        storyboard1.Duration = (Duration) TimeSpan.FromSeconds(val1);
        storyboard1.Children.Add((Timeline) doubleAnimation1);
      }
      DoubleAnimation doubleAnimation2 = new DoubleAnimation();
      Storyboard.SetTarget((Timeline) doubleAnimation2, (DependencyObject) childTransform);
      Storyboard.SetTargetProperty((Timeline) doubleAnimation2, new PropertyPath("(CompositeTransform.TranslateY)", new object[0]));
      doubleAnimation2.EasingFunction = easingFunction;
      doubleAnimation2.To = new double?(num2);
      doubleAnimation2.Duration = (Duration) TimeSpan.FromSeconds(num7);
      Storyboard storyboard2 = (Storyboard) null;
      if (val2 > 0.0)
      {
        storyboard2 = new Storyboard();
        storyboard2.Duration = (Duration) TimeSpan.FromSeconds(val2);
        storyboard2.Children.Add((Timeline) doubleAnimation2);
      }
      this.KillFlickStoryboard();
      this._flickStoryboard = new Storyboard();
      this._flickStoryboard.Completed += new EventHandler(this.sb_FlickCompleted);
      if (num8 > 0.0)
      {
        this._flickStoryboard.Duration = (Duration) TimeSpan.FromSeconds(num8);
        if (storyboard1 != null)
          this._flickStoryboard.Children.Add((Timeline) storyboard1);
        if (storyboard2 != null)
          this._flickStoryboard.Children.Add((Timeline) storyboard2);
        this._flickStoryboard.Begin();
      }
      else
        this.DoFlickAnimationCompleted();
    }

    private void sb_AnimateToCompleted(object sender, EventArgs e)
    {
      this.RecalculateViewport();
      this.State = PanZoomContainer.PanZoomState.Idle;
      this._isAnimateToRunning = false;
      this.FireEvents();
    }

    private void sb_FlickCompleted(object sender, EventArgs e) => this.DoFlickAnimationCompleted();

    private void DoFlickAnimationCompleted()
    {
      this.BounceViewportToBounds(true);
      this.FireEvents();
    }

    private void KillFlickStoryboard()
    {
      this._flickStoryboard.Pause();
      this._flickStoryboard.Completed -= new EventHandler(this.sb_FlickCompleted);
    }

    private void KillAnimateToStoryboard()
    {
      this._animateToStoryboard.Pause();
      this._animateToStoryboard.Completed -= new EventHandler(this.sb_AnimateToCompleted);
    }

    private void EnsureTransform()
    {
      FrameworkElement content = this.Content as FrameworkElement;
      if (content is Panel panel)
      {
        if (panel.Children.Count <= 0 || panel.Children[0].RenderTransform == this._childTransform)
          return;
        panel.Children[0].RenderTransform = (Transform) this._childTransform;
      }
      else
      {
        if (content == null || content.RenderTransform == this._childTransform)
          return;
        content.RenderTransform = (Transform) this._childTransform;
      }
    }

    private void RecalculateViewport() => this.UpdateTransformAndViewport(this._childTransform.ScaleX, this._childTransform.TranslateX, this._childTransform.TranslateY);

    private void UpdateTransformAndViewport(
      double zoomFactor,
      double offsetXAtSOZ,
      double offsetYAtSOZ)
    {
      this.EnsureTransform();
      this.CurrentScale = zoomFactor;
      this._childTransform.ScaleX = zoomFactor;
      this._childTransform.ScaleY = zoomFactor;
      this._childTransform.TranslateX = offsetXAtSOZ;
      this._childTransform.TranslateY = offsetYAtSOZ;
      Rect rect = this._childTransform.Inverse.TransformBounds(new Rect(0.0, 0.0, this.ActualWidth, this.ActualHeight));
      this._viewportTransform.ScaleX = this._currentScale;
      this._viewportTransform.ScaleY = this._currentScale;
      this.ViewportAtSOZ = this._viewportTransform.TransformBounds(rect);
      if (this._scrollH != null)
      {
        this._scrollH.Minimum = 0.0;
        this._scrollH.Maximum = this.ScrollableWidth;
        this._scrollH.Value = -this._childTransform.TranslateX;
      }
      if (this._scrollV == null)
        return;
      this._scrollV.Minimum = 0.0;
      this._scrollV.Maximum = this.ScrollableHeight;
      this._scrollV.Value = -this._childTransform.TranslateY;
    }

    private void PanZoomContainer_LayoutUpdated(object sender, EventArgs e)
    {
      this.RecalculateViewport();
      this.FireEvents();
    }

    private PanZoomContainer.CardinalDirection DetermineCardinalDirection(Point p)
    {
      double num1 = Math.Abs(p.X);
      double num2 = Math.Abs(p.Y);
      if (num1 > num2)
        return PanZoomContainer.CardinalDirection.Horizontal;
      return num2 > num1 ? PanZoomContainer.CardinalDirection.Vertical : PanZoomContainer.CardinalDirection.None;
    }

    private Point CalculateDelta(Point candidateDelta, Point current, Point origin)
    {
      Point point = candidateDelta;
      if (point.X == 0.0 && point.Y == 0.0)
        point = new Point(current.X - origin.X, current.Y - origin.Y);
      return point;
    }

    public void HandleManipulationStarted(object sender, ManipulationStartedEventArgs e)
    {
      this._manipulationOriginAtStartedEvent = e.ManipulationOrigin;
      this._manipulationOriginAtLastDeltaEvent = e.ManipulationOrigin;
      this._isPinchStretch = false;
      if (this._isAnimateToRunning)
        return;
      this._manipulationStartedTickCount = Environment.TickCount;
      this._panLock = PanZoomContainer.PanLock.None;
      this.KillFlickStoryboard();
      e.Handled = true;
      this.FireEvents();
    }

    public void HandleManipulationCompleted(
      object sender,
      ManipulationCompletedEventArgs e,
      bool shouldTreatAsInertial)
    {
      if (this._isAnimateToRunning)
        return;
      if (shouldTreatAsInertial && !this._isPinchStretch)
        this.GenerateFlicks(e.FinalVelocities.LinearVelocity);
      else
        this.BounceViewportToBounds(shouldTreatAsInertial);
      e.Handled = true;
      this.FireEvents();
    }

    public void HandleManipulationDelta(object sender, ManipulationDeltaEventArgs e)
    {
      double num = e.DeltaManipulation.UniformScale;
      Point point1 = this.CalculateDelta(e.DeltaManipulation.Translation, e.ManipulationOrigin, this._manipulationOriginAtLastDeltaEvent);
      Point point2;
      if (e.DeltaManipulation.Translation.X == 0.0)
      {
        point2 = e.DeltaManipulation.Translation;
        if (point2.Y == 0.0 && (Math.Abs(point1.X) > 50.0 || Math.Abs(point1.Y) > 50.0))
        {
          this._manipulationOriginAtStartedEvent.X += point1.X;
          this._manipulationOriginAtStartedEvent.Y += point1.Y;
          point1 = new Point(0.0, 0.0);
          num = 0.0;
        }
      }
      Point delta = this.CalculateDelta(e.CumulativeManipulation.Translation, e.ManipulationOrigin, this._manipulationOriginAtStartedEvent);
      if (!this._isAnimateToRunning)
      {
        this.State = PanZoomContainer.PanZoomState.Manipulating;
        double gestureZoomFactor = this.CurrentScale;
        double translateX = this._childTransform.TranslateX;
        double translateY = this._childTransform.TranslateY;
        point2 = e.CumulativeManipulation.Scale;
        if (!point2.Equals(new Point(0.0, 0.0)) && num > 0.1)
        {
          this._panLock = PanZoomContainer.PanLock.Free;
          double oldScale = gestureZoomFactor;
          gestureZoomFactor = Math.Max(gestureZoomFactor * num, this.GetMinimumScaleWithOverage(0.2));
          double newScale = gestureZoomFactor;
          Point manipulationOrigin = e.ManipulationOrigin;
          ref double local1 = ref translateX;
          ref double local2 = ref translateY;
          PanZoomContainer.AdjustOffsetsForScaleAroundPoint(oldScale, newScale, manipulationOrigin, ref local1, ref local2);
          this._isPinchStretch = true;
        }
        if (this._panLock == PanZoomContainer.PanLock.None)
        {
          if (this.IsContentFitToWidth())
          {
            this._panLock = PanZoomContainer.PanLock.Vertical;
          }
          else
          {
            switch (this.DetermineCardinalDirection(delta))
            {
              case PanZoomContainer.CardinalDirection.Vertical:
                this._panLock = PanZoomContainer.PanLock.Vertical;
                break;
              case PanZoomContainer.CardinalDirection.Horizontal:
                this._panLock = PanZoomContainer.PanLock.Horizontal;
                break;
            }
          }
        }
        else if (Environment.TickCount - this._manipulationStartedTickCount < 1000)
        {
          int cardinalDirection = (int) this.DetermineCardinalDirection(delta);
          if (this._panLock == PanZoomContainer.PanLock.Horizontal && Math.Abs(delta.Y) > 65.0)
            this._panLock = PanZoomContainer.PanLock.Free;
          else if (this._panLock == PanZoomContainer.PanLock.Vertical && Math.Abs(delta.X) > 65.0 && !this.IsContentFitToWidth())
            this._panLock = PanZoomContainer.PanLock.Free;
        }
        if (this._panLock != PanZoomContainer.PanLock.Vertical)
          translateX += point1.X;
        if (this._panLock != PanZoomContainer.PanLock.Horizontal)
          translateY += point1.Y;
        this.ClampToGestureBounds(ref gestureZoomFactor, ref translateX, ref translateY);
        this.UpdateTransformAndViewport(gestureZoomFactor, translateX, translateY);
        e.Handled = true;
        this.FireEvents();
      }
      this._manipulationOriginAtLastDeltaEvent = e.ManipulationOrigin;
    }

    private static void AdjustOffsetsForScaleAroundPoint(
      double oldScale,
      double newScale,
      Point scaleCenter,
      ref double offsetXAtSOZ,
      ref double offsetYAtSOZ)
    {
      double num1 = newScale / oldScale;
      double num2 = 1.0 / oldScale - 1.0 / newScale;
      double num3 = scaleCenter.X * num2;
      double num4 = scaleCenter.Y * num2;
      offsetXAtSOZ *= num1;
      offsetYAtSOZ *= num1;
      offsetXAtSOZ -= num3 * newScale;
      offsetYAtSOZ -= num4 * newScale;
    }

    private void FireEvents()
    {
      int num = this._fireStateChanged ? 1 : 0;
      bool fireScaleChanged = this._fireScaleChanged;
      bool fireViewportChanged = this._fireViewportChanged;
      this._fireStateChanged = false;
      this._fireScaleChanged = false;
      this._fireViewportChanged = false;
      if (num != 0 && this.PanZoomStateChanged != null)
        this.PanZoomStateChanged((object) this, new PanZoomContainer.PanZoomStateEventArgs(this._state));
      if (fireScaleChanged && this.PanZoomScaleChanged != null)
        this.PanZoomScaleChanged((object) this, new PanZoomContainer.PanZoomScaleEventArgs(this._currentScale));
      if (!fireViewportChanged || this.PanZoomViewportChanged == null)
        return;
      this.PanZoomViewportChanged((object) this, new PanZoomContainer.PanZoomViewportEventArgs(this._viewportAtSOZ));
    }

    public enum PanZoomState
    {
      Idle,
      Manipulating,
      Inertia,
    }

    public class PanZoomStateEventArgs : EventArgs
    {
      private PanZoomContainer.PanZoomState _state;

      public PanZoomStateEventArgs(PanZoomContainer.PanZoomState state) => this._state = state;

      public PanZoomContainer.PanZoomState State => this._state;
    }

    public class PanZoomScaleEventArgs : EventArgs
    {
      private double _scale;

      public PanZoomScaleEventArgs(double scale) => this._scale = scale;

      public double Scale => this._scale;
    }

    public class PanZoomViewportEventArgs : EventArgs
    {
      private Rect _viewportAtSOZ;

      public PanZoomViewportEventArgs(Rect viewportAtSOZ) => this._viewportAtSOZ = viewportAtSOZ;

      public Rect Viewport => this._viewportAtSOZ;
    }

    private enum PanLock
    {
      None,
      Vertical,
      Horizontal,
      Free,
    }

    private enum CardinalDirection
    {
      None,
      Vertical,
      Horizontal,
    }
  }
}
