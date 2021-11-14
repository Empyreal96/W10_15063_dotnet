// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Automation.Peers.PanoramaAutomationPeer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;

namespace Microsoft.Phone.Automation.Peers
{
  public class PanoramaAutomationPeer : 
    ItemsControlAutomationPeer,
    ISelectionProvider,
    IScrollProvider
  {
    public PanoramaAutomationPeer(Panorama owner)
      : base((ItemsControl) owner)
    {
    }

    protected override string GetClassNameCore() => "Panorama";

    protected override List<AutomationPeer> GetChildrenCore()
    {
      UIElement panningTitle = (UIElement) ((Panorama) this.Owner).PanningTitle;
      List<AutomationPeer> automationPeerList = base.GetChildrenCore();
      if (panningTitle != null)
      {
        if (automationPeerList == null)
          automationPeerList = new List<AutomationPeer>();
        automationPeerList.InsertRange(0, (IEnumerable<AutomationPeer>) this.GetAutomationPeerChildren(panningTitle));
      }
      return automationPeerList;
    }

    public override object GetPattern(PatternInterface patternInterface) => patternInterface == PatternInterface.Selection || patternInterface == PatternInterface.Scroll ? (object) this : (object) null;

    bool ISelectionProvider.CanSelectMultiple => false;

    bool ISelectionProvider.IsSelectionRequired => true;

    IRawElementProviderSimple[] ISelectionProvider.GetSelection() => new IRawElementProviderSimple[1]
    {
      this.ProviderFromPeer(this.GetPeerForSelectedItem())
    };

    void IScrollProvider.Scroll(
      ScrollAmount horizontalAmount,
      ScrollAmount verticalAmount)
    {
      if (!this.IsEnabled())
        throw new ElementNotEnabledException();
      int num1 = horizontalAmount != ScrollAmount.NoAmount ? 1 : 0;
      bool flag = verticalAmount != ScrollAmount.NoAmount;
      int num2 = 0;
      Panorama owner = (Panorama) this.Owner;
      int count = owner.Items.Count;
      if (((num1 == 0 ? 0 : (!this.HorizontallyScrollable ? 1 : 0)) | (flag ? 1 : 0)) != 0)
        throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);
      switch (horizontalAmount)
      {
        case ScrollAmount.LargeDecrement:
        case ScrollAmount.SmallDecrement:
          num2 = -1;
          goto case ScrollAmount.NoAmount;
        case ScrollAmount.NoAmount:
          if (num2 == 0)
            break;
          ItemContainerGenerator containerGenerator = owner.ItemContainerGenerator;
          for (int index = 1; index < count; ++index)
          {
            PanoramaItem panoramaItem = (PanoramaItem) containerGenerator.ContainerFromIndex((owner.SelectedIndex + count + index * num2) % count);
            if (panoramaItem.Visibility == Visibility.Visible)
            {
              owner.GoTo(-panoramaItem.StartPosition);
              break;
            }
          }
          break;
        case ScrollAmount.LargeIncrement:
        case ScrollAmount.SmallIncrement:
          num2 = 1;
          goto case ScrollAmount.NoAmount;
        default:
          throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);
      }
    }

    void IScrollProvider.SetScrollPercent(
      double horizontalPercent,
      double verticalPercent)
    {
      if (!this.IsEnabled())
        throw new ElementNotEnabledException();
      int num = horizontalPercent != -1.0 ? 1 : 0;
      bool flag = verticalPercent != -1.0;
      Panorama owner = (Panorama) this.Owner;
      if (((num == 0 ? 0 : (!this.HorizontallyScrollable ? 1 : 0)) | (flag ? 1 : 0)) != 0)
        throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);
      if (num == 0)
        return;
      if (horizontalPercent >= 0.0 && horizontalPercent <= 100.0)
        owner.AutomationSetScrollPercent(horizontalPercent);
      else
        throw new ArgumentOutOfRangeException(nameof (horizontalPercent), string.Format(Resources.IScrollProvider_OutOfRange, (object) nameof (horizontalPercent), (object) horizontalPercent.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) "0", (object) "100"));
    }

    double IScrollProvider.HorizontalScrollPercent
    {
      get
      {
        Panorama owner = (Panorama) this.Owner;
        return this.GetHorizontalScrollPercent(owner.ViewportWidth, owner.ItemsWidth, -owner.ActualOffset);
      }
    }

    double IScrollProvider.VerticalScrollPercent => -1.0;

    double IScrollProvider.HorizontalViewSize
    {
      get
      {
        Panorama owner = (Panorama) this.Owner;
        return this.GetHorizontalViewSize(owner.ViewportWidth, owner.ItemsWidth);
      }
    }

    double IScrollProvider.VerticalViewSize => 100.0;

    bool IScrollProvider.HorizontallyScrollable => this.HorizontallyScrollable;

    bool IScrollProvider.VerticallyScrollable => false;

    private bool HorizontallyScrollable
    {
      get
      {
        Panorama owner = (Panorama) this.Owner;
        return this.IsHorizontallyScrollable(owner.ViewportWidth, owner.ItemsWidth);
      }
    }

    internal void RaiseSelectionChangedEvent(PanoramaItem selectedItem)
    {
      if (!(selectedItem.GetOrCreateAutomationPeer() is PanoramaItemAutomationPeer automationPeer))
        return;
      automationPeer.RaiseAutomationEvent(AutomationEvents.SelectionItemPatternOnElementSelected);
    }

    internal void RaiseSelectionPropertyChangedEvents(
      PanoramaItem oldSelectedItem,
      PanoramaItem newSelectedItem)
    {
      Panorama owner = (Panorama) this.Owner;
      PanoramaItemAutomationPeer automationPeer = newSelectedItem.GetOrCreateAutomationPeer() as PanoramaItemAutomationPeer;
      int offset = oldSelectedItem != null ? oldSelectedItem.StartPosition : 0;
      int startPosition = newSelectedItem.StartPosition;
      automationPeer?.RaisePropertyChangedEvent(SelectionItemPatternIdentifiers.IsSelectedProperty, (object) false, (object) true);
      if (startPosition == offset)
        return;
      double horizontalScrollPercent1 = this.GetHorizontalScrollPercent(owner.ViewportWidth, owner.ItemsWidth, offset);
      double horizontalScrollPercent2 = this.GetHorizontalScrollPercent(owner.ViewportWidth, owner.ItemsWidth, startPosition);
      this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.HorizontalScrollPercentProperty, (object) horizontalScrollPercent1, (object) horizontalScrollPercent2);
    }

    internal void RaiseScrollPropertyChangedEvents(int oldViewportWidth, int oldItemsWidth)
    {
      int count = ((ItemsControl) this.Owner).Items.Count;
      IScrollProvider scrollProvider = (IScrollProvider) this;
      bool flag = this.IsHorizontallyScrollable(oldViewportWidth, oldItemsWidth);
      double horizontalViewSize = this.GetHorizontalViewSize(oldViewportWidth, oldItemsWidth);
      if (flag != this.HorizontallyScrollable)
        this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.HorizontallyScrollableProperty, (object) flag, (object) this.HorizontallyScrollable);
      if (horizontalViewSize == scrollProvider.HorizontalViewSize)
        return;
      this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.HorizontalViewSizeProperty, (object) horizontalViewSize, (object) scrollProvider.HorizontalViewSize);
    }

    public bool IsHorizontallyScrollable(int viewportWidth, int itemsWidth) => viewportWidth < itemsWidth;

    public double GetHorizontalViewSize(int viewportWidth, int itemsWidth) => this.IsHorizontallyScrollable(viewportWidth, itemsWidth) && itemsWidth > 0 ? 100.0 * (double) viewportWidth / (double) itemsWidth : 100.0;

    public double GetHorizontalScrollPercent(int viewportWidth, int itemsWidth, int offset) => this.IsHorizontallyScrollable(viewportWidth, itemsWidth) ? (double) offset * 100.0 / (double) (itemsWidth - (viewportWidth - 48)) : -1.0;

    private AutomationPeer GetPeerForSelectedItem()
    {
      Panorama owner = (Panorama) this.Owner;
      AutomationPeer automationPeer = (AutomationPeer) null;
      if (owner.SelectedIndex != -1)
      {
        IList<AutomationPeer> childrenCore = (IList<AutomationPeer>) base.GetChildrenCore();
        if (childrenCore != null && owner.SelectedIndex < childrenCore.Count)
          automationPeer = childrenCore[owner.SelectedIndex];
      }
      return automationPeer;
    }

    internal void SetSelectedItem(object item)
    {
      Panorama owner = (Panorama) this.Owner;
      PanoramaItem panoramaItem = (PanoramaItem) owner.ItemContainerGenerator.ContainerFromItem(item);
      if (panoramaItem.Visibility != Visibility.Visible)
        return;
      owner.GoTo(-panoramaItem.StartPosition);
    }
  }
}
