// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IMediaElementAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (MediaElementAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2997697320, 30069, 16755, 155, 199, 128, 54, 122, 22, 78, 210)]
  internal interface IMediaElementAutomationPeerFactory
  {
    MediaElementAutomationPeer CreateInstanceWithOwner(
      MediaElement owner,
      object outer,
      out object inner);
  }
}
