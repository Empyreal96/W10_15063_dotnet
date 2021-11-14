// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.MarshaledRoutePath
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  internal struct MarshaledRoutePath : IDisposable
  {
    public uint LengthInMeters;
    public uint DurationInSeconds;
    public MarshaledBoundingRectangle BoundingBox;
    public uint GeometryCoordinatesCount;
    public IntPtr GeometryCoordinatesArray;

    public MarshaledGeoCoordinates GetGeometryCoordinates(uint index) => index < this.GeometryCoordinatesCount ? (MarshaledGeoCoordinates) Marshal.PtrToStructure((IntPtr) ((long) (int) this.GeometryCoordinatesArray + (long) index * (long) Marshal.SizeOf(typeof (MarshaledGeoCoordinates))), typeof (MarshaledGeoCoordinates)) : throw new ArgumentOutOfRangeException(nameof (index), string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.OutOfRangeExceptionFormat, (object) nameof (index), (object) 0, (object) (uint) ((int) this.GeometryCoordinatesCount - 1)));

    [SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification = "GC.SuppressFinalize being called correctly on this")]
    public void Dispose()
    {
      if (!(this.GeometryCoordinatesArray != IntPtr.Zero))
        return;
      Marshal.FreeCoTaskMem(this.GeometryCoordinatesArray);
      this.GeometryCoordinatesArray = IntPtr.Zero;
      GC.SuppressFinalize((object) this);
    }
  }
}
