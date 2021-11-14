// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapLocationFinderResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [Guid(1139929465, 59596, 17910, 190, 210, 84, 204, 191, 150, 93, 154)]
  [ExclusiveTo(typeof (MapLocationFinderResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapLocationFinderResult
  {
    IVectorView<MapLocation> Locations { get; }

    MapLocationFinderStatus Status { get; }
  }
}
