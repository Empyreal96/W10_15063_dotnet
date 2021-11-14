// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.GeocoordinateSatelliteData
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  public sealed class GeocoordinateSatelliteData : IGeocoordinateSatelliteData
  {
    public extern IReference<double> PositionDilutionOfPrecision { [MethodImpl] get; }

    public extern IReference<double> HorizontalDilutionOfPrecision { [MethodImpl] get; }

    public extern IReference<double> VerticalDilutionOfPrecision { [MethodImpl] get; }
  }
}
