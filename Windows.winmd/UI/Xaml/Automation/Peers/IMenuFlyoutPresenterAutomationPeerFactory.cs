// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IMenuFlyoutPresenterAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MenuFlyoutPresenterAutomationPeer))]
  [Guid(129308461, 30237, 17707, 158, 109, 250, 42, 139, 224, 173, 38)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMenuFlyoutPresenterAutomationPeerFactory
  {
    MenuFlyoutPresenterAutomationPeer CreateInstanceWithOwner(
      MenuFlyoutPresenter owner,
      object outer,
      out object inner);
  }
}
