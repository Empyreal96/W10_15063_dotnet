// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IVector3KeyFrameAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [Guid(3355680170, 41601, 17346, 167, 61, 182, 142, 60, 83, 60, 64)]
  [ExclusiveTo(typeof (Vector3KeyFrameAnimation))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IVector3KeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, Vector3 value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      Vector3 value,
      CompositionEasingFunction easingFunction);
  }
}
