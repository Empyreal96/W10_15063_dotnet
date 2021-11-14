// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFlipViewItemDataAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FlipViewItemDataAutomationPeer))]
  [WebHostHidden]
  [Guid(1015432083, 2794, 20088, 188, 17, 183, 117, 202, 196, 17, 76)]
  internal interface IFlipViewItemDataAutomationPeerFactory
  {
    FlipViewItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      FlipViewAutomationPeer parent,
      object outer,
      out object inner);
  }
}
