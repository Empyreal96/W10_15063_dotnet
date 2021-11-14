// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.PivotItem
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Automation.Peers;
using Microsoft.Phone.Controls.Primitives;
using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  [TemplateVisualState(GroupName = "Position States", Name = "Center")]
  [TemplateVisualState(GroupName = "Position States", Name = "Left")]
  [TemplateVisualState(GroupName = "Position States", Name = "Right")]
  public class PivotItem : ContentControl
  {
    private const string PivotPositionsGroupName = "Position States";
    private const string PivotStateCenter = "Center";
    private const string PivotStateLeft = "Left";
    private const string PivotStateRight = "Right";
    private const string ContentName = "Content";
    private AnimationDirection? _firstAnimation;
    private AnimationDirection _direction;
    public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(nameof (Header), typeof (object), typeof (PivotItem), new PropertyMetadata((PropertyChangedCallback) null));

    internal bool IsFirstVisualChildVisible { get; set; }

    internal UIElement FirstVisualChild { get; set; }

    public object Header
    {
      get => this.GetValue(PivotItem.HeaderProperty);
      set => this.SetValue(PivotItem.HeaderProperty, value);
    }

    public PivotItem()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_STARTUP, PerfLog.PivotItem);
      this.DefaultStyleKey = (object) typeof (PivotItem);
      this.SetAutomaticBitmapCache();
      this.Loaded += new RoutedEventHandler(this.PivotItem_Loaded);
    }

    private void PivotItem_Loaded(object sender, RoutedEventArgs e)
    {
      this.Loaded -= new RoutedEventHandler(this.PivotItem_Loaded);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_STARTUP, PerfLog.PivotItem);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_ARRANGE, PerfLog.PivotItem);
      Size size = base.ArrangeOverride(finalSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_ARRANGE, PerfLog.PivotItem);
      return size;
    }

    protected override Size MeasureOverride(Size availableSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_MEASURE, PerfLog.PivotItem);
      Size size = base.MeasureOverride(availableSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_MEASURE, PerfLog.PivotItem);
      return size;
    }

    public override void OnApplyTemplate()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_APPLYTEMPLATE, PerfLog.PivotItem);
      base.OnApplyTemplate();
      AnimationDirection? firstAnimation = this._firstAnimation;
      this.MoveTo(AnimationDirection.Center);
      if (firstAnimation.HasValue)
        this.MoveTo(firstAnimation.Value);
      this._firstAnimation = new AnimationDirection?(AnimationDirection.Center);
      this.FirstVisualChild = (UIElement) VisualTreeHelper.GetChild((DependencyObject) this, 0);
      if (this.FirstVisualChild != null)
        this.FirstVisualChild.Visibility = this.IsFirstVisualChildVisible ? Visibility.Visible : Visibility.Collapsed;
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_APPLYTEMPLATE, PerfLog.PivotItem);
    }

    protected override AutomationPeer OnCreateAutomationPeer()
    {
      ItemsControlAutomationPeer itemsControlAutomationPeer = (ItemsControlAutomationPeer) null;
      ItemsControl itemsControl = ItemsControl.ItemsControlFromItemContainer((DependencyObject) this);
      if (itemsControl != null)
        itemsControlAutomationPeer = itemsControl.GetOrCreateAutomationPeer() as ItemsControlAutomationPeer;
      return (AutomationPeer) new PivotItemAutomationPeer(this, itemsControlAutomationPeer);
    }

    internal void MoveTo(AnimationDirection direction)
    {
      bool useTransitions = (uint) direction > 0U;
      this._direction = direction;
      if (!this._firstAnimation.HasValue & useTransitions)
        this._firstAnimation = new AnimationDirection?(direction);
      else
        this.UpdateVisualStates(useTransitions);
    }

    private void UpdateVisualStates(bool useTransitions) => VisualStateManager.GoToState((Control) this, PivotItem.StateNameFromAnimationDirection(this._direction), useTransitions);

    private static string StateNameFromAnimationDirection(AnimationDirection direction)
    {
      switch (direction)
      {
        case AnimationDirection.Center:
          return "Center";
        case AnimationDirection.Left:
          return "Left";
        case AnimationDirection.Right:
          return "Right";
        default:
          throw new InvalidOperationException();
      }
    }
  }
}
