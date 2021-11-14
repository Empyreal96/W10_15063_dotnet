// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Automation.Peers.PivotAutomationPeer
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
  public class PivotAutomationPeer : ItemsControlAutomationPeer, ISelectionProvider, IScrollProvider
  {
    public PivotAutomationPeer(Pivot owner)
      : base((ItemsControl) owner)
    {
    }

    protected override string GetClassNameCore() => "Pivot";

    public override object GetPattern(PatternInterface patternInterface) => patternInterface == PatternInterface.Selection || patternInterface == PatternInterface.Scroll ? (object) this : (object) null;

    protected override List<AutomationPeer> GetChildrenCore()
    {
      UIElement titlePart = ((Pivot) this.Owner).TitlePart;
      List<AutomationPeer> automationPeerList = base.GetChildrenCore();
      if (titlePart != null)
      {
        if (automationPeerList == null)
          automationPeerList = new List<AutomationPeer>();
        automationPeerList.InsertRange(0, (IEnumerable<AutomationPeer>) this.GetAutomationPeerChildren(titlePart));
      }
      return automationPeerList;
    }

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
      int num = horizontalAmount != ScrollAmount.NoAmount ? 1 : 0;
      bool flag = verticalAmount != ScrollAmount.NoAmount;
      Pivot owner = (Pivot) this.Owner;
      int count = owner.Items.Count;
      if (((num == 0 ? 0 : (!this.HorizontallyScrollable ? 1 : 0)) | (flag ? 1 : 0)) != 0)
        throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);
      switch (horizontalAmount)
      {
        case ScrollAmount.LargeDecrement:
        case ScrollAmount.SmallDecrement:
          Pivot pivot1 = owner;
          pivot1.SelectedIndex = (pivot1.SelectedIndex + count - 1) % count;
          break;
        case ScrollAmount.NoAmount:
          break;
        case ScrollAmount.LargeIncrement:
        case ScrollAmount.SmallIncrement:
          Pivot pivot2 = owner;
          pivot2.SelectedIndex = (pivot2.SelectedIndex + 1) % count;
          break;
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
      bool flag1 = horizontalPercent != -1.0;
      bool flag2 = verticalPercent != -1.0;
      Pivot owner = (Pivot) this.Owner;
      if (((!flag1 ? 0 : (!this.HorizontallyScrollable ? 1 : 0)) | (flag2 ? 1 : 0)) != 0)
        throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);
      if (flag1 && horizontalPercent < 0.0 || horizontalPercent > 100.0)
        throw new ArgumentOutOfRangeException(nameof (horizontalPercent), string.Format(Resources.IScrollProvider_OutOfRange, (object) nameof (horizontalPercent), (object) horizontalPercent.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) "0", (object) "100"));
      if (!flag1)
        return;
      int count = owner.Items.Count;
      int num = Math.Min((int) ((double) count * horizontalPercent / 100.0), count - 1);
      owner.SelectedIndex = num;
    }

    double IScrollProvider.HorizontalScrollPercent
    {
      get
      {
        Pivot owner = (Pivot) this.Owner;
        return this.GetHorizontalScrollPercent(owner.Items.Count, owner.IsLocked, owner.SelectedIndex);
      }
    }

    double IScrollProvider.VerticalScrollPercent => -1.0;

    double IScrollProvider.HorizontalViewSize
    {
      get
      {
        Pivot owner = (Pivot) this.Owner;
        return this.GetHorizontalViewSize(owner.Items.Count, owner.IsLocked);
      }
    }

    double IScrollProvider.VerticalViewSize => 100.0;

    bool IScrollProvider.HorizontallyScrollable => this.HorizontallyScrollable;

    bool IScrollProvider.VerticallyScrollable => this.VerticallyScrollable;

    private bool HorizontallyScrollable
    {
      get
      {
        Pivot owner = (Pivot) this.Owner;
        return this.IsHorizontallyScrollable(owner.Items.Count, owner.IsLocked);
      }
    }

    private bool VerticallyScrollable => false;

    internal void RaiseSelectionChangedEvent(PivotItem selectedItem)
    {
      if (!(selectedItem.GetOrCreateAutomationPeer() is PivotItemAutomationPeer automationPeer))
        return;
      automationPeer.RaiseAutomationEvent(AutomationEvents.SelectionItemPatternOnElementSelected);
    }

    internal void RaisePropertyChangedEvents(
      int oldItemsCount,
      bool oldIsLocked,
      int oldSelectedIndex,
      int newSelectedIndex)
    {
      Pivot owner = (Pivot) this.Owner;
      int count = owner.Items.Count;
      IScrollProvider scrollProvider = (IScrollProvider) this;
      bool flag = this.IsHorizontallyScrollable(oldItemsCount, oldIsLocked);
      double horizontalViewSize = this.GetHorizontalViewSize(oldItemsCount, oldIsLocked);
      double horizontalScrollPercent1 = this.GetHorizontalScrollPercent(oldItemsCount, oldIsLocked, oldSelectedIndex);
      double horizontalScrollPercent2 = this.GetHorizontalScrollPercent(count, owner.IsLocked, newSelectedIndex);
      if (flag != this.HorizontallyScrollable)
        this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.HorizontallyScrollableProperty, (object) flag, (object) this.HorizontallyScrollable);
      if (horizontalViewSize != scrollProvider.HorizontalViewSize)
        this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.HorizontalViewSizeProperty, (object) horizontalViewSize, (object) scrollProvider.HorizontalViewSize);
      if (horizontalScrollPercent1 != horizontalScrollPercent2)
        this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.HorizontalScrollPercentProperty, (object) horizontalScrollPercent1, (object) horizontalScrollPercent2);
      if (newSelectedIndex == -1 || oldSelectedIndex == newSelectedIndex)
        return;
      IList<AutomationPeer> childrenCore = (IList<AutomationPeer>) base.GetChildrenCore();
      if (childrenCore == null || newSelectedIndex >= childrenCore.Count || !(childrenCore[newSelectedIndex] is PivotItemAutomationPeer itemAutomationPeer))
        return;
      itemAutomationPeer.RaisePropertyChangedEvent(SelectionItemPatternIdentifiers.IsSelectedProperty, (object) false, (object) true);
    }

    internal void RaisePropertyChangedEvents(
      int oldItemsCount,
      bool oldIsLocked,
      int selectedIndex)
    {
      int oldItemsCount1 = oldItemsCount;
      int num1 = oldIsLocked ? 1 : 0;
      int num2 = selectedIndex;
      this.RaisePropertyChangedEvents(oldItemsCount1, num1 != 0, num2, num2);
    }

    public bool IsHorizontallyScrollable(int itemsCount, bool isLocked) => itemsCount > 1 && !isLocked;

    public double GetHorizontalViewSize(int itemsCount, bool isLocked) => this.IsHorizontallyScrollable(itemsCount, isLocked) ? 100.0 / (double) itemsCount : 100.0;

    public double GetHorizontalScrollPercent(int itemsCount, bool isLocked, int selectedIndex) => this.IsHorizontallyScrollable(itemsCount, isLocked) ? (double) selectedIndex * 100.0 / (double) itemsCount : -1.0;

    private AutomationPeer GetPeerForSelectedItem()
    {
      Pivot owner = (Pivot) this.Owner;
      AutomationPeer automationPeer = (AutomationPeer) null;
      if (owner.SelectedIndex != -1)
      {
        IList<AutomationPeer> childrenCore = (IList<AutomationPeer>) base.GetChildrenCore();
        if (childrenCore != null && owner.SelectedIndex < childrenCore.Count)
          automationPeer = childrenCore[owner.SelectedIndex];
      }
      return automationPeer;
    }
  }
}
