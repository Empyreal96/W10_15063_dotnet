// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IFrameworkElementAutomationPeerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameworkElementAutomationPeer))]
  [Guid(3116415383, 10272, 17569, 165, 168, 155, 128, 30, 220, 38, 158)]
  internal interface IFrameworkElementAutomationPeerStatics
  {
    AutomationPeer FromElement(UIElement element);

    AutomationPeer CreatePeerForElement(UIElement element);
  }
}
