// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapPolyline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IMapPolylineStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapPolyline : MapElement, IMapPolyline
  {
    [MethodImpl]
    public extern MapPolyline();

    public extern Geopath Path { [MethodImpl] get; [MethodImpl] set; }

    public extern Color StrokeColor { [MethodImpl] get; [MethodImpl] set; }

    public extern double StrokeThickness { [MethodImpl] get; [MethodImpl] set; }

    public extern bool StrokeDashed { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PathProperty { [MethodImpl] get; }

    public static extern DependencyProperty StrokeDashedProperty { [MethodImpl] get; }
  }
}
