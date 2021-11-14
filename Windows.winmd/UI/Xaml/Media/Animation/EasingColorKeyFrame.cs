// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EasingColorKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IEasingColorKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class EasingColorKeyFrame : ColorKeyFrame, IEasingColorKeyFrame
  {
    [MethodImpl]
    public extern EasingColorKeyFrame();

    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }
  }
}
