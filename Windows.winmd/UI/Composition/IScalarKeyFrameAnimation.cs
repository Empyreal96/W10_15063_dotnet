// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IScalarKeyFrameAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Guid(2921893801, 9516, 19349, 167, 37, 191, 133, 227, 128, 0, 161)]
  [ExclusiveTo(typeof (ScalarKeyFrameAnimation))]
  internal interface IScalarKeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    void InsertKeyFrame(float normalizedProgressKey, float value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    void InsertKeyFrame(
      float normalizedProgressKey,
      float value,
      CompositionEasingFunction easingFunction);
  }
}
