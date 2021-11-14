// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISemanticZoomAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SemanticZoomAutomationPeer))]
  [Guid(4112045133, 42131, 17558, 176, 119, 150, 116, 199, 244, 197, 250)]
  [WebHostHidden]
  internal interface ISemanticZoomAutomationPeerFactory
  {
    SemanticZoomAutomationPeer CreateInstanceWithOwner(
      SemanticZoom owner,
      object outer,
      out object inner);
  }
}
