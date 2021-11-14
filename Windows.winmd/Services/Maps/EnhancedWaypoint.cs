// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.EnhancedWaypoint
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [Activatable(typeof (IEnhancedWaypointFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EnhancedWaypoint : IEnhancedWaypoint
  {
    [MethodImpl]
    public extern EnhancedWaypoint(Geopoint point, WaypointKind kind);

    public extern Geopoint Point { [MethodImpl] get; }

    public extern WaypointKind Kind { [MethodImpl] get; }
  }
}
