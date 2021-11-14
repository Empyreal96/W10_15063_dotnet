// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Automation.Peers.PanoramaItemAutomationPeer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Properties;
using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

namespace Microsoft.Phone.Automation.Peers
{
  public class PanoramaItemAutomationPeer : 
    ItemAutomationPeer,
    ISelectionItemProvider,
    IScrollItemProvider
  {
    public PanoramaItemAutomationPeer(
      PanoramaItem owner,
      ItemsControlAutomationPeer itemsControlAutomationPeer)
      : base((object) owner, itemsControlAutomationPeer)
    {
    }

    protected override string GetClassNameCore() => "PanoramaItem";

    public override object GetPattern(PatternInterface patternInterface) => patternInterface == PatternInterface.SelectionItem || patternInterface == PatternInterface.ScrollItem ? (object) this : (object) null;

    void ISelectionItemProvider.Select()
    {
      if (!this.IsEnabled())
        throw new ElementNotEnabledException();
      this.SetSelectedItem(this.Item);
    }

    void ISelectionItemProvider.AddToSelection() => throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);

    void ISelectionItemProvider.RemoveFromSelection() => throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);

    bool ISelectionItemProvider.IsSelected => this.GetSelectedItem() == this.Item;

    IRawElementProviderSimple ISelectionItemProvider.SelectionContainer => this.ProviderFromPeer((AutomationPeer) this.ItemsControlAutomationPeer);

    void IScrollItemProvider.ScrollIntoView()
    {
      if (!this.IsEnabled())
        throw new ElementNotEnabledException();
      this.SetSelectedItem(this.Item);
    }

    private void SetSelectedItem(object item)
    {
      if (this.ItemsControlAutomationPeer == null)
        return;
      ((PanoramaAutomationPeer) this.ItemsControlAutomationPeer).SetSelectedItem(item);
    }

    private object GetSelectedItem()
    {
      object obj = (object) null;
      if (this.ItemsControlAutomationPeer != null)
        obj = ((Panorama) this.ItemsControlAutomationPeer.Owner ?? throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed)).SelectedItem;
      return obj;
    }
  }
}
