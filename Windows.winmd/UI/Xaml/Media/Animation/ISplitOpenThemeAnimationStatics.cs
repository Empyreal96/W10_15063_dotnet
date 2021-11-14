// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplitOpenThemeAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [Guid(2370632329, 14993, 17805, 176, 251, 76, 173, 98, 92, 191, 141)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SplitOpenThemeAnimation))]
  internal interface ISplitOpenThemeAnimationStatics
  {
    DependencyProperty OpenedTargetNameProperty { get; }

    DependencyProperty OpenedTargetProperty { get; }

    DependencyProperty ClosedTargetNameProperty { get; }

    DependencyProperty ClosedTargetProperty { get; }

    DependencyProperty ContentTargetNameProperty { get; }

    DependencyProperty ContentTargetProperty { get; }

    DependencyProperty OpenedLengthProperty { get; }

    DependencyProperty ClosedLengthProperty { get; }

    DependencyProperty OffsetFromCenterProperty { get; }

    DependencyProperty ContentTranslationDirectionProperty { get; }

    DependencyProperty ContentTranslationOffsetProperty { get; }
  }
}
