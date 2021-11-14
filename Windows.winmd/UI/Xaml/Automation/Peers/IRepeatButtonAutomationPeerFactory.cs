// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRepeatButtonAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RepeatButtonAutomationPeer))]
  [WebHostHidden]
  [Guid(1785723348, 22366, 20064, 189, 214, 236, 20, 65, 155, 79, 246)]
  internal interface IRepeatButtonAutomationPeerFactory
  {
    RepeatButtonAutomationPeer CreateInstanceWithOwner(
      RepeatButton owner,
      object outer,
      out object inner);
  }
}
