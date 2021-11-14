// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceRouteStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [Guid(4117598826, 21997, 18881, 176, 156, 75, 130, 35, 181, 13, 179)]
  [ExclusiveTo(typeof (GuidanceRoute))]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  [WebHostHidden]
  internal interface IGuidanceRouteStatics
  {
    bool CanCreateFromMapRoute(MapRoute mapRoute);

    GuidanceRoute TryCreateFromMapRoute(MapRoute mapRoute);
  }
}
