// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ICaptureElementAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CaptureElementAutomationPeer))]
  [Guid(2610097992, 34281, 18537, 177, 117, 143, 124, 244, 90, 109, 159)]
  internal interface ICaptureElementAutomationPeerFactory
  {
    CaptureElementAutomationPeer CreateInstanceWithOwner(
      CaptureElement owner,
      object outer,
      out object inner);
  }
}
