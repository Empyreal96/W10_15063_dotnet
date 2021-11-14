// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TranslateTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Media
{
  [Static(typeof (ITranslateTransformStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class TranslateTransform : Transform, ITranslateTransform
  {
    [MethodImpl]
    public extern TranslateTransform();

    public extern double X { [MethodImpl] get; [MethodImpl] set; }

    public extern double Y { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty XProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }

    public static extern DependencyProperty YProperty { [ConditionallyIndependentlyAnimatable, MethodImpl] get; }
  }
}
