// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewBaseHeaderItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewBaseHeaderItemAutomationPeer))]
  [Guid(1089247583, 54833, 16388, 131, 46, 109, 134, 67, 229, 21, 97)]
  internal interface IListViewBaseHeaderItemAutomationPeerFactory
  {
    ListViewBaseHeaderItemAutomationPeer CreateInstanceWithOwner(
      ListViewBaseHeaderItem owner,
      object outer,
      out object inner);
  }
}
