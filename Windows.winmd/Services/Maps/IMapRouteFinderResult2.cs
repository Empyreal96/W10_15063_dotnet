// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteFinderResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapRouteFinderResult))]
  [Guid(544250989, 55564, 18120, 145, 198, 125, 75, 228, 239, 178, 21)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMapRouteFinderResult2
  {
    IVectorView<MapRoute> AlternateRoutes { get; }
  }
}
