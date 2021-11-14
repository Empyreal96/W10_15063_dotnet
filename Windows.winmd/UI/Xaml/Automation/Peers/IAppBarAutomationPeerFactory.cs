// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAppBarAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2204169442, 58262, 17687, 175, 93, 244, 207, 52, 197, 78, 223)]
  [ExclusiveTo(typeof (AppBarAutomationPeer))]
  [WebHostHidden]
  internal interface IAppBarAutomationPeerFactory
  {
    AppBarAutomationPeer CreateInstanceWithOwner(
      AppBar owner,
      object outer,
      out object inner);
  }
}
