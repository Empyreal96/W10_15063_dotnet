// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISelectorAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (SelectorAutomationPeer))]
  [Guid(2068993606, 33435, 19916, 189, 82, 90, 141, 3, 153, 56, 122)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISelectorAutomationPeerFactory
  {
    SelectorAutomationPeer CreateInstanceWithOwner(
      Selector owner,
      object outer,
      out object inner);
  }
}
