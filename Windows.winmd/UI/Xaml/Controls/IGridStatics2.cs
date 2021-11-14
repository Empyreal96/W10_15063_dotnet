// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGridStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Grid))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(761685592, 22710, 18971, 132, 27, 135, 91, 169, 59, 93, 106)]
  internal interface IGridStatics2
  {
    DependencyProperty BorderBrushProperty { get; }

    DependencyProperty BorderThicknessProperty { get; }

    DependencyProperty CornerRadiusProperty { get; }

    DependencyProperty PaddingProperty { get; }
  }
}
