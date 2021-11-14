// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ComboBoxAutomationPeer
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
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (IComboBoxAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class ComboBoxAutomationPeer : 
    SelectorAutomationPeer,
    IComboBoxAutomationPeer,
    IExpandCollapseProvider,
    IValueProvider,
    IWindowProvider
  {
    [MethodImpl]
    public extern ComboBoxAutomationPeer(ComboBox owner);

    public extern ExpandCollapseState ExpandCollapseState { [MethodImpl] get; }

    [MethodImpl]
    public extern void Collapse();

    [MethodImpl]
    public extern void Expand();

    public extern bool IsReadOnly { [MethodImpl] get; }

    public extern string Value { [MethodImpl] get; }

    [MethodImpl]
    public extern void SetValue(string value);

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
