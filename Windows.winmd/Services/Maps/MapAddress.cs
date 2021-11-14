// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapAddress
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class MapAddress : IMapAddress, IMapAddress2
  {
    public extern string BuildingName { [MethodImpl] get; }

    public extern string BuildingFloor { [MethodImpl] get; }

    public extern string BuildingRoom { [MethodImpl] get; }

    public extern string BuildingWing { [MethodImpl] get; }

    public extern string StreetNumber { [MethodImpl] get; }

    public extern string Street { [MethodImpl] get; }

    public extern string Neighborhood { [MethodImpl] get; }

    public extern string District { [MethodImpl] get; }

    public extern string Town { [MethodImpl] get; }

    public extern string Region { [MethodImpl] get; }

    public extern string RegionCode { [MethodImpl] get; }

    public extern string Country { [MethodImpl] get; }

    public extern string CountryCode { [MethodImpl] get; }

    public extern string PostCode { [MethodImpl] get; }

    public extern string Continent { [MethodImpl] get; }

    public extern string FormattedAddress { [MethodImpl] get; }
  }
}
