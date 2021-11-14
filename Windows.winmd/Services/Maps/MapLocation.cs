// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.MapLocation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public sealed class MapLocation : IMapLocation
  {
    public extern Geopoint Point { [MethodImpl] get; }

    public extern string DisplayName { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern MapAddress Address { [MethodImpl] get; }
  }
}
