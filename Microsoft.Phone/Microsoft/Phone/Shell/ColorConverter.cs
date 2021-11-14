// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.ColorConverter
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Microsoft.Phone.Shell
{
  internal class ColorConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
        return (object) string.Empty;
      Color color = (Color) value;
      if (color.A != byte.MaxValue)
        return (object) string.Empty;
      return (object) string.Format((IFormatProvider) CultureInfo.InvariantCulture, "#{0}{1}{2}", (object) color.R.ToString("X2"), (object) color.G.ToString("X2"), (object) color.B.ToString("X2"));
    }

    public object ConvertBack(
      object value,
      Type targetType,
      object parameter,
      CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
