// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemContainerGenerator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1081499392, 33776, 19839, 177, 184, 241, 157, 228, 241, 213, 218)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemContainerGenerator))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IItemContainerGenerator
  {
    event ItemsChangedEventHandler ItemsChanged;

    [Deprecated("ItemFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ItemFromContainer.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    object ItemFromContainer(DependencyObject container);

    [Deprecated("ContainerFromItem may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromItem.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    DependencyObject ContainerFromItem(object item);

    [Deprecated("IndexFromContainer may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.IndexFromContainer.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    int IndexFromContainer(DependencyObject container);

    [Deprecated("ContainerFromIndex may be altered or unavailable for releases after Windows 8.1. Instead, use ItemsControl.ContainerFromIndex.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")]
    DependencyObject ContainerFromIndex(int index);

    ItemContainerGenerator GetItemContainerGeneratorForPanel(Panel panel);

    void StartAt(
      GeneratorPosition position,
      GeneratorDirection direction,
      bool allowStartAtRealizedItem);

    void Stop();

    DependencyObject GenerateNext(out bool isNewlyRealized);

    void PrepareItemContainer(DependencyObject container);

    void RemoveAll();

    void Remove(GeneratorPosition position, int count);

    GeneratorPosition GeneratorPositionFromIndex(int itemIndex);

    int IndexFromGeneratorPosition(GeneratorPosition position);

    void Recycle(GeneratorPosition position, int count);
  }
}
