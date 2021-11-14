// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.VirtualizingPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Composable(typeof (IVirtualizingPanelFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class VirtualizingPanel : 
    Panel,
    IVirtualizingPanel,
    IVirtualizingPanelOverrides,
    IVirtualizingPanelProtected
  {
    public extern ItemContainerGenerator ItemContainerGenerator { [MethodImpl] get; }

    [MethodImpl]
    extern void IVirtualizingPanelOverrides.OnItemsChanged(
      object sender,
      ItemsChangedEventArgs args);

    [MethodImpl]
    extern void IVirtualizingPanelOverrides.OnClearChildren();

    [MethodImpl]
    extern void IVirtualizingPanelOverrides.BringIndexIntoView(int index);

    [MethodImpl]
    extern void IVirtualizingPanelProtected.AddInternalChild(
      UIElement child);

    [MethodImpl]
    extern void IVirtualizingPanelProtected.InsertInternalChild(
      int index,
      UIElement child);

    [MethodImpl]
    extern void IVirtualizingPanelProtected.RemoveInternalChildRange(
      int index,
      int range);
  }
}
