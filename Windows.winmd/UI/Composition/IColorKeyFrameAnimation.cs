// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IColorKeyFrameAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Guid(2477635049, 36357, 17811, 132, 163, 220, 161, 82, 120, 30, 86)]
  [ExclusiveTo(typeof (ColorKeyFrameAnimation))]
  internal interface IColorKeyFrameAnimation
  {
    CompositionColorSpace InterpolationColorSpace { get; set; }

    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, Color value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      Color value,
      CompositionEasingFunction easingFunction);
  }
}
