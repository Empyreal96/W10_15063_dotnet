// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EasingFunctionBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Composable(typeof (IEasingFunctionBaseFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IEasingFunctionBaseStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public class EasingFunctionBase : DependencyObject, IEasingFunctionBase
  {
    public extern EasingMode EasingMode { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern double Ease(double normalizedTime);

    public static extern DependencyProperty EasingModeProperty { [MethodImpl] get; }
  }
}
