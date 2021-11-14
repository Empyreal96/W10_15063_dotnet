// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ItemAutomationPeer))]
  [WebHostHidden]
  [Guid(688279667, 56893, 19775, 151, 180, 77, 111, 157, 83, 68, 77)]
  internal interface IItemAutomationPeerFactory
  {
    ItemAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      ItemsControlAutomationPeer parent,
      object outer,
      out object inner);
  }
}
