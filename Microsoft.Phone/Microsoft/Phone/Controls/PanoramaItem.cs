// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.PanoramaItem
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Automation.Peers;
using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  public class PanoramaItem : ContentControl
  {
    public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(nameof (Header), typeof (object), typeof (PanoramaItem), (PropertyMetadata) null);
    public static readonly DependencyProperty HeaderTemplateProperty = DependencyProperty.Register(nameof (HeaderTemplate), typeof (DataTemplate), typeof (PanoramaItem), (PropertyMetadata) null);
    public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register(nameof (Orientation), typeof (Orientation), typeof (PanoramaItem), new PropertyMetadata((object) Orientation.Vertical, new PropertyChangedCallback(PanoramaItem.OnOrientationChanged)));

    internal int StartPosition { get; set; }

    internal int ItemWidth { get; set; }

    public PanoramaItem()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_STARTUP, PerfLog.PanoramaItem);
      this.DefaultStyleKey = (object) typeof (PanoramaItem);
      this.SetAutomaticBitmapCache();
      this.EnsureHasTranslateTransform();
      this.Loaded += new RoutedEventHandler(this.PanoramaItem_Loaded);
    }

    internal void EnsureHasTranslateTransform()
    {
      if (this.RenderTransform is TranslateTransform)
        return;
      this.RenderTransform = (Transform) new TranslateTransform();
    }

    private void PanoramaItem_Loaded(object sender, RoutedEventArgs e)
    {
      this.Loaded -= new RoutedEventHandler(this.PanoramaItem_Loaded);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_STARTUP, PerfLog.PanoramaItem);
    }

    public object Header
    {
      get => this.GetValue(PanoramaItem.HeaderProperty);
      set => this.SetValue(PanoramaItem.HeaderProperty, value);
    }

    public DataTemplate HeaderTemplate
    {
      get => (DataTemplate) this.GetValue(PanoramaItem.HeaderTemplateProperty);
      set => this.SetValue(PanoramaItem.HeaderTemplateProperty, (DependencyObject) value);
    }

    public Orientation Orientation
    {
      get => (Orientation) this.GetValue(PanoramaItem.OrientationProperty);
      set => this.SetValue(PanoramaItem.OrientationProperty, (Enum) value);
    }

    protected override Size MeasureOverride(Size availableSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_MEASURE, PerfLog.PanoramaItem);
      Size size = base.MeasureOverride(availableSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_MEASURE, PerfLog.PanoramaItem);
      return size;
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_ARRANGE, PerfLog.PanoramaItem);
      Size size = base.ArrangeOverride(finalSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_ARRANGE, PerfLog.PanoramaItem);
      return size;
    }

    protected override AutomationPeer OnCreateAutomationPeer()
    {
      ItemsControlAutomationPeer itemsControlAutomationPeer = (ItemsControlAutomationPeer) null;
      ItemsControl itemsControl = ItemsControl.ItemsControlFromItemContainer((DependencyObject) this);
      if (itemsControl != null)
        itemsControlAutomationPeer = itemsControl.GetOrCreateAutomationPeer() as ItemsControlAutomationPeer;
      return (AutomationPeer) new PanoramaItemAutomationPeer(this, itemsControlAutomationPeer);
    }

    private static void OnOrientationChanged(
      DependencyObject obj,
      DependencyPropertyChangedEventArgs args)
    {
      PanoramaItem panoramaItem = (PanoramaItem) obj;
      panoramaItem.InvalidateMeasure();
      if (!(VisualTreeHelper.GetParent((DependencyObject) panoramaItem) is FrameworkElement parent))
        return;
      parent.InvalidateMeasure();
    }
  }
}
