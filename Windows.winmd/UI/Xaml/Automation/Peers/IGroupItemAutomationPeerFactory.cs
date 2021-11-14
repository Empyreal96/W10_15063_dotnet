// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IGroupItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (GroupItemAutomationPeer))]
  [Guid(1453737319, 61980, 19600, 179, 121, 21, 162, 124, 127, 132, 9)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGroupItemAutomationPeerFactory
  {
    GroupItemAutomationPeer CreateInstanceWithOwner(
      GroupItem owner,
      object outer,
      out object inner);
  }
}
