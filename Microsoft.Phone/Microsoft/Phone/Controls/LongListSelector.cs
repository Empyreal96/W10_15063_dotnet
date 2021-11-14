// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.LongListSelector
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Automation.Peers;
using Microsoft.Phone.Controls.Properties;
using MS.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Security;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  [StyleTypedProperty(Property = "JumpListStyle", StyleTargetType = typeof (LongListSelector))]
  [TemplatePart(Name = "VerticalScrollBar", Type = typeof (ScrollBar))]
  [TemplateVisualState(GroupName = "ScrollStates", Name = "Scrolling")]
  [TemplateVisualState(GroupName = "ScrollStates", Name = "NotScrolling")]
  [TemplatePart(Name = "ViewportControl", Type = typeof (ViewportControl))]
  public class LongListSelector : Control, INotifyPropertyChanged
  {
    public static readonly DependencyProperty ListHeaderTemplateProperty = DependencyProperty.Register(nameof (ListHeaderTemplate), typeof (DataTemplate), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnListHeaderTemplateChanged(e))));
    public static readonly DependencyProperty ListHeaderProperty = DependencyProperty.Register(nameof (ListHeader), typeof (object), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnListHeaderChanged(e))));
    public static readonly DependencyProperty ListFooterTemplateProperty = DependencyProperty.Register(nameof (ListFooterTemplate), typeof (DataTemplate), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnListFooterTemplateChanged(e))));
    public static readonly DependencyProperty ListFooterProperty = DependencyProperty.Register(nameof (ListFooter), typeof (object), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnListFooterChanged(e))));
    public static readonly DependencyProperty GroupHeaderTemplateProperty = DependencyProperty.Register(nameof (GroupHeaderTemplate), typeof (DataTemplate), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnGroupHeaderTemplateChanged(e))));
    public static readonly DependencyProperty GroupFooterTemplateProperty = DependencyProperty.Register(nameof (GroupFooterTemplate), typeof (DataTemplate), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnGroupFooterTemplateChanged(e))));
    public static readonly DependencyProperty ItemTemplateProperty = DependencyProperty.Register(nameof (ItemTemplate), typeof (DataTemplate), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnItemTemplateChanged(e))));
    public static readonly DependencyProperty ItemsSourceProperty = DependencyProperty.Register(nameof (ItemsSource), typeof (IList), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnItemsSourceChanged(e))));
    private static DependencyProperty LayoutModeProperty = DependencyProperty.Register(nameof (LayoutMode), typeof (LongListSelectorLayoutMode), typeof (LongListSelector), new PropertyMetadata((object) LongListSelectorLayoutMode.List, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnLayoutModeChanged(e))));
    public static readonly DependencyProperty GridCellSizeProperty = DependencyProperty.Register(nameof (GridCellSize), typeof (Size), typeof (LongListSelector), new PropertyMetadata((object) Size.Empty, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnGridCellSizeChanged(e))));
    public static readonly DependencyProperty HideEmptyGroupsProperty = DependencyProperty.Register(nameof (HideEmptyGroups), typeof (bool), typeof (LongListSelector), new PropertyMetadata((object) false, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnHideEmptyGroupsChanged(e))));
    public static readonly DependencyProperty IsGroupingEnabledProperty = DependencyProperty.Register(nameof (IsGroupingEnabled), typeof (bool), typeof (LongListSelector), new PropertyMetadata((object) false, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnIsGroupingEnabledChanged(e))));
    public static readonly DependencyProperty JumpListStyleProperty = DependencyProperty.Register(nameof (JumpListStyle), typeof (Style), typeof (LongListSelector), new PropertyMetadata((object) null, (PropertyChangedCallback) ((s, e) => ((LongListSelector) s).OnJumpListStyleChanged(e))));
    internal const string ViewportControlName = "ViewportControl";
    internal const string VerticalScrollName = "VerticalScrollBar";
    internal const string HorizontalScrollName = "HorizontalScrollBar";
    internal const string ScrollGroup = "ScrollStates";
    internal const string ScrollingState = "Scrolling";
    internal const string NotScrollingState = "NotScrolling";
    internal const double ScrollLineDelta = 16.0;
    private const int DefaultMaxBufferedHeights = 64;
    private const int MinValue = -8388608;
    private const int MaxValue = 8388352;
    private static readonly Size _measureSize = new Size(double.PositiveInfinity, double.PositiveInfinity);
    private static readonly Rect _zeroRect = new Rect(0.0, 0.0, 0.0, 0.0);
    private double _bufferHeight;
    private double _viewportMoveThreshold;
    private ViewportControl _container;
    private ScrollBar _verticalScroll;
    private ScrollBar _horizontalScroll;
    private Canvas _contentPanel;
    private Canvas _itemsPanel;
    private RectangleGeometry _clipGeometry;
    [SecurityCritical]
    private IntPtr _dmLongListSelector;
    private JumpListController _jumpListController;
    private LongListSelectorCache _cache;
    private LongListSelectorItemCollection _items;
    private Binding[] _templateBindings = new Binding[5];
    private double _topBound = -8388608.0;
    private double _rightBound = 8388352.0;
    private double _bottomBound = 8388352.0;
    private Rect _viewport;
    private IList<LongListSelector.RealizedRange> _realizedRanges = (IList<LongListSelector.RealizedRange>) new List<LongListSelector.RealizedRange>();
    private LinkedList<LongListSelector.RealizedElement> _realizedElements = new LinkedList<LongListSelector.RealizedElement>();
    private IDictionary<object, LongListSelector.RealizedElement> _realizedHeaderGroups = (IDictionary<object, LongListSelector.RealizedElement>) new Dictionary<object, LongListSelector.RealizedElement>();
    private Iterator<LongListSelectorItem> _currentHeaderIterator;
    private LongListSelector.RealizedElement _currentHeaderElement;
    private bool _isCurrentHeaderOrphaned;
    private LongListSelector.RealizedElement _previousHeaderElement;
    private bool _isPreviousHeaderOrphaned;
    private CircularBuffer<double> _itemHeights = new CircularBuffer<double>(64);
    private CircularBuffer<double> _otherElementHeights = new CircularBuffer<double>(64);
    private double _bufferedItemHeights;
    private double _bufferedOtherElementHeights;
    private int _maxBufferedHeights = 64;
    private double _estimatedTop;
    private double _estimatedHeight;
    private IDictionary<LongListSelectorItem, LongListSelector.ItemChangeType> _itemChanges = (IDictionary<LongListSelectorItem, LongListSelector.ItemChangeType>) new Dictionary<LongListSelectorItem, LongListSelector.ItemChangeType>();
    private IDictionary<object, LongListSelector.ItemChangeType> _groupChanges = (IDictionary<object, LongListSelector.ItemChangeType>) new Dictionary<object, LongListSelector.ItemChangeType>();
    private bool _isItemsReset;
    private IDictionary<ContentPresenter, double> _heightChanges = (IDictionary<ContentPresenter, double>) new Dictionary<ContentPresenter, double>();
    private IDictionary<ContentPresenter, double> _ignoreHeightChanges = (IDictionary<ContentPresenter, double>) new Dictionary<ContentPresenter, double>();
    private int _gridColumnsInRow = 1;
    private int _otherElementCount;
    private int _itemRowCount;
    private int _realizedItemRowCount;
    private bool _isBalanceDirty;
    private bool _isAPDirty;
    private Rect _lastBalanceViewport;
    private Rect _lastReportedViewport;
    private object _selectedItem;
    private bool _isBalancing;
    private Action _deferredAction;
    private ContentPresenter _groupHeaderUsedToOpenJumplist;

    public event SelectionChangedEventHandler SelectionChanged;

    public event EventHandler<ItemRealizationEventArgs> ItemRealized;

    public event EventHandler<ItemRealizationEventArgs> ItemUnrealized;

    public event EventHandler JumpListOpening;

    public event EventHandler JumpListClosed;

    public event EventHandler ManipulationStateChanged;

    public event PropertyChangedEventHandler PropertyChanged;

    public DataTemplate ListHeaderTemplate
    {
      get => (DataTemplate) this.GetValue(LongListSelector.ListHeaderTemplateProperty);
      set => this.SetValue(LongListSelector.ListHeaderTemplateProperty, (DependencyObject) value);
    }

    private void OnListHeaderTemplateChanged(DependencyPropertyChangedEventArgs args)
    {
      this.ThrowIfBalancing();
      this.UpdateHasListHeader();
    }

    public object ListHeader
    {
      get => this.GetValue(LongListSelector.ListHeaderProperty);
      set => this.SetValue(LongListSelector.ListHeaderProperty, value);
    }

    private void OnListHeaderChanged(DependencyPropertyChangedEventArgs e)
    {
      this.ThrowIfBalancing();
      this.UpdateHasListHeader();
    }

    public DataTemplate ListFooterTemplate
    {
      get => (DataTemplate) this.GetValue(LongListSelector.ListFooterTemplateProperty);
      set => this.SetValue(LongListSelector.ListFooterTemplateProperty, (DependencyObject) value);
    }

    private void OnListFooterTemplateChanged(DependencyPropertyChangedEventArgs args)
    {
      this.ThrowIfBalancing();
      this.UpdateHasListFooter();
    }

    public object ListFooter
    {
      get => this.GetValue(LongListSelector.ListFooterProperty);
      set => this.SetValue(LongListSelector.ListFooterProperty, value);
    }

    private void OnListFooterChanged(DependencyPropertyChangedEventArgs e)
    {
      this.ThrowIfBalancing();
      this.UpdateHasListFooter();
    }

    public DataTemplate GroupHeaderTemplate
    {
      get => (DataTemplate) this.GetValue(LongListSelector.GroupHeaderTemplateProperty);
      set => this.SetValue(LongListSelector.GroupHeaderTemplateProperty, (DependencyObject) value);
    }

    private void OnGroupHeaderTemplateChanged(DependencyPropertyChangedEventArgs args)
    {
      this.ThrowIfBalancing();
      if (this._items != null)
      {
        bool flag = args.NewValue != null;
        if (flag != this._items.HasGroupHeader)
          this._items.HasGroupHeader = flag;
      }
      this.SetItemsPanelClip();
    }

    public DataTemplate GroupFooterTemplate
    {
      get => (DataTemplate) this.GetValue(LongListSelector.GroupFooterTemplateProperty);
      set => this.SetValue(LongListSelector.GroupFooterTemplateProperty, (DependencyObject) value);
    }

    private void OnGroupFooterTemplateChanged(DependencyPropertyChangedEventArgs args)
    {
      this.ThrowIfBalancing();
      if (this._items == null)
        return;
      bool flag = args.NewValue != null;
      if (flag == this._items.HasGroupFooter)
        return;
      this._items.HasGroupFooter = flag;
    }

    public DataTemplate ItemTemplate
    {
      get => (DataTemplate) this.GetValue(LongListSelector.ItemTemplateProperty);
      set => this.SetValue(LongListSelector.ItemTemplateProperty, (DependencyObject) value);
    }

    private void OnItemTemplateChanged(DependencyPropertyChangedEventArgs e) => this.ThrowIfBalancing();

    public IList ItemsSource
    {
      get => (IList) this.GetValue(LongListSelector.ItemsSourceProperty);
      set => this.SetValue(LongListSelector.ItemsSourceProperty, (object) value);
    }

    private void OnItemsSourceChanged(DependencyPropertyChangedEventArgs e)
    {
      this.ThrowIfBalancing();
      this.Reset();
      if (e.NewValue == null)
        return;
      this.QueueBalance();
    }

    public LongListSelectorLayoutMode LayoutMode
    {
      get => (LongListSelectorLayoutMode) this.GetValue(LongListSelector.LayoutModeProperty);
      set => this.SetValue(LongListSelector.LayoutModeProperty, (Enum) value);
    }

    private void OnLayoutModeChanged(DependencyPropertyChangedEventArgs e)
    {
      this.ThrowIfBalancing();
      if ((LongListSelectorLayoutMode) e.NewValue == LongListSelectorLayoutMode.Grid)
      {
        this._itemHeights.Clear();
        this._bufferedItemHeights = 0.0;
      }
      this.UpdateGridColumns();
      this.ResetRealized(true);
      this.QueueBalance();
    }

    public Size GridCellSize
    {
      get => (Size) this.GetValue(LongListSelector.GridCellSizeProperty);
      set => this.SetValue(LongListSelector.GridCellSizeProperty, (object) value);
    }

    private void OnGridCellSizeChanged(DependencyPropertyChangedEventArgs e)
    {
      this.ThrowIfBalancing();
      if (this.LayoutMode != LongListSelectorLayoutMode.Grid)
        return;
      this.UpdateGridColumns();
      this.ResetRealized(true);
      this.QueueBalance();
    }

    public bool HideEmptyGroups
    {
      get => (bool) this.GetValue(LongListSelector.HideEmptyGroupsProperty);
      set => this.SetValue(LongListSelector.HideEmptyGroupsProperty, value);
    }

    private void OnHideEmptyGroupsChanged(DependencyPropertyChangedEventArgs e)
    {
      this.ThrowIfBalancing();
      if (this._items == null)
        return;
      this._items.IncludeEmptyGroups = !(bool) e.NewValue;
    }

    public bool IsGroupingEnabled
    {
      get => (bool) this.GetValue(LongListSelector.IsGroupingEnabledProperty);
      set => this.SetValue(LongListSelector.IsGroupingEnabledProperty, value);
    }

    private void OnIsGroupingEnabledChanged(DependencyPropertyChangedEventArgs e)
    {
      this.ThrowIfBalancing();
      this.Reset();
      this.QueueBalance();
    }

    public Style JumpListStyle
    {
      get => (Style) this.GetValue(LongListSelector.JumpListStyleProperty);
      set => this.SetValue(LongListSelector.JumpListStyleProperty, (DependencyObject) value);
    }

    private void OnJumpListStyleChanged(DependencyPropertyChangedEventArgs e) => this.ThrowIfBalancing();

    internal double ScrollOffset
    {
      get
      {
        double num = 0.0;
        if (this._container != null)
        {
          Rect rect = this._container.Viewport;
          double top1 = rect.Top;
          rect = this._container.Bounds;
          double top2 = rect.Top;
          num = top1 - top2;
        }
        return num;
      }
      set => this.ScrollToOffset(value);
    }

    internal double ScrollViewport
    {
      get
      {
        double num = 0.0;
        if (this._container != null)
          num = this._container.Viewport.Height;
        return num;
      }
    }

    internal double ScrollExtent
    {
      get
      {
        double num = 0.0;
        if (this._container != null)
          num = this._container.Bounds.Height;
        return num;
      }
    }

    public ManipulationState ManipulationState => this._container == null ? (ManipulationState) 0 : this._container.ManipulationState;

    internal object InitialItem { get; set; }

    public object SelectedItem
    {
      get => this._selectedItem;
      set
      {
        if (this._selectedItem == value)
          return;
        object selectedItem = this._selectedItem;
        this._selectedItem = value;
        SelectionChangedEventHandler selectionChanged = this.SelectionChanged;
        if (selectionChanged != null)
          selectionChanged((object) this, new SelectionChangedEventArgs((IList) new object[1]
          {
            selectedItem
          }, (IList) new object[1]
          {
            this._selectedItem
          }));
        this.FirePropertyChangedEvent(nameof (SelectedItem));
        if (AutomationPeer.ListenerExists(AutomationEvents.SelectionItemPatternOnElementSelected))
        {
          LongListSelectorAutomationPeer automationPeer = this.GetOrCreateAutomationPeer() as LongListSelectorAutomationPeer;
          ContentPresenter containerForSelectedItem = this.AutomationGetContainerForSelectedItem();
          if (automationPeer != null && containerForSelectedItem != null)
            automationPeer.RaiseSelectionChangedEvent(containerForSelectedItem);
        }
        if (!AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged))
          return;
        LongListSelectorAutomationPeer automationPeer1 = this.GetOrCreateAutomationPeer() as LongListSelectorAutomationPeer;
        ContentPresenter containerForSelectedItem1 = this.AutomationGetContainerForSelectedItem();
        if (automationPeer1 == null || containerForSelectedItem1 == null)
          return;
        automationPeer1.RaiseSelectionPropertyChangedEvents(containerForSelectedItem1);
      }
    }

    public LongListSelector()
    {
      this.DefaultStyleKey = (object) typeof (LongListSelector);
      this.AllowSetManipulationRouting(false);
      this._cache = new LongListSelectorCache();
      this._contentPanel = new Canvas();
      this._contentPanel.Background = (Brush) new SolidColorBrush(Colors.Transparent);
      this._clipGeometry = new RectangleGeometry();
      this._clipGeometry.Transform = (Transform) new CompositeTransform();
      this._itemsPanel = new Canvas();
      Canvas.SetZIndex((UIElement) this._itemsPanel, -1);
      this._contentPanel.Children.Add((UIElement) this._itemsPanel);
      this._templateBindings[0] = new Binding(nameof (ListHeaderTemplate))
      {
        Source = (object) this
      };
      this._templateBindings[1] = new Binding(nameof (GroupHeaderTemplate))
      {
        Source = (object) this
      };
      this._templateBindings[2] = new Binding(nameof (ItemTemplate))
      {
        Source = (object) this
      };
      this._templateBindings[3] = new Binding(nameof (GroupFooterTemplate))
      {
        Source = (object) this
      };
      this._templateBindings[4] = new Binding(nameof (ListFooterTemplate))
      {
        Source = (object) this
      };
      this.SizeChanged += new SizeChangedEventHandler(this.OnLongListSelectorSizeChanged);
      this._bufferHeight = Application.Current.Host.Content.ActualHeight;
      this._viewportMoveThreshold = this._bufferHeight / 8.0;
    }

    public void ScrollTo(object item) => this.ScrollTo(item, new bool?(), true);

    public override void OnApplyTemplate()
    {
      base.OnApplyTemplate();
      this.ThrowIfBalancing();
      if (this._container != null)
      {
        this._container.ViewportChanged -= new EventHandler<ViewportChangedEventArgs>(this.OnContainerViewportChanged);
        ((FrameworkElement) this._container).SizeChanged -= new SizeChangedEventHandler(this.OnContainerSizeChanged);
        ((ContentControl) this._container).Content = (object) null;
        if (this._verticalScroll != null)
          this._container.ManipulationStateChanged -= new EventHandler<ManipulationStateChangedEventArgs>(this.OnContainerManipulationStateChanged);
      }
      this._container = this.GetTemplateChild("ViewportControl") as ViewportControl;
      this._verticalScroll = this.GetTemplateChild("VerticalScrollBar") as ScrollBar;
      this._horizontalScroll = this.GetTemplateChild("HorizontalScrollBar") as ScrollBar;
      if (this._container != null)
      {
        ((FrameworkElement) this._container).ApplyTemplateInternal();
        if (!this.HasDirectManipulationControl())
        {
          XcpImports.UIElement_SetAutomaticBitmapCache((DependencyObject) this, true);
          XcpImports.UIElement_SetAutomaticBitmapCache((DependencyObject) this._itemsPanel, true);
          this.SetDirectManipulationControl();
          XcpImports.Control_SetDirectManipulationTarget((Control) this, (UIElement) this._container.ElementContentElement);
        }
        this._container.ManipulationLockMode = (ManipulationLockMode) 2;
        this._container.ViewportChanged += new EventHandler<ViewportChangedEventArgs>(this.OnContainerViewportChanged);
        ((FrameworkElement) this._container).SizeChanged += new SizeChangedEventHandler(this.OnContainerSizeChanged);
        ((ContentControl) this._container).Content = (object) this._contentPanel;
        this.UpdateContainerBounds();
        if (this._verticalScroll != null)
          this._container.ManipulationStateChanged += new EventHandler<ManipulationStateChangedEventArgs>(this.OnContainerManipulationStateChanged);
      }
      if (this._verticalScroll != null)
        this._verticalScroll.Minimum = 0.0;
      if (this._horizontalScroll != null)
        this._horizontalScroll.Minimum = 0.0;
      UIElement uiElement1 = (UIElement) null;
      UIElement uiElement2 = (UIElement) null;
      if (this._horizontalScroll != null)
      {
        this._horizontalScroll.ApplyTemplateInternal();
        uiElement1 = (UIElement) this._horizontalScroll.ElementHorizontalThumb;
        if (uiElement1 != null && !(uiElement1.RenderTransform is CompositeTransform))
          uiElement1.RenderTransform = (Transform) new CompositeTransform();
      }
      if (this._verticalScroll != null)
      {
        this._verticalScroll.ApplyTemplateInternal();
        uiElement2 = (UIElement) this._verticalScroll.ElementVerticalThumb;
        if (uiElement2 != null && !(uiElement2.RenderTransform is CompositeTransform))
          uiElement2.RenderTransform = (Transform) new CompositeTransform();
      }
      if (this._container == null)
        return;
      XcpImports.ContentControl_SetDirectManipulationScrollThumbs((ContentControl) this._container, uiElement1, uiElement2);
    }

    internal IEnumerable<UIElement> ChildElements => (IEnumerable<UIElement>) this._itemsPanel.Children;

    protected override Size MeasureOverride(Size availableSize)
    {
      if (this._isBalanceDirty && this._container != null && ((FrameworkElement) this._container).ActualWidth != 0.0)
      {
        if (this.InitialItem != null)
        {
          this.InitialScroll(this.InitialItem);
          this.InitialItem = (object) null;
        }
        else
          this.Balance(true);
      }
      return base.MeasureOverride(availableSize);
    }

    private double EstimatedItemHeight => this.LayoutMode != LongListSelectorLayoutMode.Grid ? (this._itemHeights.Count > 0 ? this._bufferedItemHeights / (double) this._itemHeights.Count : 0.0) : this.GridCellSize.Height;

    private double EstimatedNonItemHeight => this._otherElementHeights.Count <= 0 ? 0.0 : this._bufferedOtherElementHeights / (double) this._otherElementHeights.Count;

    private void Balance(bool containerViewport)
    {
      this.ThrowIfBalancing();
      this._isBalancing = true;
      try
      {
        if (containerViewport)
          this._viewport = this._container.Viewport;
        if (this._container != null && this._jumpListController == null && this.EnsureItems())
        {
          if ((this._isItemsReset || this._itemChanges.Count > 0 || this._groupChanges.Count > 0 ? 1 : (this._heightChanges.Count > 0 ? 1 : 0)) != 0)
          {
            LongListSelectorItem stopItem;
            if (this._realizedElements.Count > 0)
            {
              if ((this._itemChanges.Count > 0 || this._groupChanges.Count > 0) && this._realizedElements.Count == 1)
              {
                stopItem = this._realizedElements.First.Value.Item;
                if (stopItem.ItemKind == LongListSelectorItemKind.ListFooter)
                {
                  this._realizedRanges[0].Clear();
                  this._realizedRanges.Clear();
                  Iterator<LongListSelectorItem> iterator = this._items.GetIterator();
                  iterator.MoveNext();
                  this._realizedRanges.Add(new LongListSelector.RealizedRange(this, iterator));
                  this._isItemsReset = true;
                }
              }
              if (this._isItemsReset)
                this.ResetRealized(containerViewport);
              else
                this.HandleItemChanges();
            }
            stopItem = new LongListSelectorItem();
            this.GetElementCounts(stopItem, out this._itemRowCount, out this._otherElementCount);
            this._topBound = -8388608.0;
            this._bottomBound = 8388352.0;
            this.UpdateEstimatedTop();
            this._isItemsReset = false;
            this._itemChanges.Clear();
            this._groupChanges.Clear();
            this._heightChanges.Clear();
          }
          Rect requireRect1;
          Rect allowRect1;
          this.GetBufferRects(out requireRect1, out allowRect1);
          this.SkipToRect(allowRect1);
          bool areBoundsUpdated;
          this.HealElements(requireRect1, allowRect1, out areBoundsUpdated);
          if (areBoundsUpdated)
          {
            Rect requireRect2;
            Rect allowRect2;
            this.GetBufferRects(out requireRect2, out allowRect2);
            if (requireRect2.Top != requireRect1.Top || requireRect2.Bottom != requireRect1.Bottom)
              this.HealElements(requireRect2, allowRect2, out areBoundsUpdated);
          }
        }
        this._isBalanceDirty = false;
        this._lastBalanceViewport = this._viewport;
        this.UpdateAutomationPeersParent();
      }
      finally
      {
        this._isBalancing = false;
      }
      if (this._deferredAction == null)
        return;
      Action deferredAction = this._deferredAction;
      this._deferredAction = (Action) null;
      deferredAction();
    }

    private void SkipToRect(Rect target)
    {
      if (this._realizedRanges.Count <= 0)
        return;
      if (this._realizedRanges[this._realizedRanges.Count - 1].TailY < target.Top)
      {
        this.ClearToY(target.Top);
        this._realizedRanges[0].SkipToY(target.Top);
      }
      else
      {
        if (this._realizedRanges[0].HeadY <= target.Bottom)
          return;
        this.ClearToY(target.Bottom);
        this._realizedRanges[0].SkipToY(target.Bottom);
      }
    }

    private LinkedListNode<LongListSelector.RealizedElement> TrimElement(
      LongListSelector.RealizedRange range,
      bool fromHead)
    {
      LinkedListNode<LongListSelector.RealizedElement> linkedListNode1 = fromHead ? range.HeadNode : range.TailNode;
      LongListSelectorItem listSelectorItem = linkedListNode1.Value.Item;
      LinkedListNode<LongListSelector.RealizedElement> linkedListNode2;
      if (fromHead)
      {
        range.TrimHead();
        linkedListNode2 = range.HeadNode;
      }
      else
      {
        range.TrimTail();
        linkedListNode2 = range.TailNode;
      }
      if (listSelectorItem.ItemKind == LongListSelectorItemKind.Item)
      {
        if (linkedListNode2 != null)
        {
          Point position = linkedListNode1.Value.Position;
          double y1 = position.Y;
          position = linkedListNode2.Value.Position;
          double y2 = position.Y;
          if (y1 == y2)
            goto label_7;
        }
        --this._realizedItemRowCount;
      }
label_7:
      return linkedListNode2;
    }

    private void HealElements(Rect requireRect, Rect allowRect, out bool areBoundsUpdated)
    {
      int index1 = 0;
      while (index1 < this._realizedRanges.Count)
      {
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[index1];
        while (realizedRange.TailY >= allowRect.Bottom && realizedRange.TailNode != null)
          realizedRange.TrimTail();
        if (realizedRange.HeadNode != null)
        {
          LinkedListNode<LongListSelector.RealizedElement> linkedListNode = realizedRange.HeadNode;
          while (linkedListNode != null && realizedRange.HeadY + linkedListNode.Value.Presenter.ActualHeight < allowRect.Top)
            linkedListNode = this.TrimElement(realizedRange, true);
        }
        if (realizedRange.TailNode == null && this._realizedRanges.Count > 1)
        {
          this._realizedRanges.RemoveAt(index1);
          realizedRange.Dispose();
        }
        else
          ++index1;
      }
      this._realizedRanges[0].UpdateItemColumns();
      LongListSelector.RealizedRange nextRange = this._realizedRanges[0];
      LongListSelector.AddItemResult appendResult = LongListSelector.AddItemResult.Success;
      int index2 = 0;
      while (index2 < this._realizedRanges.Count)
      {
        LongListSelector.RealizedRange range = nextRange;
        nextRange = index2 < this._realizedRanges.Count - 1 ? this._realizedRanges[index2 + 1] : (LongListSelector.RealizedRange) null;
        appendResult = LongListSelector.AddItemResult.Success;
        while (range.TailY < requireRect.Bottom && appendResult == LongListSelector.AddItemResult.Success)
          appendResult = this.AppendElement(range, nextRange, requireRect.Bottom);
        if (appendResult == LongListSelector.AddItemResult.RangeCollision)
        {
          nextRange.MergeToHead(range);
          this._realizedRanges.RemoveAt(index2);
          range.Dispose();
        }
        else
          ++index2;
      }
      while (this._realizedRanges.Count > 1)
      {
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[1];
        realizedRange.Clear();
        this._realizedRanges.RemoveAt(1);
        realizedRange.Dispose();
        appendResult = LongListSelector.AddItemResult.Success;
      }
      LongListSelector.AddItemResult prependResult = LongListSelector.AddItemResult.Success;
      LongListSelector.RealizedRange realizedRange1 = this._realizedRanges[0];
      if (realizedRange1.HeadY >= requireRect.Top)
      {
        while (realizedRange1.HeadY >= requireRect.Top && prependResult == LongListSelector.AddItemResult.Success)
          prependResult = this.PrependElement(realizedRange1);
      }
      if (this.IsGroupingEnabled && this._items.HasGroupHeader)
        this.UpdateCurrentHeader();
      this.UpdateEstimatedHeight();
      areBoundsUpdated = this.UpdateBounds(appendResult, prependResult);
    }

    private bool UpdateBounds(
      LongListSelector.AddItemResult appendResult,
      LongListSelector.AddItemResult prependResult)
    {
      bool flag = this.UpdateBottomBound(appendResult);
      if (this.UpdateTopBound(prependResult))
        flag = true;
      this.UpdateContainerBounds();
      if (this._container.ManipulationState == null)
      {
        double yOffset = 0.0;
        if (this._topBound != -8388608.0 && this._topBound > this._viewport.Top)
          yOffset = this._viewport.Top - this._topBound;
        else if (this._bottomBound != 8388352.0 && this._bottomBound < this._viewport.Bottom)
          yOffset = this._topBound == -8388608.0 || this._bottomBound - this._topBound > this._viewport.Height ? this._viewport.Bottom - this._bottomBound : this._viewport.Top - this._topBound;
        if (yOffset != 0.0)
          this.ShiftRealizedItems(yOffset);
      }
      return flag;
    }

    private LongListSelector.AddItemResult AppendElement(
      LongListSelector.RealizedRange range,
      LongListSelector.RealizedRange nextRange,
      double bottom)
    {
      double tailY = range.TailY;
      int num = (int) range.Append(nextRange, bottom);
      if (num != 0)
        return (LongListSelector.AddItemResult) num;
      if (range.TailY == tailY)
        return (LongListSelector.AddItemResult) num;
      ++this._realizedItemRowCount;
      return (LongListSelector.AddItemResult) num;
    }

    private LongListSelector.AddItemResult PrependElement(
      LongListSelector.RealizedRange range)
    {
      double headY = range.HeadY;
      int num = (int) range.Prepend();
      if (num != 0)
        return (LongListSelector.AddItemResult) num;
      if (range.HeadY == headY)
        return (LongListSelector.AddItemResult) num;
      ++this._realizedItemRowCount;
      return (LongListSelector.AddItemResult) num;
    }

    private bool UpdateBottomBound(LongListSelector.AddItemResult appendResult)
    {
      bool flag = false;
      if (this._realizedRanges.Count > 0)
      {
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[this._realizedRanges.Count - 1];
        if (realizedRange.TailNode != null)
        {
          double num = realizedRange.TailY + realizedRange.TailNode.Value.Presenter.DesiredSize.Height;
          if (appendResult == LongListSelector.AddItemResult.EndOfItems)
          {
            if (num != this._bottomBound)
            {
              this._bottomBound = num;
              flag = true;
            }
          }
          else if (num > this._bottomBound)
          {
            this._bottomBound = 8388352.0;
            flag = true;
          }
        }
      }
      return flag;
    }

    private bool UpdateTopBound(LongListSelector.AddItemResult prependResult)
    {
      bool flag = false;
      if (this._realizedRanges.Count > 0)
      {
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[0];
        if (prependResult == LongListSelector.AddItemResult.EndOfItems)
        {
          if (this._topBound != realizedRange.HeadY)
          {
            this._topBound = realizedRange.HeadY;
            flag = true;
          }
        }
        else
        {
          if (realizedRange.HeadY < this._topBound)
          {
            this._topBound = -8388608.0;
            flag = true;
          }
          if (realizedRange.HeadY < this._estimatedTop)
          {
            this._estimatedTop = realizedRange.HeadY - this.EstimatedItemHeight;
            flag = true;
          }
        }
      }
      return flag;
    }

    private void UpdateEstimatedTop()
    {
      if (this._realizedRanges.Count <= 0)
        return;
      LongListSelector.RealizedRange realizedRange = this._realizedRanges[0];
      int itemRowCount;
      int nonItemCount;
      this.GetElementCounts(realizedRange.HeadIterator.Current, out itemRowCount, out nonItemCount);
      this._estimatedTop = realizedRange.HeadY - ((double) itemRowCount * this.EstimatedItemHeight + (double) nonItemCount * this.EstimatedNonItemHeight);
    }

    private void UpdateEstimatedHeight()
    {
      if (this._realizedRanges.Count <= 0)
        return;
      LongListSelector.RealizedRange realizedRange = this._realizedRanges[this._realizedRanges.Count - 1];
      if (realizedRange.TailNode == null || realizedRange.TailNode.Value == null)
        return;
      int itemRowCount;
      int nonItemCount;
      this.GetElementCounts(realizedRange.TailIterator.IsCurrentValid ? realizedRange.TailIterator.Current : realizedRange.TailNode.Value.Item, out itemRowCount, out nonItemCount);
      this._estimatedHeight = this.EstimatedItemHeight * (double) (this._itemRowCount - itemRowCount) + this.EstimatedNonItemHeight * (double) (this._otherElementCount - nonItemCount) + (realizedRange.TailY + realizedRange.TailNode.Value.Presenter.DesiredSize.Height) - (this._topBound == -8388608.0 ? this._estimatedTop : this._topBound);
      if (this._estimatedHeight >= 0.0)
        return;
      this._estimatedHeight = 0.0;
    }

    private bool TryGetRealizedItemsTop(out double top)
    {
      if (this._realizedRanges.Count > 0)
      {
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[0];
        if (realizedRange.HeadNode != null)
        {
          top = realizedRange.HeadY;
          return true;
        }
      }
      top = double.NaN;
      return false;
    }

    private bool TryGetRealizedItemsBottom(out double bottom)
    {
      if (this._realizedRanges.Count > 0)
      {
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[this._realizedRanges.Count - 1];
        if (realizedRange.TailNode != null)
        {
          bottom = realizedRange.TailY + realizedRange.TailNode.Value.Presenter.DesiredSize.Height;
          return true;
        }
      }
      bottom = double.NaN;
      return false;
    }

    private void UpdateContainerBounds()
    {
      if (this._topBound != -8388608.0)
        this._estimatedTop = this._topBound;
      Rect newBounds = new Rect(0.0, this._topBound, this._rightBound, this._bottomBound - this._topBound);
      if (this._topBound == -8388608.0 || this._bottomBound == 8388352.0)
      {
        if (this._realizedElements.Count > 0)
        {
          newBounds.Y = this._estimatedTop;
          newBounds.Height = this._estimatedHeight;
        }
        if (this._topBound != -8388608.0)
          newBounds.Y = this._topBound;
        else if (this._bottomBound != 8388352.0)
          newBounds.Y = this._bottomBound - newBounds.Height;
      }
      if (this._realizedRanges.Count > 0)
      {
        if (this._realizedRanges[0].HeadY < newBounds.Y)
        {
          double num = newBounds.Y - this._realizedRanges[0].HeadY;
          newBounds.Y -= num;
          newBounds.Height += num;
        }
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[this._realizedRanges.Count - 1];
        if (realizedRange.TailY > newBounds.Y + newBounds.Height)
          newBounds.Height = realizedRange.TailY - newBounds.Y;
      }
      if (this._realizedRanges.Count > 0)
      {
        if (this._realizedRanges[0].HeadY < newBounds.Y)
        {
          double num = newBounds.Y - this._realizedRanges[0].HeadY;
          newBounds.Y -= num;
          newBounds.Height += num;
        }
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[this._realizedRanges.Count - 1];
        if (realizedRange.TailY > newBounds.Y + newBounds.Height)
          newBounds.Height = realizedRange.TailY - newBounds.Y;
      }
      this.SetContainerBounds(newBounds);
      this.UpdateScrollBars(newBounds);
      if (this._contentPanel == null)
        return;
      this._contentPanel.Height = newBounds.Height;
    }

    private void SetContainerBounds(Rect newBounds)
    {
      double height = this._container.Bounds.Height;
      this._container.Bounds = newBounds;
      if (!AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged) || newBounds.Top == -8388608.0 || (newBounds.Bottom == 8388352.0 || !(this.GetOrCreateAutomationPeer() is LongListSelectorAutomationPeer automationPeer)))
        return;
      automationPeer.RaiseScrollPropertyChangedEvents(height, this.ScrollViewport, this.ScrollOffset);
    }

    private LongListSelector.ItemChangeType GetItemChanges(LongListSelectorItem item)
    {
      LongListSelector.ItemChangeType itemChangeType1 = LongListSelector.ItemChangeType.None;
      LongListSelector.ItemChangeType itemChangeType2;
      if (this._itemChanges.TryGetValue(item, out itemChangeType2))
        itemChangeType1 |= itemChangeType2;
      if (item.Group != null && this._groupChanges.TryGetValue(item.Group, out itemChangeType2))
        itemChangeType1 |= itemChangeType2;
      return itemChangeType1;
    }

    private bool HasHeightChange(
      LongListSelector.RealizedElement previous,
      LongListSelector.RealizedElement element)
    {
      double num;
      return this._heightChanges.TryGetValue(previous.Presenter, out num) && element.Position.Y - previous.Position.Y != num;
    }

    private void HandleItemChanges()
    {
      LongListSelector.RealizedRange realizedRange1 = (LongListSelector.RealizedRange) null;
      for (int index = 0; index < this._realizedRanges.Count; ++index)
      {
        LongListSelector.RealizedRange realizedRange2 = this._realizedRanges[index];
        if (realizedRange2.TrimChanges(true) && index == 0)
        {
          this._topBound = -8388608.0;
          this.UpdateContainerBounds();
        }
        if (realizedRange2.HeadNode != null)
        {
          if (realizedRange2 != realizedRange1 && realizedRange2.TrimChanges(false) && index == this._realizedRanges.Count - 1)
          {
            this._bottomBound = 8388352.0;
            this.UpdateContainerBounds();
          }
          LinkedListNode<LongListSelector.RealizedElement> linkedListNode = realizedRange2.HeadNode;
          LinkedListNode<LongListSelector.RealizedElement> next = realizedRange2.HeadNode.Next;
          Iterator<LongListSelectorItem> iterator;
          using (iterator = realizedRange2.HeadIterator.Clone())
          {
            for (; next != realizedRange2.TailNode.Next; next = next.Next)
            {
              if (iterator.MoveNext())
              {
                if ((this.GetItemChanges(next.Value.Item) & LongListSelector.ItemChangeType.Remove) != LongListSelector.ItemChangeType.None || (this.GetItemChanges(iterator.Current) & LongListSelector.ItemChangeType.Add) != LongListSelector.ItemChangeType.None || linkedListNode != null && this.HasHeightChange(linkedListNode.Value, next.Value))
                {
                  realizedRange1 = realizedRange2.SplitBefore(next, iterator);
                  if (index < this._realizedRanges.Count - 1)
                  {
                    this._realizedRanges.Insert(index + 1, realizedRange1);
                    break;
                  }
                  this._realizedRanges.Add(realizedRange1);
                  break;
                }
                next.Value.UpdateItem(iterator.Current);
                linkedListNode = next;
              }
              else
                break;
            }
          }
        }
        else if (this._realizedRanges.Count > 1)
        {
          this._realizedRanges.RemoveAt(index);
          --index;
        }
      }
    }

    private void ScrollToGroup(object group, bool setUiaFocus = false) => this.ScrollTo(group, new bool?(true), true, setUiaFocus);

    private void ScrollTo(object item, bool? isGroup, bool containerViewport, bool setUiaFocus = false)
    {
      if (this._isBalancing)
      {
        this._deferredAction = (Action) (() => this.ScrollTo(item, isGroup, containerViewport));
      }
      else
      {
        if (!this.EnsureItems())
          throw new ArgumentException(Resources.LongListSelector_ScrollToInvalidItem);
        if (isGroup.HasValue && isGroup.Value && !this.IsGroupingEnabled)
          throw new InvalidOperationException(Resources.LongListSelector_ScrollToGroupNoGroups);
        Iterator<LongListSelectorItem> iterator = this._items.GetIterator(item, isGroup);
        if (iterator == null)
          throw new ArgumentException(Resources.LongListSelector_ScrollToInvalidItem);
        if (containerViewport)
        {
          this._container.SetViewportOrigin(new Point(0.0, this._container.Viewport.Top));
          this._viewport = this._container.Viewport;
          this._topBound = -8388608.0;
          this._bottomBound = 8388352.0;
        }
        else
        {
          this._container.SetViewportOrigin(new Point(0.0, this._viewport.Top));
          this._topBound = this._estimatedTop;
          this._bottomBound = this._estimatedTop + this._estimatedHeight;
        }
        this.UpdateContainerBounds();
        this.ResetRealized(containerViewport);
        foreach (LongListSelector.RealizedRange realizedRange in (IEnumerable<LongListSelector.RealizedRange>) this._realizedRanges)
          realizedRange.Dispose();
        this._realizedRanges.Clear();
        this._realizedRanges.Add(new LongListSelector.RealizedRange(this, iterator));
        if (this.IsGroupingEnabled && this._items.HasGroupHeader)
        {
          LongListSelectorItem current = iterator.Current;
          this.AdvanceCurrentGroup(current.Group, new bool?());
          current = iterator.Current;
          if (current.ItemKind == LongListSelectorItemKind.Item && this._currentHeaderElement != null)
            this._realizedRanges[0].ShiftY(this._currentHeaderElement.Presenter.DesiredSize.Height);
        }
        int itemRowCount;
        int nonItemCount;
        this.GetElementCounts(iterator.Current, out itemRowCount, out nonItemCount);
        this._estimatedTop = !containerViewport ? 0.0 : this._viewport.Top - ((double) nonItemCount * this.EstimatedNonItemHeight + (double) itemRowCount * this.EstimatedItemHeight);
        this.Balance(containerViewport);
        if (!setUiaFocus || !AutomationPeer.ListenerExists(AutomationEvents.AutomationFocusChanged))
          return;
        this.TrySetUiaFocus((UIElement) this.AutomationGetContainerForItem(item));
      }
    }

    private void ScrollToOffset(double offset)
    {
      if (this._container == null)
        return;
      int count = this._realizedElements.Count;
      double y = offset + this._container.Bounds.Top;
      if (count > 0 && this._realizedElements.First.Value.Position.Y <= y && this._realizedElements.Last.Value.Position.Y + this._realizedElements.Last.Value.Presenter.DesiredSize.Height >= y)
      {
        this._container.SetViewportOrigin(new Point(0.0, y));
        this.Balance(true);
      }
      else
      {
        bool flag1 = true;
        bool flag2 = false;
        double tailHeight = 0.0;
        Point point = new Point();
        LongListSelector.RealizedRange realizedRange = this._realizedRanges[0];
        LongListSelectorItem? nullable = new LongListSelectorItem?();
        Iterator<LongListSelectorItem> iterator;
        if (count > 0)
        {
          if (this._realizedElements.First.Value.Position.Y < y)
          {
            iterator = realizedRange.TailIterator.Clone();
            point = this._realizedElements.Last.Value.Position;
            tailHeight = this._realizedElements.Last.Value.Presenter.ActualHeight;
          }
          else
          {
            flag1 = false;
            iterator = realizedRange.HeadIterator.Clone();
            point = this._realizedElements.First.Value.Position;
          }
        }
        else
        {
          iterator = this._items.GetIterator();
          point = new Point(0.0, this._container.Viewport.Top);
        }
        while (!flag2 && (flag1 && iterator.MoveNext() || !flag1 && iterator.MovePrevious()))
        {
          LongListSelectorItem current = iterator.Current;
          double newItemHeight = current.ItemKind == LongListSelectorItemKind.Item ? this.EstimatedItemHeight : this.EstimatedNonItemHeight;
          if (current.ItemKind == LongListSelectorItemKind.Item || current.ItemKind == LongListSelectorItemKind.GroupHeader)
            nullable = new LongListSelectorItem?(current);
          if (flag1)
          {
            point = realizedRange.GetAppendPosition(point.Y, current, tailHeight);
            tailHeight = newItemHeight;
            flag2 = point.Y + newItemHeight >= y;
          }
          else
          {
            point = realizedRange.GetPrependPosition(point.Y, current, newItemHeight);
            flag2 = point.Y <= y;
          }
        }
        if (nullable.HasValue)
          this.ScrollTo(nullable.Value.Data, new bool?(nullable.Value.ItemKind == LongListSelectorItemKind.GroupHeader), true);
        iterator.Dispose();
      }
    }

    private void InitialScroll(object item)
    {
      if (!this.EnsureItems())
        throw new ArgumentException(Resources.LongListSelector_ScrollToInvalidItem);
      int itemRowCount;
      this.GetElementCounts((this._items.GetIterator(item, new bool?(false)) ?? throw new ArgumentException(Resources.LongListSelector_ScrollToInvalidItem)).Current, out itemRowCount, out int _);
      double y = (double) (itemRowCount - 1) * this.EstimatedItemHeight;
      this._topBound = -8388608.0;
      this._bottomBound = 8388352.0;
      this._estimatedTop = 0.0;
      this._estimatedHeight = (double) this._itemRowCount * this.EstimatedItemHeight;
      this._viewport = new Rect(0.0, y, ((FrameworkElement) this._container).ActualWidth, this._bufferHeight);
      this._estimatedTop = 0.0;
      this._topBound = 0.0;
      this._bottomBound = this._estimatedHeight;
      this.UpdateBounds(LongListSelector.AddItemResult.Success, LongListSelector.AddItemResult.Success);
      this._viewport.Y -= this._estimatedTop;
      this.ScrollTo(item, new bool?(), false);
      this.SetContainerBounds(new Rect(0.0, this._estimatedTop, ((FrameworkElement) this._container).ActualWidth, this._estimatedHeight));
    }

    private void InitializeHeaderPosition(LongListSelector.RealizedElement header)
    {
      int itemRowCount;
      int nonItemCount;
      this.GetElementCounts(header.Item, out itemRowCount, out nonItemCount);
      header.Position = new Point(0.0, (double) (itemRowCount - 8388608 + nonItemCount));
    }

    private bool EnsureItems()
    {
      bool flag = true;
      if (this._items == null)
      {
        if (this.ItemsSource != null)
        {
          // ISSUE: method pointer
          // ISSUE: method pointer
          // ISSUE: method pointer
          this._items = this.IsGroupingEnabled ? (LongListSelectorItemCollection) new LongListSelectorGroupedItemCollection(this.ItemsSource, new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnItemsCollectionChanged)), new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnItemsGroupChanged))) : (LongListSelectorItemCollection) new LongListSelectorFlatItemCollection(this.ItemsSource, new NotifyCollectionChangedEventHandler((object) this, __methodptr(OnItemsCollectionChanged)));
          this._items.IncludeEmptyGroups = !this.HideEmptyGroups;
          this._items.ListHeader = this.ListHeader;
          this._items.ListFooter = this.ListFooter;
          this._items.HasListHeader = this.ListHeader is UIElement || this.ListHeaderTemplate != null;
          this._items.HasListFooter = this.ListFooter is UIElement || this.ListFooterTemplate != null;
          this._items.HasGroupHeader = this.GroupHeaderTemplate != null;
          this._items.HasGroupFooter = this.GroupFooterTemplate != null;
          Iterator<LongListSelectorItem> iterator = this._items.GetIterator();
          iterator.MoveNext();
          this._realizedRanges.Add(new LongListSelector.RealizedRange(this, iterator));
          if (this.IsGroupingEnabled)
            this._currentHeaderIterator = this._items.GetHeaderIterator();
          this.GetElementCounts(new LongListSelectorItem(), out this._itemRowCount, out this._otherElementCount);
          this.SetItemsPanelClip();
        }
        else
          flag = false;
      }
      return flag;
    }

    private void UpdateGridColumns()
    {
      int gridColumnsInRow1 = this._gridColumnsInRow;
      this._gridColumnsInRow = 1;
      if (this._container != null)
      {
        Size gridCellSize;
        if (this.LayoutMode == LongListSelectorLayoutMode.Grid && ((FrameworkElement) this._container).ActualWidth > this.GridCellSize.Width && this.GridCellSize.Width != 0.0)
        {
          double actualWidth = ((FrameworkElement) this._container).ActualWidth;
          gridCellSize = this.GridCellSize;
          double width = gridCellSize.Width;
          this._gridColumnsInRow = (int) Math.Floor(actualWidth / width);
        }
        gridCellSize = this.GridCellSize;
        this._rightBound = Math.Max(gridCellSize.Width, ((FrameworkElement) this._container).ActualWidth);
        this.UpdateContainerBounds();
      }
      this.GetElementCounts(new LongListSelectorItem(), out this._itemRowCount, out this._otherElementCount);
      int gridColumnsInRow2 = this._gridColumnsInRow;
      if (gridColumnsInRow1 == gridColumnsInRow2)
        return;
      this.ResetRealized(true);
      this.QueueBalance();
    }

    private void UpdateScrollBars(Rect newBounds)
    {
      if (this._verticalScroll != null)
      {
        if (newBounds.Height > this._viewport.Height)
        {
          this._verticalScroll.Visibility = Visibility.Visible;
          this._verticalScroll.Maximum = newBounds.Height - this._viewport.Height;
          this._verticalScroll.Value = this._viewport.Top - newBounds.Top;
          this._verticalScroll.ViewportSize = this._viewport.Height;
        }
        else
          this._verticalScroll.Visibility = Visibility.Collapsed;
      }
      if (this._horizontalScroll == null)
        return;
      if (this._viewport.Width < newBounds.Right && newBounds.Right != 8388352.0)
      {
        this._horizontalScroll.Visibility = Visibility.Visible;
        this._horizontalScroll.Maximum = newBounds.Right - this._viewport.Width;
        this._horizontalScroll.Value = this._viewport.Left;
        this._horizontalScroll.ViewportSize = this._viewport.Width;
      }
      else
        this._horizontalScroll.Visibility = Visibility.Collapsed;
    }

    private void GetBufferRects(out Rect requireRect, out Rect allowRect)
    {
      double y = this._viewport.Top - this._bufferHeight;
      double height = this._viewport.Height + this._bufferHeight * 2.0;
      if (y < this._topBound)
        y = this._topBound;
      else if (y + height > this._bottomBound)
        y = this._bottomBound - height;
      if (y == this._topBound && this._items != null)
      {
        height += this.EstimatedItemHeight;
        if (this._items.HasGroupHeader)
          height += this.EstimatedNonItemHeight;
        if (this._items.HasListHeader)
          height += this.EstimatedNonItemHeight;
      }
      allowRect = new Rect(this._viewport.Left, y, this._viewport.Width, height);
      requireRect = allowRect;
    }

    private void GetElementCounts(
      LongListSelectorItem stopItem,
      out int itemRowCount,
      out int nonItemCount)
    {
      object obj = (object) null;
      bool flag1 = stopItem.Equals((object) new LongListSelectorItem());
      if (!flag1)
        obj = stopItem.Group;
      nonItemCount = 0;
      itemRowCount = 0;
      if (this._items == null)
        return;
      if (this._items.HasListHeader)
        ++nonItemCount;
      if (this._items.HasListFooter)
        ++nonItemCount;
      bool flag2 = false;
      int num = 0;
      if (this.IsGroupingEnabled)
      {
        if (this.GroupHeaderTemplate != null)
        {
          flag2 = true;
          ++num;
        }
        if (this.GroupFooterTemplate != null)
          ++num;
      }
      foreach (IList groupList in this._items.GetGroupLists())
      {
        if (groupList != null)
        {
          if (groupList == obj || !flag1 && !this.IsGroupingEnabled)
          {
            if (flag2 && (!this.HideEmptyGroups || groupList.Count > 0))
              ++nonItemCount;
            if (stopItem.ItemKind != LongListSelectorItemKind.Item)
              break;
            itemRowCount += (int) Math.Ceiling((double) (stopItem.IndexInGroup + 1) / (double) this._gridColumnsInRow);
            break;
          }
          itemRowCount += (int) Math.Ceiling((double) groupList.Count / (double) this._gridColumnsInRow);
          if (!this.HideEmptyGroups || groupList.Count > 0)
            nonItemCount += num;
        }
        else if (!this.HideEmptyGroups)
          nonItemCount += num;
      }
    }

    private void UpdateCurrentHeader()
    {
      LongListSelector.RealizedElement element = this._isCurrentHeaderOrphaned ? this._currentHeaderElement : (LongListSelector.RealizedElement) null;
      LongListSelectorItem current;
      if (this._isCurrentHeaderOrphaned)
      {
        current = this._realizedRanges[0].HeadIterator.Current;
        if (current.Group != null)
        {
          current = this._realizedRanges[0].HeadIterator.Current;
          object group1 = current.Group;
          object obj = group1;
          current = this._currentHeaderElement.Item;
          object group2 = current.Group;
          if (obj != group2)
          {
            this._currentHeaderElement = (LongListSelector.RealizedElement) null;
            if (this._lastBalanceViewport.Top < this._viewport.Top)
            {
              do
              {
                current = this._currentHeaderIterator.Current;
              }
              while (current.Group != group1 && this._currentHeaderIterator.MoveNext());
            }
            else
            {
              do
              {
                current = this._currentHeaderIterator.Current;
              }
              while (current.Group != group1 && this._currentHeaderIterator.MovePrevious());
            }
          }
        }
      }
      if (this._realizedHeaderGroups.Count > 0)
      {
        LongListSelector.RealizedElement realizedElement = (LongListSelector.RealizedElement) null;
        if (this._currentHeaderElement == null)
        {
          current = this._currentHeaderIterator.Current;
          if (current.Group != null)
          {
            IDictionary<object, LongListSelector.RealizedElement> realizedHeaderGroups = this._realizedHeaderGroups;
            current = this._currentHeaderIterator.Current;
            object group = current.Group;
            ref LongListSelector.RealizedElement local = ref this._currentHeaderElement;
            realizedHeaderGroups.TryGetValue(group, out local);
          }
        }
        Point position;
        if (this._currentHeaderElement != null)
        {
          position = this._currentHeaderElement.Position;
          if (position.Y > this._viewport.Top)
          {
            while (this._currentHeaderIterator.MovePrevious())
            {
              current = this._currentHeaderIterator.Current;
              if (current.Group != null)
              {
                IDictionary<object, LongListSelector.RealizedElement> realizedHeaderGroups = this._realizedHeaderGroups;
                current = this._currentHeaderIterator.Current;
                object group = current.Group;
                ref LongListSelector.RealizedElement local = ref realizedElement;
                if (realizedHeaderGroups.TryGetValue(group, out local))
                {
                  position = realizedElement.Position;
                  if (position.Y <= this._viewport.Top)
                    break;
                }
                else
                  break;
              }
              else
                break;
            }
            this._currentHeaderElement = realizedElement;
            goto label_24;
          }
        }
        while (this._currentHeaderIterator.MoveNext())
        {
          current = this._currentHeaderIterator.Current;
          if (current.Group != null)
          {
            IDictionary<object, LongListSelector.RealizedElement> realizedHeaderGroups = this._realizedHeaderGroups;
            current = this._currentHeaderIterator.Current;
            object group = current.Group;
            ref LongListSelector.RealizedElement local = ref realizedElement;
            if (realizedHeaderGroups.TryGetValue(group, out local))
            {
              position = realizedElement.Position;
              if (position.Y < this._viewport.Top)
                this._currentHeaderElement = realizedElement;
              else
                break;
            }
            else
              break;
          }
          else
            break;
        }
        this._currentHeaderIterator.MovePrevious();
label_24:
        if (this._currentHeaderElement != element)
          this._isCurrentHeaderOrphaned = false;
      }
      if (this._currentHeaderElement == null)
      {
        current = this._realizedRanges[0].HeadIterator.Current;
        if (current.Group != null)
        {
          current = this._realizedRanges[0].HeadIterator.Current;
          object group = current.Group;
          bool? forward = new bool?();
          if (this._lastBalanceViewport.Top != this._viewport.Top)
            forward = new bool?(this._lastBalanceViewport.Top < this._viewport.Top);
          this.AdvanceCurrentGroup(group, forward);
        }
      }
      this.UpdatePreviousHeader();
      if (element == null || element == this._currentHeaderElement || element == this._previousHeaderElement)
        return;
      this.RecycleDisplayItem(element);
    }

    private void UpdatePreviousHeader()
    {
      LongListSelector.RealizedElement element = this._isPreviousHeaderOrphaned ? this._previousHeaderElement : (LongListSelector.RealizedElement) null;
      if (this._currentHeaderIterator.MovePrevious())
      {
        if (this._realizedHeaderGroups.TryGetValue(this._currentHeaderIterator.Current.Group, out this._previousHeaderElement))
        {
          this._isPreviousHeaderOrphaned = false;
        }
        else
        {
          this._previousHeaderElement = this.RealizeDisplayItem(this._currentHeaderIterator, LongListSelector.RealizeOptions.AsOrphan);
          this.InitializeHeaderPosition(this._previousHeaderElement);
          this._isPreviousHeaderOrphaned = true;
        }
      }
      else
      {
        this._previousHeaderElement = (LongListSelector.RealizedElement) null;
        this._isPreviousHeaderOrphaned = false;
      }
      this._currentHeaderIterator.MoveNext();
      if (element == null || element == this._previousHeaderElement || element == this._currentHeaderElement)
        return;
      this.RecycleDisplayItem(element);
    }

    private void UpdateHasListHeader()
    {
      if (this._items == null)
        return;
      bool flag = this.ListHeader is UIElement || this.ListHeaderTemplate != null;
      if (flag != this._items.HasListHeader)
        this._items.HasListHeader = flag;
      if (!this.IsGroupingEnabled || flag)
        return;
      this._currentHeaderElement = (LongListSelector.RealizedElement) null;
      this._currentHeaderIterator.Reset();
    }

    private void UpdateHasListFooter()
    {
      if (this._items == null)
        return;
      bool flag = this.ListFooter is UIElement || this.ListFooterTemplate != null;
      if (flag == this._items.HasListFooter)
        return;
      this._items.HasListFooter = flag;
    }

    private void AdvanceCurrentGroup(object group, bool? forward)
    {
      if (!forward.HasValue)
        this._currentHeaderIterator.Reset();
      if (!forward.HasValue || forward.Value)
      {
        while (this._currentHeaderIterator.Current.Group != group && this._currentHeaderIterator.MoveNext())
          ;
      }
      else
      {
        while (this._currentHeaderIterator.Current.Group != group && this._currentHeaderIterator.MovePrevious())
          ;
      }
      if (forward.HasValue && this._currentHeaderIterator.Current.Group != group)
      {
        this._currentHeaderIterator.Reset();
        while (this._currentHeaderIterator.Current.Group != group && this._currentHeaderIterator.MoveNext())
          ;
      }
      if (this._currentHeaderIterator.Current.Group == null)
        return;
      if (this._realizedHeaderGroups.TryGetValue(group, out this._currentHeaderElement))
      {
        this._isCurrentHeaderOrphaned = false;
      }
      else
      {
        this._currentHeaderElement = this.RealizeDisplayItem(this._currentHeaderIterator, LongListSelector.RealizeOptions.AsOrphan);
        this.InitializeHeaderPosition(this._currentHeaderElement);
        this._isCurrentHeaderOrphaned = true;
      }
    }

    private LongListSelector.RealizedElement RealizeDisplayItem(
      Iterator<LongListSelectorItem> iterator,
      LongListSelector.RealizeOptions options)
    {
      bool flag1 = this._currentHeaderElement != null && this._currentHeaderElement.Item.Equals((object) iterator.Current);
      bool flag2 = this._previousHeaderElement != null && this._previousHeaderElement.Item.Equals((object) iterator.Current);
      LongListSelectorItem current;
      bool flag3;
      ContentPresenter presenter1;
      LongListSelector.RealizedElement realizedElement1;
      if (!flag1 && !flag2)
      {
        LongListSelectorCache cache = this._cache;
        int itemKind1 = (int) iterator.Current.ItemKind;
        Binding[] templateBindings = this._templateBindings;
        current = iterator.Current;
        int itemKind2 = (int) current.ItemKind;
        Binding templateBinding = templateBindings[itemKind2];
        current = iterator.Current;
        object data = current.Data;
        ref bool local = ref flag3;
        presenter1 = cache.Get((LongListSelectorItemKind) itemKind1, templateBinding, data, out local);
        realizedElement1 = new LongListSelector.RealizedElement(presenter1, iterator.Current);
        if (flag3)
          presenter1.AutomationPeerProvider = new Func<ContentPresenter, AutomationPeer>(this.OnCreateItemAutomationPeer);
        this._isAPDirty = true;
      }
      else
      {
        if (flag1)
        {
          realizedElement1 = this._currentHeaderElement;
          this._isCurrentHeaderOrphaned = false;
        }
        else
        {
          realizedElement1 = this._previousHeaderElement;
          this._isPreviousHeaderOrphaned = false;
        }
        presenter1 = realizedElement1.Presenter;
        flag3 = false;
      }
      if (this.LayoutMode == LongListSelectorLayoutMode.Grid)
      {
        current = iterator.Current;
        if (current.ItemKind == LongListSelectorItemKind.Item)
        {
          presenter1.Width = this.GridCellSize.Width;
          presenter1.Height = this.GridCellSize.Height;
          goto label_12;
        }
      }
      presenter1.Width = ((FrameworkElement) this._container).ActualWidth;
      presenter1.Height = double.NaN;
label_12:
      current = iterator.Current;
      if (current.ItemKind == LongListSelectorItemKind.GroupHeader)
      {
        if ((options & LongListSelector.RealizeOptions.AsOrphan) != LongListSelector.RealizeOptions.AsOrphan)
        {
          IDictionary<object, LongListSelector.RealizedElement> realizedHeaderGroups = this._realizedHeaderGroups;
          current = iterator.Current;
          object data = current.Data;
          LongListSelector.RealizedElement realizedElement2 = realizedElement1;
          realizedHeaderGroups.Add(data, realizedElement2);
        }
        if (flag3)
        {
          this._contentPanel.Children.Add((UIElement) presenter1);
          presenter1.Tap += new EventHandler<GestureEventArgs>(this.OnGroupHeaderTap);
        }
        if (!flag1 && !flag2 && this.HasDirectManipulationControl())
        {
          XcpImports.UIElement_SetAutomaticBitmapCache((DependencyObject) presenter1, true);
          this.DirectManipulationAddHeader(presenter1);
        }
      }
      else if (flag3)
      {
        this._itemsPanel.Children.Add((UIElement) presenter1);
        current = iterator.Current;
        if (current.ItemKind == LongListSelectorItemKind.Item)
          presenter1.Tap += new EventHandler<GestureEventArgs>(this.OnItemTap);
      }
      presenter1.Measure(LongListSelector._measureSize);
      Rect zeroRect = LongListSelector._zeroRect;
      zeroRect.Width = presenter1.DesiredSize.Width;
      zeroRect.Height = presenter1.DesiredSize.Height;
      presenter1.Arrange(zeroRect);
      presenter1.SizeChanged += new SizeChangedEventHandler(this.OnElementSizeChanged);
      this._maxBufferedHeights = Math.Max(this._maxBufferedHeights, this._realizedElements.Count + 1);
      current = iterator.Current;
      if (current.ItemKind == LongListSelectorItemKind.Item)
      {
        if (this._itemHeights.Count >= this._maxBufferedHeights)
          this._bufferedItemHeights -= this._itemHeights.DequeueTail();
        this._itemHeights.EnqueueHead(presenter1.DesiredSize.Height);
        this._bufferedItemHeights += presenter1.DesiredSize.Height;
      }
      else
      {
        if (this._otherElementHeights.Count >= this._maxBufferedHeights)
          this._bufferedOtherElementHeights -= this._otherElementHeights.DequeueTail();
        this._otherElementHeights.EnqueueHead(presenter1.DesiredSize.Height);
        this._bufferedOtherElementHeights += presenter1.DesiredSize.Height;
      }
      if (!flag1 && !flag2)
      {
        EventHandler<ItemRealizationEventArgs> itemRealized = this.ItemRealized;
        ContentPresenter presenter2 = presenter1;
        current = iterator.Current;
        int itemKind = (int) current.ItemKind;
        this.FireItemRealizationEvent(itemRealized, presenter2, (LongListSelectorItemKind) itemKind);
        IDictionary<ContentPresenter, double> ignoreHeightChanges = this._ignoreHeightChanges;
        ContentPresenter key = presenter1;
        double height = key.DesiredSize.Height;
        ignoreHeightChanges.Add(key, height);
      }
      return realizedElement1;
    }

    private void RecycleDisplayItem(LongListSelector.RealizedElement element)
    {
      bool flag1 = true;
      if (element.Item.ItemKind == LongListSelectorItemKind.GroupHeader)
      {
        bool flag2 = element == this._currentHeaderElement;
        bool flag3 = element == this._previousHeaderElement;
        if ((!flag2 || this._isCurrentHeaderOrphaned) && (!flag3 || this._isPreviousHeaderOrphaned))
        {
          if (this.HasDirectManipulationControl())
            this.DirectManipulationRemoveHeader(element.Presenter);
          if (flag2)
            this._isCurrentHeaderOrphaned = false;
          else if (flag3)
            this._isPreviousHeaderOrphaned = false;
          else
            this._realizedHeaderGroups.Remove(element.Item.Data);
        }
        else
        {
          flag1 = false;
          if (flag2)
            this._isCurrentHeaderOrphaned = true;
          else
            this._isPreviousHeaderOrphaned = true;
          this._realizedHeaderGroups.Remove(element.Item.Data);
        }
      }
      if (!flag1)
        return;
      EventHandler<ItemRealizationEventArgs> itemUnrealized = this.ItemUnrealized;
      ContentPresenter presenter1 = element.Presenter;
      LongListSelectorItem listSelectorItem = element.Item;
      int itemKind1 = (int) listSelectorItem.ItemKind;
      this.FireItemRealizationEvent(itemUnrealized, presenter1, (LongListSelectorItemKind) itemKind1);
      LongListSelectorCache cache = this._cache;
      listSelectorItem = element.Item;
      int itemKind2 = (int) listSelectorItem.ItemKind;
      ContentPresenter presenter2 = element.Presenter;
      cache.Put((LongListSelectorItemKind) itemKind2, presenter2);
      element.Presenter.SizeChanged -= new SizeChangedEventHandler(this.OnElementSizeChanged);
      this._ignoreHeightChanges.Remove(element.Presenter);
    }

    private void ShiftRealizedItems(double yOffset)
    {
      if (this._topBound != -8388608.0)
        this._topBound += yOffset;
      foreach (LongListSelector.RealizedRange realizedRange in (IEnumerable<LongListSelector.RealizedRange>) this._realizedRanges)
        realizedRange.ShiftElements(yOffset);
      if (this._bottomBound != 8388352.0)
        this._bottomBound += yOffset;
      this.UpdateContainerBounds();
    }

    private void ClearToY(double yValue)
    {
      foreach (LongListSelector.RealizedRange realizedRange in (IEnumerable<LongListSelector.RealizedRange>) this._realizedRanges)
        realizedRange.ClearToY(yValue);
      double num1 = double.MaxValue;
      int index1 = -1;
      int index2 = 0;
      while (index2 < this._realizedRanges.Count)
      {
        double num2 = Math.Abs(yValue - this._realizedRanges[index2].HeadY);
        if (num2 < num1)
        {
          num1 = num2;
          if (index1 >= 0)
          {
            this._realizedRanges.RemoveAt(index1);
            index1 = index2 - 1;
          }
          else
          {
            index1 = index2;
            ++index2;
          }
        }
        else
          this._realizedRanges.RemoveAt(index1);
      }
    }

    private void Reset()
    {
      if (this._items != null)
      {
        this._items.Dispose();
        this._items = (LongListSelectorItemCollection) null;
      }
      foreach (LongListSelector.RealizedRange realizedRange in (IEnumerable<LongListSelector.RealizedRange>) this._realizedRanges)
        realizedRange.Dispose();
      this._realizedRanges.Clear();
      this.ResetCurrentHeader();
      if (this._currentHeaderIterator != null)
      {
        this._currentHeaderIterator.Dispose();
        this._currentHeaderIterator = (Iterator<LongListSelectorItem>) null;
      }
      this.ResetBounds();
      this._otherElementCount = this._itemRowCount = this._realizedItemRowCount = 0;
      this._itemHeights.Clear();
      this._bufferedItemHeights = 0.0;
      this._otherElementHeights.Clear();
      this._bufferedOtherElementHeights = 0.0;
      this.SetItemsPanelClip();
    }

    private void ResetBounds()
    {
      this._topBound = -8388608.0;
      this._bottomBound = 8388352.0;
      if (this._container == null)
        return;
      this.UpdateContainerBounds();
    }

    private void ResetRealized(bool containerViewport)
    {
      if (containerViewport && this._container != null)
        this._viewport = this._container.Viewport;
      if (this._realizedElements.Count > 0)
        this.ClearToY(this._viewport.Top);
      this.ResetCurrentHeader();
      this._realizedItemRowCount = 0;
      this.ResetBounds();
    }

    private void ResetCurrentHeader()
    {
      if (this._currentHeaderElement != null && this._isCurrentHeaderOrphaned)
      {
        this.RecycleDisplayItem(this._currentHeaderElement);
        this._currentHeaderElement = (LongListSelector.RealizedElement) null;
      }
      if (this._previousHeaderElement == null || !this._isPreviousHeaderOrphaned)
        return;
      this.RecycleDisplayItem(this._previousHeaderElement);
      this._previousHeaderElement = (LongListSelector.RealizedElement) null;
    }

    private void SetItemsPanelClip() => this._itemsPanel.Clip = this._items != null && this.IsGroupingEnabled && this._items.HasGroupHeader ? (Geometry) this._clipGeometry : (Geometry) null;

    private void QueueBalance()
    {
      this._isBalanceDirty = true;
      this.InvalidateMeasure();
    }

    private void QueueChanges<TKey>(
      IDictionary<TKey, LongListSelector.ItemChangeType> changes,
      NotifyCollectionChangedEventArgs args)
    {
      switch ((int) args.Action)
      {
        case 0:
          this.QueueChanges<TKey>(changes, args.NewItems, LongListSelector.ItemChangeType.Add);
          break;
        case 1:
          this.QueueChanges<TKey>(changes, args.OldItems, LongListSelector.ItemChangeType.Remove);
          break;
        case 2:
          this.QueueChanges<TKey>(changes, args.NewItems, LongListSelector.ItemChangeType.Add);
          this.QueueChanges<TKey>(changes, args.OldItems, LongListSelector.ItemChangeType.Remove);
          break;
      }
    }

    private void QueueChanges<TKey>(
      IDictionary<TKey, LongListSelector.ItemChangeType> changes,
      IList keys,
      LongListSelector.ItemChangeType change)
    {
      foreach (TKey key in (IEnumerable) keys)
      {
        LongListSelector.ItemChangeType itemChangeType;
        if (changes.TryGetValue(key, out itemChangeType))
          changes[key] = change | itemChangeType;
        else
          changes.Add(key, change);
      }
    }

    private void FireItemRealizationEvent(
      EventHandler<ItemRealizationEventArgs> handler,
      ContentPresenter presenter,
      LongListSelectorItemKind itemKind)
    {
      if (handler == null)
        return;
      ItemRealizationEventArgs e = new ItemRealizationEventArgs(presenter, itemKind);
      handler((object) this, e);
    }

    private void FirePropertyChangedEvent(string propertyName)
    {
      PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
      if (propertyChanged == null)
        return;
      propertyChanged((object) this, new PropertyChangedEventArgs(propertyName));
    }

    private void OnItemTap(object sender, GestureEventArgs e) => this.SelectedItem = ((ContentPresenter) sender).Content;

    private void OnGroupHeaderTap(object sender, GestureEventArgs e) => this.OpenJumpList((ContentPresenter) sender);

    private void OnJumpListOpening(LongListSelector jumpListSelector)
    {
      EventHandler jumpListOpening = this.JumpListOpening;
      if (jumpListOpening == null)
        return;
      jumpListOpening((object) this, EventArgs.Empty);
    }

    private void OnJumpListClosing(object item)
    {
      this._jumpListController = (JumpListController) null;
      if (item != null)
        this.ScrollToGroup(item, true);
      else if (AutomationPeer.ListenerExists(AutomationEvents.AutomationFocusChanged))
        this.TrySetUiaFocus((UIElement) this._groupHeaderUsedToOpenJumplist);
      this._groupHeaderUsedToOpenJumplist = (ContentPresenter) null;
      this.QueueBalance();
    }

    private void OnJumpListClosed()
    {
      EventHandler jumpListClosed = this.JumpListClosed;
      if (jumpListClosed == null)
        return;
      jumpListClosed((object) this, EventArgs.Empty);
    }

    private void OnContainerManipulationStateChanged(object sender, EventArgs e)
    {
      if (this._container.ManipulationState == null)
        VisualStateManager.GoToState((Control) this, "NotScrolling", true);
      else
        VisualStateManager.GoToState((Control) this, "Scrolling", false);
      EventHandler manipulationStateChanged = this.ManipulationStateChanged;
      if (manipulationStateChanged != null)
        manipulationStateChanged((object) this, EventArgs.Empty);
      this.FirePropertyChangedEvent("ManipulationState");
    }

    private void OnContainerViewportChanged(object sender, EventArgs e)
    {
      if (!this._isBalanceDirty && (Math.Abs(this._lastBalanceViewport.Top - this._container.Viewport.Top) > this._viewportMoveThreshold || this._lastBalanceViewport.Width != this._container.Viewport.Width))
        this.QueueBalance();
      if (AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged) && this.GetOrCreateAutomationPeer() is LongListSelectorAutomationPeer automationPeer)
      {
        double scrollExtent = this.ScrollExtent;
        double height = this._lastReportedViewport.Height;
        double oldScrollOffset = this._lastReportedViewport.Top - this._container.Bounds.Top;
        automationPeer.RaiseScrollPropertyChangedEvents(scrollExtent, height, oldScrollOffset);
      }
      this._lastReportedViewport = this._container.Viewport;
    }

    private void OnItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
    {
      if (this._isItemsReset)
        return;
      if (args.Action != 4)
      {
        this.QueueChanges<LongListSelectorItem>(this._itemChanges, args);
      }
      else
      {
        this._isItemsReset = true;
        this._itemChanges.Clear();
        this._groupChanges.Clear();
      }
      this.QueueBalance();
    }

    private void OnItemsGroupChanged(object sender, NotifyCollectionChangedEventArgs args)
    {
      if (args.Action != 4)
        this.QueueChanges<object>(this._groupChanges, args);
      else
        this.QueueChanges<object>(this._groupChanges, (IList) new object[1]
        {
          sender
        }, LongListSelector.ItemChangeType.Add | LongListSelector.ItemChangeType.Remove);
      this.QueueBalance();
    }

    private void OnLongListSelectorSizeChanged(object sender, SizeChangedEventArgs e)
    {
      Size size = e.PreviousSize;
      double width1 = size.Width;
      size = e.NewSize;
      double width2 = size.Width;
      if (width1 != width2)
        this._isItemsReset = true;
      this._clipGeometry.Rect = new Rect(new Point(0.0, 0.0), e.NewSize);
      this.QueueBalance();
    }

    private void OnContainerSizeChanged(object sender, SizeChangedEventArgs e)
    {
      Size size = e.NewSize;
      double width1 = size.Width;
      size = e.PreviousSize;
      double width2 = size.Width;
      if (width1 == width2)
        return;
      if (this.LayoutMode == LongListSelectorLayoutMode.List)
      {
        foreach (LongListSelector.RealizedElement realizedElement in this._realizedElements)
          realizedElement.Presenter.Width = e.NewSize.Width;
        if (this._currentHeaderElement != null && this._isCurrentHeaderOrphaned)
          this._currentHeaderElement.Presenter.Width = e.NewSize.Width;
        if (this._previousHeaderElement != null && this._isPreviousHeaderOrphaned)
          this._previousHeaderElement.Presenter.Width = e.NewSize.Width;
        this._rightBound = e.NewSize.Width;
      }
      else
        this.UpdateGridColumns();
    }

    private void OnElementSizeChanged(object sender, SizeChangedEventArgs e)
    {
      ContentPresenter key = sender as ContentPresenter;
      bool flag = false;
      double num;
      if (this._ignoreHeightChanges.TryGetValue(key, out num))
      {
        flag = e.NewSize.Height == num;
        this._ignoreHeightChanges.Remove(key);
      }
      if (flag)
        return;
      this._heightChanges[key] = e.NewSize.Height;
      this.QueueBalance();
    }

    internal void OpenJumpList(ContentPresenter groupHeaderUsedToOpenJumplist)
    {
      if (this.JumpListStyle == null || this._jumpListController != null)
        return;
      FrameworkElement frameworkElement = (FrameworkElement) this;
      object obj = DependencyProperty.UnsetValue;
      for (; frameworkElement != null; frameworkElement = VisualTreeHelper.GetParent((DependencyObject) frameworkElement) as FrameworkElement)
      {
        obj = frameworkElement.ReadLocalValue(FrameworkElement.FlowDirectionProperty);
        if (obj != DependencyProperty.UnsetValue)
          break;
      }
      this._groupHeaderUsedToOpenJumplist = groupHeaderUsedToOpenJumplist;
      this._jumpListController = new JumpListController(this.ItemsSource, this.JumpListStyle, new Action<LongListSelector>(this.OnJumpListOpening), new Action<object>(this.OnJumpListClosing), new Action(this.OnJumpListClosed), obj == DependencyProperty.UnsetValue ? FlowDirection.LeftToRight : frameworkElement.FlowDirection);
      this._jumpListController.BeginOpen();
    }

    private void ThrowIfBalancing()
    {
      if (this._isBalancing)
        throw new InvalidOperationException(Resources.LongListSelector_IsBalancing);
    }

    protected override AutomationPeer OnCreateAutomationPeer() => (AutomationPeer) new LongListSelectorAutomationPeer(this);

    internal AutomationPeer OnCreateItemAutomationPeer(ContentPresenter presenter) => (AutomationPeer) new LongListSelectorItemAutomationPeer(presenter, this);

    internal List<AutomationPeer> AutomationGetChildrenAP()
    {
      List<AutomationPeer> automationPeerList = new List<AutomationPeer>();
      foreach (LongListSelector.RealizedElement realizedElement in this._realizedElements)
      {
        LongListSelectorItemKind itemKind = realizedElement.Item.ItemKind;
        if (this.IsGroupingEnabled)
        {
          if (itemKind != LongListSelectorItemKind.Item && itemKind != LongListSelectorItemKind.GroupFooter)
            automationPeerList.Add(realizedElement.Presenter.GetOrCreateAutomationPeer());
        }
        else
          automationPeerList.Add(realizedElement.Presenter.GetOrCreateAutomationPeer());
      }
      return automationPeerList;
    }

    internal List<AutomationPeer> AutomationGetGroupChildrenAP(
      ContentPresenter headerContainer)
    {
      List<AutomationPeer> automationPeerList = new List<AutomationPeer>();
      bool flag = false;
      foreach (LongListSelector.RealizedElement realizedElement in this._realizedElements)
      {
        if (realizedElement.Presenter == headerContainer)
          flag = true;
        else if (flag)
        {
          switch (realizedElement.Item.ItemKind)
          {
            case LongListSelectorItemKind.Item:
            case LongListSelectorItemKind.GroupFooter:
              automationPeerList.Add(realizedElement.Presenter.GetOrCreateAutomationPeer());
              continue;
            default:
              goto label_9;
          }
        }
      }
label_9:
      return automationPeerList;
    }

    internal ContentPresenter AutomationGetContainerForSelectedItem() => this.AutomationGetContainerForItem(this.SelectedItem);

    internal ContentPresenter AutomationGetContainerForItem(object item)
    {
      ContentPresenter contentPresenter = (ContentPresenter) null;
      foreach (LongListSelector.RealizedElement realizedElement in this._realizedElements)
      {
        if (realizedElement.Item.Data == item)
        {
          contentPresenter = realizedElement.Presenter;
          break;
        }
      }
      return contentPresenter;
    }

    internal LongListSelectorItem? AutomationItemFromContainer(
      ContentPresenter container)
    {
      LongListSelectorItem? nullable = new LongListSelectorItem?();
      foreach (LongListSelector.RealizedElement realizedElement in this._realizedElements)
      {
        if (realizedElement.Presenter == container)
        {
          nullable = new LongListSelectorItem?(realizedElement.Item);
          break;
        }
      }
      return nullable;
    }

    internal void AutomationScrollIntoView(ContentPresenter presenter)
    {
      double top = Canvas.GetTop((UIElement) presenter);
      if (presenter.Visibility != Visibility.Visible || this._realizedElements.Count <= 0)
        return;
      Point position = this._realizedElements.First.Value.Position;
      if (position.Y > top)
        return;
      position = this._realizedElements.Last.Value.Position;
      if (position.Y + this._realizedElements.Last.Value.Presenter.DesiredSize.Height < top)
        return;
      double num1 = this.ScrollOffset + this.ScrollViewport;
      double num2 = top - this._container.Bounds.Top;
      double num3 = num2 + presenter.DesiredSize.Height;
      double num4 = 0.0;
      if (num1 < num3)
        num4 = num3 - num1;
      if (num2 - num4 < this.ScrollOffset)
        num4 = num2 - this.ScrollOffset;
      if (num4 == 0.0)
        return;
      this.ScrollOffset += num4;
    }

    private void TrySetUiaFocus(UIElement element)
    {
      if (element == null)
        return;
      FrameworkElementAutomationPeer.CreatePeerForElement(element)?.RaiseAutomationEvent(AutomationEvents.AutomationFocusChanged);
    }

    private void UpdateAutomationPeersParent()
    {
      if (!this._isAPDirty)
        return;
      AutomationPeer automationPeer1 = this.GetAutomationPeer();
      if (automationPeer1 != null)
      {
        AutomationPeer parent = (AutomationPeer) null;
        foreach (LongListSelector.RealizedElement realizedElement in this._realizedElements)
        {
          AutomationPeer automationPeer2 = realizedElement.Presenter.GetAutomationPeer();
          if (automationPeer2 != null)
          {
            if (realizedElement.Item.ItemKind == LongListSelectorItemKind.GroupHeader)
              parent = automationPeer2;
            if (parent != null && (realizedElement.Item.ItemKind == LongListSelectorItemKind.GroupFooter || realizedElement.Item.ItemKind == LongListSelectorItemKind.Item))
              automationPeer2.SetAutomationPeerParent(parent);
            else
              automationPeer2.SetAutomationPeerParent(automationPeer1);
          }
        }
      }
      this._isAPDirty = false;
    }

    [Conditional("DEBUG")]
    private void CalculateBufferUtilization()
    {
      if (!this.TryGetRealizedItemsTop(out double _) || !this.TryGetRealizedItemsBottom(out double _))
        return;
      double top = this._viewport.Top;
      double bottom = this._viewport.Bottom;
    }

    [Conditional("DEBUG")]
    private void ValidateAllRanges()
    {
      foreach (LongListSelector.RealizedRange realizedRange in (IEnumerable<LongListSelector.RealizedRange>) this._realizedRanges)
        ;
    }

    [Conditional("LLS_TRACE")]
    internal static void LlsTrace(string format, params object[] p)
    {
    }

    internal static string GetDebugName(object item)
    {
      if (item == null)
        return "null";
      return item.ToString() + " (" + (object) item.GetHashCode() + ")";
    }

    [Conditional("DEBUG")]
    private void DumpRange(LongListSelector.RealizedRange range)
    {
      if (range.HeadNode == null)
        return;
      LinkedListNode<LongListSelector.RealizedElement> linkedListNode = range.HeadNode;
      string str1 = "";
      LongListSelectorItem current;
      do
      {
        string str2 = str1;
        current = linkedListNode.Value.Item;
        string debugName = LongListSelector.GetDebugName(current.Data);
        str1 = str2 + debugName + ";";
        linkedListNode = linkedListNode.Next;
      }
      while (linkedListNode != range.TailNode.Next);
      string str3 = "";
      using (Iterator<LongListSelectorItem> iterator = range.HeadIterator.Clone())
      {
        do
        {
          if (iterator != null)
          {
            current = iterator.Current;
            if (current.Data != null)
            {
              string str2 = str3;
              current = iterator.Current;
              string debugName = LongListSelector.GetDebugName(current.Data);
              str3 = str2 + debugName + ";";
            }
          }
        }
        while (iterator.MoveNext());
      }
    }

    [Conditional("DEBUG")]
    private void ValidateState()
    {
      bool flag1 = this._currentHeaderElement == null;
      bool flag2 = this._previousHeaderElement == null;
      Dictionary<object, bool> dictionary1 = new Dictionary<object, bool>();
      foreach (object key in (IEnumerable<object>) this._realizedHeaderGroups.Keys)
        dictionary1.Add(key, true);
      if (this._realizedRanges.Count > 0)
      {
        foreach (LongListSelector.RealizedRange realizedRange in (IEnumerable<LongListSelector.RealizedRange>) this._realizedRanges)
        {
          if (realizedRange.HeadNode != null)
          {
            using (Iterator<LongListSelectorItem> iterator = realizedRange.HeadIterator.Clone())
            {
              LinkedListNode<LongListSelector.RealizedElement> linkedListNode = realizedRange.HeadNode;
              do
              {
                int num1;
                if (!flag1)
                {
                  LongListSelectorItem listSelectorItem = linkedListNode.Value.Item;
                  object data1 = listSelectorItem.Data;
                  listSelectorItem = this._currentHeaderElement.Item;
                  object data2 = listSelectorItem.Data;
                  num1 = data1 == data2 ? 1 : 0;
                }
                else
                  num1 = 1;
                flag1 = num1 != 0;
                int num2;
                if (!flag2)
                {
                  LongListSelectorItem listSelectorItem = linkedListNode.Value.Item;
                  object data1 = listSelectorItem.Data;
                  listSelectorItem = this._previousHeaderElement.Item;
                  object data2 = listSelectorItem.Data;
                  num2 = data1 == data2 ? 1 : 0;
                }
                else
                  num2 = 1;
                flag2 = num2 != 0;
                LongListSelectorItem listSelectorItem1 = linkedListNode.Value.Item;
                if (listSelectorItem1.ItemKind == LongListSelectorItemKind.GroupHeader)
                {
                  Dictionary<object, bool> dictionary2 = dictionary1;
                  listSelectorItem1 = linkedListNode.Value.Item;
                  object data1 = listSelectorItem1.Data;
                  if (dictionary2.ContainsKey(data1))
                  {
                    Dictionary<object, bool> dictionary3 = dictionary1;
                    listSelectorItem1 = linkedListNode.Value.Item;
                    object data2 = listSelectorItem1.Data;
                    dictionary3.Remove(data2);
                  }
                }
                linkedListNode = linkedListNode.Next;
                if (linkedListNode == realizedRange.TailNode.Next)
                  break;
              }
              while (iterator.MoveNext());
            }
          }
        }
      }
      int count1 = this._realizedRanges.Count;
      foreach (object key in dictionary1.Keys)
        ;
      int count2 = this._realizedRanges.Count;
    }

    [SecuritySafeCritical]
    private bool HasDirectManipulationControl() => this._dmLongListSelector != IntPtr.Zero;

    [SecuritySafeCritical]
    private void SetDirectManipulationControl() => XcpImports.Control_SetLongListSelectorDirectManipulationControl((Control) this, ref this._dmLongListSelector);

    [SecuritySafeCritical]
    private void DirectManipulationAddHeader(ContentPresenter cp) => XcpImports.DMLongListSelector_AddHeader(this._dmLongListSelector, (UIElement) cp);

    [SecuritySafeCritical]
    private void DirectManipulationRemoveHeader(ContentPresenter cp) => XcpImports.DMLongListSelector_RemoveHeader(this._dmLongListSelector, (UIElement) cp);

    [Flags]
    private enum ItemChangeType
    {
      None = 0,
      Add = 1,
      Remove = 2,
    }

    private enum AddItemResult
    {
      Success,
      RangeCollision,
      EndOfBuffer,
      EndOfItems,
    }

    internal enum RealizeOptions
    {
      None,
      AsOrphan,
    }

    private class RealizedElement
    {
      private Point _position;

      internal RealizedElement(ContentPresenter presenter, LongListSelectorItem item)
      {
        this.Presenter = presenter;
        this.Item = item;
      }

      internal ContentPresenter Presenter { get; private set; }

      internal LongListSelectorItem Item { get; private set; }

      internal Point Position
      {
        get => this._position;
        set
        {
          this._position = value;
          Canvas.SetLeft((UIElement) this.Presenter, this._position.X);
          Canvas.SetTop((UIElement) this.Presenter, this._position.Y);
        }
      }

      internal void UpdateItem(LongListSelectorItem newItem) => this.Item = newItem;
    }

    private class RealizedRange : IDisposable
    {
      private LongListSelector _parent;
      private LinkedListNode<LongListSelector.RealizedElement> _headNode;
      private LinkedListNode<LongListSelector.RealizedElement> _tailNode;
      private double _headY;
      private double _tailY;
      private bool _isRangeEmpty;

      internal RealizedRange(LongListSelector parent, Iterator<LongListSelectorItem> iterator)
      {
        this._parent = parent;
        this.HeadIterator = iterator;
        this.ResetTailIterator();
        this._headY = this._tailY = this._parent._viewport.Top;
      }

      private RealizedRange(
        LongListSelector parent,
        Iterator<LongListSelectorItem> headIterator,
        LinkedListNode<LongListSelector.RealizedElement> headNode,
        Iterator<LongListSelectorItem> tailIterator,
        LinkedListNode<LongListSelector.RealizedElement> tailNode)
      {
        this._parent = parent;
        this.HeadIterator = headIterator;
        this.HeadNode = headNode;
        this.TailIterator = tailIterator;
        this.TailNode = tailNode;
      }

      internal Iterator<LongListSelectorItem> HeadIterator { get; private set; }

      internal Iterator<LongListSelectorItem> TailIterator { get; private set; }

      internal LinkedListNode<LongListSelector.RealizedElement> HeadNode
      {
        get => this._headNode;
        private set
        {
          this._headNode = value;
          if (this._headNode == null)
            return;
          this._headY = this._headNode.Value.Position.Y;
        }
      }

      internal LinkedListNode<LongListSelector.RealizedElement> TailNode
      {
        get => this._tailNode;
        private set
        {
          this._tailNode = value;
          if (this._tailNode == null)
            return;
          this._tailY = this._tailNode.Value.Position.Y;
        }
      }

      internal double HeadY => this._headY;

      internal double TailY => this._tailY;

      internal void ShiftY(double y)
      {
        this._headY += y;
        this._tailY += y;
      }

      public void Dispose()
      {
        this.Clear();
        this.HeadIterator.Dispose();
        this.HeadIterator = (Iterator<LongListSelectorItem>) null;
        this.TailIterator.Dispose();
        this.TailIterator = (Iterator<LongListSelectorItem>) null;
      }

      internal void TrimHead()
      {
        bool flag = this.HeadIterator.Current.Equals((object) this.HeadNode.Value.Item);
        if (flag)
          this.MoveNext(this.HeadIterator);
        LinkedListNode<LongListSelector.RealizedElement> headNode = this.HeadNode;
        this._parent.RecycleDisplayItem(headNode.Value);
        if (this.HeadNode != this.TailNode)
        {
          this.HeadNode = headNode.Next;
        }
        else
        {
          this.HeadNode = this.TailNode = (LinkedListNode<LongListSelector.RealizedElement>) null;
          if (flag)
          {
            if (!this.MovePrevious(this.HeadIterator))
              this.MoveNext(this.HeadIterator);
            this.ResetTailIterator();
            this._headY = this.TailY;
          }
          else
          {
            this.TailIterator.Reset();
            this.ResetHeadIterator();
            this._headY = this._tailY = this._parent._viewport.Top;
          }
        }
        this._parent._realizedElements.Remove(headNode);
      }

      internal void TrimTail()
      {
        this.EnsureTailIterator();
        bool flag = this.TailIterator.Current.Equals((object) this.TailNode.Value.Item);
        if (flag)
          this.MovePrevious(this.TailIterator);
        LinkedListNode<LongListSelector.RealizedElement> tailNode = this.TailNode;
        this._parent.RecycleDisplayItem(tailNode.Value);
        if (this.HeadNode != this.TailNode)
        {
          this.TailNode = tailNode.Previous;
        }
        else
        {
          this.HeadNode = this.TailNode = (LinkedListNode<LongListSelector.RealizedElement>) null;
          if (flag)
          {
            this.ResetHeadIterator();
            this._tailY = this.HeadY;
          }
          else
          {
            this.TailIterator.Reset();
            this.ResetHeadIterator();
            this._headY = this._tailY = this._parent._viewport.Top;
          }
        }
        this._parent._realizedElements.Remove(tailNode);
      }

      internal void MergeToHead(LongListSelector.RealizedRange range)
      {
        this.MergeItemsLayout(range);
        Iterator<LongListSelectorItem> headIterator = this.HeadIterator;
        this.HeadIterator = range.HeadIterator;
        this.HeadNode = range.HeadNode;
        range.HeadIterator = headIterator;
        LongListSelector.RealizedRange realizedRange = range;
        // ISSUE: variable of the null type
        __Null local;
        LinkedListNode<LongListSelector.RealizedElement> linkedListNode = (LinkedListNode<LongListSelector.RealizedElement>) (local = null);
        realizedRange.TailNode = (LinkedListNode<LongListSelector.RealizedElement>) local;
        realizedRange.HeadNode = linkedListNode;
      }

      internal LongListSelector.AddItemResult Append(
        LongListSelector.RealizedRange nextRange,
        double bottom)
      {
        this.EnsureTailIterator();
        LongListSelector.AddItemResult addItemResult = LongListSelector.AddItemResult.Success;
        if (!this.MoveNext(this.TailIterator))
          addItemResult = LongListSelector.AddItemResult.EndOfItems;
        else if (nextRange != null && this.TailIterator.Current.Equals((object) nextRange.HeadIterator.Current))
          addItemResult = LongListSelector.AddItemResult.RangeCollision;
        Point point = new Point();
        if (addItemResult == LongListSelector.AddItemResult.Success)
        {
          point = this.GetAppendPosition(this.TailY, this.TailIterator.Current, this.TailNode != null ? this.TailNode.Value.Presenter.DesiredSize.Height : 0.0);
          if (point.Y >= bottom)
            addItemResult = LongListSelector.AddItemResult.EndOfBuffer;
        }
        if (addItemResult == LongListSelector.AddItemResult.Success)
        {
          LongListSelector.RealizedElement realizedElement = this._parent.RealizeDisplayItem(this.TailIterator, LongListSelector.RealizeOptions.None);
          realizedElement.Position = point;
          this.TailNode = this.TailNode == null || this.TailNode == this._parent._realizedElements.Last ? this._parent._realizedElements.AddLast(realizedElement) : this._parent._realizedElements.AddAfter(this.TailNode, realizedElement);
          if (this.HeadNode == null)
            this.HeadNode = this.TailNode;
        }
        else
          this.MovePrevious(this.TailIterator);
        return addItemResult;
      }

      internal LongListSelector.AddItemResult Prepend()
      {
        LongListSelector.AddItemResult addItemResult = LongListSelector.AddItemResult.Success;
        if (!this.MovePrevious(this.HeadIterator))
          addItemResult = LongListSelector.AddItemResult.EndOfItems;
        if (addItemResult == LongListSelector.AddItemResult.Success)
        {
          LongListSelectorItem current = this.HeadIterator.Current;
          LongListSelector.RealizedElement realizedElement = this._parent.RealizeDisplayItem(this.HeadIterator, LongListSelector.RealizeOptions.None);
          realizedElement.Position = this.GetPrependPosition(this.HeadY, current, realizedElement.Presenter.DesiredSize.Height);
          this.HeadNode = this.HeadNode == null || this.HeadNode == this._parent._realizedElements.First ? this._parent._realizedElements.AddFirst(realizedElement) : this._parent._realizedElements.AddBefore(this.HeadNode, realizedElement);
          if (this.TailNode == null)
            this.TailNode = this.HeadNode;
        }
        else
          this.MoveNext(this.HeadIterator);
        return addItemResult;
      }

      internal void ShiftElements(double yOffset)
      {
        if (yOffset == 0.0)
          return;
        this._headY += yOffset;
        if (this.HeadNode != null)
        {
          LinkedListNode<LongListSelector.RealizedElement> linkedListNode = this.HeadNode;
          do
          {
            Point point;
            ref Point local = ref point;
            Point position = linkedListNode.Value.Position;
            double x = position.X;
            position = linkedListNode.Value.Position;
            double y = position.Y + yOffset;
            local = new Point(x, y);
            linkedListNode.Value.Position = point;
            linkedListNode = linkedListNode.Next;
          }
          while (linkedListNode != this.TailNode.Next);
        }
        this._tailY += yOffset;
      }

      internal bool MergeItemsLayout(LongListSelector.RealizedRange range)
      {
        int num = 0;
        LongListSelector.RealizedRange realizedRange = range;
        Point appendPosition = realizedRange.GetAppendPosition(realizedRange.TailY, this.HeadIterator.Current, range.TailNode != null ? range.TailNode.Value.Presenter.DesiredSize.Height : 0.0);
        double yOffset = appendPosition.Y - this.HeadNode.Value.Position.Y;
        if (this.HeadIterator.Current.ItemKind != LongListSelectorItemKind.Item || this._parent._gridColumnsInRow == 1 || appendPosition.X == this.HeadNode.Value.Position.X)
        {
          if (this.HeadY < this._parent._viewport.Top)
          {
            range.ShiftElements(-yOffset);
            return num != 0;
          }
          this.ShiftElements(yOffset);
          return num != 0;
        }
        this._headY += yOffset;
        this.UpdateItemPositions(appendPosition);
        return num != 0;
      }

      private void UpdateItemPositions(Point newPosition)
      {
        using (Iterator<LongListSelectorItem> iterator = this.HeadIterator.Clone())
        {
          LinkedListNode<LongListSelector.RealizedElement> linkedListNode1 = this.HeadNode;
          LinkedListNode<LongListSelector.RealizedElement> linkedListNode2 = (LinkedListNode<LongListSelector.RealizedElement>) null;
          do
          {
            linkedListNode1.Value.UpdateItem(iterator.Current);
            if (linkedListNode2 != null)
              newPosition = this.GetAppendPosition(newPosition.Y, linkedListNode1.Value.Item, linkedListNode2 != null ? linkedListNode2.Value.Presenter.DesiredSize.Height : 0.0);
            linkedListNode1.Value.Position = newPosition;
            linkedListNode2 = linkedListNode1;
            linkedListNode1 = linkedListNode1.Next;
            if (linkedListNode1 == this.TailNode.Next)
              break;
          }
          while (iterator.MoveNext());
        }
        this._tailY = newPosition.Y;
      }

      internal void UpdateItemColumns()
      {
        if (this.HeadNode == null || this.HeadNode.Value.Item.ItemKind != LongListSelectorItemKind.Item)
          return;
        int num1 = this.HeadNode.Value.Item.IndexInGroup % this._parent._gridColumnsInRow;
        int num2 = this.HeadIterator.Current.IndexInGroup % this._parent._gridColumnsInRow;
        int num3 = num2;
        if (num1 == num3)
          return;
        this.UpdateItemPositions(new Point((double) num2 * this._parent.GridCellSize.Width, this.HeadY));
      }

      internal void Clear()
      {
        while (this.HeadNode != null)
          this.TrimTail();
      }

      internal void ClearToY(double yValue)
      {
        bool flag = true;
        LinkedListNode<LongListSelector.RealizedElement> linkedListNode = this.HeadNode;
        while (linkedListNode != null)
        {
          if (flag && linkedListNode.Value.Position.Y + linkedListNode.Value.Presenter.ActualHeight > yValue)
          {
            flag = false;
            LinkedListNode<LongListSelector.RealizedElement> tailNode = this.TailNode;
          }
          if (flag)
          {
            this.TrimHead();
            linkedListNode = this.HeadNode;
          }
          else
          {
            this.TrimTail();
            linkedListNode = this.TailNode;
          }
        }
      }

      internal void SkipToY(double yValue)
      {
        if (yValue > this.TailY)
        {
          Point point = new Point(0.0, this.TailY);
          double y;
          bool flag;
          do
          {
            y = point.Y;
            flag = this.MoveNext(this.TailIterator) & this.MoveNext(this.HeadIterator);
            if (flag)
              point = this.GetAppendPosition(y, this.TailIterator.Current, this.TailIterator.Current.ItemKind == LongListSelectorItemKind.Item ? this._parent.EstimatedItemHeight : this._parent.EstimatedNonItemHeight);
          }
          while (flag && point.Y < yValue);
          this.MovePrevious(this.TailIterator);
          this.MovePrevious(this.HeadIterator);
          this._tailY = this._headY = y;
        }
        else
        {
          if (yValue >= this.HeadY)
            return;
          double headY = this.HeadY;
          bool flag = true;
          while (flag && headY > yValue)
          {
            flag = this.MovePrevious(this.HeadIterator) & this.MovePrevious(this.TailIterator);
            if (flag)
              headY = this.GetPrependPosition(headY, this.HeadIterator.Current, this.TailIterator.Current.ItemKind == LongListSelectorItemKind.Item ? this._parent.EstimatedItemHeight : this._parent.EstimatedNonItemHeight).Y;
          }
          this._headY = this._tailY = headY;
        }
      }

      internal LongListSelector.RealizedRange SplitBefore(
        LinkedListNode<LongListSelector.RealizedElement> node,
        Iterator<LongListSelectorItem> iterator)
      {
        LongListSelector.RealizedRange realizedRange = new LongListSelector.RealizedRange(this._parent, iterator.Clone(), node, this.TailIterator, this.TailNode);
        this.TailNode = node.Previous;
        Iterator<LongListSelectorItem> iterator1 = iterator.Clone();
        this.MovePrevious(iterator1);
        this.TailIterator = iterator1;
        return realizedRange;
      }

      internal bool TrimChanges(bool atHead)
      {
        bool flag1 = false;
        Iterator<LongListSelectorItem> iterator = atHead ? this.HeadIterator : this.TailIterator;
        bool flag2 = true;
        while (flag2 && this._parent.GetItemChanges(iterator.Current) != LongListSelector.ItemChangeType.None)
        {
          flag2 = !atHead ? this.MovePrevious(iterator) : this.MoveNext(iterator);
          flag1 = true;
        }
        LinkedListNode<LongListSelector.RealizedElement> linkedListNode = atHead ? this.HeadNode : this.TailNode;
        while (linkedListNode != null && (this._parent.GetItemChanges(linkedListNode.Value.Item) & LongListSelector.ItemChangeType.Remove) != LongListSelector.ItemChangeType.None)
        {
          if (atHead)
          {
            this.TrimHead();
            linkedListNode = this.HeadNode;
          }
          else
          {
            this.TrimTail();
            linkedListNode = this.TailNode;
          }
          flag1 = true;
        }
        return flag1;
      }

      [Conditional("DEBUG")]
      internal void ValidateState()
      {
        if (this.HeadNode == null)
          return;
        using (Iterator<LongListSelectorItem> iterator = this.HeadIterator.Clone())
        {
          LinkedListNode<LongListSelector.RealizedElement> linkedListNode = this.HeadNode;
          do
          {
            linkedListNode = linkedListNode.Next;
          }
          while (linkedListNode != this.TailNode.Next && iterator.MoveNext());
        }
      }

      private void ResetHeadIterator()
      {
        if (this.HeadIterator != null)
          this.HeadIterator.Dispose();
        this.HeadIterator = this.TailIterator.Clone();
        this.HeadIterator.MoveNext();
        this._isRangeEmpty = true;
      }

      private void ResetTailIterator()
      {
        if (this.TailIterator != null)
          this.TailIterator.Dispose();
        this.TailIterator = this.HeadIterator.Clone();
        this.TailIterator.MovePrevious();
        this._isRangeEmpty = true;
      }

      private void EnsureTailIterator()
      {
        if (!this._isRangeEmpty)
          return;
        this.ResetTailIterator();
      }

      public Point GetAppendPosition(
        double tailY,
        LongListSelectorItem item,
        double tailHeight)
      {
        double x = 0.0;
        if (this._parent._gridColumnsInRow > 1)
          x = (item.ItemKind != LongListSelectorItemKind.Item ? 0.0 : (double) (item.IndexInGroup % this._parent._gridColumnsInRow)) * this._parent.GridCellSize.Width;
        double y = tailY;
        if (x == 0.0)
          y += tailHeight;
        return new Point(x, y);
      }

      public Point GetPrependPosition(
        double headY,
        LongListSelectorItem item,
        double newItemHeight)
      {
        double x = 0.0;
        double y = headY;
        if (item.ItemKind == LongListSelectorItemKind.Item)
        {
          int num = item.IndexInGroup % this._parent._gridColumnsInRow;
          if (this._parent.LayoutMode == LongListSelectorLayoutMode.Grid)
            x = (double) num * this._parent.GridCellSize.Width;
          if (num == this._parent._gridColumnsInRow - 1)
            y -= newItemHeight;
          else if (item.Group is IList group4 && item.IndexInGroup == group4.Count - 1)
            y -= newItemHeight;
        }
        else
          y -= newItemHeight;
        return new Point(x, y);
      }

      private bool MoveNext(Iterator<LongListSelectorItem> iterator)
      {
        if (this._isRangeEmpty && iterator == this.HeadIterator)
          return false;
        bool flag = this.HeadIterator.AtSamePosition(this.TailIterator);
        int num = iterator.MoveNext() ? 1 : 0;
        this._isRangeEmpty = flag && iterator == this.HeadIterator;
        return num != 0;
      }

      private bool MovePrevious(Iterator<LongListSelectorItem> iterator)
      {
        if (this._isRangeEmpty && iterator == this.TailIterator)
          return false;
        bool flag = this.HeadIterator.AtSamePosition(this.TailIterator);
        int num = iterator.MovePrevious() ? 1 : 0;
        this._isRangeEmpty = flag && iterator == this.TailIterator;
        return num != 0;
      }

      [Conditional("Debug")]
      internal void DebugPrint()
      {
      }
    }
  }
}
