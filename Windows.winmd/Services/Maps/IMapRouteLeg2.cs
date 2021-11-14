// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.IMapRouteLeg2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [ExclusiveTo(typeof (MapRouteLeg))]
  [Guid(48367149, 51654, 17848, 142, 84, 26, 16, 181, 122, 23, 232)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMapRouteLeg2
  {
    TimeSpan DurationWithoutTraffic { get; }

    TrafficCongestion TrafficCongestion { get; }
  }
}
