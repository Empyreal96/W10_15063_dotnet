// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.FlyoutPresenterAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Composable(typeof (IFlyoutPresenterAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class FlyoutPresenterAutomationPeer : 
    FrameworkElementAutomationPeer,
    IFlyoutPresenterAutomationPeer
  {
    [MethodImpl]
    public extern FlyoutPresenterAutomationPeer(FlyoutPresenter owner);
  }
}
