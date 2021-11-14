// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.PanMapGestureEventArgs
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Windows;

namespace Microsoft.Phone.Maps.Controls
{
  internal sealed class PanMapGestureEventArgs : MapGestureEventArgs
  {
    public PanMapGestureEventArgs(Point from, Point to)
    {
      this.From = from;
      this.To = to;
    }

    public Point From { get; set; }

    public Point To { get; set; }
  }
}
