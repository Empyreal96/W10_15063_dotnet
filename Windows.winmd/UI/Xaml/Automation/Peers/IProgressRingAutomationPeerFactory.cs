// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IProgressRingAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4091224139, 5502, 16572, 149, 147, 85, 188, 92, 113, 164, 246)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ProgressRingAutomationPeer))]
  internal interface IProgressRingAutomationPeerFactory
  {
    ProgressRingAutomationPeer CreateInstanceWithOwner(
      ProgressRing owner,
      object outer,
      out object inner);
  }
}
