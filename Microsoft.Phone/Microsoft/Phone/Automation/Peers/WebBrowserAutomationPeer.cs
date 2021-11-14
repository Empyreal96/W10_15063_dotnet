// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Automation.Peers.WebBrowserAutomationPeer
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Microsoft.Phone.Automation.Peers
{
  public class WebBrowserAutomationPeer : FrameworkElementAutomationPeer
  {
    public WebBrowserAutomationPeer(WebBrowser owner)
      : base((FrameworkElement) owner)
    {
    }

    protected override string GetClassNameCore() => this.Owner.GetType().Name;

    protected override AutomationControlType GetAutomationControlTypeCore() => AutomationControlType.Pane;

    protected override List<AutomationPeer> GetChildrenCore() => (List<AutomationPeer>) null;

    protected override string GetNameCore()
    {
      string str = base.GetNameCore();
      if (string.IsNullOrEmpty(str))
        str = (this.Owner as WebBrowser).Name;
      return str;
    }

    internal virtual void GetHostedProvider(IntPtr windowlessSite, ref IntPtr provider) => (this.Owner as WebBrowser).GetHostedProvider(windowlessSite, ref provider);

    internal virtual bool IsWebBrowserAutomationPeer() => true;
  }
}
