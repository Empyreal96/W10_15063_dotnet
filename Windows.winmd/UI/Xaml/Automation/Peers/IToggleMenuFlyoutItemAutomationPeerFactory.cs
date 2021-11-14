// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IToggleMenuFlyoutItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2486586231, 36716, 18487, 170, 227, 148, 208, 16, 216, 209, 98)]
  [ExclusiveTo(typeof (ToggleMenuFlyoutItemAutomationPeer))]
  internal interface IToggleMenuFlyoutItemAutomationPeerFactory
  {
    ToggleMenuFlyoutItemAutomationPeer CreateInstanceWithOwner(
      ToggleMenuFlyoutItem owner,
      object outer,
      out object inner);
  }
}
