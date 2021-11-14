// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.QuadKey
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Microsoft.Phone.Maps.Controls
{
  public struct QuadKey : IEquatable<QuadKey>
  {
    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "x, y are correct")]
    public QuadKey(int x, int y, int zoomLevel)
      : this()
    {
      this.ZoomLevel = zoomLevel;
      this.X = x;
      this.Y = y;
    }

    public QuadKey(string quadKey)
      : this()
    {
      if (string.IsNullOrEmpty(quadKey))
        throw new ArgumentNullException(nameof (quadKey));
      int x;
      int y;
      int zoomLevel;
      QuadKey.QuadKeyToQuadPixel(quadKey, out x, out y, out zoomLevel);
      this.ZoomLevel = zoomLevel;
      this.X = x;
      this.Y = y;
    }

    public int ZoomLevel { get; set; }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "x is correct")]
    public int X { get; set; }

    [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "y is correct")]
    public int Y { get; set; }

    public string Key => QuadKey.QuadPixelToQuadKey(this.X, this.Y, this.ZoomLevel);

    public static bool operator ==(QuadKey tile1, QuadKey tile2) => tile1.X == tile2.X && tile1.Y == tile2.Y && tile1.ZoomLevel == tile2.ZoomLevel;

    public static bool operator !=(QuadKey tile1, QuadKey tile2) => !(tile1 == tile2);

    public bool Equals(QuadKey other) => this == other;

    public override bool Equals(object other) => other != null && this.Equals((QuadKey) other);

    public override int GetHashCode()
    {
      int num1 = this.X;
      int hashCode1 = num1.GetHashCode();
      num1 = this.Y;
      int hashCode2 = num1.GetHashCode();
      int num2 = hashCode1 ^ hashCode2;
      num1 = this.ZoomLevel;
      int hashCode3 = num1.GetHashCode();
      return num2 ^ hashCode3;
    }

    private static string QuadPixelToQuadKey(int x, int y, int zoomLevel)
    {
      if (zoomLevel <= 0)
        return string.Empty;
      int num1 = 1 << zoomLevel;
      if (y < 0 || y >= num1)
        return string.Empty;
      x = (x % num1 + num1) % num1;
      StringBuilder stringBuilder = new StringBuilder(zoomLevel);
      for (int index = zoomLevel - 1; index >= 0; --index)
      {
        char ch = '0';
        int num2 = 1 << index;
        if ((x & num2) != 0)
          ++ch;
        if ((y & num2) != 0)
          ch = (char) ((uint) (char) ((uint) ch + 1U) + 1U);
        stringBuilder.Append(ch);
      }
      return stringBuilder.ToString();
    }

    private static void QuadKeyToQuadPixel(
      string quadKey,
      out int x,
      out int y,
      out int zoomLevel)
    {
      x = 0;
      y = 0;
      zoomLevel = quadKey.Length;
      int num = 1 << zoomLevel - 1;
      foreach (char ch in quadKey)
      {
        num >>= 1;
        switch (ch)
        {
          case '0':
            continue;
          case '1':
            x |= num;
            continue;
          case '2':
            y |= num;
            continue;
          case '3':
            x |= num;
            y |= num;
            continue;
          default:
            throw new ArgumentException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.EnumMatchingExceptionFormat, (object) nameof (quadKey)), nameof (quadKey));
        }
      }
    }
  }
}
