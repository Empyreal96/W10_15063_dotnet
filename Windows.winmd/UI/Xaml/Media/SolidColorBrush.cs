// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.SolidColorBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(typeof (ISolidColorBrushFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (ISolidColorBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "Color")]
  public sealed class SolidColorBrush : Brush, ISolidColorBrush
  {
    [MethodImpl]
    public extern SolidColorBrush(Color color);

    [MethodImpl]
    public extern SolidColorBrush();

    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ColorProperty { [IndependentlyAnimatable, MethodImpl] get; }
  }
}
