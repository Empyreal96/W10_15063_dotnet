// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapServiceStatics4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Guid(143272034, 27324, 16910, 148, 95, 76, 253, 137, 198, 115, 86)]
  [ExclusiveTo(typeof (MapService))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMapServiceStatics4
  {
    MapServiceDataUsagePreference DataUsagePreference { set; get; }
  }
}
