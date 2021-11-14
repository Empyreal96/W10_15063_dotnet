// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IScrollViewerAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(655228797, 55661, 18681, 163, 106, 194, 82, 170, 156, 70, 112)]
  [ExclusiveTo(typeof (ScrollViewerAutomationPeer))]
  internal interface IScrollViewerAutomationPeerFactory
  {
    ScrollViewerAutomationPeer CreateInstanceWithOwner(
      ScrollViewer owner,
      object outer,
      out object inner);
  }
}
