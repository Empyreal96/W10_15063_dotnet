// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeolocator2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3518246509, 34961, 17332, 173, 54, 39, 198, 254, 154, 151, 177)]
  [ExclusiveTo(typeof (Geolocator))]
  internal interface IGeolocator2
  {
    void AllowFallbackToConsentlessPositions();
  }
}
