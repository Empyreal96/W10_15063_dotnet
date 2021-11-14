// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISwipeHintThemeAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(601234007, 37141, 19811, 176, 74, 184, 159, 28, 116, 77, 192)]
  [ExclusiveTo(typeof (SwipeHintThemeAnimation))]
  internal interface ISwipeHintThemeAnimationStatics
  {
    DependencyProperty TargetNameProperty { get; }

    DependencyProperty ToHorizontalOffsetProperty { get; }

    DependencyProperty ToVerticalOffsetProperty { get; }
  }
}
