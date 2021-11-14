// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.RadioButtonAutomationPeer
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Composable(typeof (IRadioButtonAutomationPeerFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class RadioButtonAutomationPeer : 
    ToggleButtonAutomationPeer,
    IRadioButtonAutomationPeer,
    ISelectionItemProvider
  {
    [MethodImpl]
    public extern RadioButtonAutomationPeer(RadioButton owner);

    public extern bool IsSelected { [MethodImpl] get; }

    public extern IRawElementProviderSimple SelectionContainer { [MethodImpl] get; }

    [MethodImpl]
    public extern void AddToSelection();

    [MethodImpl]
    public extern void RemoveFromSelection();

    [MethodImpl]
    public extern void Select();
  }
}
