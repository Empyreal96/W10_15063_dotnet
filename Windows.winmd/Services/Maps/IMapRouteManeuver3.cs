// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteManeuver3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(2795583711, 1155, 16742, 133, 190, 185, 147, 54, 193, 24, 117)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRouteManeuver))]
  internal interface IMapRouteManeuver3
  {
    IVectorView<ManeuverWarning> Warnings { get; }
  }
}
