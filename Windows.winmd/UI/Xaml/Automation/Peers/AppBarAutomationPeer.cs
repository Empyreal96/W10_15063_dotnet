// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.AppBarAutomationPeer
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IAppBarAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class AppBarAutomationPeer : 
    FrameworkElementAutomationPeer,
    IAppBarAutomationPeer,
    IToggleProvider,
    IExpandCollapseProvider,
    IWindowProvider
  {
    [MethodImpl]
    public extern AppBarAutomationPeer(AppBar owner);

    public extern ToggleState ToggleState { [MethodImpl] get; }

    [MethodImpl]
    public extern void Toggle();

    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    [MethodImpl]
    public extern void Collapse();

    [MethodImpl]
    public extern void Expand();

    public extern bool IsModal { [MethodImpl] get; }

    public extern bool IsTopmost { [MethodImpl] get; }

    public extern bool Maximizable { [MethodImpl] get; }

    public extern bool Minimizable { [MethodImpl] get; }

    public extern WindowInteractionState InteractionState { [MethodImpl] get; }

    public extern WindowVisualState VisualState { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public extern void SetVisualState(WindowVisualState state);

    [MethodImpl]
    public extern bool WaitForInputIdle(int milliseconds);
  }
}
