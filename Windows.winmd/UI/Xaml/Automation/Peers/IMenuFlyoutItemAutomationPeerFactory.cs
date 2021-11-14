// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IMenuFlyoutItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (MenuFlyoutItemAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3498835128, 8401, 17880, 162, 194, 47, 19, 13, 247, 20, 224)]
  [WebHostHidden]
  internal interface IMenuFlyoutItemAutomationPeerFactory
  {
    MenuFlyoutItemAutomationPeer CreateInstanceWithOwner(
      MenuFlyoutItem owner,
      object outer,
      out object inner);
  }
}
