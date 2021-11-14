// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IScrollBarAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3778027792, 45035, 17813, 142, 61, 237, 192, 132, 74, 43, 33)]
  [ExclusiveTo(typeof (ScrollBarAutomationPeer))]
  internal interface IScrollBarAutomationPeerFactory
  {
    ScrollBarAutomationPeer CreateInstanceWithOwner(
      ScrollBar owner,
      object outer,
      out object inner);
  }
}
