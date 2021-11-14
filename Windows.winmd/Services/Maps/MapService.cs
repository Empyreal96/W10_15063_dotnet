// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapService
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IMapServiceStatics4), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IMapServiceStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapServiceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IMapServiceStatics3), 131072, "Windows.Foundation.UniversalApiContract")]
  public static class MapService
  {
    public static extern MapServiceDataUsagePreference DataUsagePreference { [MethodImpl] set; [MethodImpl] get; }

    public static extern string DataAttributions { [MethodImpl] get; }

    public static extern string WorldViewRegionCode { [MethodImpl] get; }

    public static extern string ServiceToken { [MethodImpl] set; [MethodImpl] get; }
  }
}
