// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAppBarButtonAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(2934977578, 44215, 17116, 151, 227, 132, 112, 113, 134, 95, 214)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (AppBarButtonAutomationPeer))]
  internal interface IAppBarButtonAutomationPeerFactory
  {
    AppBarButtonAutomationPeer CreateInstanceWithOwner(
      AppBarButton owner,
      object outer,
      out object inner);
  }
}
