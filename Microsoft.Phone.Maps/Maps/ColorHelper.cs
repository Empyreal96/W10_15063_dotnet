// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.ColorHelper
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System.Windows.Media;

namespace Microsoft.Phone.Maps
{
  internal static class ColorHelper
  {
    public static Color FromArgb(int color) => Color.FromArgb((byte) (color >> 24), (byte) (color >> 16), (byte) (color >> 8), (byte) color);

    public static int ToArgb(this Color color) => (int) color.A << 24 | (int) color.R << 16 | (int) color.G << 8 | (int) color.B;
  }
}
