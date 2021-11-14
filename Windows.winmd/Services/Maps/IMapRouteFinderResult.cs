// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteFinderResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapRouteFinderResult))]
  [Guid(2825429786, 37922, 18092, 140, 161, 177, 97, 77, 75, 251, 226)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRouteFinderResult
  {
    MapRoute Route { get; }

    MapRouteFinderStatus Status { get; }
  }
}
