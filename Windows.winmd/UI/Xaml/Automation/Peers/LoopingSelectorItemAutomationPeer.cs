// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.LoopingSelectorItemAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LoopingSelectorItemAutomationPeer : 
    FrameworkElementAutomationPeer,
    ILoopingSelectorItemAutomationPeer,
    IScrollItemProvider,
    ISelectionItemProvider
  {
    [MethodImpl]
    public extern void ScrollIntoView();

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
