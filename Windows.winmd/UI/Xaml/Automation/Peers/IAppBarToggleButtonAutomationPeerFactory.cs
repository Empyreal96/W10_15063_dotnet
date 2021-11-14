// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAppBarToggleButtonAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (AppBarToggleButtonAutomationPeer))]
  [Guid(3606647709, 705, 16929, 149, 145, 125, 78, 254, 183, 71, 1)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarToggleButtonAutomationPeerFactory
  {
    AppBarToggleButtonAutomationPeer CreateInstanceWithOwner(
      AppBarToggleButton owner,
      object outer,
      out object inner);
  }
}
