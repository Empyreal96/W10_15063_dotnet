// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IMediaTransportControlsAutomationPeerFactory
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
  [Guid(4095520771, 57603, 19120, 129, 42, 160, 143, 189, 181, 112, 206)]
  [ExclusiveTo(typeof (MediaTransportControlsAutomationPeer))]
  internal interface IMediaTransportControlsAutomationPeerFactory
  {
    MediaTransportControlsAutomationPeer CreateInstanceWithOwner(
      MediaTransportControls owner,
      object outer,
      out object inner);
  }
}
