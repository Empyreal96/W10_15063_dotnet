// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListViewItemDataAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(3504018107, 55061, 17699, 172, 192, 30, 16, 114, 216, 227, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListViewItemDataAutomationPeer))]
  [WebHostHidden]
  internal interface IListViewItemDataAutomationPeerFactory
  {
    ListViewItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      ListViewBaseAutomationPeer parent,
      object outer,
      out object inner);
  }
}
