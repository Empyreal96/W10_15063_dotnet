// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISelectorItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(1725427195, 30829, 17250, 169, 100, 235, 251, 33, 119, 108, 48)]
  [ExclusiveTo(typeof (SelectorItemAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISelectorItemAutomationPeerFactory
  {
    SelectorItemAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      SelectorAutomationPeer parent,
      object outer,
      out object inner);
  }
}
