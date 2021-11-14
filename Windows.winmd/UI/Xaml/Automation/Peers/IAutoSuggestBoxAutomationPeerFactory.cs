// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IAutoSuggestBoxAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2147772489, 6375, 17525, 179, 98, 75, 189, 83, 210, 69, 98)]
  [ExclusiveTo(typeof (AutoSuggestBoxAutomationPeer))]
  internal interface IAutoSuggestBoxAutomationPeerFactory
  {
    AutoSuggestBoxAutomationPeer CreateInstanceWithOwner(
      AutoSuggestBox owner);
  }
}
