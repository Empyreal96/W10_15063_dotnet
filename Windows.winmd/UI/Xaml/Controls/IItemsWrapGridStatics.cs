// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsWrapGridStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1321550461, 9376, 17562, 183, 99, 48, 119, 186, 15, 45, 213)]
  [ExclusiveTo(typeof (ItemsWrapGrid))]
  [WebHostHidden]
  internal interface IItemsWrapGridStatics
  {
    DependencyProperty GroupPaddingProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty MaximumRowsOrColumnsProperty { get; }

    DependencyProperty ItemWidthProperty { get; }

    DependencyProperty ItemHeightProperty { get; }

    DependencyProperty GroupHeaderPlacementProperty { get; }

    DependencyProperty CacheLengthProperty { get; }
  }
}
