// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.PivotAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Activatable(typeof (IPivotAutomationPeerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class PivotAutomationPeer : 
    ItemsControlAutomationPeer,
    IPivotAutomationPeer,
    IScrollProvider,
    ISelectionProvider
  {
    [MethodImpl]
    public extern PivotAutomationPeer(Pivot owner);

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
