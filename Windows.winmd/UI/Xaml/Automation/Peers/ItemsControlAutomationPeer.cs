// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ItemsControlAutomationPeer
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
  [Composable(typeof (IItemsControlAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class ItemsControlAutomationPeer : 
    FrameworkElementAutomationPeer,
    IItemsControlAutomationPeer,
    IItemContainerProvider,
    IItemsControlAutomationPeer2,
    IItemsControlAutomationPeerOverrides2
  {
    [MethodImpl]
    public extern ItemsControlAutomationPeer(ItemsControl owner);

    [MethodImpl]
    public extern IRawElementProviderSimple FindItemByProperty(
      IRawElementProviderSimple startAfter,
      AutomationProperty automationProperty,
      object value);

    [MethodImpl]
    public extern ItemAutomationPeer CreateItemAutomationPeer(object item);

    [MethodImpl]
    extern ItemAutomationPeer IItemsControlAutomationPeerOverrides2.OnCreateItemAutomationPeer(
      object item);
  }
}
