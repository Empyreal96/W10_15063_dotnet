// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IVenueData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(1727238535, 24803, 19247, 181, 39, 79, 83, 241, 195, 198, 119)]
  [ExclusiveTo(typeof (VenueData))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVenueData
  {
    string Id { get; }

    string Level { get; }
  }
}
