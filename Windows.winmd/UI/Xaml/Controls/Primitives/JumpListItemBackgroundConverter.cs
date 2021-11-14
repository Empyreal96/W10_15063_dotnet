// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.JumpListItemBackgroundConverter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IJumpListItemBackgroundConverterStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class JumpListItemBackgroundConverter : 
    DependencyObject,
    IJumpListItemBackgroundConverter,
    IValueConverter
  {
    [MethodImpl]
    public extern JumpListItemBackgroundConverter();

    public extern Brush Enabled { [MethodImpl] get; [MethodImpl] set; }

    public extern Brush Disabled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern object Convert(
      object value,
      TypeName targetType,
      object parameter,
      string language);

    [MethodImpl]
    public extern object ConvertBack(
      object value,
      TypeName targetType,
      object parameter,
      string language);

    public static extern DependencyProperty EnabledProperty { [MethodImpl] get; }

    public static extern DependencyProperty DisabledProperty { [MethodImpl] get; }
  }
}
