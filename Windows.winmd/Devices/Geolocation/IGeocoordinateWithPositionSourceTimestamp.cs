// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeocoordinateWithPositionSourceTimestamp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geocoordinate))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2235825154, 51697, 17936, 175, 224, 139, 195, 166, 168, 112, 54)]
  internal interface IGeocoordinateWithPositionSourceTimestamp
  {
    IReference<DateTime> PositionSourceTimestamp { get; }
  }
}
