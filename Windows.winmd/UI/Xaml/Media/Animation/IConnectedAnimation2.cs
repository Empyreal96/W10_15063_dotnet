// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IConnectedAnimation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Composition;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1563397724, 22603, 19933, 182, 104, 151, 56, 145, 67, 20, 89)]
  [ExclusiveTo(typeof (ConnectedAnimation))]
  internal interface IConnectedAnimation2
  {
    bool IsScaleAnimationEnabled { get; set; }

    [Overload("TryStartWithCoordinatedElements")]
    bool TryStart(UIElement destination, IIterable<UIElement> coordinatedElements);

    void SetAnimationComponent(
      ConnectedAnimationComponent component,
      ICompositionAnimationBase animation);
  }
}
