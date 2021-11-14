// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewHeaderItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(124159636, 11429, 19428, 168, 185, 89, 45, 72, 247, 96, 135)]
  [ExclusiveTo(typeof (ListViewHeaderItemAutomationPeer))]
  [WebHostHidden]
  internal interface IListViewHeaderItemAutomationPeerFactory
  {
    ListViewHeaderItemAutomationPeer CreateInstanceWithOwner(
      ListViewHeaderItem owner,
      object outer,
      out object inner);
  }
}
