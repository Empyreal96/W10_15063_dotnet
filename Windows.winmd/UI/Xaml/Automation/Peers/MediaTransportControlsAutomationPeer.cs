// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.MediaTransportControlsAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IMediaTransportControlsAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class MediaTransportControlsAutomationPeer : 
    FrameworkElementAutomationPeer,
    IMediaTransportControlsAutomationPeer
  {
    [MethodImpl]
    public extern MediaTransportControlsAutomationPeer(MediaTransportControls owner);
  }
}
