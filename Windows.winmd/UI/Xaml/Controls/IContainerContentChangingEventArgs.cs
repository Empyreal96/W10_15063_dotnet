// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IContainerContentChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (ContainerContentChangingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(132049575, 399, 19930, 179, 153, 253, 78, 19, 163, 27, 234)]
  [WebHostHidden]
  internal interface IContainerContentChangingEventArgs
  {
    SelectorItem ItemContainer { get; }

    bool InRecycleQueue { get; }

    int ItemIndex { get; }

    object Item { get; }

    uint Phase { get; }

    bool Handled { get; set; }

    [Overload("RegisterUpdateCallback")]
    void RegisterUpdateCallback(
      TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);

    [Overload("RegisterUpdateCallbackWithPhase")]
    void RegisterUpdateCallback(
      uint callbackPhase,
      TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);
  }
}
