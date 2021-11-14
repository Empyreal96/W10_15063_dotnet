// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPolyline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [ExclusiveTo(typeof (Polyline))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2447139576, 17075, 18419, 132, 118, 197, 81, 36, 167, 196, 198)]
  [WebHostHidden]
  internal interface IPolyline
  {
    FillRule FillRule { get; set; }

    PointCollection Points { get; set; }
  }
}
