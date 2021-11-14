// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MarshaledMargins
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.Maps.Controls
{
  [StructLayout(LayoutKind.Sequential, Pack = 8)]
  internal struct MarshaledMargins
  {
    public int Left;
    public int Top;
    public int Right;
    public int Bottom;

    public MarshaledMargins(double l, double t, double r, double b)
    {
      this.Left = (int) l;
      this.Top = (int) t;
      this.Right = (int) r;
      this.Bottom = (int) b;
    }
  }
}
