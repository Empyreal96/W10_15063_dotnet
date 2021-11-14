// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPolygon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Polygon))]
  [Guid(3816119321, 11853, 19404, 141, 52, 134, 135, 25, 87, 250, 1)]
  [WebHostHidden]
  internal interface IPolygon
  {
    FillRule FillRule { get; set; }

    PointCollection Points { get; set; }
  }
}
