// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeoposition2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geoposition))]
  [Guid(2137192087, 34417, 19213, 134, 248, 71, 74, 132, 150, 24, 124)]
  internal interface IGeoposition2 : IGeoposition
  {
    VenueData VenueData { get; }
  }
}
