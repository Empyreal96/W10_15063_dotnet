// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ListViewItemDataAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Composable(typeof (IListViewItemDataAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class ListViewItemDataAutomationPeer : 
    SelectorItemAutomationPeer,
    IListViewItemDataAutomationPeer,
    IScrollItemProvider
  {
    [MethodImpl]
    public extern ListViewItemDataAutomationPeer(object item, ListViewBaseAutomationPeer parent);

    [MethodImpl]
    public extern void ScrollIntoView();
  }
}
