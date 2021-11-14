// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IItemsControlAutomationPeerFactory
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
  [Guid(1077453401, 11802, 18890, 165, 51, 198, 79, 24, 21, 119, 230)]
  [ExclusiveTo(typeof (ItemsControlAutomationPeer))]
  internal interface IItemsControlAutomationPeerFactory
  {
    ItemsControlAutomationPeer CreateInstanceWithOwner(
      ItemsControl owner,
      object outer,
      out object inner);
  }
}
