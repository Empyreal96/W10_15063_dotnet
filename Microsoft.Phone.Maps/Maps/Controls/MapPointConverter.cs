// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.MapPointConverter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;

namespace Microsoft.Phone.Maps.Controls
{
  public class MapPointConverter : TypeConverter
  {
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) => sourceType == typeof (string);

    public override object ConvertFrom(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value)
    {
      if (value is string str)
      {
        char[] chArray = new char[1]{ ',' };
        string[] strArray = str.Split(chArray);
        double result1;
        double result2;
        if (strArray.Length == 2 && double.TryParse(strArray[0], NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture, out result1) && double.TryParse(strArray[1], NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture, out result2))
          return (object) new Point(result1, result2);
      }
      return (object) null;
    }
  }
}
