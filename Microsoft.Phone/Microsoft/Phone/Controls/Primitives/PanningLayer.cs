// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Primitives.PanningLayer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using MS.Internal;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Microsoft.Phone.Controls.Primitives
{
  [TemplatePart(Name = "LocalTransform", Type = typeof (TranslateTransform))]
  [TemplatePart(Name = "PanningTransform", Type = typeof (TranslateTransform))]
  [TemplatePart(Name = "LeftWraparound", Type = typeof (Border))]
  [TemplatePart(Name = "RightWraparound", Type = typeof (Border))]
  [TemplatePart(Name = "PanningStackPanel", Type = typeof (StackPanel))]
  [TemplatePart(Name = "ContentPresenter", Type = typeof (ContentPresenter))]
  public class PanningLayer : ContentControl
  {
    private const string LocalTransformName = "LocalTransform";
    private const string PanningTransformName = "PanningTransform";
    private const string LeftWraparoundName = "LeftWraparound";
    private const string RightWraparoundName = "RightWraparound";
    private const string PanningStackPanelName = "PanningStackPanel";
    private const string ContentPresenterName = "ContentPresenter";
    protected static readonly Duration Immediately = new Duration(TimeSpan.Zero);
    private readonly IEasingFunction _easingFunction;
    private ContentPresenter contentPresenter;
    private TransformAnimator animator;
    private bool isStatic;

    protected TranslateTransform LocalTransform { get; set; }

    protected TranslateTransform PanningTransform { get; set; }

    internal Border LeftWraparound { get; set; }

    internal FrameworkElementProxy LeftWraparoundProxy { get; set; }

    internal Border RightWraparound { get; set; }

    internal FrameworkElementProxy RightWraparoundProxy { get; set; }

    private StackPanel PanningStackPanel { get; set; }

    public PanningLayer()
    {
      ExponentialEase exponentialEase = new ExponentialEase();
      exponentialEase.Exponent = -8.00636756765025;
      exponentialEase.EasingMode = EasingMode.EaseIn;
      this._easingFunction = (IEasingFunction) exponentialEase;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_STARTUP, PerfLog.PanningLayer);
      this.DefaultStyleKey = (object) typeof (PanningLayer);
      this.Loaded += new RoutedEventHandler(this.PanningLayer_Loaded);
    }

    private void PanningLayer_Loaded(object sender, RoutedEventArgs e)
    {
      this.Loaded -= new RoutedEventHandler(this.PanningLayer_Loaded);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_STARTUP, PerfLog.PanningLayer);
    }

    public override void OnApplyTemplate()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_APPLYTEMPLATE, PerfLog.PanningLayer);
      base.OnApplyTemplate();
      this.LocalTransform = this.GetTemplateChild("LocalTransform") as TranslateTransform;
      this.PanningTransform = this.GetTemplateChild("PanningTransform") as TranslateTransform;
      this.LeftWraparound = this.GetTemplateChild("LeftWraparound") as Border;
      this.RightWraparound = this.GetTemplateChild("RightWraparound") as Border;
      this.PanningStackPanel = this.GetTemplateChild("PanningStackPanel") as StackPanel;
      this.ContentPresenter = this.GetTemplateChild("ContentPresenter") as ContentPresenter;
      this.animator = this.PanningTransform != null ? new TransformAnimator(this.PanningTransform) : (TransformAnimator) null;
      if (this.LeftWraparoundProxy == null)
        this.LeftWraparoundProxy = new FrameworkElementProxy();
      if (this.RightWraparoundProxy == null)
        this.RightWraparoundProxy = new FrameworkElementProxy();
      if (this.ContentPresenter != null)
        this.ContentPresenter.SetAutomaticBitmapCache();
      this.LeftWraparoundProxy.Target = (UIElement) this.ContentPresenter;
      this.RightWraparoundProxy.Target = (UIElement) this.ContentPresenter;
      if (this.LeftWraparound != null)
        this.LeftWraparound.Child = (UIElement) this.LeftWraparoundProxy;
      if (this.RightWraparound != null)
        this.RightWraparound.Child = (UIElement) this.RightWraparoundProxy;
      if (this.PanningStackPanel != null)
      {
        this.PanningStackPanel.SetAutomaticBitmapCache();
        this.DirectManipulationSetTarget((UIElement) this.PanningStackPanel);
      }
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_APPLYTEMPLATE, PerfLog.PanningLayer);
    }

    protected override Size MeasureOverride(Size availableSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_MEASURE, PerfLog.PanningLayer);
      Size size = base.MeasureOverride(availableSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_MEASURE, PerfLog.PanningLayer);
      return size;
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_ARRANGE, PerfLog.PanningLayer);
      Size size = base.ArrangeOverride(finalSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_ARRANGE, PerfLog.PanningLayer);
      return size;
    }

    protected internal ContentPresenter ContentPresenter
    {
      get => this.contentPresenter;
      set
      {
        if (this.contentPresenter != null)
          this.contentPresenter.SizeChanged -= new SizeChangedEventHandler(this.OnContentSizeChanged);
        this.contentPresenter = value;
        if (this.contentPresenter == null)
          return;
        this.contentPresenter.SizeChanged += new SizeChangedEventHandler(this.OnContentSizeChanged);
      }
    }

    protected virtual double PanRate => 1.0;

    public void GoTo(int targetOffset, Duration duration)
    {
      if (this.animator == null || this.IsStatic)
        return;
      this.animator.GoTo((double) (int) ((double) targetOffset * this.PanRate), duration, this._easingFunction, (Action) null);
    }

    public virtual void Wraparound(int direction)
    {
      double num = this.ContentPresenter != null ? this.ContentPresenter.ActualWidth : 0.0;
      if (direction < 0)
        this.GoTo((int) ((this.ActualOffset + num) / this.PanRate), PanningLayer.Immediately);
      else
        this.GoTo((int) ((this.ActualOffset - num) / this.PanRate), PanningLayer.Immediately);
    }

    internal void Refresh() => this.UpdateWrappingRectangles();

    protected virtual void UpdateWrappingRectangles()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_UPDATEWRAPPING, PerfLog.PanningLayer);
      Thickness thickness = this.ContentPresenter != null ? this.ContentPresenter.Margin : new Thickness(0.0);
      this.UpdateWrappingRectanglesInternal(thickness, thickness);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_UPDATEWRAPPING, PerfLog.PanningLayer);
    }

    internal void UpdateWrappingRectanglesInternal(
      Thickness leftWraparoundMargin,
      Thickness rightWraparoundMargin)
    {
      this.UpdateWrappingBorder(this.LeftWraparound, leftWraparoundMargin);
      this.UpdateWrappingBorder(this.RightWraparound, rightWraparoundMargin);
      if (this.LeftWraparound == null || this.LocalTransform == null)
        return;
      double num = this.LeftWraparound.Visibility == Visibility.Visible ? -this.LeftWraparound.Width - this.LeftWraparound.Margin.Left : 0.0;
      this.LocalTransform.X = this.IsStatic ? 0.0 : num - this.LeftWraparound.Margin.Right;
    }

    private void UpdateWrappingBorder(Border wraparoundBorder, Thickness wraparoundMargin)
    {
      if (wraparoundBorder == null)
        return;
      wraparoundBorder.Visibility = this.ShouldShowWrappers ? Visibility.Visible : Visibility.Collapsed;
      if (!this.ShouldShowWrappers)
        return;
      wraparoundBorder.Height = this.ContentPresenter != null ? this.ContentPresenter.ActualHeight : 0.0;
      wraparoundBorder.Width = this.ContentPresenter != null ? this.ContentPresenter.ActualWidth : 0.0;
      wraparoundBorder.Margin = wraparoundMargin;
    }

    internal bool IsStatic
    {
      get => this.isStatic;
      set
      {
        if (value == this.isStatic)
          return;
        this.isStatic = value;
        if (this.isStatic)
          this.ActualOffset = 0.0;
        else
          this.UpdateWrappingRectangles();
      }
    }

    protected internal virtual bool ShouldShowWrappers => !this.IsStatic && this.Owner != null && this.Owner.ShouldAllowWraparound;

    internal Panorama Owner { get; set; }

    internal double ActualOffset
    {
      get => this.PanningTransform == null ? 0.0 : this.PanningTransform.X;
      private set
      {
        if (this.PanningTransform == null)
          return;
        this.PanningTransform.X = value;
      }
    }

    private void OnContentSizeChanged(object sender, SizeChangedEventArgs e)
    {
      this.UpdateWrappingRectangles();
      this.DirectManipulationSetLayerWidth(this.ContentPresenter != null ? (float) this.ContentPresenter.ActualWidth : 0.0f);
    }

    protected virtual void DirectManipulationSetLayerWidth(float width)
    {
      if (this.Owner == null)
        return;
      this.Owner.DirectManipulationSetItemsLayerWidth(width);
    }

    protected virtual void DirectManipulationSetTarget(UIElement target)
    {
      if (this.Owner == null)
        return;
      this.Owner.DirectManipulationSetItemsLayerTarget(target);
    }
  }
}
