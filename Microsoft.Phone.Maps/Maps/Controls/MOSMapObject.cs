// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MOSMapObject
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Phone.Maps.Controls
{
  internal abstract class MOSMapObject : IMapElementModel
  {
    public ulong ZIndex
    {
      get => this.MapObjectAdapter.ZIndex;
      set => this.MapObjectAdapter.ZIndex = value;
    }

    public bool Visible
    {
      get => this.MapObjectAdapter.Visible;
      set => this.MapObjectAdapter.Visible = value;
    }

    [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", Justification = "DangerousGetHandle is being called deliberately")]
    public IntPtr Handle => this.MapObjectAdapter.NativeHandle.DangerousGetHandle();

    public object Backend => (object) this.MapObjectAdapter;

    internal abstract MapObjectAdapter MapObjectAdapter { get; }
  }
}
