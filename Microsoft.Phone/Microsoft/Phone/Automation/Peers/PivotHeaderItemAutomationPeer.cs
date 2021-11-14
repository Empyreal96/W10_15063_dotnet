// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Automation.Peers.PivotHeaderItemAutomationPeer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls.Primitives;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

namespace Microsoft.Phone.Automation.Peers
{
  public class PivotHeaderItemAutomationPeer : FrameworkElementAutomationPeer, IInvokeProvider
  {
    internal bool ContainsSingleTextBlock
    {
      get
      {
        List<AutomationPeer> children = this.GetChildren();
        return children != null && children.Count == 0;
      }
    }

    public PivotHeaderItemAutomationPeer(PivotHeaderItem owner)
      : base((FrameworkElement) owner)
    {
    }

    protected override string GetClassNameCore() => "PivotHeaderItem";

    public override object GetPattern(PatternInterface patternInterface) => patternInterface == PatternInterface.Invoke ? (object) this : base.GetPattern(patternInterface);

    protected override List<AutomationPeer> GetChildrenCore()
    {
      List<AutomationPeer> childrenCore = base.GetChildrenCore();
      if (childrenCore != null && childrenCore.Count == 1 && childrenCore[0].GetAutomationControlType() == AutomationControlType.Text)
        childrenCore.Clear();
      return childrenCore;
    }

    protected override AutomationControlType GetAutomationControlTypeCore() => this.ContainsSingleTextBlock ? AutomationControlType.Text : AutomationControlType.Pane;

    protected override string GetNameCore()
    {
      string str = base.GetNameCore();
      if (string.IsNullOrEmpty(str) && this.ContainsSingleTextBlock)
        str = base.GetChildrenCore()[0].GetName();
      return str;
    }

    public void Invoke()
    {
      AutomationPeer parent = this.GetParent();
      if (parent == null || !(parent.GetPattern(PatternInterface.SelectionItem) is ISelectionItemProvider pattern))
        return;
      pattern.Select();
    }
  }
}
