// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IFrameworkElementAutomationPeerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Composable(typeof (IFrameworkElementAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class FrameworkElementAutomationPeer : AutomationPeer, IFrameworkElementAutomationPeer
  {
    [MethodImpl]
    public extern FrameworkElementAutomationPeer(FrameworkElement owner);

    public extern UIElement Owner { [MethodImpl] get; }

    [MethodImpl]
    public static extern AutomationPeer FromElement(UIElement element);

    [MethodImpl]
    public static extern AutomationPeer CreatePeerForElement(UIElement element);
  }
}
