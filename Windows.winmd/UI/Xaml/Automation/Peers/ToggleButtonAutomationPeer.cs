// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ToggleButtonAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Composable(typeof (IToggleButtonAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class ToggleButtonAutomationPeer : 
    ButtonBaseAutomationPeer,
    IToggleButtonAutomationPeer,
    IToggleProvider
  {
    [MethodImpl]
    public extern ToggleButtonAutomationPeer(ToggleButton owner);

    public extern ToggleState ToggleState { [MethodImpl] get; }

    [MethodImpl]
    public extern void Toggle();
  }
}
