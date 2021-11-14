// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ItemContainerGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ItemContainerGenerator : IItemContainerGenerator
  {
    public extern event ItemsChangedEventHandler ItemsChanged;

    [Deprecated("ItemFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ItemFromContainer.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern object ItemFromContainer(DependencyObject container);

    [Deprecated("ContainerFromItem may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromItem.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern DependencyObject ContainerFromItem(object item);

    [Deprecated("IndexFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.IndexFromContainer.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern int IndexFromContainer(DependencyObject container);

    [Deprecated("ContainerFromIndex may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromIndex.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    [MethodImpl]
    public extern DependencyObject ContainerFromIndex(int index);

    [MethodImpl]
    public extern ItemContainerGenerator GetItemContainerGeneratorForPanel(
      Panel panel);

    [MethodImpl]
    public extern void StartAt(
      GeneratorPosition position,
      GeneratorDirection direction,
      bool allowStartAtRealizedItem);

    [MethodImpl]
    public extern void Stop();

    [MethodImpl]
    public extern DependencyObject GenerateNext(out bool isNewlyRealized);

    [MethodImpl]
    public extern void PrepareItemContainer(DependencyObject container);

    [MethodImpl]
    public extern void RemoveAll();

    [MethodImpl]
    public extern void Remove(GeneratorPosition position, int count);

    [MethodImpl]
    public extern GeneratorPosition GeneratorPositionFromIndex(int itemIndex);

    [MethodImpl]
    public extern int IndexFromGeneratorPosition(GeneratorPosition position);

    [MethodImpl]
    public extern void Recycle(GeneratorPosition position, int count);
  }
}
