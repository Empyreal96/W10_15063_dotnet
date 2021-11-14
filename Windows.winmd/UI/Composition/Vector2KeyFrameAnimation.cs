// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Vector2KeyFrameAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public sealed class Vector2KeyFrameAnimation : KeyFrameAnimation, IVector2KeyFrameAnimation
  {
    [Overload("InsertKeyFrame")]
    [MethodImpl]
    public extern void InsertKeyFrame(float normalizedProgressKey, Vector2 value);

    [Overload("InsertKeyFrameWithEasingFunction")]
    [MethodImpl]
    public extern void InsertKeyFrame(
      float normalizedProgressKey,
      Vector2 value,
      CompositionEasingFunction easingFunction);
  }
}
