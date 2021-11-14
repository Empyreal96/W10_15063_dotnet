// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IItemsControlAutomationPeer2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemsControlAutomationPeer))]
  [Guid(3297610007, 38312, 18360, 165, 23, 191, 137, 26, 108, 3, 155)]
  internal interface IItemsControlAutomationPeer2
  {
    ItemAutomationPeer CreateItemAutomationPeer(object item);
  }
}
