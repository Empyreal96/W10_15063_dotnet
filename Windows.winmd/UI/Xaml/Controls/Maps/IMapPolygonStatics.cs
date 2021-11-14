// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapPolygonStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapPolygon))]
  [Guid(938832830, 2427, 16972, 135, 204, 46, 224, 66, 253, 166, 210)]
  [WebHostHidden]
  internal interface IMapPolygonStatics
  {
    DependencyProperty PathProperty { get; }

    DependencyProperty StrokeThicknessProperty { get; }

    DependencyProperty StrokeDashedProperty { get; }
  }
}
