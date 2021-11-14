// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ISearchBoxAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (SearchBoxAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3015709744, 32682, 16827, 142, 145, 124, 118, 28, 82, 103, 241)]
  internal interface ISearchBoxAutomationPeerFactory
  {
    SearchBoxAutomationPeer CreateInstanceWithOwner(
      SearchBox owner,
      object outer,
      out object inner);
  }
}
