// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.MediaPlayerElementAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Composable(typeof (IMediaPlayerElementAutomationPeerFactory), CompositionType.Public, 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class MediaPlayerElementAutomationPeer : 
    FrameworkElementAutomationPeer,
    IMediaPlayerElementAutomationPeer
  {
    [MethodImpl]
    public extern MediaPlayerElementAutomationPeer(MediaPlayerElement owner);
  }
}
