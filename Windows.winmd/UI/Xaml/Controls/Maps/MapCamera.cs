// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapCamera
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IMapCameraFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class MapCamera : DependencyObject, IMapCamera
  {
    [MethodImpl]
    public extern MapCamera(Geopoint location);

    [MethodImpl]
    public extern MapCamera(Geopoint location, double headingInDegrees);

    [MethodImpl]
    public extern MapCamera(Geopoint location, double headingInDegrees, double pitchInDegrees);

    [MethodImpl]
    public extern MapCamera(
      Geopoint location,
      double headingInDegrees,
      double pitchInDegrees,
      double rollInDegrees,
      double fieldOfViewInDegrees);

    public extern Geopoint Location { [MethodImpl] get; [MethodImpl] set; }

    public extern double Heading { [MethodImpl] get; [MethodImpl] set; }

    public extern double Pitch { [MethodImpl] get; [MethodImpl] set; }

    public extern double Roll { [MethodImpl] get; [MethodImpl] set; }

    public extern double FieldOfView { [MethodImpl] get; [MethodImpl] set; }
  }
}
