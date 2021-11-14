// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRoute2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3519403020, 8723, 19120, 162, 96, 70, 179, 129, 105, 190, 172)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MapRoute))]
  internal interface IMapRoute2
  {
    MapRouteRestrictions ViolatedRestrictions { get; }

    bool HasBlockedRoads { get; }
  }
}
