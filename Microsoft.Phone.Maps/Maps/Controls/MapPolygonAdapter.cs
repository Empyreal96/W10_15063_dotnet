﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapPolygonAdapter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Windows.Media;

namespace Microsoft.Phone.Maps.Controls
{
  internal class MapPolygonAdapter : MapObjectAdapter
  {
    private readonly MapObjectSafeHandle nativeHandle;

    public MapPolygonAdapter()
    {
      Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_Create(out this.nativeHandle));
      if (this.nativeHandle.IsInvalid)
        throw new InvalidOperationException(Resources.CreationException);
    }

    public MarshaledGeoCoordinates[] Path
    {
      set
      {
        MapObjectSafeHandle nativeHandle = this.nativeHandle;
        MarshaledGeoCoordinates[] coordinatesArray = value;
        int length = coordinatesArray.Length;
        Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_SetPath(nativeHandle, coordinatesArray, length));
      }
    }

    public Color StrokeColor
    {
      get
      {
        int color;
        Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_GetStrokeColor(this.nativeHandle, out color));
        return ColorHelper.FromArgb(color);
      }
      set => Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_SetStrokeColor(this.nativeHandle, value.ToArgb()));
    }

    public Color FillColor
    {
      get
      {
        int color;
        Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_GetFillColor(this.nativeHandle, out color));
        return ColorHelper.FromArgb(color);
      }
      set => Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_SetFillColor(this.nativeHandle, value.ToArgb()));
    }

    public bool StrokeDashed
    {
      set => Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_SetStrokeDashed(this.nativeHandle, value));
    }

    public uint StrokeThickness
    {
      get
      {
        uint width;
        Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_GetStrokeThickness(this.nativeHandle, out width));
        return width;
      }
      set => Marshal.ThrowExceptionForHR(Shim.AgMapPolygon_SetStrokeThickness(this.nativeHandle, value));
    }

    internal override MapObjectSafeHandle NativeHandle => this.nativeHandle;
  }
}
