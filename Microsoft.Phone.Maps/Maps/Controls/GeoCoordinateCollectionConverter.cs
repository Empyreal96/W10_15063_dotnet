// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.GeoCoordinateCollectionConverter
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Device.Location;
using System.Globalization;

namespace Microsoft.Phone.Maps.Controls
{
  public class GeoCoordinateCollectionConverter : TypeConverter
  {
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) => sourceType == typeof (string);

    public override object ConvertFrom(
      ITypeDescriptorContext context,
      CultureInfo culture,
      object value)
    {
      GeoCoordinateCollection coordinateCollection = (GeoCoordinateCollection) null;
      if (value is string str1)
      {
        coordinateCollection = new GeoCoordinateCollection();
        GeoCoordinateConverter coordinateConverter = new GeoCoordinateConverter();
        int num = -1;
        for (int index = 0; index < str1.Length + 1; ++index)
        {
          if (index >= str1.Length || char.IsWhiteSpace(str1[index]))
          {
            int startIndex = num + 1;
            int length = index - startIndex;
            if (length >= 1)
            {
              string str = str1.Substring(startIndex, length);
              GeoCoordinate geoCoordinate = (GeoCoordinate) coordinateConverter.ConvertFrom((object) str);
              if (!(geoCoordinate != (GeoCoordinate) null))
                return (object) null;
              ((Collection<GeoCoordinate>) coordinateCollection).Add(geoCoordinate);
            }
            num = index;
          }
        }
      }
      return (object) coordinateCollection;
    }
  }
}
