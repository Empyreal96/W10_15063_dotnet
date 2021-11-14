// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteManeuver2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapRouteManeuver))]
  [Guid(1568394652, 31899, 16863, 131, 139, 234, 226, 30, 75, 5, 169)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRouteManeuver2
  {
    double StartHeading { get; }

    double EndHeading { get; }

    string StreetName { get; }
  }
}
