// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.ISplitCloseThemeAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (SplitCloseThemeAnimation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2057915881, 52379, 20112, 161, 26, 0, 80, 162, 33, 106, 158)]
  internal interface ISplitCloseThemeAnimationStatics
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
