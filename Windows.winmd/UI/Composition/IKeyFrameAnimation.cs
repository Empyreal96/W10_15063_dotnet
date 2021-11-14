// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IKeyFrameAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(309231394, 15081, 17728, 154, 138, 222, 174, 138, 74, 74, 132)]
  [ExclusiveTo(typeof (KeyFrameAnimation))]
  internal interface IKeyFrameAnimation
  {
    TimeSpan DelayTime { get; set; }

    TimeSpan Duration { get; set; }

    AnimationIterationBehavior IterationBehavior { get; set; }

    int IterationCount { get; set; }

    int KeyFrameCount { get; }

    AnimationStopBehavior StopBehavior { get; set; }

    [Overload("InsertExpressionKeyFrame")]
    void InsertExpressionKeyFrame(float normalizedProgressKey, string value);

    [Overload("InsertExpressionKeyFrameWithEasingFunction")]
    void InsertExpressionKeyFrame(
      float normalizedProgressKey,
      string value,
      CompositionEasingFunction easingFunction);
  }
}
