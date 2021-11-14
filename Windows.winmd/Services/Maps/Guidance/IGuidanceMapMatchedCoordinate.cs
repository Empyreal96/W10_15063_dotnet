// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceMapMatchedCoordinate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Geolocation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [ExclusiveTo(typeof (GuidanceMapMatchedCoordinate))]
  [Guid(3081548136, 10514, 19097, 175, 241, 121, 134, 9, 185, 129, 254)]
  [WebHostHidden]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  internal interface IGuidanceMapMatchedCoordinate
  {
    Geopoint Location { get; }

    double CurrentHeading { get; }

    double CurrentSpeed { get; }

    bool IsOnStreet { get; }

    GuidanceRoadSegment Road { get; }
  }
}
