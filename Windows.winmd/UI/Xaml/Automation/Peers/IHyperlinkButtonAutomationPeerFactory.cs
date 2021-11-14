// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IHyperlinkButtonAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(1505498721, 49538, 18863, 149, 38, 68, 184, 142, 98, 132, 85)]
  [ExclusiveTo(typeof (HyperlinkButtonAutomationPeer))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHyperlinkButtonAutomationPeerFactory
  {
    HyperlinkButtonAutomationPeer CreateInstanceWithOwner(
      HyperlinkButton owner,
      object outer,
      out object inner);
  }
}
