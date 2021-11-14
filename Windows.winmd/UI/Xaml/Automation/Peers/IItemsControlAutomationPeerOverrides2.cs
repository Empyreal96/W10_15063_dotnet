// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IItemsControlAutomationPeerOverrides2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemsControlAutomationPeer))]
  [Guid(907919592, 46447, 17897, 128, 254, 16, 160, 251, 15, 225, 119)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IItemsControlAutomationPeerOverrides2
  {
    ItemAutomationPeer OnCreateItemAutomationPeer(object item);
  }
}
