// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ItemAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IItemAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class ItemAutomationPeer : AutomationPeer, IItemAutomationPeer, IVirtualizedItemProvider
  {
    [MethodImpl]
    public extern ItemAutomationPeer(object item, ItemsControlAutomationPeer parent);

    public extern object Item { [MethodImpl] get; }

    public extern ItemsControlAutomationPeer ItemsControlAutomationPeer { [MethodImpl] get; }

    [MethodImpl]
    public extern void Realize();
  }
}
