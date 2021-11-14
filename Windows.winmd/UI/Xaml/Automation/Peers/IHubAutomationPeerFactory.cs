// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IHubAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3345142847, 31197, 17390, 135, 119, 141, 8, 179, 154, 160, 101)]
  [ExclusiveTo(typeof (HubAutomationPeer))]
  [WebHostHidden]
  internal interface IHubAutomationPeerFactory
  {
    HubAutomationPeer CreateInstanceWithOwner(
      Hub owner,
      object outer,
      out object inner);
  }
}
