// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListBoxAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(3795198341, 32246, 18935, 138, 188, 76, 51, 241, 163, 212, 110)]
  [ExclusiveTo(typeof (ListBoxAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IListBoxAutomationPeerFactory
  {
    ListBoxAutomationPeer CreateInstanceWithOwner(
      ListBox owner,
      object outer,
      out object inner);
  }
}
