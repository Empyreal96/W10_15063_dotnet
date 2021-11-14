// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.GuidanceMapMatchedCoordinate
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  public sealed class GuidanceMapMatchedCoordinate : IGuidanceMapMatchedCoordinate
  {
    public extern Geopoint Location { [MethodImpl] get; }

    public extern double CurrentHeading { [MethodImpl] get; }

    public extern double CurrentSpeed { [MethodImpl] get; }

    public extern bool IsOnStreet { [MethodImpl] get; }

    public extern GuidanceRoadSegment Road { [MethodImpl] get; }
  }
}
