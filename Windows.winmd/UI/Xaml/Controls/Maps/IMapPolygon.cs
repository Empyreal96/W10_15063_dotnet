// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapPolygon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Guid(2883199621, 18726, 19514, 165, 249, 25, 223, 127, 105, 219, 61)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapPolygon))]
  internal interface IMapPolygon
  {
    Geopath Path { get; set; }

    Color StrokeColor { get; set; }

    double StrokeThickness { get; set; }

    bool StrokeDashed { get; set; }

    Color FillColor { get; set; }
  }
}
