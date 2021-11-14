// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeopoint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geopoint))]
  [Guid(1811546347, 58734, 18875, 156, 175, 203, 170, 120, 168, 188, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeopoint : IGeoshape
  {
    BasicGeoposition Position { get; }
  }
}
