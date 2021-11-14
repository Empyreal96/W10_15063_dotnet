// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewBaseAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewBaseAutomationPeer))]
  [Guid(1892926142, 35152, 17991, 147, 98, 253, 0, 47, 143, 248, 46)]
  [WebHostHidden]
  internal interface IListViewBaseAutomationPeerFactory
  {
    ListViewBaseAutomationPeer CreateInstanceWithOwner(
      ListViewBase owner,
      object outer,
      out object inner);
  }
}
