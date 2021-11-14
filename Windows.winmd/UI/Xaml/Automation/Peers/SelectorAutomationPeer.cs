// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.SelectorAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ISelectorAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class SelectorAutomationPeer : 
    ItemsControlAutomationPeer,
    ISelectorAutomationPeer,
    ISelectionProvider
  {
    [MethodImpl]
    public extern SelectorAutomationPeer(Selector owner);

    public extern bool CanSelectMultiple { [MethodImpl] get; }

    public extern bool IsSelectionRequired { [MethodImpl] get; }

    [MethodImpl]
    public extern IRawElementProviderSimple[] GetSelection();
  }
}
