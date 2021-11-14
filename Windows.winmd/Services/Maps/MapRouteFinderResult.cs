// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteFinderResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MapRouteFinderResult : IMapRouteFinderResult, IMapRouteFinderResult2
  {
    public extern MapRoute Route { [MethodImpl] get; }

    public extern MapRouteFinderStatus Status { [MethodImpl] get; }

    public extern IVectorView<MapRoute> AlternateRoutes { [MethodImpl] get; }
  }
}
