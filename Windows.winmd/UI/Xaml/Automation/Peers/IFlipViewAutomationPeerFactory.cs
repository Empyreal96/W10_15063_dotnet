// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFlipViewAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1133882125, 36227, 18492, 136, 235, 226, 97, 123, 13, 41, 63)]
  [ExclusiveTo(typeof (FlipViewAutomationPeer))]
  [WebHostHidden]
  internal interface IFlipViewAutomationPeerFactory
  {
    FlipViewAutomationPeer CreateInstanceWithOwner(
      FlipView owner,
      object outer,
      out object inner);
  }
}
