// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class ContainerContentChangingEventArgs : IContainerContentChangingEventArgs
  {
    [MethodImpl]
    public extern ContainerContentChangingEventArgs();

    public extern SelectorItem ItemContainer { [MethodImpl] get; }

    public extern bool InRecycleQueue { [MethodImpl] get; }

    public extern int ItemIndex { [MethodImpl] get; }

    public extern object Item { [MethodImpl] get; }

    public extern uint Phase { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    [Overload("RegisterUpdateCallback")]
    [MethodImpl]
    public extern void RegisterUpdateCallback(
      TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);

    [Overload("RegisterUpdateCallbackWithPhase")]
    [MethodImpl]
    public extern void RegisterUpdateCallback(
      uint callbackPhase,
      TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);
  }
}
