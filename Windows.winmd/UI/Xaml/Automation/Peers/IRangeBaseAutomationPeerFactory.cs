// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRangeBaseAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(2189194753, 12408, 17529, 149, 234, 145, 55, 76, 160, 98, 7)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (RangeBaseAutomationPeer))]
  internal interface IRangeBaseAutomationPeerFactory
  {
    RangeBaseAutomationPeer CreateInstanceWithOwner(
      RangeBase owner,
      object outer,
      out object inner);
  }
}
