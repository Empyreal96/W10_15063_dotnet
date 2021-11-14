// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Panorama
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Automation.Peers;
using Microsoft.Phone.Controls.Primitives;
using MS.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Microsoft.Phone.Controls
{
  [TemplatePart(Name = "BackgroundLayer", Type = typeof (PanningLayer))]
  [TemplatePart(Name = "TitleLayer", Type = typeof (PanningLayer))]
  [TemplatePart(Name = "ItemsLayer", Type = typeof (PanningLayer))]
  [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof (PanoramaItem))]
  public class Panorama : ItemsControl
  {
    internal const int Spacing = 48;
    private const string BackgroundLayerElement = "BackgroundLayer";
    private const string TitleLayerElement = "TitleLayer";
    private const string ItemsLayerElement = "ItemsLayer";
    internal static readonly Duration Immediately = new Duration(TimeSpan.Zero);
    private static readonly Duration DefaultDuration = new Duration(TimeSpan.FromMilliseconds(800.0));
    private static readonly Duration FlickDuration = Panorama.DefaultDuration;
    private static readonly Duration SnapDuration = Panorama.DefaultDuration;
    private static readonly Duration PanDuration = new Duration(TimeSpan.FromMilliseconds(150.0));
    private const double EntranceProjectionCenterOfRotationX = -0.1;
    private int _itemsWidth;
    private int _viewportWidth;
    private int _cumulativeDragDelta;
    private int _flickDirection;
    private int _targetOffset;
    private int _initialTargetOffset;
    private bool _dragged;
    private bool _updateBackgroundPending = true;
    private bool _entranceAnimationPlayed;
    private PanningLayer _panningBackground;
    private PanningLayer _panningTitle;
    private PanningLayer _panningItems;
    private bool _adjustSelectedRequested;
    private bool _suppressSelectionChangedEvent;
    private bool _loaded;
    private FlipperButton _leftFlipper;
    private FlipperButton _rightFlipper;
    private float previousBackgroundWidth;
    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof (Title), typeof (object), typeof (Panorama), (PropertyMetadata) null);
    public static readonly DependencyProperty TitleTemplateProperty = DependencyProperty.Register(nameof (TitleTemplate), typeof (DataTemplate), typeof (Panorama), (PropertyMetadata) null);
    public static readonly DependencyProperty HeaderTemplateProperty = DependencyProperty.Register(nameof (HeaderTemplate), typeof (DataTemplate), typeof (Panorama), (PropertyMetadata) null);
    public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register(nameof (SelectedItem), typeof (object), typeof (Panorama), new PropertyMetadata((object) null, new PropertyChangedCallback(Panorama.OnSelectionChanged)));
    public static readonly DependencyProperty SelectedIndexProperty = DependencyProperty.Register(nameof (SelectedIndex), typeof (int), typeof (Panorama), new PropertyMetadata((object) -1));
    public static readonly DependencyProperty DefaultItemProperty = DependencyProperty.Register(nameof (DefaultItem), typeof (object), typeof (Panorama), new PropertyMetadata((object) null, new PropertyChangedCallback(Panorama.OnDefaultItemChanged)));
    private static readonly DependencyProperty BackgroundShadowProperty = DependencyProperty.Register("BackgroundShadow", typeof (Brush), typeof (Panorama), new PropertyMetadata((object) null, new PropertyChangedCallback(Panorama.OnBackgroundShadowChanged)));
    private readonly Dictionary<object, PanoramaItem> _itemToContainer = new Dictionary<object, PanoramaItem>();
    private readonly Dictionary<PanoramaItem, object> _containerToItem = new Dictionary<PanoramaItem, object>();
    [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Justification = "This is correct use of DependencyProperty.")]
    public static readonly DependencyProperty ItemContainerStyleProperty = DependencyProperty.Register(nameof (ItemContainerStyle), typeof (Style), typeof (Panorama), (PropertyMetadata) null);
    private Panorama.DragLock _dragLock;
    private bool _dragging;
    private WeakReference _gestureSource;
    private Point _gestureOrigin;
    [SecurityCritical]
    private IntPtr _directManipulationControl;
    private bool _isHandlingDirectManipulation;
    private bool _manipulationStarted;

    internal PanoramaPanel Panel { get; set; }

    internal int ActualOffset
    {
      get
      {
        int num = 0;
        if (this._panningItems != null)
          num = (int) this._panningItems.ActualOffset;
        return num;
      }
    }

    internal int ItemsWidth
    {
      get => this._itemsWidth;
      set
      {
        int itemsWidth = this._itemsWidth;
        this._itemsWidth = value;
        this.DirectManipulationSetItemsWidth(value);
        if (!AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged) || !(this.GetOrCreateAutomationPeer() is PanoramaAutomationPeer automationPeer))
          return;
        automationPeer.RaiseScrollPropertyChangedEvents(this.ViewportWidth, itemsWidth);
      }
    }

    internal int ViewportWidth
    {
      get => this._viewportWidth;
      private set
      {
        int viewportWidth = this._viewportWidth;
        this._viewportWidth = value;
        this.DirectManipulationSetViewportWidth(value);
        if (!AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged) || !(this.GetOrCreateAutomationPeer() is PanoramaAutomationPeer automationPeer))
          return;
        automationPeer.RaiseScrollPropertyChangedEvents(viewportWidth, this.ItemsWidth);
      }
    }

    internal int ViewportHeight { get; private set; }

    internal int AdjustedViewportWidth => Math.Max(0, this.ViewportWidth - 48);

    public event EventHandler<SelectionChangedEventArgs> SelectionChanged;

    public object Title
    {
      get => this.GetValue(Panorama.TitleProperty);
      set => this.SetValue(Panorama.TitleProperty, value);
    }

    public DataTemplate TitleTemplate
    {
      get => (DataTemplate) this.GetValue(Panorama.TitleTemplateProperty);
      set => this.SetValue(Panorama.TitleTemplateProperty, (DependencyObject) value);
    }

    public DataTemplate HeaderTemplate
    {
      get => (DataTemplate) this.GetValue(Panorama.HeaderTemplateProperty);
      set => this.SetValue(Panorama.HeaderTemplateProperty, (DependencyObject) value);
    }

    public object SelectedItem
    {
      get => this.GetValue(Panorama.SelectedItemProperty);
      private set => this.SetValue(Panorama.SelectedItemProperty, value);
    }

    public int SelectedIndex
    {
      get => (int) this.GetValue(Panorama.SelectedIndexProperty);
      private set => this.SetValue(Panorama.SelectedIndexProperty, value);
    }

    public object DefaultItem
    {
      get => this.GetValue(Panorama.DefaultItemProperty);
      set
      {
        this.SetValue(Panorama.DefaultItemProperty, value);
        this.OnDefaultItemSet();
      }
    }

    internal PanningLayer PanningTitle => this._panningTitle;

    internal PanoramaItem GetDefaultItemContainer() => this.GetContainer(this.DefaultItem);

    public Panorama()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_STARTUP, PerfLog.Panorama);
      this.DefaultStyleKey = (object) typeof (Panorama);
      this.SetAutomaticBitmapCache();
      this.AllowSetManipulationRouting(false);
      this.ManipulationStarted += new EventHandler<ManipulationStartedEventArgs>(this.OnManipulationStarted);
      this.ManipulationDelta += new EventHandler<ManipulationDeltaEventArgs>(this.OnManipulationDelta);
      this.ManipulationCompleted += new EventHandler<ManipulationCompletedEventArgs>(this.OnManipulationCompleted);
      this.SizeChanged += new SizeChangedEventHandler(this.OnSizeChanged);
      this.PanoramaSelectedIndexChanged += new EventHandler(this.OnPanoramaSelectedIndexChanged);
      if (DesignerProperties.IsInDesignTool)
      {
        this.Loaded += new RoutedEventHandler(this.OnLoaded);
        this.Unloaded += new RoutedEventHandler(this.OnUnloaded);
      }
      this.Loaded += new RoutedEventHandler(this.Panorama_Loaded);
    }

    private void Panorama_Loaded(object sender, RoutedEventArgs e)
    {
      this.Loaded -= new RoutedEventHandler(this.Panorama_Loaded);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_STARTUP, PerfLog.Panorama);
    }

    private void OnLoaded(object sender, RoutedEventArgs e) => this._loaded = true;

    private void OnUnloaded(object sender, RoutedEventArgs e) => this._loaded = false;

    public override void OnApplyTemplate()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_APPLYTEMPLATE, PerfLog.Panorama);
      base.OnApplyTemplate();
      if (this._panningBackground != null)
        this._panningBackground.Owner = (Panorama) null;
      if (this._panningTitle != null)
        this._panningTitle.Owner = (Panorama) null;
      if (this._panningItems != null)
        this._panningItems.Owner = (Panorama) null;
      this._panningBackground = this.GetTemplateChild("BackgroundLayer") as PanningLayer;
      this._panningTitle = this.GetTemplateChild("TitleLayer") as PanningLayer;
      this._panningItems = this.GetTemplateChild("ItemsLayer") as PanningLayer;
      if (this._panningBackground != null)
        this._panningBackground.Owner = this;
      if (this._panningTitle != null)
        this._panningTitle.Owner = this;
      if (this._panningItems != null)
        this._panningItems.Owner = this;
      this.SetBinding(Panorama.BackgroundShadowProperty, new Binding("Background")
      {
        RelativeSource = new RelativeSource(RelativeSourceMode.Self)
      });
      this.CreateDirectManipulationControl();
      if (!DesignerProperties.IsInDesignTool && !this._entranceAnimationPlayed)
      {
        this.PlayEntranceAnimation();
        this._entranceAnimationPlayed = true;
      }
      if (FlipperButton.ShouldShowFlippers)
        this.ApplyFlippers();
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_APPLYTEMPLATE, PerfLog.Panorama);
    }

    private void ApplyFlippers()
    {
      this.RemoveFlipperFromTree(this._leftFlipper);
      this.RemoveFlipperFromTree(this._rightFlipper);
      this._leftFlipper = (FlipperButton) null;
      this._rightFlipper = (FlipperButton) null;
      if (this._panningTitle == null || !(VisualTreeHelper.GetParent((DependencyObject) this._panningTitle) is Grid parent))
        return;
      this._leftFlipper = new FlipperButton();
      this._leftFlipper.HorizontalAlignment = HorizontalAlignment.Left;
      this._leftFlipper.Content = (object) "\uE0E2";
      this._leftFlipper.ApplyTemplate();
      this._leftFlipper.Click += new RoutedEventHandler(this.OnFlipperButtonClick);
      parent.Children.Add((UIElement) this._leftFlipper);
      this._rightFlipper = new FlipperButton();
      this._rightFlipper.HorizontalAlignment = HorizontalAlignment.Left;
      this._rightFlipper.Content = (object) "\uE0E3";
      this._rightFlipper.ApplyTemplate();
      this._rightFlipper.Click += new RoutedEventHandler(this.OnFlipperButtonClick);
      parent.Children.Add((UIElement) this._rightFlipper);
    }

    private void RemoveFlipperFromTree(FlipperButton elementToRemove)
    {
      if (elementToRemove == null)
        return;
      elementToRemove.RemoveFromTree();
      elementToRemove.Click -= new RoutedEventHandler(this.OnFlipperButtonClick);
    }

    private void OnFlipperButtonClick(object sender, RoutedEventArgs args)
    {
      if (sender == this._leftFlipper)
      {
        int index = this.SelectedIndex - 1;
        if (index < 0)
          index = this.Items.Count - 1;
        this.DefaultItem = this.Items[index];
      }
      if (sender != this._rightFlipper)
        return;
      this.DefaultItem = this.Items[(this.SelectedIndex + 1) % this.Items.Count];
    }

    protected override Size MeasureOverride(Size availableSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_MEASURE, PerfLog.Panorama);
      if (Application.Current.Host.Content.ActualWidth > 0.0)
      {
        this.ViewportWidth = !double.IsInfinity(availableSize.Width) ? (int) availableSize.Width : (int) Application.Current.Host.Content.ActualWidth;
        this.ViewportHeight = !double.IsInfinity(availableSize.Height) ? (int) availableSize.Height : (int) Application.Current.Host.Content.ActualHeight;
      }
      else
      {
        this.ViewportWidth = (int) Math.Min(availableSize.Width, 480.0);
        this.ViewportHeight = (int) Math.Min(availableSize.Height, 800.0);
      }
      base.MeasureOverride(new Size(double.PositiveInfinity, (double) this.ViewportHeight));
      if (double.IsInfinity(availableSize.Width))
        availableSize.Width = (double) this.ViewportWidth;
      if (double.IsInfinity(availableSize.Height))
        availableSize.Height = (double) this.ViewportHeight;
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_MEASURE, PerfLog.Panorama);
      return availableSize;
    }

    protected override AutomationPeer OnCreateAutomationPeer() => (AutomationPeer) new PanoramaAutomationPeer(this);

    internal bool ShouldAllowWraparound => this.Panel != null && this.Panel.VisibleChildren != null && this.Panel.VisibleChildren.Count > 1;

    protected virtual void OnItemsChanged(NotifyCollectionChangedEventArgs e)
    {
      base.OnItemsChanged(e);
      this.RequestAdjustSelection();
    }

    internal void RequestAdjustSelection()
    {
      if (this._adjustSelectedRequested)
        return;
      this.LayoutUpdated += new EventHandler(this.LayoutUpdatedAdjustSelection);
      this._adjustSelectedRequested = true;
    }

    private void LayoutUpdatedAdjustSelection(object sender, EventArgs e)
    {
      this._adjustSelectedRequested = false;
      this.LayoutUpdated -= new EventHandler(this.LayoutUpdatedAdjustSelection);
      this.AdjustSelection();
    }

    private void AdjustSelection()
    {
      if (DesignerProperties.IsInDesignTool)
      {
        if (!this._loaded)
          return;
        this._targetOffset = 0;
        this.GoTo(this._targetOffset, Panorama.Immediately);
      }
      else
      {
        object selectedItem1 = this.SelectedItem;
        object selectedItem2 = (object) null;
        bool flag = false;
        if (this.Panel != null && this.Panel.VisibleChildren.Count > 0)
        {
          if (selectedItem1 == null)
          {
            selectedItem2 = this.GetItem(this.Panel.VisibleChildren[0]);
          }
          else
          {
            PanoramaItem container = this.GetContainer(selectedItem1);
            flag = this._entranceAnimationPlayed;
            selectedItem2 = container == null || !this.Panel.VisibleChildren.Contains(container) ? this.GetItem(this.Panel.VisibleChildren[0]) : selectedItem1;
          }
        }
        else
        {
          this._targetOffset = 0;
          this.GoTo(this._targetOffset, Panorama.Immediately);
        }
        if (false)
          this.SelectedItem = selectedItem2;
        else
          this.SetSelectionInternal(selectedItem2);
        if (!flag)
          return;
        PanoramaItem container1 = this.GetContainer(selectedItem2);
        if (container1 == null)
          return;
        this._targetOffset = -container1.StartPosition;
        this.GoTo(this._targetOffset, Panorama.Immediately);
      }
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_ARRANGE, PerfLog.Panorama);
      finalSize.Width = this.DesiredSize.Width;
      base.ArrangeOverride(finalSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_ARRANGE, PerfLog.Panorama);
      return finalSize;
    }

    protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
    {
      this.ApplyItemContainerStyle(element);
      base.PrepareContainerForItemOverride(element, item);
      this._itemToContainer[item] = (PanoramaItem) element;
      this._containerToItem[(PanoramaItem) element] = item;
      if (!(element is PanoramaItem panoramaItem))
        return;
      if (panoramaItem.Content == null && panoramaItem != item)
        panoramaItem.Content = item;
      if (panoramaItem.HeaderTemplate == null && element.ReadLocalValue(PanoramaItem.HeaderTemplateProperty) == DependencyProperty.UnsetValue)
        panoramaItem.HeaderTemplate = this.HeaderTemplate;
      if (panoramaItem.Header != null || item is UIElement || panoramaItem.ReadLocalValue(PanoramaItem.HeaderProperty) != DependencyProperty.UnsetValue)
        return;
      panoramaItem.Header = item;
    }

    public Style ItemContainerStyle
    {
      get => this.GetValue(Panorama.ItemContainerStyleProperty) as Style;
      set => this.SetValue(Panorama.ItemContainerStyleProperty, (DependencyObject) value);
    }

    protected override bool IsItemItsOwnContainerOverride(object item) => item is PanoramaItem;

    protected override DependencyObject GetContainerForItemOverride()
    {
      PanoramaItem panoramaItem = new PanoramaItem();
      this.ApplyItemContainerStyle((DependencyObject) panoramaItem);
      return (DependencyObject) panoramaItem;
    }

    protected override void ClearContainerForItemOverride(DependencyObject element, object item)
    {
      base.ClearContainerForItemOverride(element, item);
      this._itemToContainer.Remove(item);
      this._containerToItem.Remove((PanoramaItem) element);
    }

    protected virtual void ApplyItemContainerStyle(DependencyObject container)
    {
      if (!(container is PanoramaItem panoramaItem) || panoramaItem.ReadLocalValue(FrameworkElement.StyleProperty) != DependencyProperty.UnsetValue)
        return;
      Style itemContainerStyle = this.ItemContainerStyle;
      if (itemContainerStyle != null)
        panoramaItem.Style = itemContainerStyle;
      else
        panoramaItem.ClearValue(FrameworkElement.StyleProperty);
    }

    protected object GetItem(PanoramaItem container)
    {
      object obj = (object) null;
      if (container != null)
        this._containerToItem.TryGetValue(container, out obj);
      return obj;
    }

    protected PanoramaItem GetContainer(object item)
    {
      PanoramaItem panoramaItem = (PanoramaItem) null;
      if (item != null)
        this._itemToContainer.TryGetValue(item, out panoramaItem);
      return panoramaItem;
    }

    private void ReleaseMouseCaptureAtGestureOrigin()
    {
      if (this._gestureSource == null || !(this._gestureSource.Target is FrameworkElement target))
        return;
      foreach (UIElement inHostCoordinate in VisualTreeHelper.FindElementsInHostCoordinates(target.TransformToVisual((UIElement) null).Transform(this._gestureOrigin), Application.Current.RootVisual))
        inHostCoordinate.ReleaseMouseCapture();
    }

    private static double AngleFromVector(double x, double y)
    {
      double num = Math.Atan2(y, x);
      if (num < 0.0)
        num = 2.0 * Math.PI + num;
      return num * 360.0 / (2.0 * Math.PI);
    }

    [SecuritySafeCritical]
    private void CreateDirectManipulationControl() => XcpImports.ItemsControl_CreatePanoramaDirectManipulationControl((ItemsControl) this, ref this._directManipulationControl);

    [SecuritySafeCritical]
    private void SetDirectManipulationHandled(ManipulationDeltaEventArgs args, out bool handled) => XcpImports.ItemsControl_SetDirectManipulationHandled((ItemsControl) this, args, ref handled);

    [SecuritySafeCritical]
    private void DirectManipulationSetViewportWidth(int width)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetViewportWidth(this._directManipulationControl, width);
    }

    [SecuritySafeCritical]
    private void DirectManipulationSetItemsWidth(int width)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetItemsWidth(this._directManipulationControl, width);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetItemsLayerWidth(float width)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetItemsLayerWidth(this._directManipulationControl, width);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetTitleLayerWidth(float width)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetTitleLayerWidth(this._directManipulationControl, width);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetBackgroundLayerWidth(float width)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetBackgroundLayerWidth(this._directManipulationControl, width);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetItemsLayerTarget(UIElement target)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetItemsLayerTarget(this._directManipulationControl, target);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetTitleLayerTarget(UIElement target)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetTitleLayerTarget(this._directManipulationControl, target);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetBackgroundLayerTarget(
      UIElement target,
      UIElement leftWraparound)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetBackgroundLayerTarget(this._directManipulationControl, target, leftWraparound);
    }

    [SecuritySafeCritical]
    private void DirectManipulationSetBackgroundLayerIsStatic(bool isStatic)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_SetBackgroundLayerIsStatic(this._directManipulationControl, isStatic);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetPanoramaItems(PanoramaItemNative[] items)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      IntPtr manipulationControl = this._directManipulationControl;
      PanoramaItemNative[] panoramaItemNativeArray = items;
      int num = panoramaItemNativeArray != null ? items.Length : 0;
      XcpImports.Panorama_SetPanoramaItems(manipulationControl, panoramaItemNativeArray, num);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetItemStops(PanoramaItemStopNative[] stops)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      IntPtr manipulationControl = this._directManipulationControl;
      PanoramaItemStopNative[] panoramaItemStopNativeArray = stops;
      int num = panoramaItemStopNativeArray != null ? stops.Length : 0;
      XcpImports.Panorama_SetItemStops(manipulationControl, panoramaItemStopNativeArray, num);
    }

    [SecuritySafeCritical]
    private void DirectManipulationAnimateTo(float offset, float duration, int direction)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_AnimateTo(this._directManipulationControl, offset, duration, direction);
    }

    [SecuritySafeCritical]
    private void PlayEntranceAnimation()
    {
      if (!(this.Projection is PlaneProjection))
        this.Projection = (Projection) new PlaneProjection()
        {
          CenterOfRotationX = -0.1
        };
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Panorama_PlayEntranceAnimation(this._directManipulationControl);
    }

    private void OnManipulationStarted(object sender, ManipulationStartedEventArgs e)
    {
      this._gestureSource = new WeakReference((object) e.ManipulationContainer);
      this._gestureOrigin = e.ManipulationOrigin;
      this._dragLock = Panorama.DragLock.Unset;
      this._dragging = false;
      this._manipulationStarted = true;
      this._initialTargetOffset = this._targetOffset = this._panningItems != null ? (int) this._panningItems.ActualOffset : 0;
      this._flickDirection = 0;
      this._cumulativeDragDelta = 0;
      this._dragged = false;
    }

    private void OnManipulationDelta(object sender, ManipulationDeltaEventArgs e)
    {
      if (!this._manipulationStarted)
        return;
      if (!this._dragging)
        this.ReleaseMouseCaptureAtGestureOrigin();
      this._dragging = true;
      if (this._dragLock == Panorama.DragLock.Unset)
      {
        double num = Panorama.AngleFromVector(e.CumulativeManipulation.Translation.X, e.CumulativeManipulation.Translation.Y) % 180.0;
        this._dragLock = num <= 45.0 || num >= 135.0 ? Panorama.DragLock.Horizontal : (num <= 45.0 || num >= 135.0 ? Panorama.DragLock.Free : Panorama.DragLock.Vertical);
      }
      if (this._dragLock != Panorama.DragLock.Horizontal)
        return;
      e.Handled = true;
      if (e.DeltaManipulation.Translation.X == 0.0 || this._flickDirection != 0)
        return;
      this._cumulativeDragDelta = (int) e.CumulativeManipulation.Translation.X;
      this._targetOffset += (int) e.DeltaManipulation.Translation.X;
      if (Math.Abs(this._cumulativeDragDelta) > this.ViewportWidth)
        return;
      this._dragged = true;
      bool handled;
      this.SetDirectManipulationHandled(e, out handled);
      if (handled)
      {
        this._isHandlingDirectManipulation = true;
        this._manipulationStarted = false;
      }
      else
        this.GoTo(this.CoerceTargetOffset(this._targetOffset), Panorama.PanDuration);
    }

    private int CoerceTargetOffset(int targetOffset)
    {
      int num = targetOffset;
      if (!this.ShouldAllowWraparound && this.Panel != null)
        num = this.Panel.CoerceTargetOffset(targetOffset);
      return num;
    }

    private void OnManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
    {
      this._dragLock = Panorama.DragLock.Unset;
      this._dragging = false;
      if (e.IsInertial)
      {
        double num = Panorama.AngleFromVector(e.FinalVelocities.LinearVelocity.X, e.FinalVelocities.LinearVelocity.Y);
        if (num <= 45.0 || num >= 315.0)
          num = 0.0;
        else if (num >= 135.0 && num <= 225.0)
          num = 180.0;
        this.ReleaseMouseCaptureAtGestureOrigin();
        if (num == 180.0)
          this._flickDirection = -1;
        else if (num == 0.0)
          this._flickDirection = 1;
      }
      if (!this._isHandlingDirectManipulation)
      {
        if (!this._manipulationStarted)
          return;
        this._manipulationStarted = false;
        if (this._flickDirection == 0)
        {
          if (!this._dragged)
            return;
          this._cumulativeDragDelta = (int) e.TotalManipulation.Translation.X;
          this._targetOffset = this._initialTargetOffset + this._cumulativeDragDelta;
          this._initialTargetOffset = 0;
          int direction = Math.Sign(this._cumulativeDragDelta);
          if (this.Panel == null)
            return;
          e.Handled = true;
          int snapTo;
          PanoramaItem newSelection;
          bool wraparound;
          this.Panel.GetSnapOffset(this._targetOffset, this.ViewportWidth, direction, out snapTo, out newSelection, out wraparound);
          if (wraparound)
          {
            if (!this.ShouldAllowWraparound)
              return;
            this.WrapAround(direction);
          }
          object obj = this.GetItem(newSelection);
          if (obj != null)
            this.SelectedItem = obj;
          this.GoTo(snapTo, Panorama.SnapDuration, wraparound ? direction : 0);
        }
        else
        {
          this.ProcessFlick();
          e.Handled = true;
        }
      }
      else
      {
        this._isHandlingDirectManipulation = false;
        this._manipulationStarted = false;
        e.Handled = true;
      }
    }

    private void ProcessFlick()
    {
      if (this._flickDirection == 0)
        return;
      int offset = this._panningItems != null ? (int) this._panningItems.ActualOffset : 0;
      if (this.Panel == null)
        return;
      PanoramaPanel.ItemStop previous;
      PanoramaPanel.ItemStop current;
      PanoramaPanel.ItemStop next;
      this.Panel.GetStops(offset, this.ItemsWidth, out previous, out current, out next);
      if (previous == current && current == next && next == null)
        return;
      this._targetOffset = this._flickDirection < 0 ? -next.Position : -previous.Position;
      bool flag = Math.Sign(this._targetOffset - (this._panningItems != null ? (int) this._panningItems.ActualOffset : 0)) != Math.Sign(this._flickDirection);
      if (flag)
      {
        if (!this.ShouldAllowWraparound)
          return;
        this.WrapAround(Math.Sign(this._flickDirection));
      }
      this.SelectedItem = this.GetItem(this._flickDirection < 0 ? next.Item : previous.Item);
      this.GoTo(this._targetOffset, Panorama.FlickDuration, flag ? this._flickDirection : 0);
    }

    private void GoTo(int offset, Duration duration, int direction)
    {
      if (this._panningBackground != null)
        this._panningBackground.GoTo(offset, duration);
      if (this._panningTitle != null)
        this._panningTitle.GoTo(offset, duration);
      if (this._panningItems != null)
        this._panningItems.GoTo(offset, duration);
      this.DirectManipulationAnimateTo((float) offset, (float) duration.TimeSpan.TotalSeconds, direction);
    }

    private void GoTo(int offset, Duration duration) => this.GoTo(offset, duration, 0);

    internal void GoTo(int offset) => this.GoTo(offset, Panorama.Immediately);

    internal void AutomationSetScrollPercent(double percent)
    {
      int snapTo;
      this.Panel.GetSnapOffset(-(int) (percent * (double) (this.ItemsWidth - this.AdjustedViewportWidth) / 100.0), this.ViewportWidth, 1, out snapTo, out PanoramaItem _, out bool _);
      this.GoTo(snapTo);
    }

    private void WrapAround(int direction)
    {
      if (this._panningBackground != null)
        this._panningBackground.Wraparound(direction);
      if (this._panningTitle != null)
        this._panningTitle.Wraparound(direction);
      if (this._panningItems == null)
        return;
      this._panningItems.Wraparound(direction);
    }

    private void SetSelectionInternal(object selectedItem)
    {
      this._suppressSelectionChangedEvent = true;
      this.SelectedItem = selectedItem;
      this._suppressSelectionChangedEvent = false;
    }

    private void OnPanoramaSelectedIndexChanged(object sender, EventArgs e)
    {
      if (this.Panel == null)
        return;
      object obj;
      if (Microsoft.Phone.QuirksMode.ShouldPanoramaSelectOnlyValidItems())
      {
        PanoramaItem visibleChild = this.Panel.VisibleChildren[this.PanoramaSelectedIndex];
        obj = !this.Items.Contains((object) visibleChild) ? this.GetItem(visibleChild) : (object) visibleChild;
      }
      else
        obj = (object) this.Panel.VisibleChildren[this.PanoramaSelectedIndex];
      if (obj == this.SelectedItem)
        return;
      this.SelectedItem = obj;
      if (this._panningItems == null)
        return;
      this._panningItems.Refresh();
    }

    private static void OnSelectionChanged(
      DependencyObject obj,
      DependencyPropertyChangedEventArgs args)
    {
      if (!(obj is Panorama panorama1))
        return;
      panorama1.ClearFocusOnChild();
      Panorama panorama2 = panorama1;
      panorama2.SelectedIndex = panorama2.Items.IndexOf(args.NewValue);
      if (panorama1._suppressSelectionChangedEvent || !panorama1.Items.Contains(args.NewValue))
        return;
      SafeRaise.Raise<SelectionChangedEventArgs>(panorama1.SelectionChanged, (object) panorama1, (SafeRaise.GetEventArgs<SelectionChangedEventArgs>) (() =>
      {
        object[] objArray1;
        if (args.OldValue != null)
          objArray1 = new object[1]{ args.OldValue };
        else
          objArray1 = new object[0];
        object[] objArray2;
        if (args.NewValue != null)
          objArray2 = new object[1]{ args.NewValue };
        else
          objArray2 = new object[0];
        return new SelectionChangedEventArgs((IList) objArray1, (IList) objArray2);
      }));
      if (AutomationPeer.ListenerExists(AutomationEvents.SelectionItemPatternOnElementSelected))
      {
        PanoramaAutomationPeer automationPeer = panorama1.GetOrCreateAutomationPeer() as PanoramaAutomationPeer;
        PanoramaItem container = panorama1.GetContainer(args.NewValue);
        if (automationPeer != null && container != null)
          automationPeer.RaiseSelectionChangedEvent(container);
      }
      if (!AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged))
        return;
      PanoramaAutomationPeer automationPeer1 = panorama1.GetOrCreateAutomationPeer() as PanoramaAutomationPeer;
      PanoramaItem container1 = panorama1.GetContainer(args.NewValue);
      PanoramaItem container2 = panorama1.GetContainer(args.OldValue);
      automationPeer1?.RaiseSelectionPropertyChangedEvents(container2, container1);
    }

    private static void OnDefaultItemChanged(
      DependencyObject obj,
      DependencyPropertyChangedEventArgs args)
    {
      ((Panorama) obj).OnDefaultItemSet();
    }

    private void OnDefaultItemSet()
    {
      if (this.Panel == null)
        return;
      this.Panel.NotifyDefaultItemChanged();
      if (this.Panel.VisibleChildren.Count > 0)
        this.SelectedItem = this.DefaultItem;
      if (this._panningItems != null)
        this._panningItems.Refresh();
      this.GoTo(0, Panorama.Immediately);
    }

    private static void OnBackgroundShadowChanged(
      DependencyObject obj,
      DependencyPropertyChangedEventArgs args)
    {
      Panorama panorama = (Panorama) obj;
      if (panorama._updateBackgroundPending)
        return;
      panorama.UpdateBackground();
    }

    private void UpdateBackground()
    {
      if (this._panningBackground == null)
        return;
      this._updateBackgroundPending = false;
      this._panningBackground.ContentPresenter.Height = (double) this.ViewportHeight;
      if (this.Background is SolidColorBrush)
      {
        this._panningBackground.ContentPresenter.Width = (double) this.ViewportWidth;
        this._panningBackground.IsStatic = true;
      }
      else if (this.Background is GradientBrush)
      {
        this._panningBackground.ContentPresenter.Width = (double) Math.Max(this.ItemsWidth, this.ViewportWidth);
        this._panningBackground.IsStatic = this._panningBackground.ContentPresenter.Width == (double) this.ViewportWidth;
      }
      else if (this.Background is ImageBrush)
      {
        BitmapImage bmp = ((ImageBrush) this.Background).ImageSource as BitmapImage;
        if (this._panningBackground.ContentPresenter != null && bmp != null)
        {
          if (bmp.PixelWidth == 0)
          {
            bmp.ImageOpened -= new EventHandler<RoutedEventArgs>(this.OnBackgroundImageOpened);
            bmp.ImageOpened += new EventHandler<RoutedEventArgs>(this.OnBackgroundImageOpened);
            this.Dispatcher.BeginInvoke((Action) (() => this.AsyncUpdateBackground(bmp)));
          }
          this._panningBackground.ContentPresenter.Width = (double) bmp.PixelWidth;
          this.previousBackgroundWidth = (float) bmp.PixelWidth;
        }
        this._panningBackground.IsStatic = false;
      }
      this._panningBackground.Refresh();
      this.DirectManipulationSetBackgroundLayerIsStatic(this._panningBackground.IsStatic);
    }

    private void OnBackgroundImageOpened(object sender, RoutedEventArgs e) => this.AsyncUpdateBackground((BitmapImage) sender);

    private void AsyncUpdateBackground(BitmapImage img)
    {
      img.ImageOpened -= new EventHandler<RoutedEventArgs>(this.OnBackgroundImageOpened);
      this.UpdateBackground();
    }

    private new void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
      this.ViewportWidth = (int) e.NewSize.Width;
      this.ViewportHeight = (int) e.NewSize.Height;
      if (this.Panel != null)
        this.ItemsWidth = (int) this.Panel.ActualWidth;
      this.UpdateBackground();
      this.Clip = (Geometry) new RectangleGeometry()
      {
        Rect = new Rect(0.0, 0.0, e.NewSize.Width, e.NewSize.Height)
      };
      if (this._rightFlipper == null)
        return;
      this._rightFlipper.Margin = new Thickness(this.ActualWidth - 18.0, 0.0, 0.0, 0.0);
    }

    private enum DragLock
    {
      Unset,
      Free,
      Vertical,
      Horizontal,
    }
  }
}
