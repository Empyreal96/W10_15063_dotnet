// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Automation.Peers.MapAutomationPeer
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps;
using Microsoft.Phone.Maps.Controls;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Microsoft.Phone.Automation.Peers
{
  public class MapAutomationPeer : FrameworkElementAutomationPeer
  {
    public MapAutomationPeer(Map owner)
      : base((FrameworkElement) owner)
    {
    }

    protected override AutomationControlType GetAutomationControlTypeCore() => AutomationControlType.Pane;

    protected override string GetClassNameCore() => "Map";

    protected override string GetNameCore() => Resources.UIAMapName;
  }
}
