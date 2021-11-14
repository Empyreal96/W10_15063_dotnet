// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IRichEditBoxAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (RichEditBoxAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1965851545, 53910, 19847, 144, 32, 164, 117, 14, 136, 91, 60)]
  internal interface IRichEditBoxAutomationPeerFactory
  {
    RichEditBoxAutomationPeer CreateInstanceWithOwner(
      RichEditBox owner,
      object outer,
      out object inner);
  }
}
