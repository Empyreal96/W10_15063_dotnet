// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeolocatorWithScalarAccuracy
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geolocator))]
  [Guid(2532692929, 47119, 17930, 153, 77, 169, 108, 71, 165, 26, 164)]
  internal interface IGeolocatorWithScalarAccuracy : IGeolocator
  {
    IReference<uint> DesiredAccuracyInMeters { get; set; }
  }
}
