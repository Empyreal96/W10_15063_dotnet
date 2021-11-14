// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.StringToResourceConverter
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.TaskModel.Interop;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Microsoft.Phone.Shell
{
  internal class StringToResourceConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value == null)
        return (object) string.Empty;
      string str1 = (string) value;
      string str2 = "@";
      if (str1.Length > str2.Length && str1.StartsWith(str2, StringComparison.OrdinalIgnoreCase))
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("@");
        stringBuilder.Append(ApplicationHost.Current.AppInstallFolder);
        stringBuilder.Append("\\");
        stringBuilder.Append(str1.Substring(1));
        str1 = stringBuilder.ToString();
      }
      return (object) str1;
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
