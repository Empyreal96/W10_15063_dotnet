// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.SplineDoubleKeyFrame
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
  [Static(typeof (ISplineDoubleKeyFrameStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SplineDoubleKeyFrame : DoubleKeyFrame, ISplineDoubleKeyFrame
  {
    [MethodImpl]
    public extern SplineDoubleKeyFrame();

    public extern KeySpline KeySpline { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty KeySplineProperty { [MethodImpl] get; }
  }
}
