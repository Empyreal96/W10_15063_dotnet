// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IToggleButtonAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(3374419140, 44363, 19715, 166, 164, 125, 89, 230, 54, 0, 4)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ToggleButtonAutomationPeer))]
  internal interface IToggleButtonAutomationPeerFactory
  {
    ToggleButtonAutomationPeer CreateInstanceWithOwner(
      ToggleButton owner,
      object outer,
      out object inner);
  }
}
