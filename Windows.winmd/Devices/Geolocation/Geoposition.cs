// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Geolocation.Geoposition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Geolocation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Geoposition : IGeoposition, IGeoposition2
  {
    public extern Geocoordinate Coordinate { [MethodImpl] get; }

    public extern CivicAddress CivicAddress { [MethodImpl] get; }

    public extern VenueData VenueData { [MethodImpl] get; }
  }
}
