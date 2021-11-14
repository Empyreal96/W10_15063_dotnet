// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IThumbAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ThumbAutomationPeer))]
  [WebHostHidden]
  [Guid(2533835775, 44865, 17920, 181, 93, 38, 212, 61, 248, 96, 225)]
  internal interface IThumbAutomationPeerFactory
  {
    ThumbAutomationPeer CreateInstanceWithOwner(
      Thumb owner,
      object outer,
      out object inner);
  }
}
