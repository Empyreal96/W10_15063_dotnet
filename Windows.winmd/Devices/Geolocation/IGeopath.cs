// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.IGeopath
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ExclusiveTo(typeof (Geopath))]
  [Guid(3846166457, 11684, 18196, 166, 82, 222, 133, 147, 40, 152, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeopath : IGeoshape
  {
    IVectorView<BasicGeoposition> Positions { get; }
  }
}
