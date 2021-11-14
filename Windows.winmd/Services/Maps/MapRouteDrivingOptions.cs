// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapRouteDrivingOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class MapRouteDrivingOptions : IMapRouteDrivingOptions
  {
    [MethodImpl]
    public extern MapRouteDrivingOptions();

    public extern uint MaxAlternateRouteCount { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<double> InitialHeading { [MethodImpl] get; [MethodImpl] set; }

    public extern MapRouteOptimization RouteOptimization { [MethodImpl] get; [MethodImpl] set; }

    public extern MapRouteRestrictions RouteRestrictions { [MethodImpl] get; [MethodImpl] set; }
  }
}
