// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IPivotAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [Guid(1056837524, 3217, 17217, 185, 172, 27, 86, 180, 230, 184, 79)]
  [ExclusiveTo(typeof (PivotAutomationPeer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPivotAutomationPeerFactory
  {
    PivotAutomationPeer CreateInstanceWithOwner(Pivot owner);
  }
}
