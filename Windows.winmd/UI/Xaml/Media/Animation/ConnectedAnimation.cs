// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ConnectedAnimation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Animation
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ConnectedAnimation : IConnectedAnimation, IConnectedAnimation2
  {
    public extern event TypedEventHandler<ConnectedAnimation, object> Completed;

    [Overload("TryStart")]
    [MethodImpl]
    public extern bool TryStart(UIElement destination);

    [MethodImpl]
    public extern void Cancel();

    public extern bool IsScaleAnimationEnabled { [MethodImpl] get; [MethodImpl] set; }

    [Overload("TryStartWithCoordinatedElements")]
    [MethodImpl]
    public extern bool TryStart(UIElement destination, IIterable<UIElement> coordinatedElements);

    [MethodImpl]
    public extern void SetAnimationComponent(
      ConnectedAnimationComponent component,
      ICompositionAnimationBase animation);
  }
}
