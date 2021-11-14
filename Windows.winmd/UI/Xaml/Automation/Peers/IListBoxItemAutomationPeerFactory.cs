// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IListBoxItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ListBoxItemAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1352637912, 45226, 17471, 161, 16, 65, 32, 154, 244, 79, 28)]
  internal interface IListBoxItemAutomationPeerFactory
  {
    ListBoxItemAutomationPeer CreateInstanceWithOwner(
      ListBoxItem owner,
      object outer,
      out object inner);
  }
}
