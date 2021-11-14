// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.Primitives.PanoramaPanel
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using MS.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Microsoft.Phone.Controls.Primitives
{
  public class PanoramaPanel : Panel
  {
    private const int SnapThresholdDivisor = 3;
    private Panorama _owner;
    private readonly List<PanoramaItem> _visibleChildren = new List<PanoramaItem>();
    private readonly List<PanoramaPanel.ItemStop> _itemStops = new List<PanoramaPanel.ItemStop>();
    private PanoramaItem _selectedItem;

    internal IList<PanoramaItem> VisibleChildren => (IList<PanoramaItem>) this._visibleChildren;

    private Panorama Owner
    {
      get => this._owner;
      set
      {
        if (this._owner == value)
          return;
        if (this._owner != null)
          this._owner.Panel = (PanoramaPanel) null;
        this._owner = value;
        if (this._owner == null)
          return;
        this._owner.Panel = this;
      }
    }

    public PanoramaPanel()
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_STARTUP, PerfLog.PanoramaPanel);
      this.SizeChanged += new SizeChangedEventHandler(this.PanoramaPanel_SizeChanged);
      this.Loaded += new RoutedEventHandler(this.PanoramaPanel_Loaded);
      this.Unloaded += new RoutedEventHandler(this.PanoramaPanel_UnLoaded);
    }

    private void PanoramaPanel_Loaded(object sender, RoutedEventArgs e)
    {
      this.Loaded -= new RoutedEventHandler(this.PanoramaPanel_Loaded);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_STARTUP, PerfLog.PanoramaPanel);
    }

    private void PanoramaPanel_UnLoaded(object sender, RoutedEventArgs e) => this._owner = (Panorama) null;

    private void PanoramaPanel_SizeChanged(object sender, SizeChangedEventArgs e)
    {
      if (this.Owner == null)
        return;
      this.Owner.ItemsWidth = (int) e.NewSize.Width;
    }

    private void UpdateDirectManipulationVisibleChildren()
    {
      if (this.Owner == null)
        return;
      PanoramaItemNative[] items = (PanoramaItemNative[]) null;
      if (this.VisibleChildren.Count > 0)
      {
        items = new PanoramaItemNative[this.VisibleChildren.Count];
        for (int index = 0; index < this.VisibleChildren.Count; ++index)
        {
          items[index].StartPosition = (__Null) this.VisibleChildren[index].StartPosition;
          items[index].ItemWidth = (__Null) this.VisibleChildren[index].ItemWidth;
          items[index].Orientation = this.VisibleChildren[index].Orientation == Orientation.Vertical ? (__Null) 0 : (__Null) 1;
        }
      }
      this.Owner.DirectManipulationSetPanoramaItems(items);
    }

    protected override Size MeasureOverride(Size availableSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_MEASURE, PerfLog.PanoramaPanel);
      if (this._owner == null)
        this.FindOwner();
      int defaultItemIndex = this.GetDefaultItemIndex();
      int num1 = this.Owner != null ? this.Owner.AdjustedViewportWidth : 0;
      int num2 = this.Owner != null ? (int) Math.Min(availableSize.Height, (double) this.Owner.ViewportHeight) : 0;
      Size size1 = new Size(0.0, (double) num2);
      Size size2 = new Size((double) num1, (double) num2);
      Size size3 = new Size(double.PositiveInfinity, (double) num2);
      int count = this.Children.Count;
      this._visibleChildren.Clear();
      for (int index = 0; index < count; ++index)
      {
        if (this.Children[(index + defaultItemIndex) % count] is PanoramaItem child1)
        {
          if (child1.Visibility == Visibility.Visible)
          {
            PanoramaItem panoramaItem = child1;
            panoramaItem.Measure(panoramaItem.Orientation == Orientation.Vertical ? size2 : size3);
            this._visibleChildren.Add(child1);
            if (child1.Orientation == Orientation.Vertical)
              size1.Width += (double) num1;
            else
              size1.Width += Math.Max((double) num1, child1.DesiredSize.Width);
          }
          else if (Microsoft.Phone.QuirksMode.ShouldPanoramaCallMeasureForCollapsedItems())
          {
            PanoramaItem panoramaItem = child1;
            panoramaItem.Measure(panoramaItem.Orientation == Orientation.Vertical ? size2 : size3);
          }
        }
      }
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_MEASURE, PerfLog.PanoramaPanel);
      return size1;
    }

    protected override Size ArrangeOverride(Size finalSize)
    {
      PerfLog.BeginLogMarker(PerfMarkerEvents.MPC_PANO_ARRANGE, PerfLog.PanoramaPanel);
      this._itemStops.Clear();
      double num = 0.0;
      Rect finalRect = new Rect(0.0, 0.0, 0.0, finalSize.Height);
      for (int index = 0; index < this._visibleChildren.Count; ++index)
      {
        PanoramaItem visibleChild = this._visibleChildren[index];
        finalRect.X = (double) (visibleChild.StartPosition = (int) num);
        this._itemStops.Add(new PanoramaPanel.ItemStop(visibleChild, index, visibleChild.StartPosition));
        if (visibleChild.Orientation == Orientation.Vertical)
        {
          finalRect.Width = this.Owner != null ? (double) this.Owner.AdjustedViewportWidth : 0.0;
        }
        else
        {
          finalRect.Width = Math.Max(this.Owner != null ? (double) this.Owner.AdjustedViewportWidth : 0.0, visibleChild.DesiredSize.Width);
          if (this.Owner != null && finalRect.Width > (double) this.Owner.AdjustedViewportWidth)
            this._itemStops.Add(new PanoramaPanel.ItemStop(visibleChild, index, visibleChild.StartPosition + (int) finalRect.Width - this.Owner.AdjustedViewportWidth));
        }
        visibleChild.ItemWidth = (int) finalRect.Width;
        visibleChild.Arrange(finalRect);
        num += finalRect.Width;
      }
      if (this.Owner != null)
        this.Owner.RequestAdjustSelection();
      this.UpdateDirectManipulationVisibleChildren();
      PanoramaItemStopNative[] stops = this._itemStops.Count > 0 ? new PanoramaItemStopNative[this._itemStops.Count] : (PanoramaItemStopNative[]) null;
      for (int index = 0; index < this._itemStops.Count; ++index)
      {
        stops[index].Index = (__Null) this._itemStops[index].Index;
        stops[index].Position = (__Null) this._itemStops[index].Position;
      }
      if (this.Owner != null)
        this.Owner.DirectManipulationSetItemStops(stops);
      PerfLog.EndLogMarker(PerfMarkerEvents.MPC_PANO_ARRANGE, PerfLog.PanoramaPanel);
      return finalSize;
    }

    private int GetDefaultItemIndex()
    {
      PanoramaItem panoramaItem = this.Owner != null ? this.Owner.GetDefaultItemContainer() : (PanoramaItem) null;
      int num = panoramaItem != null ? this.Children.IndexOf((UIElement) panoramaItem) : 0;
      if (num < 0)
        num = 0;
      return num;
    }

    private void GetItemsInView(
      int offset,
      int viewportWidth,
      out int leftIndex,
      out int leftInView,
      out int centerIndex,
      out int rightIndex,
      out int rightInView)
    {
      leftIndex = leftInView = centerIndex = rightIndex = rightInView = -1;
      int count = this.VisibleChildren.Count;
      if (count == 0)
        return;
      for (int index = 0; index < count; ++index)
      {
        PanoramaItem visibleChild = this._visibleChildren[index];
        int num1 = visibleChild.StartPosition + offset;
        int num2 = num1 + visibleChild.ItemWidth - 1;
        if (num1 <= 0 && num2 >= 0)
        {
          leftIndex = index;
          leftInView = Math.Min(viewportWidth, visibleChild.ItemWidth + num1);
        }
        if (num1 < viewportWidth && num2 >= viewportWidth)
        {
          rightIndex = index;
          ref int local = ref rightInView;
          int val1 = viewportWidth;
          int num3 = Math.Min(val1, val1 - num1);
          local = num3;
        }
        if (num1 > 0 && num2 < viewportWidth)
          centerIndex = index;
        if (index == 0 && leftInView == -1)
          leftInView = num1;
        if (index == count - 1 && rightInView == -1)
          rightInView = viewportWidth - num2 - 1;
      }
    }

    internal void GetStops(
      int offset,
      int totalWidth,
      out PanoramaPanel.ItemStop previous,
      out PanoramaPanel.ItemStop current,
      out PanoramaPanel.ItemStop next)
    {
      int num1;
      int index1 = num1 = -1;
      int index2 = num1;
      int index3 = num1;
      next = current = previous = (PanoramaPanel.ItemStop) null;
      if (this.VisibleChildren.Count == 0)
        return;
      int num2 = -offset % totalWidth;
      int num3 = 0;
      foreach (PanoramaPanel.ItemStop itemStop in this._itemStops)
      {
        if (itemStop.Position < num2)
        {
          index3 = num3;
        }
        else
        {
          if (itemStop.Position > num2)
          {
            index1 = num3;
            break;
          }
          if (itemStop.Position == num2)
            index2 = num3;
        }
        ++num3;
      }
      if (index3 == -1)
        index3 = this._itemStops.Count - 1;
      if (index1 == -1)
        index1 = 0;
      previous = this._itemStops[index3];
      current = index2 != -1 ? this._itemStops[index2] : (PanoramaPanel.ItemStop) null;
      next = this._itemStops[index1];
    }

    internal int CoerceTargetOffset(int targetOffset)
    {
      int num = targetOffset;
      int count = this._itemStops.Count;
      if (count > 0)
        num = Math.Max(Math.Min(targetOffset, -this._itemStops[0].Position), -this._itemStops[count - 1].Position);
      return num;
    }

    internal void GetSnapOffset(
      int offset,
      int viewportWidth,
      int direction,
      out int snapTo,
      out PanoramaItem newSelection,
      out bool wraparound)
    {
      int num1 = viewportWidth / 3;
      wraparound = false;
      snapTo = offset;
      newSelection = this._selectedItem;
      if (this.VisibleChildren.Count == 0)
        return;
      foreach (PanoramaPanel.ItemStop itemStop in this._itemStops)
      {
        if (itemStop.Position == -offset)
        {
          newSelection = itemStop.Item;
          return;
        }
      }
      int leftIndex;
      int leftInView;
      int centerIndex;
      int rightIndex;
      int rightInView;
      this.GetItemsInView(offset, viewportWidth, out leftIndex, out leftInView, out centerIndex, out rightIndex, out rightInView);
      if (leftIndex == rightIndex && leftIndex != -1)
      {
        newSelection = this._selectedItem = this._visibleChildren[leftIndex];
      }
      else
      {
        bool flag1 = false;
        if (leftIndex == -1)
        {
          flag1 = true;
          leftIndex = this._visibleChildren.Count - 1;
        }
        bool flag2 = false;
        if (rightIndex == -1)
        {
          flag2 = true;
          rightIndex = 0;
        }
        int index;
        int num2;
        if (direction < 0)
        {
          if (rightInView > num1)
          {
            index = PanoramaPanel.GetBestIndex(centerIndex, rightIndex, leftIndex);
            num2 = -1;
          }
          else
          {
            index = PanoramaPanel.GetBestIndex(centerIndex, leftIndex, rightIndex);
            num2 = 1;
          }
        }
        else if (direction > 0)
        {
          if (leftInView > num1)
          {
            index = PanoramaPanel.GetBestIndex(centerIndex, leftIndex, rightIndex);
            num2 = 1;
          }
          else
          {
            index = PanoramaPanel.GetBestIndex(centerIndex, rightIndex, leftIndex);
            num2 = -1;
          }
        }
        else if (centerIndex != -1)
        {
          index = centerIndex;
          num2 = -1;
        }
        else if (leftInView > rightInView)
        {
          index = leftIndex;
          num2 = -1;
        }
        else
        {
          index = rightIndex;
          num2 = 1;
        }
        this._selectedItem = this._visibleChildren[index];
        snapTo = num2 >= 0 ? PanoramaPanel.GetRightAlignedOffset(this._selectedItem, viewportWidth) : PanoramaPanel.GetLeftAlignedOffset(this._selectedItem, viewportWidth);
        newSelection = this._selectedItem;
        if (!(index == leftIndex & flag1) && !(index == rightIndex & flag2))
          return;
        wraparound = true;
      }
    }

    private static int GetBestIndex(int n0, int n1, int n2)
    {
      if (n0 >= 0)
        return n0;
      if (n1 >= 0)
        return n1;
      return n2 >= 0 ? n2 : throw new InvalidOperationException("No best index.");
    }

    [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "Present for consistency with GetRightAlignedOffset.", MessageId = "viewportWidth")]
    private static int GetLeftAlignedOffset(PanoramaItem movingTo, int viewportWidth) => -movingTo.StartPosition;

    private static int GetRightAlignedOffset(PanoramaItem movingTo, int viewportWidth) => movingTo.Orientation != Orientation.Vertical ? -movingTo.ItemWidth + viewportWidth - movingTo.StartPosition - 48 : -movingTo.StartPosition;

    private void FindOwner()
    {
      FrameworkElement frameworkElement = (FrameworkElement) this;
      Panorama panorama;
      do
      {
        frameworkElement = (FrameworkElement) VisualTreeHelper.GetParent((DependencyObject) frameworkElement);
        panorama = frameworkElement as Panorama;
      }
      while (frameworkElement != null && panorama == null);
      this.Owner = panorama;
    }

    internal void NotifyDefaultItemChanged()
    {
      this.InvalidateMeasure();
      this.InvalidateArrange();
      this.UpdateLayout();
    }

    internal class ItemStop
    {
      public int Index { get; private set; }

      public int Position { get; private set; }

      public PanoramaItem Item { get; private set; }

      public ItemStop(PanoramaItem item, int index, int position)
      {
        this.Item = item;
        this.Index = index;
        this.Position = position;
      }
    }
  }
}
