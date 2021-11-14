// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IGridViewAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (GridViewAutomationPeer))]
  [WebHostHidden]
  [Guid(2328517085, 8871, 18432, 137, 75, 193, 244, 133, 243, 137, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGridViewAutomationPeerFactory
  {
    GridViewAutomationPeer CreateInstanceWithOwner(
      GridView owner,
      object outer,
      out object inner);
  }
}
