// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapPolygon
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapPolygonStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class MapPolygon : MapElement, IMapPolygon, IMapPolygon2
  {
    [MethodImpl]
    public extern MapPolygon();

    public extern Geopath Path { [MethodImpl] get; [MethodImpl] set; }

    public extern Color StrokeColor { [MethodImpl] get; [MethodImpl] set; }

    public extern double StrokeThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern bool StrokeDashed { [MethodImpl] get; [MethodImpl] set; }

    public extern Color FillColor { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<Geopath> Paths { [MethodImpl] get; }

    public static extern DependencyProperty PathProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeThicknessProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeDashedProperty { [MethodImpl] get; }
  }
}
