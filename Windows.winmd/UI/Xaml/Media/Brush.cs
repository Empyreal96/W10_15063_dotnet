// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Brush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IBrushStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IBrushFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public class Brush : DependencyObject, IBrush
  {
    [MethodImpl]
    protected extern Brush();

    public extern double Opacity { [MethodImpl] get; [MethodImpl] set; }

    public extern Transform Transform { [MethodImpl] get; [MethodImpl] set; }

    public extern Transform RelativeTransform { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty OpacityProperty { [MethodImpl] get; }

    public static extern DependencyProperty TransformProperty { [MethodImpl] get; }

    public static extern DependencyProperty RelativeTransformProperty { [MethodImpl] get; }
  }
}
