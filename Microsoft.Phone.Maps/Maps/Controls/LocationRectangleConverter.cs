// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.LocationRectangleConverter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.ComponentModel;
using System.Globalization;

namespace Microsoft.Phone.Maps.Controls
{
  public class LocationRectangleConverter : TypeConverter
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
        if (strArray.Length == 4)
          return (object) new LocationRectangle(double.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[2], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[3], (IFormatProvider) CultureInfo.InvariantCulture));
      }
      return (object) null;
    }
  }
}
