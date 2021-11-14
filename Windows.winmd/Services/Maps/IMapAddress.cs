// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3483871603, 41908, 17556, 179, 255, 203, 169, 77, 182, 150, 153)]
  [ExclusiveTo(typeof (MapAddress))]
  internal interface IMapAddress
  {
    string BuildingName { get; }

    string BuildingFloor { get; }

    string BuildingRoom { get; }

    string BuildingWing { get; }

    string StreetNumber { get; }

    string Street { get; }

    string Neighborhood { get; }

    string District { get; }

    string Town { get; }

    string Region { get; }

    string RegionCode { get; }

    string Country { get; }

    string CountryCode { get; }

    string PostCode { get; }

    string Continent { get; }
  }
}
