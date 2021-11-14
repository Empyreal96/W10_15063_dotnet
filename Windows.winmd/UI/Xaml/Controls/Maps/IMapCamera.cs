// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.IMapCamera
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MapCamera))]
  [WebHostHidden]
  [Guid(1403434531, 49400, 19851, 173, 30, 165, 149, 152, 234, 132, 11)]
  internal interface IMapCamera
  {
    Geopoint Location { get; set; }

    double Heading { get; set; }

    double Pitch { get; set; }

    double Roll { get; set; }

    double FieldOfView { get; set; }
  }
}
