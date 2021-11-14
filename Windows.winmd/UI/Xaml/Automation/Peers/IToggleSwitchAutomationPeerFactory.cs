// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IToggleSwitchAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (ToggleSwitchAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(838415331, 65272, 17433, 157, 245, 217, 239, 113, 150, 234, 52)]
  internal interface IToggleSwitchAutomationPeerFactory
  {
    ToggleSwitchAutomationPeer CreateInstanceWithOwner(
      ToggleSwitch owner,
      object outer,
      out object inner);
  }
}
