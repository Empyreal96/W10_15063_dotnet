// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.KeyFrameAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Composable(typeof (IKeyFrameAnimationFactory), CompositionType.Protected, 131072, "Windows.Foundation.UniversalApiContract")]
  public class KeyFrameAnimation : 
    CompositionAnimation,
    IKeyFrameAnimation,
    IKeyFrameAnimation2,
    IKeyFrameAnimation3
  {
    public extern TimeSpan DelayTime { [MethodImpl] get; [MethodImpl] set; }

    public extern TimeSpan Duration { [MethodImpl] get; [MethodImpl] set; }

    public extern AnimationIterationBehavior IterationBehavior { [MethodImpl] get; [MethodImpl] set; }

    public extern int IterationCount { [MethodImpl] get; [MethodImpl] set; }

    public extern int KeyFrameCount { [MethodImpl] get; }

    public extern AnimationStopBehavior StopBehavior { [MethodImpl] get; [MethodImpl] set; }

    [Overload("InsertExpressionKeyFrame")]
    [MethodImpl]
    public extern void InsertExpressionKeyFrame(float normalizedProgressKey, string value);

    [Overload("InsertExpressionKeyFrameWithEasingFunction")]
    [MethodImpl]
    public extern void InsertExpressionKeyFrame(
      float normalizedProgressKey,
      string value,
      CompositionEasingFunction easingFunction);

    public extern AnimationDirection Direction { [MethodImpl] get; [MethodImpl] set; }

    public extern AnimationDelayBehavior DelayBehavior { [MethodImpl] get; [MethodImpl] set; }
  }
}
