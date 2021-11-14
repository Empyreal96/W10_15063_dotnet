// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.HyperlinkButtonAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IHyperlinkButtonAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class HyperlinkButtonAutomationPeer : 
    ButtonBaseAutomationPeer,
    IHyperlinkButtonAutomationPeer,
    IInvokeProvider
  {
    [MethodImpl]
    public extern HyperlinkButtonAutomationPeer(HyperlinkButton owner);

    [MethodImpl]
    public extern void Invoke();
  }
}
