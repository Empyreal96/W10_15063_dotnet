// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ColorAnimationUsingKeyFrames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media.Animation
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IColorAnimationUsingKeyFramesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContentProperty(Name = "KeyFrames")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class ColorAnimationUsingKeyFrames : Timeline, IColorAnimationUsingKeyFrames
  {
    [MethodImpl]
    public extern ColorAnimationUsingKeyFrames();

    public extern ColorKeyFrameCollection KeyFrames { [MethodImpl] get; }

    public extern bool EnableDependentAnimation { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty EnableDependentAnimationProperty { [MethodImpl] get; }
  }
}
