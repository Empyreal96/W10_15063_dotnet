// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Automation.Peers.LongListSelectorItemAutomationPeer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Properties;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;

namespace Microsoft.Phone.Automation.Peers
{
  public class LongListSelectorItemAutomationPeer : 
    FrameworkElementAutomationPeer,
    ISelectionItemProvider,
    IScrollItemProvider,
    IInvokeProvider
  {
    private LongListSelector _parentLLS;
    private const string PauseDelimiter = "; ";

    private bool GroupHeaderContainsSingleTextBlock
    {
      get
      {
        List<AutomationPeer> childrenCore = base.GetChildrenCore();
        return childrenCore != null && childrenCore.Count == 1 && childrenCore[0].GetAutomationControlType() == AutomationControlType.Text;
      }
    }

    public LongListSelectorItemAutomationPeer(ContentPresenter owner, LongListSelector parentLLS)
      : base((FrameworkElement) owner)
    {
      this._parentLLS = parentLLS != null ? parentLLS : throw new ArgumentNullException(nameof (parentLLS));
    }

    public override object GetPattern(PatternInterface patternInterface)
    {
      LongListSelectorItem? nullable = this._parentLLS.AutomationItemFromContainer((ContentPresenter) this.Owner);
      object obj = (object) null;
      if (nullable.HasValue)
      {
        if (patternInterface == PatternInterface.SelectionItem && nullable.Value.ItemKind == LongListSelectorItemKind.Item)
          obj = (object) this;
        else if (patternInterface == PatternInterface.ScrollItem && (nullable.Value.ItemKind == LongListSelectorItemKind.Item || nullable.Value.ItemKind == LongListSelectorItemKind.GroupHeader))
          obj = (object) this;
        else if (patternInterface == PatternInterface.Invoke && nullable.Value.ItemKind == LongListSelectorItemKind.GroupHeader)
          obj = (object) this;
      }
      if (obj == null)
        obj = base.GetPattern(patternInterface);
      return obj;
    }

    protected override string GetClassNameCore() => "ContentPresenter";

    protected override string GetNameCore()
    {
      string str = base.GetNameCore();
      if (string.IsNullOrEmpty(str))
      {
        if (this.GetAutomationControlTypeCore() == AutomationControlType.ListItem)
          str = this.ConcatTextNodesNames();
        else if (this.GroupHeaderContainsSingleTextBlock)
          str = base.GetChildrenCore()[0].GetName();
      }
      return str;
    }

    protected override AutomationControlType GetAutomationControlTypeCore()
    {
      LongListSelectorItem? nullable = this._parentLLS.AutomationItemFromContainer((ContentPresenter) this.Owner);
      return nullable.HasValue && nullable.Value.ItemKind == LongListSelectorItemKind.GroupHeader ? AutomationControlType.Group : AutomationControlType.ListItem;
    }

    protected override List<AutomationPeer> GetChildrenCore()
    {
      LongListSelectorItem? nullable = this._parentLLS.AutomationItemFromContainer((ContentPresenter) this.Owner);
      if (!nullable.HasValue || nullable.Value.ItemKind != LongListSelectorItemKind.GroupHeader)
        return base.GetChildrenCore();
      List<AutomationPeer> automationPeerList = new List<AutomationPeer>();
      if (!this.GroupHeaderContainsSingleTextBlock)
      {
        List<AutomationPeer> childrenCore = base.GetChildrenCore();
        if (childrenCore != null)
          automationPeerList.AddRange((IEnumerable<AutomationPeer>) childrenCore);
      }
      automationPeerList.AddRange((IEnumerable<AutomationPeer>) this._parentLLS.AutomationGetGroupChildrenAP((ContentPresenter) this.Owner));
      return automationPeerList;
    }

    void IInvokeProvider.Invoke() => this._parentLLS.OpenJumpList((ContentPresenter) this.Owner);

    void ISelectionItemProvider.Select()
    {
      if (!this.IsEnabled())
        throw new ElementNotEnabledException();
      LongListSelectorItem? nullable = this._parentLLS.AutomationItemFromContainer((ContentPresenter) this.Owner);
      if (!nullable.HasValue)
        return;
      this._parentLLS.SelectedItem = nullable.Value.Data;
    }

    void ISelectionItemProvider.AddToSelection() => throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);

    void ISelectionItemProvider.RemoveFromSelection() => throw new InvalidOperationException(Resources.UIA_OperationCannotBePerformed);

    bool ISelectionItemProvider.IsSelected => this.Owner == this._parentLLS.AutomationGetContainerForSelectedItem();

    IRawElementProviderSimple ISelectionItemProvider.SelectionContainer => this.ProviderFromPeer(this._parentLLS.GetOrCreateAutomationPeer());

    void IScrollItemProvider.ScrollIntoView()
    {
      if (!this.IsEnabled())
        throw new ElementNotEnabledException();
      ContentPresenter owner = (ContentPresenter) this.Owner;
      LongListSelectorItem? nullable = this._parentLLS.AutomationItemFromContainer(owner);
      if (!nullable.HasValue || nullable.Value.ItemKind != LongListSelectorItemKind.GroupHeader && nullable.Value.ItemKind != LongListSelectorItemKind.Item)
        return;
      this._parentLLS.AutomationScrollIntoView(owner);
    }

    private string ConcatTextNodesNames()
    {
      StringBuilder stringBuilder1 = new StringBuilder();
      List<AutomationPeer> children = this.GetChildren();
      if (children != null)
      {
        foreach (AutomationPeer automationPeer in children)
        {
          if (automationPeer.GetAutomationControlType() == AutomationControlType.Text)
          {
            string name = automationPeer.GetName();
            if (!string.IsNullOrEmpty(name))
            {
              stringBuilder1.Append(name);
              stringBuilder1.Append("; ");
            }
          }
        }
      }
      if (stringBuilder1.Length > "; ".Length)
      {
        StringBuilder stringBuilder2 = stringBuilder1;
        stringBuilder2.Remove(stringBuilder2.Length - "; ".Length, "; ".Length);
      }
      return stringBuilder1.ToString();
    }
  }
}
