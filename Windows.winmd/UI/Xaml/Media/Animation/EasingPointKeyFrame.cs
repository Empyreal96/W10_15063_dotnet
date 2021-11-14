// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IEasingPointKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class EasingPointKeyFrame : PointKeyFrame, IEasingPointKeyFrame
  {
    [MethodImpl]
    public extern EasingPointKeyFrame();

    public extern EasingFunctionBase EasingFunction { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty EasingFunctionProperty { [MethodImpl] get; }
  }
}
