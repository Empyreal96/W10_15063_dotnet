// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFrameworkElementAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (FrameworkElementAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(230275260, 47122, 18659, 175, 31, 219, 197, 118, 0, 195, 37)]
  [WebHostHidden]
  internal interface IFrameworkElementAutomationPeerFactory
  {
    FrameworkElementAutomationPeer CreateInstanceWithOwner(
      FrameworkElement owner,
      object outer,
      out object inner);
  }
}
