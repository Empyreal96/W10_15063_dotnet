// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IMediaPlayerElementAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(142901367, 33455, 19737, 177, 112, 40, 42, 158, 14, 127, 55)]
  [ExclusiveTo(typeof (MediaPlayerElementAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaPlayerElementAutomationPeerFactory
  {
    MediaPlayerElementAutomationPeer CreateInstanceWithOwner(
      MediaPlayerElement owner,
      object outer,
      out object inner);
  }
}
