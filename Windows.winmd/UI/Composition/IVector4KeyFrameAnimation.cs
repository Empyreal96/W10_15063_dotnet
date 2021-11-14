// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVector4KeyFrameAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(609719387, 44509, 17285, 150, 6, 182, 163, 213, 228, 225, 185)]
  [ExclusiveTo(typeof (Vector4KeyFrameAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  internal interface IVector4KeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, Vector4 value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      Vector4 value,
      CompositionEasingFunction easingFunction);
  }
}
