// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Controls.JumpListItemForegroundConverter
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Microsoft.Phone.Controls
{
  public class JumpListItemForegroundConverter : IValueConverter
  {
    public JumpListItemForegroundConverter()
    {
      this.Enabled = (Brush) new SolidColorBrush(Colors.White);
      this.Disabled = (Brush) Application.Current.Resources[(object) "PhoneDisabledBrush"];
    }

    public Brush Enabled { get; set; }

    public Brush Disabled { get; set; }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => value is IList list && list.Count != 0 ? (object) this.Enabled : (object) this.Disabled;

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
