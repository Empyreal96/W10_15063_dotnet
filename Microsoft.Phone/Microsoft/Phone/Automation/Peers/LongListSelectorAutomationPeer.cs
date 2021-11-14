// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Automation.Peers.LongListSelectorAutomationPeer
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
  public class LongListSelectorAutomationPeer : 
    FrameworkElementAutomationPeer,
    ISelectionProvider,
    IScrollProvider
  {
    public LongListSelectorAutomationPeer(LongListSelector owner)
      : base((FrameworkElement) owner)
    {
    }

    public override object GetPattern(PatternInterface patternInterface) => patternInterface == PatternInterface.Selection || patternInterface == PatternInterface.Scroll ? (object) this : base.GetPattern(patternInterface);

    protected override string GetClassNameCore() => "LongListSelector";

    protected override AutomationControlType GetAutomationControlTypeCore() => AutomationControlType.List;

    protected override List<AutomationPeer> GetChildrenCore() => ((LongListSelector) this.Owner).AutomationGetChildrenAP();

    bool ISelectionProvider.CanSelectMultiple => false;

    bool ISelectionProvider.IsSelectionRequired => false;

    IRawElementProviderSimple[] ISelectionProvider.GetSelection()
    {
      LongListSelector owner = (LongListSelector) this.Owner;
      if (owner.SelectedItem != null)
      {
        ContentPresenter containerForSelectedItem = owner.AutomationGetContainerForSelectedItem();
        if (containerForSelectedItem != null)
          return new IRawElementProviderSimple[1]
          {
            this.ProviderFromPeer(containerForSelectedItem.GetOrCreateAutomationPeer())
          };
      }
      return (IRawElementProviderSimple[]) null;
    }

    void IScrollProvider.Scroll(
      ScrollAmount horizontalAmount,
      ScrollAmount verticalAmount)
    {
      if (!this.IsEnabled())
        throw new ElementNotEnabledException();
      bool flag = horizontalAmount != ScrollAmount.NoAmount;
      int num = verticalAmount != ScrollAmount.NoAmount ? 1 : 0;
      LongListSelector owner = (LongListSelector) this.Owner;
      if (((num == 0 ? 0 : (!this.VerticallyScrollable ? 1 : 0)) | (flag ? 1 : 0)) != 0)
        throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);
      switch (verticalAmount)
      {
        case ScrollAmount.LargeDecrement:
          owner.ScrollOffset = Math.Max(owner.ScrollOffset - owner.ScrollViewport, 0.0);
          break;
        case ScrollAmount.SmallDecrement:
          owner.ScrollOffset = Math.Max(owner.ScrollOffset - 16.0, 0.0);
          break;
        case ScrollAmount.NoAmount:
          break;
        case ScrollAmount.LargeIncrement:
          owner.ScrollOffset = Math.Min(owner.ScrollOffset + owner.ScrollViewport, owner.ScrollExtent);
          break;
        case ScrollAmount.SmallIncrement:
          owner.ScrollOffset = Math.Min(owner.ScrollOffset + 16.0, owner.ScrollExtent);
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
      bool flag = horizontalPercent != -1.0;
      int num = verticalPercent != -1.0 ? 1 : 0;
      if (((num == 0 ? 0 : (!this.VerticallyScrollable ? 1 : 0)) | (flag ? 1 : 0)) != 0)
        throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);
      if (num == 0)
        return;
      if (verticalPercent >= 0.0 && verticalPercent <= 100.0)
      {
        LongListSelector owner = (LongListSelector) this.Owner;
        owner.ScrollOffset = verticalPercent * owner.ScrollExtent / 100.0;
      }
      else
        throw new ArgumentOutOfRangeException(nameof (verticalPercent), string.Format(Resources.IScrollProvider_OutOfRange, (object) nameof (verticalPercent), (object) verticalPercent.ToString((IFormatProvider) CultureInfo.InvariantCulture), (object) "0", (object) "100"));
    }

    double IScrollProvider.HorizontalScrollPercent => -1.0;

    double IScrollProvider.VerticalScrollPercent
    {
      get
      {
        LongListSelector owner = (LongListSelector) this.Owner;
        return this.GetVerticalScrollPercent(owner.ScrollExtent, owner.ScrollViewport, owner.ScrollOffset);
      }
    }

    double IScrollProvider.HorizontalViewSize => 100.0;

    double IScrollProvider.VerticalViewSize
    {
      get
      {
        LongListSelector owner = (LongListSelector) this.Owner;
        return this.GetVerticalViewSize(owner.ScrollExtent, owner.ScrollViewport);
      }
    }

    bool IScrollProvider.HorizontallyScrollable => this.HorizontallyScrollable;

    bool IScrollProvider.VerticallyScrollable => this.VerticallyScrollable;

    private bool HorizontallyScrollable => false;

    private bool VerticallyScrollable
    {
      get
      {
        LongListSelector owner = (LongListSelector) this.Owner;
        return this.IsVerticallyScrollable(owner.ScrollExtent, owner.ScrollViewport);
      }
    }

    internal void RaiseSelectionChangedEvent(ContentPresenter selectedItem)
    {
      if (!(selectedItem.GetOrCreateAutomationPeer() is LongListSelectorItemAutomationPeer automationPeer))
        return;
      automationPeer.RaiseAutomationEvent(AutomationEvents.SelectionItemPatternOnElementSelected);
    }

    internal void RaiseSelectionPropertyChangedEvents(ContentPresenter selectedItem)
    {
      if (!(selectedItem.GetOrCreateAutomationPeer() is LongListSelectorItemAutomationPeer automationPeer))
        return;
      automationPeer.RaisePropertyChangedEvent(SelectionItemPatternIdentifiers.IsSelectedProperty, (object) false, (object) true);
    }

    internal void RaiseScrollPropertyChangedEvents(
      double oldScrollExtent,
      double oldScrollViewport,
      double oldScrollOffset)
    {
      LongListSelector owner = (LongListSelector) this.Owner;
      IScrollProvider scrollProvider = (IScrollProvider) this;
      bool flag = this.IsVerticallyScrollable(oldScrollExtent, oldScrollViewport);
      double verticalViewSize = this.GetVerticalViewSize(oldScrollExtent, oldScrollViewport);
      double verticalScrollPercent = this.GetVerticalScrollPercent(oldScrollExtent, oldScrollViewport, oldScrollOffset);
      if (flag != this.VerticallyScrollable)
        this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.VerticallyScrollableProperty, (object) flag, (object) this.VerticallyScrollable);
      if (Math.Round(verticalViewSize, 2) != Math.Round(scrollProvider.VerticalViewSize, 2))
        this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.VerticalViewSizeProperty, (object) verticalViewSize, (object) scrollProvider.VerticalViewSize);
      if (Math.Round(verticalScrollPercent, 2) == Math.Round(scrollProvider.VerticalScrollPercent, 2))
        return;
      this.RaisePropertyChangedEvent(ScrollPatternIdentifiers.VerticalScrollPercentProperty, (object) verticalScrollPercent, (object) scrollProvider.VerticalScrollPercent);
    }

    public bool IsVerticallyScrollable(double scrollExtent, double scrollViewport) => scrollExtent > scrollViewport;

    public double GetVerticalViewSize(double scrollExtent, double scrollViewport) => this.IsVerticallyScrollable(scrollExtent, scrollViewport) ? 100.0 * scrollViewport / scrollExtent : 100.0;

    public double GetVerticalScrollPercent(
      double scrollExtent,
      double scrollViewport,
      double scrollOffset)
    {
      return this.IsVerticallyScrollable(scrollExtent, scrollViewport) ? 100.0 * scrollOffset / scrollExtent : -1.0;
    }
  }
}
