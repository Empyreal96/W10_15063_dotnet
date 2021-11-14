// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Primitives.PivotHeadersControl
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using MS.Internal;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Microsoft.Phone.Controls.Primitives
{
  [TemplatePart(Name = "HeaderItemsPresenter", Type = typeof (ItemsPresenter))]
  [TemplatePart(Name = "Canvas", Type = typeof (Canvas))]
  [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof (PivotHeaderItem))]
  public class PivotHeadersControl : ItemsControl
  {
    private const string CanvasName = "Canvas";
    private const string HeaderItemsPresenterName = "HeaderItemsPresenter";
    private const double PivotSeconds = 0.5;
    private bool _isDesign;
    private Canvas _canvas;
    private ItemsPresenter _headerItemsPresenter;
    private Dictionary<Control, double> _sizes;
    private Dictionary<Control, TranslateTransform> _translations;
    private Dictionary<Control, OpacityAnimator> _opacities;
    private FrameworkElementProxy _leftMirrorProxy;
    internal readonly IEasingFunction QuarticEase = (IEasingFunction) new System.Windows.Media.Animation.QuarticEase();
    internal bool _cancelClick;
    private bool _activeSelectionChange;
    private bool _isAnimating;
    private Queue<PivotHeadersControl.AnimationInstruction> _queuedAnimations;
    internal bool _wasClicked;
    private Pivot _pivot;
    private double _animatingWidth;
    private DateTime _currentItemAnimationStarted;
    private FlipperButton _leftFlipper;
    private FlipperButton _rightFlipper;
    internal static readonly DependencyProperty SelectedIndexProperty = DependencyProperty.Register(nameof (SelectedIndex), typeof (int), typeof (PivotHeadersControl), new PropertyMetadata((object) 0, new PropertyChangedCallback(PivotHeadersControl.OnSelectedIndexPropertyChanged)));
    public static readonly DependencyProperty VisualFirstIndexProperty = DependencyProperty.Register(nameof (VisualFirstIndex), typeof (int), typeof (PivotHeadersControl), new PropertyMetadata((object) 0, new PropertyChangedCallback(PivotHeadersControl.OnVisualFirstIndexPropertyChanged)));
    private bool _ignorePropertyChange;
    private int _previousVisualFirstIndex;
    private readonly Dictionary<object, PivotHeaderItem> _itemToContainer = new Dictionary<object, PivotHeaderItem>();
    private readonly Dictionary<PivotHeaderItem, object> _containerToItem = new Dictionary<PivotHeaderItem, object>();
    [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes", Justification = "This is correct use of DependencyProperty.")]
    public static readonly DependencyProperty ItemContainerStyleProperty = DependencyProperty.Register(nameof (ItemContainerStyle), typeof (Style), typeof (PivotHeadersControl), (PropertyMetadata) null);

    internal bool IsHandlingDirectManipulation => this._pivot != null && this._pivot.IsHandlingDirectManipulation;

    protected override Size ArrangeOverride(Size finalSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_ARRANGE, PerfLog.PivotHeadersControl);
      Size size = base.ArrangeOverride(finalSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_ARRANGE, PerfLog.PivotHeadersControl);
      this.UpdateDirectManipulationPivotHeaderItems();
      return size;
    }

    protected override Size MeasureOverride(Size availableSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_MEASURE, PerfLog.PivotHeadersControl);
      Size size = base.MeasureOverride(availableSize);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_MEASURE, PerfLog.PivotHeadersControl);
      return size;
    }

    internal int SelectedIndex
    {
      get => (int) this.GetValue(PivotHeadersControl.SelectedIndexProperty);
      set => this.SetValue(PivotHeadersControl.SelectedIndexProperty, value);
    }

    private static void OnSelectedIndexPropertyChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      PivotHeadersControl pivotHeadersControl = d as PivotHeadersControl;
      int newValue = (int) e.NewValue;
      int oldValue = (int) e.OldValue;
      if (pivotHeadersControl._activeSelectionChange)
        return;
      pivotHeadersControl.SelectOne(oldValue, newValue);
    }

    public int VisualFirstIndex
    {
      get => (int) this.GetValue(PivotHeadersControl.VisualFirstIndexProperty);
      set => this.SetValue(PivotHeadersControl.VisualFirstIndexProperty, value);
    }

    private static void OnVisualFirstIndexPropertyChanged(
      DependencyObject d,
      DependencyPropertyChangedEventArgs e)
    {
      PivotHeadersControl pivotHeadersControl = d as PivotHeadersControl;
      if (pivotHeadersControl._ignorePropertyChange)
      {
        pivotHeadersControl._ignorePropertyChange = false;
      }
      else
      {
        int newValue = (int) e.NewValue;
        pivotHeadersControl._previousVisualFirstIndex = (int) e.OldValue;
        int count = pivotHeadersControl.Items.Count;
        if (count > 0 && newValue >= count)
        {
          pivotHeadersControl._ignorePropertyChange = true;
          d.SetValue(e.Property, 0);
        }
        pivotHeadersControl.UpdateItemsLayout();
      }
    }

    internal event EventHandler<SelectedIndexChangedEventArgs> SelectedIndexChanged;

    public PivotHeadersControl()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_STARTUP, PerfLog.PivotHeadersControl);
      this.DefaultStyleKey = (object) typeof (PivotHeadersControl);
      this._sizes = new Dictionary<Control, double>();
      this._translations = new Dictionary<Control, TranslateTransform>();
      this._opacities = new Dictionary<Control, OpacityAnimator>();
      this._isDesign = DesignerProperties.IsInDesignTool;
      this._queuedAnimations = new Queue<PivotHeadersControl.AnimationInstruction>();
      this.Loaded += new RoutedEventHandler(this.PivotHeadersControl_Loaded);
    }

    private void PivotHeadersControl_Loaded(object sender, RoutedEventArgs e)
    {
      this.Loaded -= new RoutedEventHandler(this.PivotHeadersControl_Loaded);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_STARTUP, PerfLog.PanoramaItem);
    }

    public override void OnApplyTemplate()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PIVOT_APPLYTEMPLATE, PerfLog.PivotHeadersControl);
      this._pivot = (Pivot) null;
      if (this._canvas != null)
        this._canvas.Children.Remove((UIElement) this._leftMirrorProxy);
      this._leftMirrorProxy = (FrameworkElementProxy) null;
      base.OnApplyTemplate();
      this._headerItemsPresenter = this.GetTemplateChild("HeaderItemsPresenter") as ItemsPresenter;
      this._canvas = this.GetTemplateChild("Canvas") as Canvas;
      if (this._headerItemsPresenter != null)
      {
        this._headerItemsPresenter.SetAutomaticBitmapCache();
        this._leftMirrorProxy = new FrameworkElementProxy();
        this._leftMirrorProxy.Target = (UIElement) this._headerItemsPresenter;
      }
      if (this._canvas != null)
      {
        this._canvas.SetAutomaticBitmapCache();
        if (this._leftMirrorProxy != null)
          this._canvas.Children.Add((UIElement) this._leftMirrorProxy);
        if (!(this._canvas.RenderTransform is TranslateTransform))
          this._canvas.RenderTransform = (Transform) new TranslateTransform();
      }
      if (this.Items.Count > 0)
        this.VisualFirstIndex = this.SelectedIndex;
      DependencyObject reference = (DependencyObject) this;
      do
      {
        reference = VisualTreeHelper.GetParent(reference);
        this._pivot = reference as Pivot;
      }
      while (this._pivot == null && reference != null);
      if (this._pivot != null)
        this._pivot.DirectManipulationSetPivotHeaderTarget((UIElement) this._canvas);
      if (this._pivot != null)
        this._pivot._clickedHeadersControl = this;
      if (FlipperButton.ShouldShowFlippers)
        this.ApplyFlippers();
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PIVOT_APPLYTEMPLATE, PerfLog.PivotHeadersControl);
    }

    private void ApplyFlippers()
    {
      this.RemoveFlipperFromTree(this._leftFlipper);
      this.RemoveFlipperFromTree(this._rightFlipper);
      this._leftFlipper = (FlipperButton) null;
      this._rightFlipper = (FlipperButton) null;
      if (this._canvas == null || !(VisualTreeHelper.GetParent((DependencyObject) this._canvas) is Grid parent))
        return;
      this._leftFlipper = new FlipperButton();
      this._leftFlipper.HorizontalAlignment = HorizontalAlignment.Left;
      this._leftFlipper.Content = (object) "\uE0E2";
      this._leftFlipper.ApplyTemplate();
      this._leftFlipper.Click += new RoutedEventHandler(this.OnFlipperButtonClick);
      parent.Children.Add((UIElement) this._leftFlipper);
      this._rightFlipper = new FlipperButton();
      this._rightFlipper.HorizontalAlignment = HorizontalAlignment.Right;
      this._rightFlipper.Margin = new Thickness(0.0, 0.0, 18.0, 0.0);
      this._rightFlipper.Content = (object) "\uE0E3";
      this._rightFlipper.ApplyTemplate();
      this._rightFlipper.Click += new RoutedEventHandler(this.OnFlipperButtonClick);
      parent.Children.Add((UIElement) this._rightFlipper);
    }

    protected virtual void OnItemsChanged(NotifyCollectionChangedEventArgs e)
    {
      base.OnItemsChanged(e);
      if (this.Items.Count > 0)
      {
        this.UpdateItemsLayout();
      }
      else
      {
        this.VisualFirstIndex = 0;
        this.SelectedIndex = 0;
      }
    }

    protected override void ClearContainerForItemOverride(DependencyObject element, object item)
    {
      base.ClearContainerForItemOverride(element, item);
      this._itemToContainer.Remove(item);
      this._containerToItem.Remove((PivotHeaderItem) element);
      PivotHeaderItem pivotHeaderItem = (PivotHeaderItem) element;
      pivotHeaderItem.ParentHeadersControl = (PivotHeadersControl) null;
      pivotHeaderItem.Item = (object) null;
      if (element != item)
        pivotHeaderItem.Item = item;
      if (!(item is Control key))
        return;
      key.SizeChanged -= new SizeChangedEventHandler(this.OnHeaderSizeChanged);
      this._sizes.Remove(key);
      this._translations.Remove(key);
    }

    protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
    {
      this.ApplyItemContainerStyle(element);
      base.PrepareContainerForItemOverride(element, item);
      this._itemToContainer[item] = (PivotHeaderItem) element;
      this._containerToItem[(PivotHeaderItem) element] = item;
      PivotHeaderItem pivotHeaderItem = (PivotHeaderItem) element;
      pivotHeaderItem.ParentHeadersControl = this;
      int num = this.ItemContainerGenerator.IndexFromContainer(element);
      if (num != -1)
        pivotHeaderItem.IsSelected = this.SelectedIndex == num;
      if (!(item is Control control))
        return;
      control.SizeChanged += new SizeChangedEventHandler(this.OnHeaderSizeChanged);
    }

    public Style ItemContainerStyle
    {
      get => this.GetValue(PivotHeadersControl.ItemContainerStyleProperty) as Style;
      set => this.SetValue(PivotHeadersControl.ItemContainerStyleProperty, (DependencyObject) value);
    }

    protected override bool IsItemItsOwnContainerOverride(object item) => item is PivotHeaderItem;

    protected override DependencyObject GetContainerForItemOverride()
    {
      PivotHeaderItem pivotHeaderItem = new PivotHeaderItem();
      this.ApplyItemContainerStyle((DependencyObject) pivotHeaderItem);
      return (DependencyObject) pivotHeaderItem;
    }

    protected virtual void ApplyItemContainerStyle(DependencyObject container)
    {
      if (!(container is PivotHeaderItem pivotHeaderItem) || pivotHeaderItem.ReadLocalValue(FrameworkElement.StyleProperty) != DependencyProperty.UnsetValue)
        return;
      Style itemContainerStyle = this.ItemContainerStyle;
      if (itemContainerStyle != null)
        pivotHeaderItem.Style = itemContainerStyle;
      else
        pivotHeaderItem.ClearValue(FrameworkElement.StyleProperty);
    }

    protected object GetItem(PivotHeaderItem container)
    {
      object obj = (object) null;
      if (container != null)
        this._containerToItem.TryGetValue(container, out obj);
      return obj;
    }

    protected PivotHeaderItem GetContainer(object item)
    {
      PivotHeaderItem pivotHeaderItem = (PivotHeaderItem) null;
      if (item != null)
        this._itemToContainer.TryGetValue(item, out pivotHeaderItem);
      return pivotHeaderItem;
    }

    internal PivotHeaderItem GetPivotHeaderItemForItem(object item)
    {
      PivotHeaderItem pivotHeaderItem1 = (PivotHeaderItem) null;
      foreach (PivotHeaderItem pivotHeaderItem2 in this._itemToContainer.Values)
      {
        if (pivotHeaderItem2.Item == item)
        {
          pivotHeaderItem1 = pivotHeaderItem2;
          break;
        }
      }
      return pivotHeaderItem1;
    }

    internal PivotItem GetPivotItemForItem(object item)
    {
      PivotItem pivotItem = (PivotItem) null;
      if (this._pivot != null)
        pivotItem = this._pivot.GetContainerInternal(item);
      return pivotItem;
    }

    private void OnHeaderSizeChanged(object sender, SizeChangedEventArgs e)
    {
      double width = e.NewSize.Width;
      double height = e.NewSize.Height;
      if (double.IsNaN(this.Height) || height > this.Height)
        this.Height = height;
      this._sizes[(Control) sender] = width;
      this.UpdateItemsLayout();
    }

    internal void OnHeaderItemClicked(PivotHeaderItem item)
    {
      if (this._isAnimating)
        return;
      if (this._cancelClick)
      {
        this._cancelClick = false;
      }
      else
      {
        this._wasClicked = true;
        item.IsSelected = true;
      }
    }

    internal void NotifyHeaderItemSelected(PivotHeaderItem item, bool isSelected)
    {
      if (!isSelected)
        return;
      int index = this.ItemContainerGenerator.IndexFromContainer((DependencyObject) item);
      this.SelectOne(this.SelectedIndex, index);
      this.SelectedIndex = index;
    }

    private void SelectOne(int previousIndex, int index)
    {
      if (this._activeSelectionChange || index < 0)
        return;
      if (index >= this.Items.Count)
        return;
      try
      {
        this._activeSelectionChange = true;
        for (int index1 = 0; index1 < this.Items.Count; ++index1)
        {
          PivotHeaderItem pivotHeaderItem = (PivotHeaderItem) this.ItemContainerGenerator.ContainerFromIndex(index1);
          if (pivotHeaderItem != null)
            pivotHeaderItem.IsSelected = index == index1;
        }
      }
      finally
      {
        SafeRaise.Raise<SelectedIndexChangedEventArgs>(this.SelectedIndexChanged, (object) this, new SelectedIndexChangedEventArgs(index));
        this._activeSelectionChange = false;
        this.BeginAnimate(previousIndex, index);
      }
    }

    internal AnimationDirection AnimationDirection { get; set; }

    internal void RestoreHeaderPosition(Duration duration)
    {
      if (this._canvas == null)
        return;
      int num = this._isAnimating ? 1 : 0;
    }

    internal void PanHeader(double cumulative, double contentWidth, Duration duration)
    {
      if (this._isAnimating)
        return;
      Canvas canvas = this._canvas;
    }

    private void BeginAnimate(int previousIndex, int newIndex)
    {
      if (this._isDesign || this._canvas == null)
      {
        this.VisualFirstIndex = newIndex;
      }
      else
      {
        if (newIndex != this.RollingIncrement(previousIndex) && newIndex != this.RollingDecrement(previousIndex) || this._wasClicked)
        {
          this._wasClicked = false;
          int next;
          for (int index = previousIndex; index != newIndex; index = next)
          {
            next = this.RollingIncrement(index);
            PivotHeadersControl.AnimationInstruction animationInstruction = new PivotHeadersControl.AnimationInstruction(index, next);
            animationInstruction._width = this.GetItemWidth(index);
            if (animationInstruction._width > 0.0)
              this._queuedAnimations.Enqueue(animationInstruction);
          }
          this.UpdateActiveAndQueuedAnimations();
        }
        else
        {
          if (this._queuedAnimations.Count == 0 && !this._isAnimating)
          {
            this.BeginAnimateInternal(previousIndex, newIndex, this.QuarticEase, new Duration?());
            return;
          }
          this._queuedAnimations.Enqueue(new PivotHeadersControl.AnimationInstruction(previousIndex, newIndex)
          {
            _ease = this.QuarticEase,
            _width = this.GetItemWidth(previousIndex)
          });
          this.UpdateActiveAndQueuedAnimations();
        }
        if (this._isAnimating)
          return;
        this.AnimateComplete();
      }
    }

    private void UpdateActiveAndQueuedAnimations()
    {
      double num1 = 0.0;
      foreach (PivotHeadersControl.AnimationInstruction queuedAnimation in this._queuedAnimations)
        num1 += queuedAnimation._width;
      if (this._isAnimating && this._animatingWidth > 0.0)
        num1 += this._animatingWidth;
      int num2 = 0;
      foreach (PivotHeadersControl.AnimationInstruction queuedAnimation in this._queuedAnimations)
      {
        ++num2;
        queuedAnimation._durationInSeconds = queuedAnimation._width / (num1 == 0.0 ? 1.0 : num1) * 0.5;
        queuedAnimation._ease = num2 == this._queuedAnimations.Count ? this.QuarticEase : (IEasingFunction) null;
        int num3 = this._isAnimating ? 1 : 0;
      }
      if (!this._isAnimating)
        return;
      double num4 = this._animatingWidth * ((DateTime.Now - this._currentItemAnimationStarted).TotalSeconds / 0.5) / (num1 == 0.0 ? 1.0 : num1);
    }

    private void BeginAnimateInternal(
      int previousIndex,
      int newIndex,
      IEasingFunction ease,
      Duration? optionalDuration)
    {
      if (previousIndex == newIndex || previousIndex < 0 || (previousIndex >= this.Items.Count || this._isDesign) || this._canvas == null)
      {
        if (this.VisualFirstIndex != newIndex)
          this.VisualFirstIndex = newIndex;
        this.AnimateComplete();
      }
      else
      {
        int num = this.Items.Count != 2 ? (newIndex == this.RollingIncrement(previousIndex) ? 1 : 0) : (this.AnimationDirection == AnimationDirection.Left ? 1 : 0);
        this._animatingWidth = this.GetItemWidth(num != 0 ? previousIndex : newIndex);
        this._currentItemAnimationStarted = DateTime.Now;
        if (num != 0)
        {
          this.VisualFirstIndex = newIndex;
          this.AnimateComplete();
        }
        else
        {
          this.VisualFirstIndex = newIndex;
          this.AnimateComplete();
        }
      }
    }

    private void AnimateComplete()
    {
      if (this._queuedAnimations.Count == 0)
      {
        this._isAnimating = false;
      }
      else
      {
        PivotHeadersControl.AnimationInstruction animationInstruction = this._queuedAnimations.Dequeue();
        Duration duration = new Duration(TimeSpan.FromSeconds(animationInstruction._durationInSeconds));
        this.BeginAnimateInternal(animationInstruction._previousIndex, animationInstruction._index, animationInstruction._ease, new Duration?(duration));
      }
    }

    private double GetLeftMirrorWidth(int index) => this.GetItemWidth(this.GetPreviousVisualIndex(index));

    private double GetNextHeaderWidth()
    {
      int index = this.VisualFirstIndex + 1;
      if (index >= this.Items.Count)
        index = 0;
      return this.GetItemWidth(index);
    }

    private double GetItemWidth(int index)
    {
      Control itemFromIndex = this.GetItemFromIndex(index) as Control;
      double d = 0.0;
      if (itemFromIndex != null && !this._sizes.TryGetValue(itemFromIndex, out d))
      {
        d = itemFromIndex.ActualWidth;
        if (!double.IsNaN(d))
          this._sizes[itemFromIndex] = d;
      }
      return d;
    }

    private int GetPreviousVisualIndex(int indexOfInterest)
    {
      int num = indexOfInterest - 1;
      return num >= 0 ? num : this.Items.Count - 1;
    }

    private void UpdateItemsLayout()
    {
      int count = this.Items.Count;
      double offset = 0.0;
      int visualFirstIndex = this.VisualFirstIndex;
      for (int index = visualFirstIndex; index < this.Items.Count; ++index)
      {
        this.FadeInItemIfNeeded(index, visualFirstIndex, this._previousVisualFirstIndex, count);
        this.SetItemPosition(index, ref offset);
      }
      if (this.VisualFirstIndex <= 0)
        return;
      for (int index = 0; index < this.VisualFirstIndex; ++index)
      {
        this.FadeInItemIfNeeded(index, visualFirstIndex, this._previousVisualFirstIndex, count);
        this.SetItemPosition(index, ref offset);
      }
    }

    private void FadeInItemIfNeeded(
      int index,
      int visualFirstIndex,
      int previousVisualFirstIndex,
      int itemCount)
    {
      if (!this._isDesign && this.RollingIncrement(index) == visualFirstIndex && index == previousVisualFirstIndex)
      {
        if (itemCount <= 1 || itemCount == 2 && this.AnimationDirection == AnimationDirection.Right)
          return;
        double num = 0.0;
        for (int index1 = this.RollingIncrement(index); index1 != index; index1 = this.RollingIncrement(index1))
          num += this.GetItemWidth(index1);
        if (num >= this.ActualWidth)
          return;
        this.FadeIn(index);
      }
      else
      {
        if (!(this.GetItemFromIndex(index) is UIElement itemFromIndex2))
          return;
        itemFromIndex2.Opacity = 1.0;
      }
    }

    private object GetItemFromIndex(int index) => this.Items.Count > index ? this.Items[index] : (object) null;

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

    private void FadeIn(int index)
    {
      Control key = (Control) this.Items[index];
      OpacityAnimator animator;
      if (!this._opacities.TryGetValue(key, out animator))
      {
        OpacityAnimator.EnsureAnimator((UIElement) key, ref animator);
        this._opacities[key] = animator;
      }
    }

    private void SetItemPosition(int i, ref double offset)
    {
    }

    [SecuritySafeCritical]
    private void UpdateDirectManipulationPivotHeaderItems()
    {
      if (this._leftMirrorProxy != null)
        TransformAnimator.GetTranslateTransform((UIElement) this._leftMirrorProxy).X = -this.GetTotalItemsWidth();
      if (this._pivot == null)
        return;
      PivotManipulationTargetNative[] items = (PivotManipulationTargetNative[]) null;
      if (this.Items.Count > 0)
      {
        items = new PivotManipulationTargetNative[this.Items.Count];
        for (int index = 0; index < this.Items.Count; ++index)
        {
          PivotHeaderItem pivotHeaderItem = (PivotHeaderItem) this.ItemContainerGenerator.ContainerFromIndex(index);
          pivotHeaderItem.RenderTransform = (Transform) new TranslateTransform();
          if (pivotHeaderItem != null)
            items[index].targetNative = (__Null) pivotHeaderItem.NativeObject;
        }
      }
      this._pivot.DirectManipulationSetPivotHeaderItems(items);
    }

    private double GetTotalItemsWidth()
    {
      double num = 0.0;
      for (int index = 0; index < this.Items.Count; ++index)
      {
        if (this.Items[index] is PivotHeaderItem pivotHeaderItem1)
          num += pivotHeaderItem1.ActualWidth;
      }
      return num;
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
      if (sender == this._leftFlipper && this._pivot != null)
      {
        int num = this._pivot.SelectedIndex - 1;
        if (num < 0)
          num = this._pivot.Items.Count - 1;
        this._pivot.SelectedIndex = num;
      }
      if (sender != this._rightFlipper || this._pivot == null)
        return;
      this._pivot.SelectedIndex = (this._pivot.SelectedIndex + 1) % this._pivot.Items.Count;
    }

    private class AnimationInstruction
    {
      public int _previousIndex;
      public int _index;
      public IEasingFunction _ease;
      public double _width;
      public double _durationInSeconds;

      public AnimationInstruction(int previous, int next)
      {
        this._previousIndex = previous;
        this._index = next;
      }
    }
  }
}
