// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IGridViewHeaderItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(746632402, 65474, 16727, 136, 221, 89, 205, 146, 227, 151, 21)]
  [ExclusiveTo(typeof (GridViewHeaderItemAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridViewHeaderItemAutomationPeerFactory
  {
    GridViewHeaderItemAutomationPeer CreateInstanceWithOwner(
      GridViewHeaderItem owner,
      object outer,
      out object inner);
  }
}
