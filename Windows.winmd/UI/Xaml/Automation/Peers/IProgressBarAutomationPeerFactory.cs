// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IProgressBarAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ExclusiveTo(typeof (ProgressBarAutomationPeer))]
  [Guid(910588331, 47119, 16820, 142, 234, 47, 82, 81, 188, 115, 156)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IProgressBarAutomationPeerFactory
  {
    ProgressBarAutomationPeer CreateInstanceWithOwner(
      ProgressBar owner,
      object outer,
      out object inner);
  }
}
