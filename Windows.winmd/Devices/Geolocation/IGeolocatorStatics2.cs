// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeolocatorStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(2570064290, 64028, 17969, 167, 29, 13, 190, 177, 37, 13, 156)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (Geolocator))]
  internal interface IGeolocatorStatics2
  {
    bool IsDefaultGeopositionRecommended { get; }

    IReference<BasicGeoposition> DefaultGeoposition { set; get; }
  }
}
