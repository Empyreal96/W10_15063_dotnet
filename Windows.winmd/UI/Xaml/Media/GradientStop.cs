// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GradientStop
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContentProperty(Name = "Color")]
  [Static(typeof (IGradientStopStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class GradientStop : DependencyObject, IGradientStop
  {
    [MethodImpl]
    public extern GradientStop();

    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    public extern double Offset { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty ColorProperty { [MethodImpl] get; }

    public static extern DependencyProperty OffsetProperty { [MethodImpl] get; }
  }
}
