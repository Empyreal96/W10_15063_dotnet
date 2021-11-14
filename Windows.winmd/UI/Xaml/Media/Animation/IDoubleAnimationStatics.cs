// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IDoubleAnimationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3799683933, 61713, 17335, 184, 36, 131, 43, 88, 215, 120, 107)]
  [ExclusiveTo(typeof (DoubleAnimation))]
  internal interface IDoubleAnimationStatics
  {
    DependencyProperty FromProperty { get; }

    DependencyProperty ToProperty { get; }

    DependencyProperty ByProperty { get; }

    DependencyProperty EasingFunctionProperty { get; }

    DependencyProperty EnableDependentAnimationProperty { get; }
  }
}
