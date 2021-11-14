// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocircle
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [Guid(971266115, 43001, 20067, 146, 167, 186, 12, 40, 209, 36, 177)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Geocircle))]
  internal interface IGeocircle : IGeoshape
  {
    BasicGeoposition Center { get; }

    double Radius { get; }
  }
}
