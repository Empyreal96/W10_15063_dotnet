// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3296590784, 64204, 16420, 167, 59, 23, 236, 78, 102, 38, 84)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ListViewItemAutomationPeer))]
  internal interface IListViewItemAutomationPeerFactory
  {
    ListViewItemAutomationPeer CreateInstanceWithOwner(
      ListViewItem owner,
      object outer,
      out object inner);
  }
}
