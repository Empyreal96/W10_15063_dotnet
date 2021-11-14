// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapPolyline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ExclusiveTo(typeof (MapPolyline))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4222428322, 9439, 19078, 143, 250, 15, 143, 77, 158, 193, 125)]
  internal interface IMapPolyline
  {
    Geopath Path { get; set; }

    Color StrokeColor { get; set; }

    double StrokeThickness { get; set; }

    bool StrokeDashed { get; set; }
  }
}
