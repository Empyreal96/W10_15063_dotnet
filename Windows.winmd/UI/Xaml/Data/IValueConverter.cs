// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IValueConverter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3874684656, 1810, 18559, 179, 19, 243, 0, 184, 215, 154, 161)]
  public interface IValueConverter
  {
    object Convert(object value, TypeName targetType, object parameter, string language);

    object ConvertBack(object value, TypeName targetType, object parameter, string language);
  }
}
