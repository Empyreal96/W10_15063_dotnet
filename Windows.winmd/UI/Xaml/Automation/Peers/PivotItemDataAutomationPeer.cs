// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.PivotItemDataAutomationPeer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPivotItemDataAutomationPeerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class PivotItemDataAutomationPeer : 
    ItemAutomationPeer,
    IPivotItemDataAutomationPeer,
    IScrollItemProvider,
    ISelectionItemProvider,
    IVirtualizedItemProvider
  {
    [MethodImpl]
    public extern PivotItemDataAutomationPeer(object item, PivotAutomationPeer parent);

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

    [MethodImpl]
    public new extern void Realize();
  }
}
