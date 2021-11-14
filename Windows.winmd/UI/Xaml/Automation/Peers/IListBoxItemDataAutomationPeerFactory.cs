// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListBoxItemDataAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListBoxItemDataAutomationPeer))]
  [Guid(3616689686, 48525, 18018, 169, 149, 32, 255, 154, 5, 96, 147)]
  [WebHostHidden]
  internal interface IListBoxItemDataAutomationPeerFactory
  {
    ListBoxItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      ListBoxAutomationPeer parent,
      object outer,
      out object inner);
  }
}
