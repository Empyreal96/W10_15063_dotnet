// Decompiled with JetBrains decompiler
// Type: System.Windows.Automation.Peers.FrameAutomationPeer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Windows.Controls;

namespace System.Windows.Automation.Peers
{
  public class FrameAutomationPeer : FrameworkElementAutomationPeer
  {
    public FrameAutomationPeer(Frame owner)
      : base((FrameworkElement) owner)
    {
    }

    protected override AutomationControlType GetAutomationControlTypeCore() => AutomationControlType.Pane;

    protected override string GetClassNameCore() => this.Owner.GetType().Name;

    protected override string GetNameCore()
    {
      string str = base.GetNameCore();
      if (string.IsNullOrEmpty(str))
        str = (this.Owner as Frame).Name;
      if (string.IsNullOrEmpty(str))
        str = this.GetClassName();
      return str;
    }

    internal void RaiseFocusChangedAutomationEvent() => this.RaiseAutomationEvent(AutomationEvents.AutomationFocusChanged);
  }
}
