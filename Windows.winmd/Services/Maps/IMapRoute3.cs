// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRoute3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MapRoute))]
  [Guid(2240618158, 62125, 17055, 187, 55, 205, 33, 9, 79, 252, 146)]
  [WebHostHidden]
  internal interface IMapRoute3
  {
    TimeSpan DurationWithoutTraffic { get; }

    TrafficCongestion TrafficCongestion { get; }
  }
}
