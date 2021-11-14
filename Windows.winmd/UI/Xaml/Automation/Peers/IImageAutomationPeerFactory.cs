// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IImageAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (ImageAutomationPeer))]
  [Guid(2419081219, 26749, 18367, 179, 162, 75, 171, 202, 216, 239, 80)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IImageAutomationPeerFactory
  {
    ImageAutomationPeer CreateInstanceWithOwner(
      Image owner,
      object outer,
      out object inner);
  }
}
