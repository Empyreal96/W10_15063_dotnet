// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.RouteLeg
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System;
using System.Collections.ObjectModel;
using System.Device.Location;

namespace Microsoft.Phone.Maps.Services
{
  public class RouteLeg : IRoutePath
  {
    internal RouteLeg()
    {
    }

    public LocationRectangle BoundingBox { get; internal set; }

    public ReadOnlyCollection<GeoCoordinate> Geometry { get; internal set; }

    public int LengthInMeters { get; internal set; }

    public TimeSpan EstimatedDuration { get; internal set; }

    public ReadOnlyCollection<RouteManeuver> Maneuvers { get; internal set; }
  }
}
