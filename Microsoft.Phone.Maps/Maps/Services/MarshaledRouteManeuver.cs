// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.MarshaledRouteManeuver
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  internal struct MarshaledRouteManeuver : IDisposable
  {
    public MarshaledGeoCoordinates StartCoordinates;
    public uint DistanceInMetersToNextManeuver;
    public RouteManeuverInstructionKind ManeuverType;
    public uint TrafficCircleExitNumber;
    private IntPtr instructionText;

    public string GetInstructionText() => Marshal.PtrToStringUni(this.instructionText);

    [SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification = "GC.SuppressFinalize being called correctly on this")]
    public void Dispose()
    {
      if (!(this.instructionText != IntPtr.Zero))
        return;
      Marshal.FreeCoTaskMem(this.instructionText);
      this.instructionText = IntPtr.Zero;
      GC.SuppressFinalize((object) this);
    }
  }
}
