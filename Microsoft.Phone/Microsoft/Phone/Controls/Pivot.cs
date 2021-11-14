// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Pivot
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
using System.Windows.Media.Animation;

namespace Microsoft.Phone.Controls
{
  [TemplatePart(Name = "TitleElement", Type = typeof (UIElement))]
  [TemplatePart(Name = "HeadersListElement", Type = typeof (PivotHeadersControl))]
  [TemplatePart(Name = "PivotItemPresenter", Type = typeof (ItemsPresenter))]
  [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof (PivotItem))]
  public class Pivot : ItemsControl
  {
    private const string ElementHeadersRowDefinitionName = "HeadersRowDefinition";
    private const string TitleElement = "TitleElement";
    private const string HeadersListElement = "HeadersListElement";
    private const string PivotItemPresenterElement = "PivotItemPresenter";
    internal const string ItemContainerStyleName = "ItemContainerStyle";
    private const double pixelsPerSecondTemporary = 600.0;
    internal const double PivotAnimationSeconds = 0.25;
    private static readonly TimeSpan PivotAnimationTimeSpan = TimeSpan.FromSeconds(0.25);
    internal static readonly Duration PivotAnimationDuration = new Duration(Pivot.PivotAnimationTimeSpan);
    internal static readonly Duration ZeroDuration = new Duration(TimeSpan.Zero);
    internal readonly IEasingFunction QuarticEase = (IEasingFunction) new System.Windows.Media.Animation.QuarticEase();
    private PivotHeadersControl _headers;
    private ItemsPresenter _itemsPresenter;
    private Panel _itemsPanel;
    private AnimationDirection? _animationHint;
    private bool _updatingHeaderItems;
    private bool _ignorePropertyChange;
    private int _lastItemsCount;
    internal PivotHeadersControl _clickedHeadersControl;
    private bool _isDMPivotItemsInitialized;
    private bool _animating;
    private bool _isHorizontalDragging;
    private double _actualWidth;
    private bool _isDesignTime;
    private bool _skippedLoadingPivotItem;
    private bool _skippedSwapVisibleContent;
    private bool _dragging;
    private bool _isLocked;
    private Pivot.DragLock _dragLock;
    private WeakReference _gestureSource;
    private Point _gestureOrigin;
    private bool _templateApplied;
    private Queue<int> _queuedIndexChanges;
    private TransformAnimator _panAnimator;
    public static readonly DependencyProperty HeaderTemplateProperty = DependencyProperty.Register(nameof (HeaderTemplate), typeof (DataTemplate), typeof (Pivot), new PropertyMetadata((PropertyChangedCallback) null));
    public static readonly DependencyProperty SelectedIndexProperty = DependencyProperty.Register(nameof (SelectedIndex), typeof (int), typeof (Pivot), new PropertyMetadata(new PropertyChangedCallback(Pivot.OnSelectedIndexPropertyChanged)));
    public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register(nameof (SelectedItem), typeof (object), typeof (Pivot), new PropertyMetadata((object) null, new PropertyChangedCallback(Pivot.OnSelectedItemPropertyChanged)));
    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof (Title), typeof (object), typeof (Pivot), new PropertyMetadata((PropertyChangedCallback) null));
    public static readonly DependencyProperty TitleTemplateProperty = DependencyProperty.Register(nameof (TitleTemplate), typeof (DataTemplate), typeof (Pivot), new PropertyMetadata((PropertyChangedCallback) null));
    private readonly Dictionary<object, PivotItem> _itemToContainer = new Dictionary<object, PivotItem>();
    private readonly Dictionary<PivotItem, object> _containerToItem = new Dictionary<PivotItem, object>();
    [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Justification = "This is correct use of DependencyProperty.")]
    public static readonly DependencyProperty ItemContainerStyleProperty = DependencyProperty.Register(nameof (ItemContainerStyle), typeof (Style), typeof (Pivot), (PropertyMetadata) null);
    [SecurityCritical]
    private IntPtr _directManipulationControl;
    private bool _isHandlingDirectManipulation;

    internal bool IsHandlingDirectManipulation => this._isHandlingDirectManipulation;

    internal UIElement TitlePart => this.GetTemplateChild("TitleElement") as UIElement;

    public event EventHandler<PivotItemEventArgs> LoadingPivotItem;

    public event EventHandler<PivotItemEventArgs> LoadedPivotItem;

    public event EventHandler<PivotItemEventArgs> UnloadingPivotItem;

    public event EventHandler<PivotItemEventArgs> UnloadedPivotItem;

    public event SelectionChangedEventHandler SelectionChanged;

    public DataTemplate HeaderTemplate
    {
      get => this.GetValue(Pivot.HeaderTemplateProperty) as DataTemplate;
      set => this.SetValue(Pivot.HeaderTemplateProperty, (DependencyObject) value);
    }

    public int SelectedIndex
    {
      get => (int) this.GetValue(Pivot.SelectedIndexProperty);
      set
      {
        if (this.IsLocked && this.ReadLocalValue(Pivot.SelectedIndexProperty) != DependencyProperty.UnsetValue)
          return;
        this.SetValue(Pivot.SelectedIndexProperty, value);
      }
    }

    private static void OnSelectedIndexPropertyChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Pivot pivot = d as Pivot;
      if (pivot._ignorePropertyChange)
      {
        pivot._ignorePropertyChange = false;
      }
      else
      {
        pivot.UpdateSelectedIndex((int) e.OldValue, (int) e.NewValue);
        pivot.UpdateDirectManipulationSelectedIndex((int) e.NewValue);
      }
    }

    public object SelectedItem
    {
      get => this.GetValue(Pivot.SelectedItemProperty);
      set => this.SetValue(Pivot.SelectedItemProperty, value);
    }

    private static void OnSelectedItemPropertyChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      Pivot pivot = d as Pivot;
      if (pivot._ignorePropertyChange)
        pivot._ignorePropertyChange = false;
      else
        pivot.UpdateSelectedItem(e.OldValue, e.NewValue);
    }

    public object Title
    {
      get => this.GetValue(Pivot.TitleProperty);
      set => this.SetValue(Pivot.TitleProperty, value);
    }

    public DataTemplate TitleTemplate
    {
      get => this.GetValue(Pivot.TitleTemplateProperty) as DataTemplate;
      set => this.SetValue(Pivot.TitleTemplateProperty, (DependencyObject) value);
    }

    public Pivot()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_STARTUP, PerfLog.Pivot);
      this.DefaultStyleKey = (object) typeof (Pivot);
      this.AllowSetManipulationRouting(false);
      this.SizeChanged += new SizeChangedEventHandler(this.OnSizeChanged);
      this.ManipulationStarted += new EventHandler<ManipulationStartedEventArgs>(this.OnManipulationStarted);
      this.ManipulationDelta += new EventHandler<ManipulationDeltaEventArgs>(this.OnManipulationDelta);
      this.ManipulationCompleted += new EventHandler<ManipulationCompletedEventArgs>(this.OnManipulationCompleted);
      this._isDesignTime = DesignerProperties.IsInDesignTool;
      this._queuedIndexChanges = new Queue<int>(5);
      this.Loaded += new RoutedEventHandler(this.Pivot_Loaded);
      this.PivotNavigateByIndexChanged += new EventHandler(this.OnPivotNavigateByIndexChanged);
    }

    private void Pivot_Loaded(object sender, RoutedEventArgs e)
    {
      this.Loaded -= new RoutedEventHandler(this.Pivot_Loaded);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_STARTUP, PerfLog.Pivot);
    }

    private void OnPivotNavigateByIndexChanged(object sender, EventArgs e)
    {
      if (this.PivotNavigateByIndex == 0)
        return;
      this.NavigateByIndexChange(this.PivotNavigateByIndex);
    }

    public override void OnApplyTemplate()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_APPLYTEMPLATE, PerfLog.Pivot);
      if (this._headers != null)
        this._headers.SelectedIndexChanged -= new EventHandler<SelectedIndexChangedEventArgs>(this.OnHeaderSelectionChanged);
      base.OnApplyTemplate();
      this._itemsPresenter = this.GetTemplateChild("PivotItemPresenter") as ItemsPresenter;
      if (this._itemsPresenter != null && !(this._itemsPresenter.RenderTransform is TranslateTransform))
        this._itemsPresenter.RenderTransform = (Transform) new TranslateTransform();
      this._headers = this.GetTemplateChild("HeadersListElement") as PivotHeadersControl;
      if (this._headers != null)
      {
        this._headers.SelectedIndexChanged += new EventHandler<SelectedIndexChangedEventArgs>(this.OnHeaderSelectionChanged);
        this.UpdateHeaders();
      }
      if (this.Items.Count > 0)
      {
        if (this.SelectedIndex < 0)
          this.SelectedIndex = 0;
        else
          this.UpdateSelectedIndex(-1, this.SelectedIndex);
      }
      this.UpdateVisibleContent(this.SelectedIndex);
      this.SetSelectedHeaderIndex(this.SelectedIndex);
      this._templateApplied = true;
      this.CreateDirectManipulationControl();
      this.UpdateDirectManipulationSelectedIndex(this.SelectedIndex);
      this.SetAutomaticBitmapCache();
      this.SetDirectManipulationTarget((UIElement) this._itemsPresenter);
      this._itemsPresenter.SetAutomaticBitmapCache();
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_APPLYTEMPLATE, PerfLog.Pivot);
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_ARRANGE, PerfLog.Pivot);
      Size size = base.ArrangeOverride(finalSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_ARRANGE, PerfLog.Pivot);
      if (this._isDMPivotItemsInitialized || !this.HasDirectManipulationControl())
        return size;
      this.UpdateDirectManipulationPivotItems();
      return size;
    }

    protected override Size MeasureOverride(Size availableSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_MEASURE, PerfLog.Pivot);
      Size size = base.MeasureOverride(availableSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_MEASURE, PerfLog.Pivot);
      return size;
    }

    protected override AutomationPeer OnCreateAutomationPeer() => (AutomationPeer) new PivotAutomationPeer(this);

    internal AutomationPeer GetPivotHeaderItemAPForItem(object item)
    {
      AutomationPeer automationPeer = (AutomationPeer) null;
      if (this._headers != null)
      {
        PivotHeaderItem headerItemForItem = this._headers.GetPivotHeaderItemForItem(item);
        if (headerItemForItem != null)
          automationPeer = FrameworkElementAutomationPeer.CreatePeerForElement((UIElement) headerItemForItem);
      }
      return automationPeer;
    }

    protected virtual void OnLoadingPivotItem(PivotItem item)
    {
      if (item != null && item.FirstVisualChild != null && item.FirstVisualChild.Visibility == Visibility.Collapsed)
        item.FirstVisualChild.Visibility = Visibility.Visible;
      if (item != null)
        item.IsFirstVisualChildVisible = true;
      SafeRaise.Raise<PivotItemEventArgs>(this.LoadingPivotItem, (object) this, (SafeRaise.GetEventArgs<PivotItemEventArgs>) (() => new PivotItemEventArgs(item)));
    }

    protected virtual void OnLoadedPivotItem(PivotItem item)
    {
      SafeRaise.Raise<PivotItemEventArgs>(this.LoadedPivotItem, (object) this, (SafeRaise.GetEventArgs<PivotItemEventArgs>) (() => new PivotItemEventArgs(item)));
      this.OptimizeVisuals();
    }

    private void OptimizeVisuals()
    {
      int selectedIndex = this.SelectedIndex;
      if (selectedIndex < 0 || this.Items.Count <= 1)
        return;
      PivotItem container1 = this.GetContainer(this.Items[this.RollingIncrement(selectedIndex)]);
      PivotItem container2 = this.GetContainer(this.Items[this.RollingDecrement(selectedIndex)]);
      UIElement next = container1?.FirstVisualChild;
      UIElement previous = container2?.FirstVisualChild;
      bool flag = true;
      if (next != null && previous != null && (next.Visibility == previous.Visibility && previous.Visibility == Visibility.Visible))
        flag = false;
      if (!flag)
        return;
      this.Dispatcher.BeginInvoke((Action) (() =>
      {
        if (next != null && next.Visibility == Visibility.Collapsed)
          next.Visibility = Visibility.Visible;
        if (previous == next)
          return;
        this.Dispatcher.BeginInvoke((Action) (() =>
        {
          if (previous == null || previous.Visibility != Visibility.Collapsed)
            return;
          previous.Visibility = Visibility.Visible;
        }));
      }));
    }

    protected virtual void OnUnloadingPivotItem(PivotItemEventArgs e)
    {
      EventHandler<PivotItemEventArgs> unloadingPivotItem = this.UnloadingPivotItem;
      if (unloadingPivotItem == null)
        return;
      unloadingPivotItem((object) this, e);
    }

    protected virtual void OnUnloadedPivotItem(PivotItemEventArgs e)
    {
      EventHandler<PivotItemEventArgs> unloadedPivotItem = this.UnloadedPivotItem;
      if (unloadedPivotItem == null)
        return;
      unloadedPivotItem((object) this, e);
    }

    protected virtual void OnItemsChanged(NotifyCollectionChangedEventArgs e)
    {
      int selectedIndex = this.SelectedIndex;
      int? nullable1 = new int?();
      int count = this.Items.Count;
      if (this._templateApplied && this.IsLocked)
        throw new InvalidOperationException("Pivot Items cannot be modified when locked");
      if (e != null)
      {
        switch ((int) e.Action)
        {
          case 0:
            if (this._templateApplied && e.NewStartingIndex == selectedIndex)
              nullable1 = new int?(selectedIndex);
            this.UpdateDirectManipulationPivotItems();
            break;
          case 1:
            nullable1 = new int?(selectedIndex);
            if (selectedIndex == e.OldStartingIndex || selectedIndex >= count)
              nullable1 = new int?(0);
            this.UpdateDirectManipulationPivotItems();
            break;
          case 4:
            this._isDMPivotItemsInitialized = false;
            break;
        }
      }
      if (nullable1.HasValue)
      {
        int? nullable2 = nullable1;
        int num = selectedIndex;
        this._animationHint = new AnimationDirection?((nullable2.GetValueOrDefault() < num ? (nullable2.HasValue ? 1 : 0) : 0) != 0 ? AnimationDirection.Right : AnimationDirection.Left);
        this.SetSelectedIndexInternal(nullable1.Value);
      }
      if (this._lastItemsCount != count && AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged) && this.GetOrCreateAutomationPeer() is PivotAutomationPeer automationPeer)
        automationPeer.RaisePropertyChangedEvents(this._lastItemsCount, this.IsLocked, this.SelectedIndex);
      this.UpdateHeaders();
      this.OptimizeVisuals();
      base.OnItemsChanged(e);
      this.UpdateLayout();
      this._lastItemsCount = count;
    }

    protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
    {
      this.ApplyItemContainerStyle(element);
      base.PrepareContainerForItemOverride(element, item);
      this._itemToContainer[item] = (PivotItem) element;
      this._containerToItem[(PivotItem) element] = item;
      PivotItem pivotItem = element as PivotItem;
      int selectedIndex = this.SelectedIndex;
      if (selectedIndex >= 0 && this.Items.Count > selectedIndex)
      {
        object obj1 = this.Items[selectedIndex];
        object obj2 = this.Items[this.RollingDecrement(selectedIndex)];
        object obj3 = this.Items[this.RollingIncrement(selectedIndex)];
        if (item == obj1)
        {
          if (pivotItem == null)
            return;
          pivotItem.IsFirstVisualChildVisible = true;
          if (!this._skippedLoadingPivotItem)
            return;
          this.OnLoadingPivotItem(pivotItem);
          if (!this._skippedSwapVisibleContent)
            return;
          this.OnLoadedPivotItem(pivotItem);
          return;
        }
        if (item == obj2 || item == obj3)
          pivotItem.IsFirstVisualChildVisible = true;
      }
      if (pivotItem == null)
        return;
      this.UpdateItemVisibility((UIElement) pivotItem, false);
    }

    private void UpdateSelectedIndex(int oldIndex, int newIndex)
    {
      object obj = (object) null;
      int count = this.Items.Count;
      if (newIndex >= 0 && newIndex < count)
        obj = this.Items[newIndex];
      else if (count > 0 && !this._isDesignTime)
      {
        this._ignorePropertyChange = true;
        this.SelectedIndex = oldIndex;
        throw new ArgumentException("SelectedIndex");
      }
      if (newIndex < 0 && this.Items.Count > 0 && !this._isDesignTime)
      {
        this._ignorePropertyChange = true;
        this.SelectedIndex = 0;
        throw new ArgumentException("SelectedIndex");
      }
      this.SelectedItem = obj;
    }

    private void SetSelectedIndexInternal(int newIndex)
    {
      this._ignorePropertyChange = true;
      this.SelectedIndex = newIndex - 1;
      this.SelectedIndex = newIndex;
      this.UpdateDirectManipulationSelectedIndex(this.SelectedIndex);
    }

    private void UpdateSelectedItem(object oldValue, object newValue)
    {
      if (newValue == null && this.Items.Count > 0 && !this._isDesignTime)
      {
        this._ignorePropertyChange = true;
        this.SelectedItem = oldValue;
        throw new ArgumentException("SelectedItem");
      }
      int num1 = this.Items.IndexOf(oldValue);
      int num2 = this.Items.IndexOf(newValue);
      if (!this._animationHint.HasValue && num1 != -1 && num2 != -1)
        this._animationHint = new AnimationDirection?(this.RollingIncrement(num2) == num1 ? AnimationDirection.Right : AnimationDirection.Left);
      PivotItem container1 = this.GetContainer(newValue);
      PivotItem container2 = this.GetContainer(oldValue);
      if (oldValue != null)
        this.OnUnloadingPivotItem(new PivotItemEventArgs(container2));
      if (container1 != null)
        this.OnLoadingPivotItem(container1);
      else
        this._skippedLoadingPivotItem = true;
      this.OnSelectionChanged(new SelectionChangedEventArgs((IList) new List<object>()
      {
        oldValue
      }, (IList) new List<object>() { newValue }));
      this.BeginAnimateContent(num2, container2, this._animationHint.GetValueOrDefault());
      this.SetSelectedHeaderIndex(num2);
      if (this.SelectedIndex == num2)
        return;
      this.SetSelectedIndexInternal(num2);
    }

    private void SetSelectedHeaderIndex(int selectedIndex)
    {
      try
      {
        this._updatingHeaderItems = true;
        if (this._headers == null || this.Items.Count <= 0)
          return;
        this._headers.SelectedIndex = selectedIndex;
      }
      finally
      {
        this._updatingHeaderItems = false;
      }
    }

    private int RollingIncrement(int index)
    {
      ++index;
      return index >= this.Items.Count ? 0 : index;
    }

    private int RollingDecrement(int index)
    {
      --index;
      return index >= 0 ? index : this.Items.Count - 1;
    }

    protected virtual void OnSelectionChanged(SelectionChangedEventArgs e)
    {
      this.ClearFocusOnChild();
      SelectionChangedEventHandler selectionChanged = this.SelectionChanged;
      if (selectionChanged != null)
        selectionChanged((object) this, e);
      if (AutomationPeer.ListenerExists(AutomationEvents.SelectionItemPatternOnElementSelected))
      {
        PivotAutomationPeer automationPeer = this.GetOrCreateAutomationPeer() as PivotAutomationPeer;
        PivotItem container = this.GetContainer(e.AddedItems[0]);
        if (automationPeer != null && container != null)
          automationPeer.RaiseSelectionChangedEvent(container);
      }
      if (!AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged))
        return;
      (this.GetOrCreateAutomationPeer() as PivotAutomationPeer)?.RaisePropertyChangedEvents(this.Items.Count, this.IsLocked, this.Items.IndexOf(e.RemovedItems[0]), this.Items.IndexOf(e.AddedItems[0]));
    }

    private bool EnoughItemsForManipulation => this.Items.Count > 1;

    private void GesturesComplete(ManipulationDelta totalManipulation)
    {
      if (this.EnoughItemsForManipulation)
      {
        if (totalManipulation != null && this._isHorizontalDragging)
          Math.Abs(totalManipulation.Translation.X);
        if (!this._animating && this._headers != null && this._itemsPresenter != null)
        {
          TransformAnimator.EnsureAnimator((FrameworkElement) this._itemsPresenter, ref this._panAnimator);
          this._panAnimator.GoTo(this.CalculateContentDestination(AnimationDirection.Center), Pivot.PivotAnimationDuration, this.QuarticEase);
          this._headers.RestoreHeaderPosition(Pivot.PivotAnimationDuration);
        }
      }
      this._isHorizontalDragging = false;
    }

    private void Flick(double angle)
    {
      if (this._clickedHeadersControl != null)
      {
        this._clickedHeadersControl._wasClicked = false;
        this._clickedHeadersControl._cancelClick = true;
      }
      if (!this.EnoughItemsForManipulation)
        return;
      int num = (int) angle;
      switch (num)
      {
        case 0:
        case 180:
          this.NavigateByIndexChange(num == 180 ? 1 : -1);
          break;
      }
    }

    private void HorizontalDrag(ManipulationDeltaEventArgs e)
    {
      this._isHorizontalDragging = true;
      if (this._clickedHeadersControl != null)
        this._clickedHeadersControl._cancelClick = true;
      if (this._animating || !this.EnoughItemsForManipulation || this._itemsPresenter == null)
        return;
      TransformAnimator.EnsureAnimator((FrameworkElement) this._itemsPresenter, ref this._panAnimator);
      Point translation = e.DeltaManipulation.Translation;
      double num = Math.Abs(translation.X);
      if (this._animating || this._panAnimator == null || this._headers == null)
        return;
      TimeSpan timeSpan = TimeSpan.FromSeconds(num / 600.0);
      TransformAnimator panAnimator = this._panAnimator;
      translation = e.CumulativeManipulation.Translation;
      double x1 = translation.X;
      Duration duration1 = new Duration(timeSpan);
      panAnimator.GoTo(x1, duration1);
      PivotHeadersControl headers = this._headers;
      translation = e.CumulativeManipulation.Translation;
      double x2 = translation.X;
      double actualWidth = this._actualWidth;
      Duration duration2 = new Duration(timeSpan);
      headers.PanHeader(x2, actualWidth, duration2);
    }

    [SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", Justification = "Property name.", MessageId = "HeaderTemplate")]
    private PivotHeaderItem CreateHeaderBindingControl(object item)
    {
      PivotHeaderItem pivotHeaderItem1 = new PivotHeaderItem();
      pivotHeaderItem1.ContentTemplate = this.HeaderTemplate;
      pivotHeaderItem1.Item = item;
      PivotHeaderItem pivotHeaderItem2 = pivotHeaderItem1;
      Binding binding = new Binding()
      {
        Source = item
      };
      if (item is PivotItem)
        binding.Path = new PropertyPath("Header", new object[0]);
      try
      {
        binding.Mode = BindingMode.OneWay;
        pivotHeaderItem2.SetBinding(ContentControl.ContentProperty, binding);
        return pivotHeaderItem2;
      }
      catch
      {
        if (this._isDesignTime)
          return (PivotHeaderItem) null;
        throw;
      }
    }

    private void UpdateHeaders()
    {
      if (this._headers == null)
        return;
      List<PivotHeaderItem> pivotHeaderItemList = new List<PivotHeaderItem>();
      int count = this.Items.Count;
      for (int index = 0; index < count; ++index)
      {
        object obj = this.Items[index];
        pivotHeaderItemList.Add(this.CreateHeaderBindingControl(obj));
      }
      try
      {
        this._updatingHeaderItems = true;
        this._headers.ItemsSource = count == 0 ? (IEnumerable) null : (IEnumerable) pivotHeaderItemList;
      }
      finally
      {
        this._updatingHeaderItems = false;
      }
    }

    private void OnHeaderSelectionChanged(object s, SelectedIndexChangedEventArgs e)
    {
      if (this._updatingHeaderItems)
        return;
      if (this.SelectedIndex != e.SelectedIndex)
        this.HeaderSelectionChanged();
      this._animationHint = new AnimationDirection?(AnimationDirection.Left);
      this.SelectedIndex = e.SelectedIndex;
    }

    private void NavigateByIndexChange(int indexDelta)
    {
      if (this._animating && this._queuedIndexChanges != null)
      {
        this._queuedIndexChanges.Enqueue(indexDelta);
      }
      else
      {
        int selectedIndex = this.SelectedIndex;
        if (selectedIndex == -1)
          return;
        this._animationHint = new AnimationDirection?(indexDelta > 0 ? AnimationDirection.Left : AnimationDirection.Right);
        int num = selectedIndex + indexDelta;
        if (num >= this.Items.Count)
          num = 0;
        else if (num < 0)
          num = this.Items.Count - 1;
        if (this._clickedHeadersControl != null)
        {
          this._clickedHeadersControl._wasClicked = false;
          this._clickedHeadersControl._cancelClick = true;
        }
        this.SelectedIndex = num;
      }
    }

    private int GetPreviousIndex()
    {
      int count = this.Items.Count;
      if (count <= 0)
        return 0;
      int num = this.SelectedIndex - 1;
      if (num < 0)
        num = count - 1;
      return num;
    }

    private int GetNextIndex()
    {
      int count = this.Items.Count;
      if (count <= 0)
        return 0;
      int num = this.SelectedIndex + 1;
      if (num > count)
        num = 0;
      return num;
    }

    private void UpdateVisibleContent(int index)
    {
      if (!this.TryHasItemsHost())
        return;
      for (int index1 = 0; index1 < this._itemsPanel.Children.Count; ++index1)
        this.UpdateItemVisibility(this._itemsPanel.Children[index1], index1 == index);
    }

    private bool TryHasItemsHost()
    {
      if (this._itemsPanel != null)
        return true;
      if (this.ItemContainerGenerator != null)
      {
        DependencyObject reference = this.ItemContainerGenerator.ContainerFromIndex(0);
        if (reference != null)
        {
          this._itemsPanel = VisualTreeHelper.GetParent(reference) as Panel;
          return this._itemsPanel != null;
        }
      }
      return false;
    }

    protected virtual void UpdateItemVisibility(UIElement element, bool toVisible)
    {
      if (element == null)
        return;
      element.IsHitTestVisible = toVisible;
      PivotItem pivotItem = element as PivotItem;
      if (toVisible && pivotItem != null && (pivotItem.FirstVisualChild != null && pivotItem.FirstVisualChild.Visibility == Visibility.Collapsed))
        pivotItem.FirstVisualChild.Visibility = Visibility.Visible;
      if (!this._isDesignTime)
        return;
      TranslateTransform translateTransform = TransformAnimator.GetTranslateTransform(element);
      if (translateTransform == null)
        return;
      translateTransform.X = toVisible ? 0.0 : -this.ActualWidth;
    }

    private double CalculateContentDestination(AnimationDirection direction)
    {
      double num = 0.0;
      double actualWidth = this.ActualWidth;
      switch (direction)
      {
        case AnimationDirection.Left:
          num = -actualWidth;
          break;
        case AnimationDirection.Right:
          num = actualWidth;
          break;
      }
      return num;
    }

    private static AnimationDirection InvertAnimationDirection(
      AnimationDirection direction)
    {
      if (direction == AnimationDirection.Left)
        return AnimationDirection.Right;
      return direction == AnimationDirection.Right ? AnimationDirection.Left : direction;
    }

    private void BeginAnimateContent(
      int newIndex,
      PivotItem oldItem,
      AnimationDirection animationDirection)
    {
      if (this._isDesignTime)
        this.SwapVisibleContent(oldItem, newIndex);
      else if (this._itemsPresenter != null)
      {
        this.GetContainer(this.SelectedItem)?.MoveTo(AnimationDirection.Center);
        if (this._headers != null && animationDirection != AnimationDirection.Center)
          this._headers.AnimationDirection = animationDirection;
        this.SwapVisibleContent(oldItem, newIndex);
        this.GetContainer(this.SelectedItem)?.MoveTo(animationDirection);
      }
      else
        this._skippedSwapVisibleContent = true;
    }

    private void SwapVisibleContent(PivotItem oldItem, int newIndex)
    {
      if (oldItem != null)
        this.OnUnloadedPivotItem(new PivotItemEventArgs(oldItem));
      this.UpdateVisibleContent(newIndex);
      PivotItem container = this.GetContainer(this.SelectedItem);
      this._skippedSwapVisibleContent = container == null;
      if (container == null)
        return;
      this.OnLoadedPivotItem(container);
    }

    private void ProcessQueuedChanges()
    {
      if (this._queuedIndexChanges == null || this._queuedIndexChanges.Count <= 0 || this._animating)
        return;
      this.NavigateByIndexChange(this._queuedIndexChanges.Dequeue());
    }

    private new void OnSizeChanged(object sender, SizeChangedEventArgs e)
    {
      this._actualWidth = this.ActualWidth;
      this.Clip = (Geometry) new RectangleGeometry()
      {
        Rect = new Rect(0.0, 0.0, this._actualWidth, this.ActualHeight)
      };
      if (!this._isDesignTime)
        return;
      this.UpdateVisibleContent(this.SelectedIndex);
    }

    private void OnManipulationStarted(object sender, ManipulationStartedEventArgs args)
    {
      this._gestureSource = new WeakReference((object) args.ManipulationContainer);
      this._gestureOrigin = args.ManipulationOrigin;
      this._dragging = false;
      this._isHorizontalDragging = false;
      if (this._clickedHeadersControl == null)
        return;
      this._clickedHeadersControl._wasClicked = false;
      this._clickedHeadersControl._cancelClick = false;
    }

    private void OnManipulationDelta(object sender, ManipulationDeltaEventArgs args)
    {
      if (!this._dragging)
        this.ReleaseMouseCaptureAtGestureOrigin();
      this._dragging = true;
      Point translation;
      if (this._dragLock == Pivot.DragLock.Unset)
      {
        translation = args.CumulativeManipulation.Translation;
        double x = translation.X;
        translation = args.CumulativeManipulation.Translation;
        double y = translation.Y;
        double num = Pivot.AngleFromVector(x, y) % 180.0;
        this._dragLock = num <= 45.0 || num >= 135.0 ? Pivot.DragLock.Horizontal : (num <= 45.0 || num >= 135.0 ? Pivot.DragLock.Free : Pivot.DragLock.Vertical);
      }
      if (this._dragLock != Pivot.DragLock.Horizontal)
        return;
      args.Handled = true;
      translation = args.DeltaManipulation.Translation;
      if (translation.X == 0.0)
        return;
      bool flag;
      XcpImports.ItemsControl_SetDirectManipulationHandled((ItemsControl) this, args, ref flag);
      if (flag)
      {
        this._isHorizontalDragging = true;
        if (this._clickedHeadersControl != null)
          this._clickedHeadersControl._cancelClick = true;
        this._isHandlingDirectManipulation = true;
      }
      else
        this.HorizontalDrag(args);
    }

    private void OnManipulationCompleted(object sender, ManipulationCompletedEventArgs args)
    {
      ManipulationDelta totalManipulation = (ManipulationDelta) null;
      this._dragLock = Pivot.DragLock.Unset;
      this._dragging = false;
      if (this._isHandlingDirectManipulation)
        args.Handled = true;
      if (args.IsInertial)
      {
        Point linearVelocity = args.FinalVelocities.LinearVelocity;
        double x = linearVelocity.X;
        linearVelocity = args.FinalVelocities.LinearVelocity;
        double y = linearVelocity.Y;
        double angle = Pivot.AngleFromVector(x, y);
        if (angle <= 45.0 || angle >= 315.0)
          angle = 0.0;
        else if (angle >= 135.0 && angle <= 225.0)
          angle = 180.0;
        if (!this._isHandlingDirectManipulation)
        {
          this.ReleaseMouseCaptureAtGestureOrigin();
          this.Flick(angle);
          if (angle == 0.0 || angle == 180.0)
            args.Handled = true;
        }
      }
      else
      {
        Point translation = args.TotalManipulation.Translation;
        if (translation.X == 0.0)
        {
          translation = args.TotalManipulation.Translation;
          if (translation.Y == 0.0)
            goto label_14;
        }
        totalManipulation = args.TotalManipulation;
        if (this._isHorizontalDragging)
          args.Handled = true;
      }
label_14:
      this.GesturesComplete(totalManipulation);
    }

    public Style ItemContainerStyle
    {
      get => this.GetValue(Pivot.ItemContainerStyleProperty) as Style;
      set => this.SetValue(Pivot.ItemContainerStyleProperty, (DependencyObject) value);
    }

    public bool IsLocked
    {
      get => this._isLocked;
      set
      {
        if (value == this._isLocked)
          return;
        this._isLocked = value;
        if (this._isLocked)
          this.FadeOutHeaders();
        else
          this.FadeInHeaders();
        this.SetDirectManipulationLockMode(this._isLocked);
        if (!AutomationPeer.ListenerExists(AutomationEvents.PropertyChanged) || !(this.GetOrCreateAutomationPeer() is PivotAutomationPeer automationPeer))
          return;
        automationPeer.RaisePropertyChangedEvents(this.Items.Count, !this._isLocked, this.SelectedIndex);
      }
    }

    protected override bool IsItemItsOwnContainerOverride(object item) => item is PivotItem;

    protected override DependencyObject GetContainerForItemOverride()
    {
      PivotItem pivotItem = new PivotItem();
      this.ApplyItemContainerStyle((DependencyObject) pivotItem);
      return (DependencyObject) pivotItem;
    }

    protected override void ClearContainerForItemOverride(DependencyObject element, object item)
    {
      base.ClearContainerForItemOverride(element, item);
      this._itemToContainer.Remove(item);
      this._containerToItem.Remove((PivotItem) element);
    }

    protected virtual void ApplyItemContainerStyle(DependencyObject container)
    {
      if (!(container is PivotItem pivotItem) || pivotItem.ReadLocalValue(FrameworkElement.StyleProperty) != DependencyProperty.UnsetValue)
        return;
      Style itemContainerStyle = this.ItemContainerStyle;
      if (itemContainerStyle != null)
        pivotItem.Style = itemContainerStyle;
      else
        pivotItem.ClearValue(FrameworkElement.StyleProperty);
    }

    protected object GetItem(PivotItem container)
    {
      object obj = (object) null;
      if (container != null)
        this._containerToItem.TryGetValue(container, out obj);
      return obj;
    }

    protected PivotItem GetContainer(object item) => this.GetContainerInternal(item);

    internal PivotItem GetContainerInternal(object item)
    {
      PivotItem pivotItem = (PivotItem) null;
      if (item != null)
        this._itemToContainer.TryGetValue(item, out pivotItem);
      return pivotItem;
    }

    private static double AngleFromVector(double x, double y)
    {
      double num = Math.Atan2(y, x);
      if (num < 0.0)
        num = 2.0 * Math.PI + num;
      return num * 360.0 / (2.0 * Math.PI);
    }

    private void ReleaseMouseCaptureAtGestureOrigin()
    {
      if (this._gestureSource == null || !(this._gestureSource.Target is FrameworkElement target))
        return;
      foreach (UIElement inHostCoordinate in VisualTreeHelper.FindElementsInHostCoordinates(target.TransformToVisual((UIElement) null).Transform(this._gestureOrigin), Application.Current.RootVisual))
        inHostCoordinate.ReleaseMouseCapture();
    }

    [SecuritySafeCritical]
    private bool HasDirectManipulationControl() => this._directManipulationControl != IntPtr.Zero;

    [SecuritySafeCritical]
    private void CreateDirectManipulationControl() => XcpImports.ItemsControl_CreatePivotDirectManipulationControl((ItemsControl) this, ref this._directManipulationControl);

    [SecuritySafeCritical]
    private void SetDirectManipulationTarget(UIElement target)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Pivot_SetDirectManipulationTarget(this._directManipulationControl, target);
    }

    [SecuritySafeCritical]
    private void HeaderSelectionChanged()
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Pivot_HeaderSelectionChanged(this._directManipulationControl);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetPivotHeaderTarget(UIElement target)
    {
      if (this._directManipulationControl != IntPtr.Zero)
        XcpImports.Pivot_SetHeaderTarget(this._directManipulationControl, target);
      if (!this._isLocked)
        return;
      this.FadeOutHeaders();
      this.SetDirectManipulationLockMode(this._isLocked);
    }

    [SecuritySafeCritical]
    internal void DirectManipulationSetPivotHeaderItems(PivotManipulationTargetNative[] items)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      IntPtr manipulationControl = this._directManipulationControl;
      PivotManipulationTargetNative[] manipulationTargetNativeArray = items;
      int num = manipulationTargetNativeArray != null ? items.Length : 0;
      XcpImports.Pivot_SetPivotHeaderItems(manipulationControl, manipulationTargetNativeArray, (uint) num);
    }

    [SecuritySafeCritical]
    private void UpdateDirectManipulationPivotItems()
    {
      PivotManipulationTargetNative[] manipulationTargetNativeArray1 = (PivotManipulationTargetNative[]) null;
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      if (this.Items.Count > 0)
      {
        manipulationTargetNativeArray1 = new PivotManipulationTargetNative[this.Items.Count];
        this._isDMPivotItemsInitialized = true;
        for (int index = 0; index < this.Items.Count; ++index)
        {
          PivotItem pivotItem = (PivotItem) this.ItemContainerGenerator.ContainerFromIndex(index);
          if (pivotItem != null)
            manipulationTargetNativeArray1[index].targetNative = (__Null) pivotItem.NativeObject;
        }
      }
      IntPtr manipulationControl = this._directManipulationControl;
      PivotManipulationTargetNative[] manipulationTargetNativeArray2 = manipulationTargetNativeArray1;
      int num = manipulationTargetNativeArray2 != null ? manipulationTargetNativeArray1.Length : 0;
      XcpImports.Pivot_SetPivotItems(manipulationControl, manipulationTargetNativeArray2, (uint) num);
    }

    [SecuritySafeCritical]
    private void UpdateDirectManipulationSelectedIndex(int index)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Pivot_UpdateSelectedIndex(this._directManipulationControl, index);
    }

    private void FadeOutHeaders()
    {
      if (this._headers == null)
        return;
      foreach (UIElement uiElement in (PresentationFrameworkCollection<object>) this._headers.Items)
        uiElement.IsHitTestVisible = false;
    }

    private void FadeInHeaders()
    {
      if (this._headers == null)
        return;
      foreach (UIElement uiElement in (PresentationFrameworkCollection<object>) this._headers.Items)
        uiElement.IsHitTestVisible = true;
    }

    [SecuritySafeCritical]
    private void SetDirectManipulationLockMode(bool isLocked)
    {
      if (!(this._directManipulationControl != IntPtr.Zero))
        return;
      XcpImports.Pivot_SetLockMode(this._directManipulationControl, isLocked);
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
