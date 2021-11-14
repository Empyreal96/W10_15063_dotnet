// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IPivotItemAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ExclusiveTo(typeof (PivotItemAutomationPeer))]
  [Guid(4068541553, 6207, 16747, 180, 26, 30, 90, 149, 138, 145, 244)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPivotItemAutomationPeerFactory
  {
    PivotItemAutomationPeer CreateInstanceWithOwner(PivotItem owner);
  }
}
