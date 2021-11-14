// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWrapGridStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WrapGrid))]
  [Guid(3494538135, 5067, 18332, 162, 133, 228, 229, 104, 70, 196, 203)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWrapGridStatics
  {
    DependencyProperty ItemWidthProperty { get; }

    DependencyProperty ItemHeightProperty { get; }

    DependencyProperty OrientationProperty { get; }

    DependencyProperty HorizontalChildrenAlignmentProperty { get; }

    DependencyProperty VerticalChildrenAlignmentProperty { get; }

    DependencyProperty MaximumRowsOrColumnsProperty { get; }
  }
}
