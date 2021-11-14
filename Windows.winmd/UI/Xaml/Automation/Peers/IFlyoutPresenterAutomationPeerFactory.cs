// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFlyoutPresenterAutomationPeerFactory
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
  [ExclusiveTo(typeof (FlyoutPresenterAutomationPeer))]
  [Guid(4082111839, 35108, 17600, 186, 68, 101, 63, 231, 159, 30, 251)]
  internal interface IFlyoutPresenterAutomationPeerFactory
  {
    FlyoutPresenterAutomationPeer CreateInstanceWithOwner(
      FlyoutPresenter owner,
      object outer,
      out object inner);
  }
}
