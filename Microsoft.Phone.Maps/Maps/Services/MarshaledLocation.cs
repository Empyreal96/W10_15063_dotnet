// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.MarshaledLocation
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Phone.Maps.Controls;
using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Services
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  internal struct MarshaledLocation
  {
    public MarshaledGeoCoordinates Coordinates;
    public MarshaledBoundingRectangle BoundingBox;
    public MarshaledLocationInformation Information;
  }
}
