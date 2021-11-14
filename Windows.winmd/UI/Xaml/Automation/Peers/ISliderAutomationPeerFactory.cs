// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISliderAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2535161942, 39546, 19961, 149, 250, 111, 92, 4, 201, 28, 172)]
  [ExclusiveTo(typeof (SliderAutomationPeer))]
  [WebHostHidden]
  internal interface ISliderAutomationPeerFactory
  {
    SliderAutomationPeer CreateInstanceWithOwner(
      Slider owner,
      object outer,
      out object inner);
  }
}
