// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IGridViewItemDataAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2791209608, 30477, 16428, 153, 111, 103, 80, 106, 242, 164, 175)]
  [ExclusiveTo(typeof (GridViewItemDataAutomationPeer))]
  [WebHostHidden]
  internal interface IGridViewItemDataAutomationPeerFactory
  {
    GridViewItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      GridViewAutomationPeer parent,
      object outer,
      out object inner);
  }
}
