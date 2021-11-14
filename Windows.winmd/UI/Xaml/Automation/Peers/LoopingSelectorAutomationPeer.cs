// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.LoopingSelectorAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LoopingSelectorAutomationPeer : 
    FrameworkElementAutomationPeer,
    ILoopingSelectorAutomationPeer,
    IExpandCollapseProvider,
    IItemContainerProvider,
    IScrollProvider,
    ISelectionProvider
  {
    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    [MethodImpl]
    public extern void Collapse();

    [MethodImpl]
    public extern void Expand();

    [MethodImpl]
    public extern IRawElementProviderSimple FindItemByProperty(
      IRawElementProviderSimple startAfter,
      AutomationProperty automationProperty,
      object value);

    public extern bool HorizontallyScrollable { [MethodImpl] get; }

    public extern double HorizontalScrollPercent { [MethodImpl] get; }

    public extern double HorizontalViewSize { [MethodImpl] get; }

    public extern bool VerticallyScrollable { [MethodImpl] get; }

    public extern double VerticalScrollPercent { [MethodImpl] get; }

    public extern double VerticalViewSize { [MethodImpl] get; }

    [MethodImpl]
    public extern void Scroll(ScrollAmount horizontalAmount, ScrollAmount verticalAmount);

    [MethodImpl]
    public extern void SetScrollPercent(double horizontalPercent, double verticalPercent);

    public extern bool CanSelectMultiple { [MethodImpl] get; }

    public extern bool IsSelectionRequired { [MethodImpl] get; }

    [MethodImpl]
    public extern IRawElementProviderSimple[] GetSelection();
  }
}
