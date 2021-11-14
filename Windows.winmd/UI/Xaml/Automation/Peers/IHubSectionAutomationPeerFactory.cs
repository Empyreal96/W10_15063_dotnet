// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IHubSectionAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HubSectionAutomationPeer))]
  [Guid(3331205096, 6124, 17193, 145, 174, 45, 11, 35, 57, 212, 152)]
  [WebHostHidden]
  internal interface IHubSectionAutomationPeerFactory
  {
    HubSectionAutomationPeer CreateInstanceWithOwner(
      HubSection owner,
      object outer,
      out object inner);
  }
}
